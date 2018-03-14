namespace SAD
{
    partial class Order
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Back = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.takeout = new System.Windows.Forms.RadioButton();
            this.subTotalTxt = new System.Windows.Forms.TextBox();
            this.quantityTxt = new System.Windows.Forms.NumericUpDown();
            this.dinein = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.prodname = new System.Windows.Forms.TextBox();
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.encoderPos = new System.Windows.Forms.Label();
            this.encoderLbl = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.paymentpanel = new System.Windows.Forms.Panel();
            this.discountCheck = new System.Windows.Forms.CheckBox();
            this.cb_discountType = new System.Windows.Forms.ComboBox();
            this.discountTypelbl = new System.Windows.Forms.Label();
            this.discountTxt = new System.Windows.Forms.TextBox();
            this.discountlbl = new System.Windows.Forms.Label();
            this.pay = new System.Windows.Forms.Button();
            this.changetxt = new System.Windows.Forms.TextBox();
            this.amountPaid = new System.Windows.Forms.TextBox();
            this.totalDue = new System.Windows.Forms.TextBox();
            this.changelbl = new System.Windows.Forms.Label();
            this.amountPaidlbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.cb_category = new System.Windows.Forms.ComboBox();
            this.product_data = new System.Windows.Forms.DataGridView();
            this.ordered_products = new System.Windows.Forms.DataGridView();
            this.ProdID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalTB = new System.Windows.Forms.TextBox();
            this.Total = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.checkout = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.stockleft = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityTxt)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.paymentpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.product_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordered_products)).BeginInit();
            this.panel10.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel13.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(29, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 31);
            this.label1.TabIndex = 37;
            this.label1.Text = "ORDER";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.Back);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-6, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1087, 54);
            this.panel1.TabIndex = 101;
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Tomato;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(984, 0);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(103, 54);
            this.Back.TabIndex = 85;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.takeout);
            this.panel6.Controls.Add(this.subTotalTxt);
            this.panel6.Controls.Add(this.quantityTxt);
            this.panel6.Controls.Add(this.dinein);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.prodname);
            this.panel6.Controls.Add(this.priceTxt);
            this.panel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(398, 214);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(244, 378);
            this.panel6.TabIndex = 204;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(480, 24);
            this.label2.TabIndex = 75;
            this.label2.Text = "Product Details                                                       ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(0, 286);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(429, 24);
            this.label12.TabIndex = 210;
            this.label12.Text = "Order Type                                                    ";
            // 
            // takeout
            // 
            this.takeout.AutoSize = true;
            this.takeout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.takeout.ForeColor = System.Drawing.Color.White;
            this.takeout.Location = new System.Drawing.Point(67, 347);
            this.takeout.Name = "takeout";
            this.takeout.Size = new System.Drawing.Size(113, 28);
            this.takeout.TabIndex = 211;
            this.takeout.TabStop = true;
            this.takeout.Text = "Take Out";
            this.takeout.UseVisualStyleBackColor = true;
            // 
            // subTotalTxt
            // 
            this.subTotalTxt.Enabled = false;
            this.subTotalTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalTxt.Location = new System.Drawing.Point(29, 240);
            this.subTotalTxt.Name = "subTotalTxt";
            this.subTotalTxt.ReadOnly = true;
            this.subTotalTxt.Size = new System.Drawing.Size(191, 29);
            this.subTotalTxt.TabIndex = 81;
            this.subTotalTxt.Text = "0";
            this.subTotalTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // quantityTxt
            // 
            this.quantityTxt.Enabled = false;
            this.quantityTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityTxt.Location = new System.Drawing.Point(29, 161);
            this.quantityTxt.Name = "quantityTxt";
            this.quantityTxt.Size = new System.Drawing.Size(191, 29);
            this.quantityTxt.TabIndex = 79;
            this.quantityTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.quantityTxt.ValueChanged += new System.EventHandler(this.quantityTxt_ValueChanged);
            // 
            // dinein
            // 
            this.dinein.AutoSize = true;
            this.dinein.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dinein.ForeColor = System.Drawing.Color.White;
            this.dinein.Location = new System.Drawing.Point(67, 313);
            this.dinein.Name = "dinein";
            this.dinein.Size = new System.Drawing.Size(94, 28);
            this.dinein.TabIndex = 212;
            this.dinein.Text = "Dine In";
            this.dinein.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(-4, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(434, 24);
            this.label5.TabIndex = 78;
            this.label5.Text = " Quantity                                                         ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(0, 203);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(417, 24);
            this.label13.TabIndex = 82;
            this.label13.Text = " SubTotal                                                     ";
            // 
            // prodname
            // 
            this.prodname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodname.Location = new System.Drawing.Point(29, 40);
            this.prodname.Name = "prodname";
            this.prodname.ReadOnly = true;
            this.prodname.Size = new System.Drawing.Size(191, 26);
            this.prodname.TabIndex = 80;
            this.prodname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // priceTxt
            // 
            this.priceTxt.Enabled = false;
            this.priceTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTxt.Location = new System.Drawing.Point(29, 83);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.ReadOnly = true;
            this.priceTxt.Size = new System.Drawing.Size(191, 29);
            this.priceTxt.TabIndex = 77;
            this.priceTxt.Text = "0";
            this.priceTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.panel7.Controls.Add(this.encoderPos);
            this.panel7.Controls.Add(this.encoderLbl);
            this.panel7.Controls.Add(this.date);
            this.panel7.Controls.Add(this.panel5);
            this.panel7.Location = new System.Drawing.Point(12, 58);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(376, 94);
            this.panel7.TabIndex = 209;
            // 
            // encoderPos
            // 
            this.encoderPos.AutoSize = true;
            this.encoderPos.BackColor = System.Drawing.Color.Transparent;
            this.encoderPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encoderPos.ForeColor = System.Drawing.Color.White;
            this.encoderPos.Location = new System.Drawing.Point(13, 60);
            this.encoderPos.Name = "encoderPos";
            this.encoderPos.Size = new System.Drawing.Size(83, 24);
            this.encoderPos.TabIndex = 211;
            this.encoderPos.Text = "position";
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
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(380, 33);
            this.panel5.TabIndex = 209;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 73;
            this.label3.Text = "Encoder: ";
            // 
            // paymentpanel
            // 
            this.paymentpanel.BackColor = System.Drawing.Color.Brown;
            this.paymentpanel.Controls.Add(this.discountCheck);
            this.paymentpanel.Controls.Add(this.cb_discountType);
            this.paymentpanel.Controls.Add(this.discountTypelbl);
            this.paymentpanel.Controls.Add(this.discountTxt);
            this.paymentpanel.Controls.Add(this.discountlbl);
            this.paymentpanel.Controls.Add(this.pay);
            this.paymentpanel.Controls.Add(this.changetxt);
            this.paymentpanel.Controls.Add(this.amountPaid);
            this.paymentpanel.Controls.Add(this.totalDue);
            this.paymentpanel.Controls.Add(this.changelbl);
            this.paymentpanel.Controls.Add(this.amountPaidlbl);
            this.paymentpanel.Controls.Add(this.label9);
            this.paymentpanel.Controls.Add(this.label6);
            this.paymentpanel.Location = new System.Drawing.Point(264, 253);
            this.paymentpanel.Name = "paymentpanel";
            this.paymentpanel.Size = new System.Drawing.Size(46, 57);
            this.paymentpanel.TabIndex = 208;
            this.paymentpanel.Visible = false;
            this.paymentpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.paymentpanel_Paint);
            // 
            // discountCheck
            // 
            this.discountCheck.AutoSize = true;
            this.discountCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountCheck.ForeColor = System.Drawing.Color.Transparent;
            this.discountCheck.Location = new System.Drawing.Point(184, 50);
            this.discountCheck.Name = "discountCheck";
            this.discountCheck.Size = new System.Drawing.Size(99, 24);
            this.discountCheck.TabIndex = 211;
            this.discountCheck.Text = "Discount";
            this.discountCheck.UseVisualStyleBackColor = true;
            this.discountCheck.CheckedChanged += new System.EventHandler(this.discountCheck_CheckedChanged);
            // 
            // cb_discountType
            // 
            this.cb_discountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_discountType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_discountType.FormattingEnabled = true;
            this.cb_discountType.Items.AddRange(new object[] {
            "Senior Citizen",
            "PWD"});
            this.cb_discountType.Location = new System.Drawing.Point(184, 202);
            this.cb_discountType.Name = "cb_discountType";
            this.cb_discountType.Size = new System.Drawing.Size(171, 32);
            this.cb_discountType.TabIndex = 210;
            this.cb_discountType.Visible = false;
            this.cb_discountType.SelectedIndexChanged += new System.EventHandler(this.cb_discountType_SelectedIndexChanged);
            // 
            // discountTypelbl
            // 
            this.discountTypelbl.AutoSize = true;
            this.discountTypelbl.BackColor = System.Drawing.Color.Transparent;
            this.discountTypelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountTypelbl.ForeColor = System.Drawing.Color.White;
            this.discountTypelbl.Location = new System.Drawing.Point(18, 209);
            this.discountTypelbl.Name = "discountTypelbl";
            this.discountTypelbl.Size = new System.Drawing.Size(163, 25);
            this.discountTypelbl.TabIndex = 96;
            this.discountTypelbl.Text = "Discount Type";
            this.discountTypelbl.Visible = false;
            // 
            // discountTxt
            // 
            this.discountTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.discountTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountTxt.Location = new System.Drawing.Point(184, 250);
            this.discountTxt.Name = "discountTxt";
            this.discountTxt.Size = new System.Drawing.Size(171, 29);
            this.discountTxt.TabIndex = 93;
            this.discountTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.discountTxt.Visible = false;
            this.discountTxt.TextChanged += new System.EventHandler(this.discountTxt_TextChanged);
            this.discountTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.discountTxt_KeyPress);
            // 
            // discountlbl
            // 
            this.discountlbl.AutoSize = true;
            this.discountlbl.BackColor = System.Drawing.Color.Transparent;
            this.discountlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountlbl.ForeColor = System.Drawing.Color.White;
            this.discountlbl.Location = new System.Drawing.Point(18, 254);
            this.discountlbl.Name = "discountlbl";
            this.discountlbl.Size = new System.Drawing.Size(147, 25);
            this.discountlbl.TabIndex = 92;
            this.discountlbl.Text = "Discount (%)";
            this.discountlbl.Visible = false;
            // 
            // pay
            // 
            this.pay.BackColor = System.Drawing.Color.LightGreen;
            this.pay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pay.ForeColor = System.Drawing.Color.Black;
            this.pay.Location = new System.Drawing.Point(225, 285);
            this.pay.Name = "pay";
            this.pay.Size = new System.Drawing.Size(91, 36);
            this.pay.TabIndex = 91;
            this.pay.Text = "Pay";
            this.pay.UseVisualStyleBackColor = false;
            this.pay.Click += new System.EventHandler(this.pay_Click);
            // 
            // changetxt
            // 
            this.changetxt.Enabled = false;
            this.changetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changetxt.Location = new System.Drawing.Point(184, 160);
            this.changetxt.Name = "changetxt";
            this.changetxt.Size = new System.Drawing.Size(171, 29);
            this.changetxt.TabIndex = 89;
            this.changetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // amountPaid
            // 
            this.amountPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountPaid.Location = new System.Drawing.Point(184, 123);
            this.amountPaid.Name = "amountPaid";
            this.amountPaid.Size = new System.Drawing.Size(171, 29);
            this.amountPaid.TabIndex = 88;
            this.amountPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.amountPaid.TextChanged += new System.EventHandler(this.amountPaid_TextChanged);
            this.amountPaid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.amountPaid_KeyPress);
            // 
            // totalDue
            // 
            this.totalDue.Enabled = false;
            this.totalDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalDue.Location = new System.Drawing.Point(184, 82);
            this.totalDue.Name = "totalDue";
            this.totalDue.Size = new System.Drawing.Size(171, 29);
            this.totalDue.TabIndex = 87;
            this.totalDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // changelbl
            // 
            this.changelbl.AutoSize = true;
            this.changelbl.BackColor = System.Drawing.Color.Transparent;
            this.changelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changelbl.ForeColor = System.Drawing.Color.White;
            this.changelbl.Location = new System.Drawing.Point(18, 164);
            this.changelbl.Name = "changelbl";
            this.changelbl.Size = new System.Drawing.Size(93, 25);
            this.changelbl.TabIndex = 79;
            this.changelbl.Text = "Change";
            // 
            // amountPaidlbl
            // 
            this.amountPaidlbl.AutoSize = true;
            this.amountPaidlbl.BackColor = System.Drawing.Color.Transparent;
            this.amountPaidlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountPaidlbl.ForeColor = System.Drawing.Color.White;
            this.amountPaidlbl.Location = new System.Drawing.Point(18, 127);
            this.amountPaidlbl.Name = "amountPaidlbl";
            this.amountPaidlbl.Size = new System.Drawing.Size(143, 25);
            this.amountPaidlbl.TabIndex = 78;
            this.amountPaidlbl.Text = "Amount paid";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(16, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 25);
            this.label9.TabIndex = 77;
            this.label9.Text = "Total due";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(-202, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1044, 33);
            this.label6.TabIndex = 75;
            this.label6.Text = "                                    PAYMENT                                      " +
    "                        ";
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Ivory;
            this.btn_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.Black;
            this.btn_clear.Location = new System.Drawing.Point(571, 603);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(71, 37);
            this.btn_clear.TabIndex = 85;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.Color.IndianRed;
            this.btn_remove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove.ForeColor = System.Drawing.Color.Black;
            this.btn_remove.Location = new System.Drawing.Point(465, 603);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(100, 37);
            this.btn_remove.TabIndex = 84;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.Black;
            this.btn_add.Location = new System.Drawing.Point(398, 603);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(63, 37);
            this.btn_add.TabIndex = 83;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // cb_category
            // 
            this.cb_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_category.FormattingEnabled = true;
            this.cb_category.Items.AddRange(new object[] {
            "All Day Breakfast",
            "Extras",
            "Pasta",
            "Burgers & Sandwiches",
            "Fries & Nachos",
            "Frappe",
            "Milkshakes",
            "House Specials",
            "All Time Favorite",
            "Hot & Cold Beverages",
            "Fresh Fruit Shakes",
            "Coolers"});
            this.cb_category.Location = new System.Drawing.Point(116, 6);
            this.cb_category.Name = "cb_category";
            this.cb_category.Size = new System.Drawing.Size(254, 33);
            this.cb_category.TabIndex = 209;
            this.cb_category.SelectedIndexChanged += new System.EventHandler(this.cb_category_SelectedIndexChanged);
            // 
            // product_data
            // 
            this.product_data.AllowUserToAddRows = false;
            this.product_data.AllowUserToDeleteRows = false;
            this.product_data.AllowUserToResizeColumns = false;
            this.product_data.AllowUserToResizeRows = false;
            this.product_data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.product_data.BackgroundColor = System.Drawing.Color.White;
            this.product_data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.product_data.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.product_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.product_data.Location = new System.Drawing.Point(9, 8);
            this.product_data.Name = "product_data";
            this.product_data.ReadOnly = true;
            this.product_data.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.product_data.RowHeadersVisible = false;
            this.product_data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.product_data.Size = new System.Drawing.Size(362, 378);
            this.product_data.TabIndex = 0;
            this.product_data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.product_data_CellClick);
            this.product_data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.product_data_CellContentClick);
            // 
            // ordered_products
            // 
            this.ordered_products.AllowUserToAddRows = false;
            this.ordered_products.AllowUserToDeleteRows = false;
            this.ordered_products.AllowUserToResizeColumns = false;
            this.ordered_products.AllowUserToResizeRows = false;
            this.ordered_products.BackgroundColor = System.Drawing.Color.MintCream;
            this.ordered_products.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ordered_products.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.ordered_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordered_products.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProdID,
            this.Name,
            this.Price,
            this.Quantity,
            this.Subtotal,
            this.OrderType});
            this.ordered_products.Location = new System.Drawing.Point(647, 254);
            this.ordered_products.Name = "ordered_products";
            this.ordered_products.ReadOnly = true;
            this.ordered_products.RowHeadersVisible = false;
            this.ordered_products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ordered_products.Size = new System.Drawing.Size(421, 338);
            this.ordered_products.TabIndex = 205;
            // 
            // ProdID
            // 
            this.ProdID.HeaderText = "Product ID";
            this.ProdID.Name = "ProdID";
            this.ProdID.ReadOnly = true;
            this.ProdID.Visible = false;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            // 
            // OrderType
            // 
            this.OrderType.HeaderText = "Order Type";
            this.OrderType.Name = "OrderType";
            this.OrderType.ReadOnly = true;
            // 
            // TotalTB
            // 
            this.TotalTB.BackColor = System.Drawing.SystemColors.Window;
            this.TotalTB.Enabled = false;
            this.TotalTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTB.Location = new System.Drawing.Point(169, 9);
            this.TotalTB.Name = "TotalTB";
            this.TotalTB.Size = new System.Drawing.Size(113, 29);
            this.TotalTB.TabIndex = 208;
            this.TotalTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.ForeColor = System.Drawing.Color.White;
            this.Total.Location = new System.Drawing.Point(103, 13);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(60, 25);
            this.Total.TabIndex = 207;
            this.Total.Text = "Total";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.panel10.Controls.Add(this.label4);
            this.panel10.Location = new System.Drawing.Point(647, 214);
            this.panel10.Margin = new System.Windows.Forms.Padding(2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(421, 35);
            this.panel10.TabIndex = 209;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(112, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 24);
            this.label4.TabIndex = 74;
            this.label4.Text = "PRODUCTS ORDERED ";
            // 
            // checkout
            // 
            this.checkout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.checkout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkout.Location = new System.Drawing.Point(288, 7);
            this.checkout.Name = "checkout";
            this.checkout.Size = new System.Drawing.Size(113, 35);
            this.checkout.TabIndex = 210;
            this.checkout.Text = "Checkout";
            this.checkout.UseVisualStyleBackColor = false;
            this.checkout.Click += new System.EventHandler(this.checkout_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.panel2.Controls.Add(this.checkout);
            this.panel2.Controls.Add(this.Total);
            this.panel2.Controls.Add(this.TotalTB);
            this.panel2.Location = new System.Drawing.Point(647, 590);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(421, 50);
            this.panel2.TabIndex = 210;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel9.Controls.Add(this.paymentpanel);
            this.panel9.Controls.Add(this.panel12);
            this.panel9.Controls.Add(this.label8);
            this.panel9.Location = new System.Drawing.Point(12, 214);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(376, 426);
            this.panel9.TabIndex = 216;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.panel12.Controls.Add(this.product_data);
            this.panel12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel12.Location = new System.Drawing.Point(-1, 32);
            this.panel12.Margin = new System.Windows.Forms.Padding(2);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(381, 394);
            this.panel12.TabIndex = 218;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 25);
            this.label8.TabIndex = 73;
            this.label8.Text = "Products";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel11.Controls.Add(this.cb_category);
            this.panel11.Controls.Add(this.label10);
            this.panel11.Location = new System.Drawing.Point(12, 159);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(376, 49);
            this.panel11.TabIndex = 217;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(3, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 25);
            this.label10.TabIndex = 73;
            this.label10.Text = "Category";
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.Peru;
            this.panel13.Controls.Add(this.stockleft);
            this.panel13.Controls.Add(this.label11);
            this.panel13.Controls.Add(this.label7);
            this.panel13.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel13.Location = new System.Drawing.Point(398, 58);
            this.panel13.Margin = new System.Windows.Forms.Padding(2);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(670, 150);
            this.panel13.TabIndex = 218;
            // 
            // stockleft
            // 
            this.stockleft.Enabled = false;
            this.stockleft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockleft.Location = new System.Drawing.Point(5, 121);
            this.stockleft.Name = "stockleft";
            this.stockleft.ReadOnly = true;
            this.stockleft.Size = new System.Drawing.Size(191, 26);
            this.stockleft.TabIndex = 211;
            this.stockleft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.stockleft.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(209, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(321, 31);
            this.label11.TabIndex = 75;
            this.label11.Text = "fresh ● flavorful ● delicious";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tempus Sans ITC", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(152, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(418, 126);
            this.label7.TabIndex = 74;
            this.label7.Text = "Cafetiere\r\n";
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1080, 654);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.ordered_products);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityTxt)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.paymentpanel.ResumeLayout(false);
            this.paymentpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.product_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordered_products)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView ordered_products;
        private System.Windows.Forms.TextBox priceTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown quantityTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.TextBox prodname;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox subTotalTxt;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox TotalTB;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.DataGridView product_data;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label encoderLbl;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label encoderPos;
        private System.Windows.Forms.Panel paymentpanel;
        private System.Windows.Forms.Button checkout;
        private System.Windows.Forms.Label changelbl;
        private System.Windows.Forms.Label amountPaidlbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox changetxt;
        private System.Windows.Forms.TextBox amountPaid;
        private System.Windows.Forms.TextBox totalDue;
        private System.Windows.Forms.Button pay;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton dinein;
        private System.Windows.Forms.RadioButton takeout;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox discountTxt;
        private System.Windows.Forms.Label discountlbl;
        public System.Windows.Forms.ComboBox cb_category;
        private System.Windows.Forms.Label discountTypelbl;
        public System.Windows.Forms.ComboBox cb_discountType;
        private System.Windows.Forms.CheckBox discountCheck;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox stockleft;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderType;
    }
}