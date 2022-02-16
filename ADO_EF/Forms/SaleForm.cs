using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_EF.Forms
{
    public partial class SaleForm : Form
    {
        private readonly Model.FirmContext _Firm;
        public SaleForm(Model.FirmContext Firm)
        {
            _Firm = Firm;
            InitializeComponent();
        }

        private void SaleForm_Load(object sender, EventArgs e)
        {
            comboBoxProducts.Items.Clear();
            foreach (Model.Product product in _Firm.Products)
            {
                comboBoxProducts.Items.Add(product);
            }
            comboBoxManager.Items.Clear();
            foreach (Model.Manager manager in _Firm.Managers.OrderBy(m=>m.Surname))
            {
                comboBoxManager.Items.Add(manager);
            }
        }

        private void comboBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            int SelectedIndex = comboBoxProducts.SelectedIndex;
            if (SelectedIndex == -1) return;
            Model.Product product = comboBoxProducts.Items[SelectedIndex] //SelectedItem 
                as Model.Product;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxManager.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите сотрудника");
                return;
            }
            if (comboBoxProducts.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите товар");
                return;
            }
            int cnt = 0;
            try
            {
                cnt = Convert.ToInt32(textBoxCount.Text);
            }
            catch
            {
                MessageBox.Show("Количество не распознано");
                return;
            }
            if (cnt <= 0)
            {
                MessageBox.Show("Неверное количество");
                return;
            }
            _Firm.Sales.Add(new Model.Sale
            {
                Id = Guid.NewGuid(),
                Id_manager = (comboBoxManager.SelectedItem
                as Model.Manager).Id,
                Id_product = (comboBoxProducts.SelectedItem
                as Model.Product).Id,
                Cnt = cnt,
                Moment = DateTime.Now

            });
            _Firm.SaveChanges();
            MessageBox.Show("Продажа оформлена");
            comboBoxManager.SelectedIndex = -1;
            comboBoxProducts.SelectedIndex = -1;
        }

        private void comboBoxManager_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelManagerId.Text = (comboBoxManager.SelectedItem
                as Model.Manager)?.Id.ToString()
                ?? "Не выбран";
        }
    }
}
