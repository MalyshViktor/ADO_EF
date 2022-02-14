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
        private Random rand;
        private readonly Model.FirmContext _Firm;
        public AddManagerForm(Model.FirmContext Firm)
        {
            _Firm = Firm;
            if (_Firm == null) throw new ArgumentNullException("_Firm is null");
            InitializeComponent();
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
                   Id = Guid.NewGuid()

               }
               ) ;
            _Firm.SaveChanges();
            MessageBox.Show("Добавлено успешно");
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
