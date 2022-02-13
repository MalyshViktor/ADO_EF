using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Practices.Unity;

namespace ADO_EF
{
    public partial class Form2 : Form
    {
        //[Dependency] public Random random { get; set; }
        private readonly Random _random;
        private readonly Model.FirmContext _Firm;

        public Form2(Random random, Model.FirmContext Firm)
        {
            _random = random;
            _Firm = Firm;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = _random.Next().ToString() + " - " + _Firm.Sales.Count();
        }
    }
}
