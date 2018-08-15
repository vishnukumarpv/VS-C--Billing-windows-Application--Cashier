namespace the_billing_concept
{
    partial class PayBillControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.atm_panel = new System.Windows.Forms.Panel();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.trans_ack_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bal_cash = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.amount_cash = new System.Windows.Forms.TextBox();
            this.total_show = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.atm_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.total_show);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(682, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 529);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.atm_panel);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.bal_cash);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.amount_cash);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(682, 529);
            this.panel2.TabIndex = 1;
            // 
            // atm_panel
            // 
            this.atm_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(241)))));
            this.atm_panel.Controls.Add(this.checkedListBox1);
            this.atm_panel.Controls.Add(this.listBox1);
            this.atm_panel.Controls.Add(this.label7);
            this.atm_panel.Controls.Add(this.label6);
            this.atm_panel.Controls.Add(this.trans_ack_textBox);
            this.atm_panel.Controls.Add(this.label5);
            this.atm_panel.Controls.Add(this.textBox2);
            this.atm_panel.Controls.Add(this.label4);
            this.atm_panel.Controls.Add(this.textBox1);
            this.atm_panel.Controls.Add(this.label3);
            this.atm_panel.Location = new System.Drawing.Point(52, 125);
            this.atm_panel.Name = "atm_panel";
            this.atm_panel.Size = new System.Drawing.Size(580, 359);
            this.atm_panel.TabIndex = 4;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Visa",
            "maetro"});
            this.checkedListBox1.Location = new System.Drawing.Point(51, 275);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(472, 29);
            this.checkedListBox1.TabIndex = 10;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Items.AddRange(new object[] {
            "Visa",
            "Maestro"});
            this.listBox1.Location = new System.Drawing.Point(50, 240);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(473, 26);
            this.listBox1.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 22);
            this.label7.TabIndex = 8;
            this.label7.Text = "Card Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "Transaction Ack.";
            // 
            // trans_ack_textBox
            // 
            this.trans_ack_textBox.Location = new System.Drawing.Point(46, 155);
            this.trans_ack_textBox.Name = "trans_ack_textBox";
            this.trans_ack_textBox.Size = new System.Drawing.Size(477, 30);
            this.trans_ack_textBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(339, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Card Last Digits";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.textBox2.Location = new System.Drawing.Point(340, 83);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(183, 34);
            this.textBox2.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Amount";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.textBox1.Location = new System.Drawing.Point(46, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 34);
            this.textBox1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(246, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Through ATM Card";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label2.Location = new System.Drawing.Point(438, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Balance ";
            // 
            // bal_cash
            // 
            this.bal_cash.Location = new System.Drawing.Point(442, 63);
            this.bal_cash.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bal_cash.Name = "bal_cash";
            this.bal_cash.Size = new System.Drawing.Size(190, 30);
            this.bal_cash.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label1.Location = new System.Drawing.Point(53, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "By Cash";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // amount_cash
            // 
            this.amount_cash.Location = new System.Drawing.Point(57, 63);
            this.amount_cash.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.amount_cash.Name = "amount_cash";
            this.amount_cash.Size = new System.Drawing.Size(190, 30);
            this.amount_cash.TabIndex = 0;
            // 
            // total_show
            // 
            this.total_show.AutoSize = true;
            this.total_show.Font = new System.Drawing.Font("Elephant", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_show.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(0)))));
            this.total_show.Location = new System.Drawing.Point(42, 45);
            this.total_show.Name = "total_show";
            this.total_show.Size = new System.Drawing.Size(242, 77);
            this.total_show.TabIndex = 6;
            this.total_show.Text = "$ 0.00";
            // 
            // PayBillControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "PayBillControl";
            this.Size = new System.Drawing.Size(1000, 529);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.atm_panel.ResumeLayout(false);
            this.atm_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox amount_cash;
        private System.Windows.Forms.Panel atm_panel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bal_cash;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox trans_ack_textBox;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label total_show;
    }
}
