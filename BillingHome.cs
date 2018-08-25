using System;
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
    public partial class BillingHome : Form
    {
         
        public BillingHome()
        {
            InitializeComponent();

            sliding_panel.Top = billing_btn.Top;
            sliding_panel.Height = billing_btn.Height;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            
        }
          

        private void close_window(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void billing_Click(object sender, EventArgs e)
        {
            sliding_panel.Height = billing_btn.Height;
            sliding_panel.Top = billing_btn.Top;
            billingControl.BringToFront();
        }

        private void price_check_Click(object sender, EventArgs e)
        {
            sliding_panel.Height = price_check_btn.Height;
            sliding_panel.Top = price_check_btn.Top;

            //BillingHome.BillingControl.BringToFront();
            priceCheck1.BringToFront();
            priceCheck1.Dock = DockStyle.Left;
            
        }

 
    }
}
