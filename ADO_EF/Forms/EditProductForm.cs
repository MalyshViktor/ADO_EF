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
    public partial class EditProductForm : Form
    {
        public Model.Product EditedProduct { get; set; }
        public EditProductForm()
        {
            InitializeComponent();
        }

        private void EditProductForm_Load(object sender, EventArgs e)
        {
            labelId.Text = EditedProduct.Id.ToString();
            textBoxName.Text = EditedProduct.Name;
            textBoxPrice.Text = EditedProduct.Price.ToString();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if(textBoxName.Text == String.Empty)
            {
                MessageBox.Show("Неверное значение наименование");
            }
            else
            {
                EditedProduct.Name = textBoxName.Text;
            }
            try
            {
                EditedProduct.Price = Convert.ToDouble(textBoxPrice.Text);
            }
            catch
            {
                MessageBox.Show("Неверно значение цены");
            }
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
