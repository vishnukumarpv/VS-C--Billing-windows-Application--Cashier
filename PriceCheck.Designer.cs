namespace the_billing_concept
{
    partial class PriceCheck
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
            this.item_name = new System.Windows.Forms.Label();
            this.item_price = new System.Windows.Forms.Label();
            this.price_find_btn = new System.Windows.Forms.Button();
            this.item_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.price_find_btn);
            this.panel1.Controls.Add(this.item_textbox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(911, 554);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.item_name);
            this.panel2.Controls.Add(this.item_price);
            this.panel2.Location = new System.Drawing.Point(123, 225);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(679, 229);
            this.panel2.TabIndex = 9;
            // 
            // item_name
            // 
            this.item_name.AutoSize = true;
            this.item_name.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_name.Location = new System.Drawing.Point(214, 35);
            this.item_name.Name = "item_name";
            this.item_name.Size = new System.Drawing.Size(244, 36);
            this.item_name.TabIndex = 9;
            this.item_name.Text = "Enter item code";
            // 
            // item_price
            // 
            this.item_price.AutoSize = true;
            this.item_price.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.item_price.Font = new System.Drawing.Font("Elephant", 55F);
            this.item_price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(0)))));
            this.item_price.Location = new System.Drawing.Point(189, 97);
            this.item_price.Margin = new System.Windows.Forms.Padding(0);
            this.item_price.Name = "item_price";
            this.item_price.Size = new System.Drawing.Size(300, 96);
            this.item_price.TabIndex = 8;
            this.item_price.Text = "$ 0.00";
            this.item_price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // price_find_btn
            // 
            this.price_find_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(0)))));
            this.price_find_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(0)))));
            this.price_find_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.price_find_btn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_find_btn.ForeColor = System.Drawing.Color.White;
            this.price_find_btn.Location = new System.Drawing.Point(332, 130);
            this.price_find_btn.Name = "price_find_btn";
            this.price_find_btn.Size = new System.Drawing.Size(186, 69);
            this.price_find_btn.TabIndex = 8;
            this.price_find_btn.Text = "Find price";
            this.price_find_btn.UseVisualStyleBackColor = false;
            this.price_find_btn.Click += new System.EventHandler(this.findProduct);
            // 
            // item_textbox
            // 
            this.item_textbox.Font = new System.Drawing.Font("Century Gothic", 18.25F);
            this.item_textbox.Location = new System.Drawing.Point(135, 80);
            this.item_textbox.Name = "item_textbox";
            this.item_textbox.Size = new System.Drawing.Size(597, 37);
            this.item_textbox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label2.Location = new System.Drawing.Point(131, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Item Name/ Code";
            // 
            // PriceCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "PriceCheck";
            this.Size = new System.Drawing.Size(911, 554);
            this.Load += new System.EventHandler(this.PriceCheck_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox item_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button price_find_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label item_name;
        private System.Windows.Forms.Label item_price;
    }
}
