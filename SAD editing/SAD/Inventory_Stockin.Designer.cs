namespace SAD
{
    partial class Inventory_Stockin
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
            this.btn_remove = new System.Windows.Forms.Button();
            this.item_panel = new System.Windows.Forms.Panel();
            this.btn_item = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.item_data = new System.Windows.Forms.DataGridView();
            this.iQuantity_txt = new System.Windows.Forms.NumericUpDown();
            this.subtotal_txt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.iExpiry_txt = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.iPrice_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.iName_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.encoderPos = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.encoderLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.stockin_btn = new System.Windows.Forms.Button();
            this.Total = new System.Windows.Forms.Label();
            this.TotalTB = new System.Windows.Forms.TextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.items_purchased = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.item_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.item_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iQuantity_txt)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.items_purchased)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Location = new System.Drawing.Point(-48, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1041, 68);
            this.panel1.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(72, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 25);
            this.label3.TabIndex = 65;
            this.label3.Text = "STOCK IN";
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btn_close.Location = new System.Drawing.Point(889, 4);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(95, 64);
            this.btn_close.TabIndex = 64;
            this.btn_close.Text = "BACK";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.panel6.Controls.Add(this.btn_remove);
            this.panel6.Controls.Add(this.item_panel);
            this.panel6.Controls.Add(this.iQuantity_txt);
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
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(11, 70);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(527, 550);
            this.panel6.TabIndex = 206;
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btn_remove.FlatAppearance.BorderSize = 0;
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btn_remove.Location = new System.Drawing.Point(304, 448);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(101, 37);
            this.btn_remove.TabIndex = 228;
            this.btn_remove.Text = "REMOVE";
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // item_panel
            // 
            this.item_panel.BackColor = System.Drawing.Color.Brown;
            this.item_panel.Controls.Add(this.btn_item);
            this.item_panel.Controls.Add(this.label10);
            this.item_panel.Controls.Add(this.item_data);
            this.item_panel.Location = new System.Drawing.Point(3, 124);
            this.item_panel.Name = "item_panel";
            this.item_panel.Size = new System.Drawing.Size(19, 171);
            this.item_panel.TabIndex = 224;
            this.item_panel.Visible = false;
            // 
            // btn_item
            // 
            this.btn_item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btn_item.FlatAppearance.BorderSize = 0;
            this.btn_item.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_item.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btn_item.Location = new System.Drawing.Point(353, 38);
            this.btn_item.Name = "btn_item";
            this.btn_item.Size = new System.Drawing.Size(144, 25);
            this.btn_item.TabIndex = 209;
            this.btn_item.Text = "Add Items";
            this.btn_item.UseVisualStyleBackColor = false;
            this.btn_item.Click += new System.EventHandler(this.btn_item_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(32, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 31);
            this.label10.TabIndex = 207;
            this.label10.Text = "ITEMS";
            // 
            // item_data
            // 
            this.item_data.AllowUserToAddRows = false;
            this.item_data.AllowUserToDeleteRows = false;
            this.item_data.AllowUserToResizeColumns = false;
            this.item_data.AllowUserToResizeRows = false;
            this.item_data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.item_data.BackgroundColor = System.Drawing.Color.White;
            this.item_data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.item_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.item_data.Location = new System.Drawing.Point(38, 66);
            this.item_data.Name = "item_data";
            this.item_data.ReadOnly = true;
            this.item_data.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.item_data.RowHeadersVisible = false;
            this.item_data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.item_data.Size = new System.Drawing.Size(459, 314);
            this.item_data.TabIndex = 0;
            this.item_data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.item_data_CellClick);
            // 
            // iQuantity_txt
            // 
            this.iQuantity_txt.Enabled = false;
            this.iQuantity_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iQuantity_txt.Location = new System.Drawing.Point(241, 271);
            this.iQuantity_txt.Name = "iQuantity_txt";
            this.iQuantity_txt.Size = new System.Drawing.Size(152, 24);
            this.iQuantity_txt.TabIndex = 223;
            this.iQuantity_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.iQuantity_txt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // subtotal_txt
            // 
            this.subtotal_txt.Enabled = false;
            this.subtotal_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotal_txt.Location = new System.Drawing.Point(242, 322);
            this.subtotal_txt.Name = "subtotal_txt";
            this.subtotal_txt.ReadOnly = true;
            this.subtotal_txt.Size = new System.Drawing.Size(151, 24);
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
            this.label11.Location = new System.Drawing.Point(111, 322);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 20);
            this.label11.TabIndex = 221;
            this.label11.Text = "Item Subtotal";
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.Black;
            this.btn_add.Location = new System.Drawing.Point(125, 448);
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
            this.btn_clear.Location = new System.Drawing.Point(213, 448);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(82, 37);
            this.btn_clear.TabIndex = 85;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // iExpiry_txt
            // 
            this.iExpiry_txt.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iExpiry_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iExpiry_txt.Location = new System.Drawing.Point(240, 373);
            this.iExpiry_txt.Name = "iExpiry_txt";
            this.iExpiry_txt.Size = new System.Drawing.Size(153, 24);
            this.iExpiry_txt.TabIndex = 219;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(111, 373);
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
            this.label8.Location = new System.Drawing.Point(111, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 20);
            this.label8.TabIndex = 216;
            this.label8.Text = "Item Quantity";
            // 
            // iPrice_txt
            // 
            this.iPrice_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iPrice_txt.Location = new System.Drawing.Point(242, 221);
            this.iPrice_txt.Name = "iPrice_txt";
            this.iPrice_txt.Size = new System.Drawing.Size(151, 24);
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
            this.label7.Location = new System.Drawing.Point(111, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 214;
            this.label7.Text = "Item Price";
            // 
            // iName_txt
            // 
            this.iName_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iName_txt.Location = new System.Drawing.Point(242, 167);
            this.iName_txt.Name = "iName_txt";
            this.iName_txt.Size = new System.Drawing.Size(151, 24);
            this.iName_txt.TabIndex = 213;
            this.iName_txt.Tag = "";
            this.iName_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.iName_txt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.iName_txt_MouseClick_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(111, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 212;
            this.label6.Text = "Item Name";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.panel7.Controls.Add(this.encoderPos);
            this.panel7.Controls.Add(this.date);
            this.panel7.Controls.Add(this.panel5);
            this.panel7.Controls.Add(this.encoderLbl);
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(527, 94);
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
            this.date.Location = new System.Drawing.Point(409, 36);
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
            this.panel5.Size = new System.Drawing.Size(527, 33);
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
            this.label2.Size = new System.Drawing.Size(572, 24);
            this.label2.TabIndex = 75;
            this.label2.Text = "ITEM RECEIPT DETAILS                                                       ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.panel2.Controls.Add(this.stockin_btn);
            this.panel2.Controls.Add(this.Total);
            this.panel2.Controls.Add(this.TotalTB);
            this.panel2.Location = new System.Drawing.Point(543, 553);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(377, 51);
            this.panel2.TabIndex = 215;
            // 
            // stockin_btn
            // 
            this.stockin_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.stockin_btn.FlatAppearance.BorderSize = 0;
            this.stockin_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stockin_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockin_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.stockin_btn.Location = new System.Drawing.Point(276, 0);
            this.stockin_btn.Name = "stockin_btn";
            this.stockin_btn.Size = new System.Drawing.Size(101, 51);
            this.stockin_btn.TabIndex = 215;
            this.stockin_btn.Text = "STOCK IN";
            this.stockin_btn.UseVisualStyleBackColor = false;
            this.stockin_btn.Click += new System.EventHandler(this.stockin_btn_Click);
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.ForeColor = System.Drawing.Color.White;
            this.Total.Location = new System.Drawing.Point(20, 12);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(51, 24);
            this.Total.TabIndex = 209;
            this.Total.Text = "Total";
            // 
            // TotalTB
            // 
            this.TotalTB.BackColor = System.Drawing.SystemColors.Window;
            this.TotalTB.Enabled = false;
            this.TotalTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTB.Location = new System.Drawing.Point(77, 9);
            this.TotalTB.Name = "TotalTB";
            this.TotalTB.Size = new System.Drawing.Size(113, 29);
            this.TotalTB.TabIndex = 210;
            this.TotalTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.panel10.Controls.Add(this.label4);
            this.panel10.Location = new System.Drawing.Point(543, 73);
            this.panel10.Margin = new System.Windows.Forms.Padding(2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(377, 40);
            this.panel10.TabIndex = 214;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(155, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 24);
            this.label4.TabIndex = 74;
            this.label4.Text = "ITEMS ";
            // 
            // items_purchased
            // 
            this.items_purchased.AllowUserToAddRows = false;
            this.items_purchased.AllowUserToDeleteRows = false;
            this.items_purchased.AllowUserToResizeColumns = false;
            this.items_purchased.AllowUserToResizeRows = false;
            this.items_purchased.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.items_purchased.BackgroundColor = System.Drawing.Color.MintCream;
            this.items_purchased.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.items_purchased.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.items_purchased.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.items_purchased.Location = new System.Drawing.Point(543, 118);
            this.items_purchased.Name = "items_purchased";
            this.items_purchased.ReadOnly = true;
            this.items_purchased.RowHeadersVisible = false;
            this.items_purchased.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.items_purchased.Size = new System.Drawing.Size(376, 430);
            this.items_purchased.TabIndex = 213;
            // 
            // Inventory_Stockin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 631);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.items_purchased);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inventory_Stockin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory_Stockin";
            this.Load += new System.EventHandler(this.Inventory_Stockin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.item_panel.ResumeLayout(false);
            this.item_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.item_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iQuantity_txt)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.items_purchased)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.NumericUpDown iQuantity_txt;
        private System.Windows.Forms.TextBox subtotal_txt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.DateTimePicker iExpiry_txt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox iPrice_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox iName_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label encoderPos;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label encoderLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.TextBox TotalTB;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView items_purchased;
        private System.Windows.Forms.Button stockin_btn;
        private System.Windows.Forms.Panel item_panel;
        private System.Windows.Forms.Button btn_item;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView item_data;
        private System.Windows.Forms.Button btn_remove;
    }
}