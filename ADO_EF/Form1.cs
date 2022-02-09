﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_EF
{
    public partial class Form1 : Form
    {
        private Model.FirmContext Firm;
        public Form1()
        {
            InitializeComponent();
            Firm = new Model.FirmContext();
            //Firm.InstallDepartments();
            //Firm.InstallManagers();
            //Firm.InstallProducts();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show(Firm.Departments.Count().ToString());
            MessageBox.Show(Firm.Managers.Count().ToString());
            MessageBox.Show(Firm.Products.Count().ToString());
            MessageBox.Show(Firm.Sales.Count().ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var dep in Firm.Departments.OrderByDescending(d => d.Name))
            {
                listBox1.Items.Add(dep);   
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var man in Firm.Managers.OrderByDescending(m=> m.Surname))
            {
                listBox1.Items.Add(man);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var prod in Firm.Products.OrderByDescending(p => p.Name))
            {
                listBox1.Items.Add(prod);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var sal in Firm.Sales.OrderByDescending(p => p.Id))
            {
                listBox1.Items.Add(sal);
            }

        }
    }
}
