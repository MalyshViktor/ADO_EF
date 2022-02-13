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
    public partial class AddProductForm : Form
    {
        private readonly Model.FirmContext _Firm;
        public AddProductForm(Model.FirmContext Firm)
        {
            _Firm = Firm;
            if (_Firm == null) throw new ArgumentNullException("_Firm is null");
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            String name = textBoxName.Text;
            if (name.Equals(String.Empty))
            {
                MessageBox.Show("Введите название");
                return;
            }
            double price;
            try
            {
                price = Convert.ToDouble(textBoxPrice.Text.Replace(".",","));
            }
            catch
            {
                MessageBox.Show("Цена не распознана");
                return;
            }
            _Firm.Products.Add(
                new Model.Product
                {
                    Name = name,
                    Price = price,
                    Id = Guid.NewGuid()
                }
                ) ;
            _Firm.SaveChanges();
            MessageBox.Show("Добавлено успешно");
        }
    }
}
