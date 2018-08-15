namespace the_billing_concept
{
    partial class BillingControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bills_datagrid = new System.Windows.Forms.DataGridView();
            this.qty_textbox = new System.Windows.Forms.TextBox();
            this.item_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cancel_button = new System.Windows.Forms.Button();
            this.pay_button = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.enter = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.n0 = new System.Windows.Forms.Button();
            this.n9 = new System.Windows.Forms.Button();
            this.n8 = new System.Windows.Forms.Button();
            this.n7 = new System.Windows.Forms.Button();
            this.n6 = new System.Windows.Forms.Button();
            this.n5 = new System.Windows.Forms.Button();
            this.n4 = new System.Windows.Forms.Button();
            this.n3 = new System.Windows.Forms.Button();
            this.n2 = new System.Windows.Forms.Button();
            this.n1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rounded_show = new System.Windows.Forms.Label();
            this.rounded = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.total_label = new System.Windows.Forms.Label();
            this.tax_show = new System.Windows.Forms.Label();
            this.tax_label = new System.Windows.Forms.Label();
            this.total_show = new System.Windows.Forms.Label();
            this.slno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bills_datagrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bills_datagrid);
            this.panel2.Controls.Add(this.qty_textbox);
            this.panel2.Controls.Add(this.item_textbox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(814, 672);
            this.panel2.TabIndex = 1;
            // 
            // bills_datagrid
            // 
            this.bills_datagrid.AllowUserToDeleteRows = false;
            this.bills_datagrid.AllowUserToResizeColumns = false;
            this.bills_datagrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bills_datagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bills_datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bills_datagrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.bills_datagrid.BackgroundColor = System.Drawing.Color.White;
            this.bills_datagrid.ColumnHeadersHeight = 26;
            this.bills_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.bills_datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.slno,
            this.id,
            this.name,
            this.qty,
            this.rate,
            this.tax,
            this.total,
            this.action});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bills_datagrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.bills_datagrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.bills_datagrid.GridColor = System.Drawing.Color.DarkGray;
            this.bills_datagrid.Location = new System.Drawing.Point(35, 101);
            this.bills_datagrid.Name = "bills_datagrid";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.bills_datagrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.bills_datagrid.RowTemplate.Height = 35;
            this.bills_datagrid.RowTemplate.ReadOnly = true;
            this.bills_datagrid.Size = new System.Drawing.Size(697, 507);
            this.bills_datagrid.TabIndex = 4;
            this.bills_datagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellClicked);
            // 
            // qty_textbox
            // 
            this.qty_textbox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qty_textbox.Location = new System.Drawing.Point(665, 59);
            this.qty_textbox.Name = "qty_textbox";
            this.qty_textbox.Size = new System.Drawing.Size(67, 26);
            this.qty_textbox.TabIndex = 3;
            this.qty_textbox.Text = "1";
            this.qty_textbox.Enter += new System.EventHandler(this.eTextBox);
            // 
            // item_textbox
            // 
            this.item_textbox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_textbox.Location = new System.Drawing.Point(35, 59);
            this.item_textbox.Name = "item_textbox";
            this.item_textbox.Size = new System.Drawing.Size(597, 26);
            this.item_textbox.TabIndex = 2;
            this.item_textbox.Enter += new System.EventHandler(this.eTextBox);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label3.Location = new System.Drawing.Point(661, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Qty.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Item Name/ Code";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(814, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 672);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cancel_button);
            this.panel5.Controls.Add(this.pay_button);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 508);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(315, 100);
            this.panel5.TabIndex = 2;
            // 
            // cancel_button
            // 
            this.cancel_button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cancel_button.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_button.Location = new System.Drawing.Point(233, 13);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(51, 69);
            this.cancel_button.TabIndex = 1;
            this.cancel_button.Text = "X";
            this.cancel_button.UseVisualStyleBackColor = false;
            // 
            // pay_button
            // 
            this.pay_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(0)))));
            this.pay_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(0)))));
            this.pay_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pay_button.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pay_button.ForeColor = System.Drawing.Color.White;
            this.pay_button.Location = new System.Drawing.Point(34, 13);
            this.pay_button.Name = "pay_button";
            this.pay_button.Size = new System.Drawing.Size(186, 69);
            this.pay_button.TabIndex = 0;
            this.pay_button.Text = "Pay";
            this.pay_button.UseVisualStyleBackColor = false;
            this.pay_button.Click += new System.EventHandler(this.processBilling);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.enter);
            this.panel4.Controls.Add(this.clear);
            this.panel4.Controls.Add(this.n0);
            this.panel4.Controls.Add(this.n9);
            this.panel4.Controls.Add(this.n8);
            this.panel4.Controls.Add(this.n7);
            this.panel4.Controls.Add(this.n6);
            this.panel4.Controls.Add(this.n5);
            this.panel4.Controls.Add(this.n4);
            this.panel4.Controls.Add(this.n3);
            this.panel4.Controls.Add(this.n2);
            this.panel4.Controls.Add(this.n1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 174);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(315, 334);
            this.panel4.TabIndex = 1;
            // 
            // enter
            // 
            this.enter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(230)))), ((int)(((byte)(132)))));
            this.enter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(138)))), ((int)(((byte)(7)))));
            this.enter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(199)))));
            this.enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enter.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter.Location = new System.Drawing.Point(204, 251);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(80, 71);
            this.enter.TabIndex = 10;
            this.enter.Text = "E";
            this.enter.UseVisualStyleBackColor = false;
            this.enter.Click += new System.EventHandler(this.itemAddToBills);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.WhiteSmoke;
            this.clear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(62)))), ((int)(((byte)(4)))));
            this.clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(199)))));
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(117, 251);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(80, 71);
            this.clear.TabIndex = 9;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clearInput);
            // 
            // n0
            // 
            this.n0.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(62)))), ((int)(((byte)(4)))));
            this.n0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(199)))));
            this.n0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.n0.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n0.Location = new System.Drawing.Point(31, 251);
            this.n0.Name = "n0";
            this.n0.Size = new System.Drawing.Size(80, 71);
            this.n0.TabIndex = 8;
            this.n0.Text = "0";
            this.n0.UseVisualStyleBackColor = true;
            this.n0.Click += new System.EventHandler(this.numberpadPressed);
            // 
            // n9
            // 
            this.n9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(62)))), ((int)(((byte)(4)))));
            this.n9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(199)))));
            this.n9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.n9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n9.Location = new System.Drawing.Point(203, 174);
            this.n9.Name = "n9";
            this.n9.Size = new System.Drawing.Size(80, 71);
            this.n9.TabIndex = 7;
            this.n9.Text = "9";
            this.n9.UseVisualStyleBackColor = true;
            this.n9.Click += new System.EventHandler(this.numberpadPressed);
            // 
            // n8
            // 
            this.n8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(62)))), ((int)(((byte)(4)))));
            this.n8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(199)))));
            this.n8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.n8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n8.Location = new System.Drawing.Point(117, 174);
            this.n8.Name = "n8";
            this.n8.Size = new System.Drawing.Size(80, 71);
            this.n8.TabIndex = 6;
            this.n8.Text = "8";
            this.n8.UseVisualStyleBackColor = true;
            this.n8.Click += new System.EventHandler(this.numberpadPressed);
            // 
            // n7
            // 
            this.n7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(62)))), ((int)(((byte)(4)))));
            this.n7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(199)))));
            this.n7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.n7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n7.Location = new System.Drawing.Point(31, 174);
            this.n7.Name = "n7";
            this.n7.Size = new System.Drawing.Size(80, 71);
            this.n7.TabIndex = 5;
            this.n7.Text = "7";
            this.n7.UseVisualStyleBackColor = true;
            this.n7.Click += new System.EventHandler(this.numberpadPressed);
            // 
            // n6
            // 
            this.n6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(62)))), ((int)(((byte)(4)))));
            this.n6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(199)))));
            this.n6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.n6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n6.Location = new System.Drawing.Point(203, 97);
            this.n6.Name = "n6";
            this.n6.Size = new System.Drawing.Size(80, 71);
            this.n6.TabIndex = 4;
            this.n6.Text = "6";
            this.n6.UseVisualStyleBackColor = true;
            this.n6.Click += new System.EventHandler(this.numberpadPressed);
            // 
            // n5
            // 
            this.n5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(62)))), ((int)(((byte)(4)))));
            this.n5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(199)))));
            this.n5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.n5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n5.Location = new System.Drawing.Point(117, 97);
            this.n5.Name = "n5";
            this.n5.Size = new System.Drawing.Size(80, 71);
            this.n5.TabIndex = 3;
            this.n5.Text = "5";
            this.n5.UseVisualStyleBackColor = true;
            this.n5.Click += new System.EventHandler(this.numberpadPressed);
            // 
            // n4
            // 
            this.n4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(62)))), ((int)(((byte)(4)))));
            this.n4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(199)))));
            this.n4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.n4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n4.Location = new System.Drawing.Point(31, 97);
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(80, 71);
            this.n4.TabIndex = 2;
            this.n4.Text = "4";
            this.n4.UseVisualStyleBackColor = true;
            this.n4.Click += new System.EventHandler(this.numberpadPressed);
            // 
            // n3
            // 
            this.n3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(62)))), ((int)(((byte)(4)))));
            this.n3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(199)))));
            this.n3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.n3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n3.Location = new System.Drawing.Point(204, 19);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(80, 71);
            this.n3.TabIndex = 1;
            this.n3.Text = "3";
            this.n3.UseVisualStyleBackColor = true;
            this.n3.Click += new System.EventHandler(this.numberpadPressed);
            // 
            // n2
            // 
            this.n2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(62)))), ((int)(((byte)(4)))));
            this.n2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(199)))));
            this.n2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.n2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n2.Location = new System.Drawing.Point(118, 19);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(80, 71);
            this.n2.TabIndex = 1;
            this.n2.Text = "2";
            this.n2.UseVisualStyleBackColor = true;
            this.n2.Click += new System.EventHandler(this.numberpadPressed);
            // 
            // n1
            // 
            this.n1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(62)))), ((int)(((byte)(4)))));
            this.n1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(199)))));
            this.n1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.n1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n1.Location = new System.Drawing.Point(32, 19);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(80, 71);
            this.n1.TabIndex = 0;
            this.n1.Text = "1";
            this.n1.UseVisualStyleBackColor = true;
            this.n1.Click += new System.EventHandler(this.numberpadPressed);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rounded_show);
            this.panel3.Controls.Add(this.rounded);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.total_label);
            this.panel3.Controls.Add(this.tax_show);
            this.panel3.Controls.Add(this.tax_label);
            this.panel3.Controls.Add(this.total_show);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(315, 174);
            this.panel3.TabIndex = 0;
            // 
            // rounded_show
            // 
            this.rounded_show.AutoSize = true;
            this.rounded_show.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rounded_show.Location = new System.Drawing.Point(216, 149);
            this.rounded_show.Name = "rounded_show";
            this.rounded_show.Size = new System.Drawing.Size(41, 21);
            this.rounded_show.TabIndex = 11;
            this.rounded_show.Text = "0.00";
            // 
            // rounded
            // 
            this.rounded.AutoSize = true;
            this.rounded.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rounded.Location = new System.Drawing.Point(30, 149);
            this.rounded.Name = "rounded";
            this.rounded.Size = new System.Drawing.Size(82, 21);
            this.rounded.TabIndex = 10;
            this.rounded.Text = "Rounded";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "0.00";
            // 
            // total_label
            // 
            this.total_label.AutoSize = true;
            this.total_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_label.Location = new System.Drawing.Point(30, 126);
            this.total_label.Name = "total_label";
            this.total_label.Size = new System.Drawing.Size(144, 21);
            this.total_label.TabIndex = 8;
            this.total_label.Text = "Total without tax";
            // 
            // tax_show
            // 
            this.tax_show.AutoSize = true;
            this.tax_show.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tax_show.Location = new System.Drawing.Point(216, 101);
            this.tax_show.Name = "tax_show";
            this.tax_show.Size = new System.Drawing.Size(41, 21);
            this.tax_show.TabIndex = 7;
            this.tax_show.Text = "0.00";
            // 
            // tax_label
            // 
            this.tax_label.AutoSize = true;
            this.tax_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tax_label.Location = new System.Drawing.Point(30, 101);
            this.tax_label.Name = "tax_label";
            this.tax_label.Size = new System.Drawing.Size(80, 21);
            this.tax_label.TabIndex = 6;
            this.tax_label.Text = "Total Tax";
            // 
            // total_show
            // 
            this.total_show.AutoSize = true;
            this.total_show.Font = new System.Drawing.Font("Elephant", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_show.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(0)))));
            this.total_show.Location = new System.Drawing.Point(42, 10);
            this.total_show.Name = "total_show";
            this.total_show.Size = new System.Drawing.Size(242, 77);
            this.total_show.TabIndex = 5;
            this.total_show.Text = "$ 0.00";
            // 
            // slno
            // 
            this.slno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.slno.DataPropertyName = "slno";
            this.slno.FillWeight = 7.604661F;
            this.slno.Frozen = true;
            this.slno.HeaderText = "Sl.No.";
            this.slno.MinimumWidth = 50;
            this.slno.Name = "slno";
            this.slno.ReadOnly = true;
            this.slno.Width = 57;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "_ID";
            this.id.MinimumWidth = 20;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.id.Visible = false;
            this.id.Width = 20;
            // 
            // name
            // 
            this.name.DataPropertyName = "Name";
            this.name.FillWeight = 523.8579F;
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 200;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // qty
            // 
            this.qty.DataPropertyName = "qty";
            this.qty.FillWeight = 10.87901F;
            this.qty.HeaderText = "Qty.";
            this.qty.MinimumWidth = 50;
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            // 
            // rate
            // 
            this.rate.DataPropertyName = "rate";
            this.rate.FillWeight = 11.38174F;
            this.rate.HeaderText = "Rate";
            this.rate.MinimumWidth = 50;
            this.rate.Name = "rate";
            this.rate.ReadOnly = true;
            // 
            // tax
            // 
            this.tax.DataPropertyName = "tax";
            this.tax.FillWeight = 33.97094F;
            this.tax.HeaderText = "Tax";
            this.tax.MinimumWidth = 50;
            this.tax.Name = "tax";
            this.tax.ReadOnly = true;
            // 
            // total
            // 
            this.total.DataPropertyName = "total";
            this.total.FillWeight = 12.3058F;
            this.total.HeaderText = "Total";
            this.total.MinimumWidth = 50;
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // action
            // 
            this.action.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.action.HeaderText = "Action";
            this.action.MinimumWidth = 40;
            this.action.Name = "action";
            this.action.Text = "del";
            // 
            // BillingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BillingControl";
            this.Size = new System.Drawing.Size(1129, 672);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bills_datagrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label total_label;
        private System.Windows.Forms.Label tax_show;
        private System.Windows.Forms.Label tax_label;
        private System.Windows.Forms.Label total_show;
        private System.Windows.Forms.Button n1;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button n0;
        private System.Windows.Forms.Button n9;
        private System.Windows.Forms.Button n8;
        private System.Windows.Forms.Button n7;
        private System.Windows.Forms.Button n6;
        private System.Windows.Forms.Button n5;
        private System.Windows.Forms.Button n4;
        private System.Windows.Forms.Button n3;
        private System.Windows.Forms.Button n2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button pay_button;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.DataGridView bills_datagrid;
        private System.Windows.Forms.TextBox qty_textbox;
        private System.Windows.Forms.TextBox item_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label rounded_show;
        private System.Windows.Forms.Label rounded;
        private System.Windows.Forms.DataGridViewTextBoxColumn slno;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn tax;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewButtonColumn action;
    }
}
