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
            labelIdManager.Text = EditedManager.Id.ToString();
            textBoxManagerSurname.Text = EditedManager.Surname;
            textBoxManagerName.Text = EditedManager.Name;
            textBoxManagerSecname.Text = EditedManager.Name;
            comboBoxIdMainDept.Items.Clear();
            foreach (Model.Manager manager in _Firm.Managers)
            {
                comboBoxIdMainDept.Items.Add(manager.Id_main_dep);
            }
        }
    }
}
