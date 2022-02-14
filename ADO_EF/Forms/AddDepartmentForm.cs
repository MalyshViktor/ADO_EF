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
    public partial class AddDepartmentForm : Form
    {
        private readonly Model.FirmContext _Firm;
        public AddDepartmentForm(Model.FirmContext Firm)
        {
            _Firm = Firm;
            if (_Firm == null) throw new ArgumentNullException("_Firm is null");
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAddDepartment_Click(object sender, EventArgs e)
        {
            String _Name = textBoxDepartment.Text;
            if (_Name.Equals(String.Empty))
            {
                MessageBox.Show("Введите название");
                return;
            }
            _Firm.Departments.Add(
                new Model.Department
                {
                    Name = _Name,
                    Id = Guid.NewGuid()

                }
            );
            _Firm.SaveChanges();
            MessageBox.Show("Добавлено успешно");
        }
    }
}
