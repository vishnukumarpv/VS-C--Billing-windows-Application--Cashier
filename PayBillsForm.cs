﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace the_billing_concept
{
    public partial class PayBillsForm : Form
    {
        private decimal total_amount;

        public decimal bill_total { get; set; }

        public DataGridView bills_datagrid { get; set; }

        public decimal _total { get { return total_amount; } }

        public PayBillsForm(decimal total_a)
        {
            this.total_amount = total_a; 
            InitializeComponent();
            

        }

        private void close_this_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void payBillControl1_Load(object sender, EventArgs e)
        {
             
            Console.WriteLine("grisdddddd :"+bills_datagrid);
            //(sender as PayBillControl)._total = this.total_amount; 
            payBillControl1._total = this.total_amount;
            payBillControl1.setTotal();
            payBillControl1.setForm(this);
            payBillControl1.bill_total = this.bill_total;
            payBillControl1.bills_datagrid = this.bills_datagrid;

        }
    }
}
