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
    public partial class EditManagerForm : Form
    {
        private readonly Model.FirmContext _Firm;
        public Model.Manager EditedManager { get; set; }
        public EditManagerForm(Model.FirmContext Firm)
        {
            _Firm = Firm;
            InitializeComponent();
        }

        private void EditManagerForm_Load(object sender, EventArgs e)
        {
            comboBoxIdMainDept.Items.Clear();
            comboBoxIdSecDept.Items.Clear();
            comboBoxIdChief.Items.Clear();
            foreach (Model.Manager manager in _Firm.Managers)
            {
                comboBoxIdChief.Items.Add(manager.Id);
            }
            foreach (Model.Department dept in _Firm.Departments)
            {
                comboBoxIdMainDept.Items.Add(dept.Id);
                comboBoxIdSecDept.Items.Add(dept.Id);
                
            }
            labelIdManager.Text = EditedManager.Id.ToString();
            textBoxManagerSurname.Text = EditedManager.Surname;
            textBoxManagerName.Text = EditedManager.Name;
            textBoxManagerSecname.Text = EditedManager.SecName;
            comboBoxIdMainDept.Text = EditedManager.Id.ToString();
            if (EditedManager.Id_sec_dep == null)
            {
                comboBoxIdSecDept.Text = " - ";
            }
            else
            {
                comboBoxIdSecDept.Text = EditedManager.Id_sec_dep.ToString();
            }
            if (EditedManager.Id_chief == null)
            {
                comboBoxIdChief.Text = " - ";
            }
            else
            {
                comboBoxIdChief.Text = EditedManager.Id_chief.ToString();
            }

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxManagerName.Text == String.Empty 
                || textBoxManagerSecname.Text == String.Empty 
                || textBoxManagerSurname.Text == String.Empty)
            {
                MessageBox.Show("Неверное значение наименование");
            }
            else
            {
                EditedManager.Surname = textBoxManagerSurname.Text;
                EditedManager.Name = textBoxManagerName.Text;
                EditedManager.SecName = textBoxManagerSecname.Text;
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
