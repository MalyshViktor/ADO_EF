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
    public partial class EditDepartmentForm : Form
    {
        public Model.Department EditedDepartment { get; set; }
        public EditDepartmentForm()
        {
            InitializeComponent();
        }

        private void EditDepartmentForm_Load(object sender, EventArgs e)
        {
            labelIdDepartment.Text = EditedDepartment.Id.ToString();
            textBoxDepartmentName.Text = EditedDepartment.Name;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxDepartmentName.Text == String.Empty)
            {
                MessageBox.Show("Неверное значение наименование");
            }
            else
            {
                EditedDepartment.Name = textBoxDepartmentName.Text;
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
