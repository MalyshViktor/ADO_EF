using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

using Microsoft.Practices.Unity;

namespace ADO_EF
{
    public partial class Form1 : Form
    {
        [Dependency] public Model.FirmContext Firm { get; set; }

        private Random random = new();
        public Form1()
        {
            InitializeComponent();
            BackColor = Color.SeaShell;

            //DateTimePicker dateTimePicker1 = new DateTimePicker();
            //dateTimePicker1.Format = DateTimePickerFormat.Short;
            //Firm = new Model.FirmContext();
            //Firm.InstallDepartments();
            //Firm.InstallManagers();
            //Firm.InstallProducts();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Firm.Departments.Count() == 0) Firm.InstallDepartments();
            if (Firm.Managers.Count() == 0) Firm.InstallManagers();
            if (Firm.Products.Count() == 0) Firm.InstallProducts();

            LabelDepartments.Text = Firm.Departments.Count().ToString();
            LabelManagers.Text = Firm.Managers.Count().ToString();
            LabelProducts.Text = Firm.Products.Count().ToString();
            LabelSales.Text = Firm.Sales.Count().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayDepartments();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DisplayManagers();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DisplayProducts();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Count
            button4.Enabled = false;
            #region Генерация и обновление статистики
            int n = 0;
            try
            {
                n = Convert.ToInt32(GenCnt.Text);
            }
            catch 
            {
                MessageBox.Show("Количество не распознано");
                return;
            }
            //Generation
            
            while (n > 0)
            {
                
                Firm.Sales.Add(new Model.Sale                       
                {                                                   
                    Id = Guid.NewGuid(),                            
                    Id_manager = Firm.Managers                      //Случайная выборка - вар.1
                    .OrderBy(m=>m.Id)                               //Упорядочивыаем по Id(можно любое поле)
                    .Skip(                                          //Пропускаем первые элементы результата
                        random.Next(                                //в количестве- случайное число
                            Firm.Managers.Count()))                 //в пределах размера исходной коллекции
                    .First()                                        //Выбираем перввй элемент(после отступа)
                    .Id,                                            //Берем из него Id

                    Id_product = Firm.Products                                                      //Случайная выборка - вар.2
                    .OrderBy(                                                                       //Используем тот факт, что запрос будет переведен в SQL
                        p=> Guid.NewGuid())                                                         // здесь получится ORDER BY NEWID() - вся таблица
                    .First()                                                                        //  Выбираем первый элемент (из всего результата)
                    .Id,                                                                            //  Берем из него Id
                    Cnt = random.Next(1, 10),                                                           
                    Moment = DateTime.Parse($"2021-01-01").AddSeconds(random.Next(60*60*24*365))
                });

                --n;
            }
            Firm.SaveChanges();
            //Displaying
            LabelSales.Text = Firm.Sales.Count().ToString();

            #endregion
            button4.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var item in Firm.Sales.
                Join
                (Firm.Managers,
                s => s.Id_manager,
                m => m.Id,
                (Sale, Manager) => new { Sale, Manager })
                .Join(Firm.Products, sm => sm.Sale.Id_product, p => p.Id,
                (sm, Product) => new{ Sale = sm.Sale, sm.Manager, Product }
                ))
            {
                listBox1.Items.Add(item.Sale.Moment.ToShortDateString()
                    + " "
                    +item.Manager.Surname + " " + item.Manager.Name.Substring(0,1) + " " + item.Manager.SecName.Substring(0, 1)
                    + " - " + item.Product.Name
                    + " - " + item.Sale.Cnt + " pcs "
                     + " - " + item.Product.Price * item.Sale.Cnt + "uah");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            
            foreach (var item in Firm.Sales.Where(s => DbFunctions.TruncateTime(s.Moment) == dateTimePicker1.Value.Date).
                Join
                (Firm.Managers,
                s => s.Id_manager,
                m => m.Id,
                (Sale, Manager) => new { Sale, Manager })
                .Join(Firm.Products, sm => sm.Sale.Id_product, p => p.Id,
                (sm, Product) => new { Sale = sm.Sale, sm.Manager, Product }
                ))
            {
                listBox1.Items.Add(item.Sale.Moment.ToShortDateString()
                    + " "
                    + item.Manager.Surname + " " + item.Manager.Name.Substring(0, 1) + " " + item.Manager.SecName.Substring(0, 1)
                    + " - " + item.Product.Name
                    + " - " + item.Sale.Cnt + " pcs "
                    + " - " + item.Product.Price * item.Sale.Cnt + "$");
            }
        }

