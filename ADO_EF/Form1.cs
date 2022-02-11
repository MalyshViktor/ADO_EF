using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_EF
{
    public partial class Form1 : Form
    {
        private Model.FirmContext Firm;
        private Random random = new();
        public Form1()
        {
            InitializeComponent();
            Firm = new Model.FirmContext();
            //Firm.InstallDepartments();
            //Firm.InstallManagers();
            //Firm.InstallProducts();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LabelDepartments.Text = Firm.Departments.Count().ToString();
            LabelManagers.Text = Firm.Managers.Count().ToString();
            LabelProducts.Text = Firm.Products.Count().ToString();
            LabelSales.Text = Firm.Sales.Count().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var dep in Firm.Departments.OrderByDescending(d => d.Name))
            {
                listBox1.Items.Add(dep);   
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var man in Firm.Managers.OrderByDescending(m=> m.Surname))
            {
                listBox1.Items.Add(man);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var prod in Firm.Products.OrderByDescending(p => p.Name))
            {
                listBox1.Items.Add(prod);
            }
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
            foreach (var item in Firm.Sales.Join
                (Firm.Managers,
                s => s.Id_manager,
                m => m.Id,
                (Sale, Manager) => new { Sale, Manager })
                .Join(Firm.Products, sm => sm.Sale.Id_product, p => p.Id,
                (sm, product) => new{ Sale = sm.Sale, sm.Manager, product }
                ))
            {
                listBox1.Items.Add(item.Sale.Moment.ToShortDateString()
                    + " "
                    +item.Manager.Surname + " " + item.Manager.Name.Substring(0,1) + " " + item.Manager.SecName.Substring(0, 1)
                    + " " item.);
            }
        }
    }
}
