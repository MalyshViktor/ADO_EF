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
    public partial class EditSaleForm : Form
    {
        private readonly Model.FirmContext _Firm;
        public Model.Sale EditedSale { get; set; }
        public EditSaleForm(Model.FirmContext Firm)
        {
            _Firm = Firm;
            InitializeComponent();
        }

        private void EditSaleForm_Load(object sender, EventArgs e)
        {
            comboBoxManager1.Items.Clear();
            comboBoxProduct1.Items.Clear();
            foreach (Model.Product products in _Firm.Products)
            {
                comboBoxProduct1.Items.Add(products);
            }
            foreach (Model.Manager manager in _Firm.Managers)
            {
                comboBoxManager1.Items.Add(manager);
            }
            //textBoxCountSale.Text = EditedSale.Cnt.ToString();
            //dateTimePicker1.Value = EditedSale.Moment;

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxCountSale.Text == String.Empty)
            {
                MessageBox.Show("Введите количество товара");
            }
            else 
            {
                //EditedSale.Cnt = Convert.ToInt32(textBoxCountSale.Text);
            }

            if (dateTimePicker1.Value.Date > DateTime.Now)
            {
                MessageBox.Show("Выбранная дата не может быть больше текущей!");
            }
            else 
            {
                //EditedSale.Moment = dateTimePicker1.Value.Date;
            }
            
            this.DialogResult = DialogResult.OK;
            Close();


        }

        private void comboBoxProduct1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int SelectedIndex = comboBoxProduct1.SelectedIndex;
            if (SelectedIndex == -1) return;
            Model.Product products = comboBoxProduct1.Items[SelectedIndex] //SelectedItem 
                as Model.Product;
        }

        private void comboBoxManager1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int SelectedIndex = comboBoxManager1.SelectedIndex;
            if (SelectedIndex == -1) return;
            Model.Manager managers = comboBoxManager1.Items[SelectedIndex] //SelectedItem 
                as Model.Manager;
        }
    }
}