        private void buttonForm2_Click(object sender, EventArgs e)
        {
            //new Form2().ShowDialog(this);
            Program.Container.Resolve<Form2>().ShowDialog(this);
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            Program.Container.
                Resolve<Forms.AddProductForm>().ShowDialog(this);
            LabelProducts.Text = Firm.Products.Count().ToString();
        }

        private void buttonAddDepartment_Click(object sender, EventArgs e)
        {
            Program.Container.
                Resolve<Forms.AddDepartmentForm>().ShowDialog(this);
                LabelDepartments.Text = Firm.Departments.Count().ToString();
        }

        private void buttonAddManager_Click(object sender, EventArgs e)
        {
            Program.Container.
            Resolve<Forms.AddManagerForm>().ShowDialog(this);
            LabelManagers.Text = Firm.Managers.Count().ToString();
        }

        private void buttonSale_Click(object sender, EventArgs e)
        {
            Program.Container.
                Resolve<Forms.SaleForm>().ShowDialog(this);
            LabelSales.Text = Firm.Sales.Count().ToString();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            int selectedIndex = listBox1.SelectedIndex;
            if (selectedIndex == -1) return;
            if (listBox1.SelectedItem is Model.Product)
            {
                Forms.EditProductForm editProductForm =
                    Program.Container
                    .Resolve<Forms.EditProductForm>();
                editProductForm.EditedProduct = listBox1.SelectedItem as Model.Product;

                editProductForm.ShowDialog(this);
                /*
                String str = editProductForm.EditedProduct.ToString() + 
                    " " + Firm.Products.Find(
                        editProductForm.EditedProduct.Id).ToString();
                */
                if (editProductForm.DialogResult == DialogResult.OK)
                {
                    Firm.SaveChanges();
                    MessageBox.Show("Изменения внесены");
                    DisplayProducts();
                }
                else 
                {
                    MessageBox.Show("Изменения отменены");
                }
                
            }
            if (listBox1.SelectedItem is Model.Department)
            {
                Forms.EditDepartmentForm editDepartmentForm =
                    Program.Container.
                    Resolve<Forms.EditDepartmentForm>();
                editDepartmentForm.EditedDepartment = listBox1.SelectedItem as Model.Department;

                editDepartmentForm.ShowDialog(this);
                if (editDepartmentForm.DialogResult == DialogResult.OK)
                {
                    Firm.SaveChanges();
                    MessageBox.Show("Изменения внесены");
                    DisplayDepartments();
                }
                else
                {
                    MessageBox.Show("Изменения отменены");
                }
            }
            //EditManagerForm
            if (listBox1.SelectedItem is Model.Manager)
            {
                Forms.EditManagerForm editManagerForm =
                     Program.Container.
                     Resolve<Forms.EditManagerForm>();
                editManagerForm.EditedManager = listBox1.SelectedItem as Model.Manager;

                editManagerForm.ShowDialog(this);
                if (editManagerForm.DialogResult == DialogResult.OK)
                {
                    Firm.SaveChanges();
                    MessageBox.Show("Изменения внесены");
                    listBox1.Items.Clear();
                    DisplayManagers();
                }
                else
                {
                    MessageBox.Show("Изменения отменены");
                }
            }
            //EditSaleForm
            if (listBox1.SelectedItem is String)
            {
                Forms.EditSaleForm editSaleForm =
                    Program.Container.
                    Resolve<Forms.EditSaleForm>();
                editSaleForm.EditedSale = listBox1.SelectedItem as Model.Sale;

                editSaleForm.ShowDialog(this);
                if (editSaleForm.DialogResult == DialogResult.OK)
                {
                    Firm.SaveChanges();
                    MessageBox.Show("Изменения внесены");
                    listBox1.Items.Clear();
                    
                }
                else
                {
                    MessageBox.Show("Изменения отменены");
                }
            }
        }

        private void DisplayManagers()
        {
            listBox1.Items.Clear();
            foreach (var manager in Firm.Managers.OrderByDescending(m => m.Surname))
            {
                listBox1.Items.Add(manager);
            }
        }       
        private void DisplayProducts()
        {
            listBox1.Items.Clear();
            foreach (Model.Product prod in Firm.Products.OrderByDescending(p => p.Name))
            {
                listBox1.Items.Add(prod);
            }
        }       
        private void DisplayDepartments()
        {
            listBox1.Items.Clear();
            foreach (var dep in Firm.Departments.OrderByDescending(d => d.Name))
            {
                listBox1.Items.Add(dep);
            }
        }
    }
}
