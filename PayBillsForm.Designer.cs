namespace the_billing_concept
{
    partial class PayBillsForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.close_this = new System.Windows.Forms.Button();
            this.payBillControl1 = new the_billing_concept.PayBillControl();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(62)))), ((int)(((byte)(4)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 8);
            this.panel1.TabIndex = 0;
            // 
            // close_this
            // 
            this.close_this.BackColor = System.Drawing.SystemColors.Window;
            this.close_this.FlatAppearance.BorderSize = 0;
            this.close_this.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.close_this.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.close_this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_this.Image = global::the_billing_concept.Properties.Resources.Close_Window_32px3;
            this.close_this.Location = new System.Drawing.Point(968, 12);
            this.close_this.Name = "close_this";
            this.close_this.Size = new System.Drawing.Size(24, 27);
            this.close_this.TabIndex = 2;
            this.close_this.UseVisualStyleBackColor = false;
            this.close_this.Click += new System.EventHandler(this.close_this_Click);
            // 
            // payBillControl1
            // 
            this.payBillControl1.BackColor = System.Drawing.Color.White;
            this.payBillControl1.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.payBillControl1.Location = new System.Drawing.Point(4, 10);
            this.payBillControl1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.payBillControl1.Name = "payBillControl1";
            this.payBillControl1.Size = new System.Drawing.Size(991, 579);
            this.payBillControl1.TabIndex = 1;
            this.payBillControl1.Load += new System.EventHandler(this.payBillControl1_Load);
            // 
            // PayBillsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.close_this);
            this.Controls.Add(this.payBillControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PayBillsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PayBillsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button close_this;
        private PayBillControl payBillControl1;
    }
}