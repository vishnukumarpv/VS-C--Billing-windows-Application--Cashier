using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace the_billing_concept
{
    public partial class PayBillControl : UserControl
    {
        public decimal total_amount;

        public decimal _total { set { total_amount = value; } }

        public PayBillControl()
        {
            InitializeComponent();
            total_show.Text = total_amount.ToString(); 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
             
        }
    }
}
