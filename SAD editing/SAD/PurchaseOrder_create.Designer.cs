namespace SAD
{
    partial class PurchaseOrder_create
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
            this.label3 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.iQuantity_txt = new System.Windows.Forms.NumericUpDown();
            this.subtotal_txt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.supplierpanel = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.supplier_data = new System.Windows.Forms.DataGridView();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.iExpiry_txt = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.iPrice_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.iName_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.supplier_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.encoderPos = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.encoderLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.items_ordered = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iQuantity_txt)).BeginInit();
            this.supplierpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplier_data)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.items_ordered)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Location = new System.Drawing.Point(-74, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(951, 65);
            this.panel1.TabIndex = 63;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(86, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 25);
            this.label3.TabIndex = 65;
            this.label3.Text = "ADD PURCHASE ORDER";
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btn_close.Location = new System.Drawing.Point(730, 1);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(87, 64);
            this.btn_close.TabIndex = 64;
            this.btn_close.Text = "BACK";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.panel6.Controls.Add(this.iQuantity_txt);
            this.panel6.Controls.Add(this.supplierpanel);
            this.panel6.Controls.Add(this.subtotal_txt);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.btn_add);
            this.panel6.Controls.Add(this.btn_clear);
            this.panel6.Controls.Add(this.iExpiry_txt);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.iPrice_txt);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.iName_txt);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.supplier_txt);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(3, 63);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(389, 542);
            this.panel6.TabIndex = 205;
            // 
            // iQuantity_txt
            // 
            this.iQuantity_txt.Enabled = false;
            this.iQuantity_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iQuantity_txt.Location = new System.Drawing.Point(152, 287);
            this.iQuantity_txt.Name = "iQuantity_txt";
            this.iQuantity_txt.Size = new System.Drawing.Size(172, 24);
            this.iQuantity_txt.TabIndex = 223;
            this.iQuantity_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.iQuantity_txt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.iQuantity_txt.ValueChanged += new System.EventHandler(this.iQuantity_txt_ValueChanged);
            // 
            // subtotal_txt
            // 
            this.subtotal_txt.Enabled = false;
            this.subtotal_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotal_txt.Location = new System.Drawing.Point(153, 338);
            this.subtotal_txt.Name = "subtotal_txt";
            this.subtotal_txt.ReadOnly = true;
            this.subtotal_txt.Size = new System.Drawing.Size(171, 24);
            this.subtotal_txt.TabIndex = 222;
            this.subtotal_txt.Tag = "";
            this.subtotal_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(28, 338);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 20);
            this.label11.TabIndex = 221;
            this.label11.Text = "Item Subtotal";
            // 
            // supplierpanel
            // 
            this.supplierpanel.BackColor = System.Drawing.Color.Brown;
            this.supplierpanel.Controls.Add(this.label10);
            this.supplierpanel.Controls.Add(this.supplier_data);
            this.supplierpanel.Location = new System.Drawing.Point(18, 110);
            this.supplierpanel.Name = "supplierpanel";
            this.supplierpanel.Size = new System.Drawing.Size(368, 429);
            this.supplierpanel.TabIndex = 220;
            this.supplierpanel.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(106, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 31);
            this.label10.TabIndex = 207;
            this.label10.Text = "SUPPLIERS";
            // 
            // supplier_data
            // 
            this.supplier_data.AllowUserToAddRows = false;
            this.supplier_data.AllowUserToDeleteRows = false;
            this.supplier_data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.supplier_data.BackgroundColor = System.Drawing.Color.White;
            this.supplier_data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.supplier_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplier_data.Location = new System.Drawing.Point(15, 51);
            this.supplier_data.Name = "supplier_data";
            this.supplier_data.ReadOnly = true;
            this.supplier_data.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.supplier_data.RowHeadersVisible = false;
            this.supplier_data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.supplier_data.Size = new System.Drawing.Size(351, 347);
            this.supplier_data.TabIndex = 0;
            this.supplier_data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.supplier_data_CellClick);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.Black;
            this.btn_add.Location = new System.Drawing.Point(153, 445);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(82, 37);
            this.btn_add.TabIndex = 83;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Ivory;
            this.btn_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.Black;
            this.btn_clear.Location = new System.Drawing.Point(241, 445);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(82, 37);
            this.btn_clear.TabIndex = 85;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            // 
            // iExpiry_txt
            // 
            this.iExpiry_txt.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iExpiry_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iExpiry_txt.Location = new System.Drawing.Point(153, 389);
            this.iExpiry_txt.Name = "iExpiry_txt";
            this.iExpiry_txt.Size = new System.Drawing.Size(171, 26);
            this.iExpiry_txt.TabIndex = 219;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(28, 389);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 20);
            this.label9.TabIndex = 218;
            this.label9.Text = "Item Expiry";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(28, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 20);
            this.label8.TabIndex = 216;
            this.label8.Text = "Item Quantity";
            // 
            // iPrice_txt
            // 
            this.iPrice_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iPrice_txt.Location = new System.Drawing.Point(153, 237);
            this.iPrice_txt.Name = "iPrice_txt";
            this.iPrice_txt.Size = new System.Drawing.Size(171, 24);
            this.iPrice_txt.TabIndex = 215;
            this.iPrice_txt.Tag = "";
            this.iPrice_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.iPrice_txt.TextChanged += new System.EventHandler(this.iPrice_txt_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(28, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 214;
            this.label7.Text = "Item Price";
            // 
            // iName_txt
            // 
            this.iName_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iName_txt.Location = new System.Drawing.Point(153, 183);
            this.iName_txt.Name = "iName_txt";
            this.iName_txt.Size = new System.Drawing.Size(171, 24);
            this.iName_txt.TabIndex = 213;
            this.iName_txt.Tag = "";
            this.iName_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(28, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 212;
            this.label6.Text = "Item Name";
            // 
            // supplier_txt
            // 
            this.supplier_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier_txt.Location = new System.Drawing.Point(153, 137);
            this.supplier_txt.Name = "supplier_txt";
            this.supplier_txt.ReadOnly = true;
            this.supplier_txt.Size = new System.Drawing.Size(171, 24);
            this.supplier_txt.TabIndex = 211;
            this.supplier_txt.Tag = "";
            this.supplier_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.supplier_txt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.supplier_txt_MouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(28, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 210;
            this.label5.Text = "Supplier";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.panel7.Controls.Add(this.encoderPos);
            this.panel7.Controls.Add(this.date);
            this.panel7.Controls.Add(this.panel5);
            this.panel7.Controls.Add(this.encoderLbl);
            this.panel7.Location = new System.Drawing.Point(0, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(393, 91);
            this.panel7.TabIndex = 209;
            // 
            // encoderPos
            // 
            this.encoderPos.AutoSize = true;
            this.encoderPos.BackColor = System.Drawing.Color.Transparent;
            this.encoderPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encoderPos.ForeColor = System.Drawing.Color.White;
            this.encoderPos.Location = new System.Drawing.Point(14, 60);
            this.encoderPos.Name = "encoderPos";
            this.encoderPos.Size = new System.Drawing.Size(83, 24);
            this.encoderPos.TabIndex = 211;
            this.encoderPos.Text = "position";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.BackColor = System.Drawing.Color.Transparent;
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.Color.White;
            this.date.Location = new System.Drawing.Point(260, 42);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(50, 24);
            this.date.TabIndex = 210;
            this.date.Text = "date";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(393, 33);
            this.panel5.TabIndex = 209;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 73;
            this.label1.Text = "Encoder: ";
            // 
            // encoderLbl
            // 
            this.encoderLbl.AutoSize = true;
            this.encoderLbl.BackColor = System.Drawing.Color.Transparent;
            this.encoderLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encoderLbl.ForeColor = System.Drawing.Color.White;
            this.encoderLbl.Location = new System.Drawing.Point(14, 36);
            this.encoderLbl.Name = "encoderLbl";
            this.encoderLbl.Size = new System.Drawing.Size(62, 24);
            this.encoderLbl.TabIndex = 73;
            this.encoderLbl.Text = "name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(479, 24);
            this.label2.TabIndex = 75;
            this.label2.Text = "ITEM DETAILS                                                       ";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.panel10.Controls.Add(this.label4);
            this.panel10.Location = new System.Drawing.Point(396, 63);
            this.panel10.Margin = new System.Windows.Forms.Padding(2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(332, 40);
            this.panel10.TabIndex = 211;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(71, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 24);
            this.label4.TabIndex = 74;
            this.label4.Text = "ITEMS ORDERED";
            // 
            // items_ordered
            // 
            this.items_ordered.AllowUserToAddRows = false;
            this.items_ordered.AllowUserToDeleteRows = false;
            this.items_ordered.AllowUserToResizeColumns = false;
            this.items_ordered.AllowUserToResizeRows = false;
            this.items_ordered.BackgroundColor = System.Drawing.Color.MintCream;
            this.items_ordered.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.items_ordered.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.items_ordered.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.items_ordered.Location = new System.Drawing.Point(398, 108);
            this.items_ordered.Name = "items_ordered";
            this.items_ordered.ReadOnly = true;
            this.items_ordered.RowHeadersVisible = false;
            this.items_ordered.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.items_ordered.Size = new System.Drawing.Size(329, 409);
            this.items_ordered.TabIndex = 210;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.panel2.Location = new System.Drawing.Point(398, 527);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(332, 67);
            this.panel2.TabIndex = 212;
            // 
            // PurchaseOrder_create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 616);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.items_ordered);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PurchaseOrder_create";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PurchaseOrder_create";
            this.Load += new System.EventHandler(this.PurchaseOrder_create_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iQuantity_txt)).EndInit();
            this.supplierpanel.ResumeLayout(false);
            this.supplierpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplier_data)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.items_ordered)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label encoderPos;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label encoderLbl;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView items_ordered;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox supplier_txt;
        private System.Windows.Forms.DateTimePicker iExpiry_txt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox iPrice_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox iName_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel supplierpanel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView supplier_data;
        private System.Windows.Forms.TextBox subtotal_txt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown iQuantity_txt;
    }
}