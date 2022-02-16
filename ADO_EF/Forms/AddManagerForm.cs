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
    public partial class AddManagerForm : Form
    {
        private readonly Model.FirmContext _Firm;
        public AddManagerForm(Model.FirmContext Firm)
        {
            _Firm = Firm;
            if (_Firm == null) throw new ArgumentNullException("_Firm is null");
            InitializeComponent();
        }

        private void AddManagerForm_Load(object sender, EventArgs e)
        {
            comboBoxIDmain.Items.Clear();
            foreach (Model.Department dept in _Firm.Departments)
            {
                comboBoxIDmain.Items.Add(dept.Id);
                comboBoxIDsec.Items.Add(dept.Id);
            }
            foreach (Model.Manager manager in _Firm.Managers)
            {
                comboBoxIdchief.Items.Add(manager.Id);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            String _Surname = textBoxSurname.Text;
            String _Name = textBoxName.Text;
            String _Secname = textBoxSecname.Text;
   
            if  (_Name.Equals(String.Empty) 
                || _Surname.Equals(String.Empty) 
                || _Secname.Equals(String.Empty))
            {
                MessageBox.Show("Введите название");
                return;
            }
            _Firm.Managers.Add(
               new Model.Manager
               {
                   Surname = _Surname,
                   Name = _Name,
                   SecName = _Secname,
                   Id = Guid.NewGuid(),
                   Id_main_dep = (comboBoxIDmain.SelectedItem
                   as Model.Department).Id,
                   Id_sec_dep = (comboBoxIDsec.SelectedItem
                   as Model.Department).Id,
                   Id_chief = (comboBoxIdchief.SelectedItem
                   as Model.Manager).Id

               }
               ) ;
            _Firm.SaveChanges();
            MessageBox.Show("Добавлено успешно");
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBoxIDmain_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelMainDept.Text = (comboBoxIDmain.SelectedItem
                 as Model.Department)?.Name.ToString() ?? " - "; 
        }

        private void comboBoxIDsec_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelIdSecDept.Text = (comboBoxIDsec.SelectedItem
                as Model.Department)?.Name.ToString() ?? " - ";
        }

        private void comboBoxIdchief_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelChief.Text = (comboBoxIdchief.SelectedItem
                as Model.Manager)?.Name.ToString()
                ?? "Не выбран";
        }
    }
}
