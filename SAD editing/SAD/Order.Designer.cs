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
            this.paymentpanel = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.dinein = new System.Windows.Forms.RadioButton();
            this.takeout = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.subTotalTxt = new System.Windows.Forms.TextBox();
            this.prodname = new System.Windows.Forms.TextBox();
            this.quantityTxt = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.encoderPos = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.encoderLbl = new System.Windows.Forms.Label();
            this.cb_category = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.product_data = new System.Windows.Forms.DataGridView();
            this.ordered_products = new System.Windows.Forms.DataGridView();
            this.TotalTB = new System.Windows.Forms.TextBox();
            this.Total = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.checkout = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.prodcategory = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.paymentpanel.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityTxt)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.product_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordered_products)).BeginInit();
            this.panel10.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.panel1.Controls.Add(this.paymentpanel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-6, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1032, 54);
            this.panel1.TabIndex = 101;
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Tomato;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(886, 3);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(113, 52);
            this.Back.TabIndex = 85;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // paymentpanel
            // 
            this.paymentpanel.BackColor = System.Drawing.Color.Brown;
            this.paymentpanel.Controls.Add(this.btn_back);
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
            this.paymentpanel.Location = new System.Drawing.Point(144, 14);
            this.paymentpanel.Name = "paymentpanel";
            this.paymentpanel.Size = new System.Drawing.Size(29, 99);
            this.paymentpanel.TabIndex = 208;
            this.paymentpanel.Visible = false;
            this.paymentpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.paymentpanel_Paint);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Tomato;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.Black;
            this.btn_back.Location = new System.Drawing.Point(232, 300);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(91, 36);
            this.btn_back.TabIndex = 212;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.button1_Click);
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
            this.pay.Location = new System.Drawing.Point(114, 300);
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
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.panel6.Controls.Add(this.prodcategory);
            this.panel6.Controls.Add(this.dinein);
            this.panel6.Controls.Add(this.takeout);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.btn_clear);
            this.panel6.Controls.Add(this.btn_remove);
            this.panel6.Controls.Add(this.btn_add);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.subTotalTxt);
            this.panel6.Controls.Add(this.prodname);
            this.panel6.Controls.Add(this.quantityTxt);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.priceTxt);
            this.panel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(6, 169);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(379, 405);
            this.panel6.TabIndex = 204;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // dinein
            // 
            this.dinein.AutoSize = true;
            this.dinein.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dinein.ForeColor = System.Drawing.Color.White;
            this.dinein.Location = new System.Drawing.Point(207, 288);
            this.dinein.Name = "dinein";
            this.dinein.Size = new System.Drawing.Size(78, 22);
            this.dinein.TabIndex = 212;
            this.dinein.Text = "Dine In";
            this.dinein.UseVisualStyleBackColor = true;
            // 
            // takeout
            // 
            this.takeout.AutoSize = true;
            this.takeout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.takeout.ForeColor = System.Drawing.Color.White;
            this.takeout.Location = new System.Drawing.Point(102, 288);
            this.takeout.Name = "takeout";
            this.takeout.Size = new System.Drawing.Size(95, 22);
            this.takeout.TabIndex = 211;
            this.takeout.TabStop = true;
            this.takeout.Text = "Take Out";
            this.takeout.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(-1, 261);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(392, 18);
            this.label12.TabIndex = 210;
            this.label12.Text = "Order Type                                                            ";
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Ivory;
            this.btn_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.Black;
            this.btn_clear.Location = new System.Drawing.Point(250, 328);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(82, 37);
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
            this.btn_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove.ForeColor = System.Drawing.Color.Black;
            this.btn_remove.Location = new System.Drawing.Point(144, 328);
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
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.Black;
            this.btn_add.Location = new System.Drawing.Point(56, 327);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(82, 37);
            this.btn_add.TabIndex = 83;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(-1, 196);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(395, 18);
            this.label13.TabIndex = 82;
            this.label13.Text = " SubTotal                                                               ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-4, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(404, 18);
            this.label2.TabIndex = 75;
            this.label2.Text = " Product Details                                                       ";
            // 
            // subTotalTxt
            // 
            this.subTotalTxt.Enabled = false;
            this.subTotalTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalTxt.Location = new System.Drawing.Point(106, 226);
            this.subTotalTxt.Name = "subTotalTxt";
            this.subTotalTxt.ReadOnly = true;
            this.subTotalTxt.Size = new System.Drawing.Size(156, 24);
            this.subTotalTxt.TabIndex = 81;
            this.subTotalTxt.Text = "0";
            this.subTotalTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // prodname
            // 
            this.prodname.Enabled = false;
            this.prodname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodname.Location = new System.Drawing.Point(103, 25);
            this.prodname.Name = "prodname";
            this.prodname.ReadOnly = true;
            this.prodname.Size = new System.Drawing.Size(156, 24);
            this.prodname.TabIndex = 80;
            this.prodname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // quantityTxt
            // 
            this.quantityTxt.Enabled = false;
            this.quantityTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityTxt.Location = new System.Drawing.Point(106, 157);
            this.quantityTxt.Name = "quantityTxt";
            this.quantityTxt.Size = new System.Drawing.Size(156, 24);
            this.quantityTxt.TabIndex = 79;
            this.quantityTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.quantityTxt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantityTxt.ValueChanged += new System.EventHandler(this.quantityTxt_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(400, 18);
            this.label5.TabIndex = 78;
            this.label5.Text = " Quantity                                                                 ";
            // 
            // priceTxt
            // 
            this.priceTxt.Enabled = false;
            this.priceTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTxt.Location = new System.Drawing.Point(103, 85);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.ReadOnly = true;
            this.priceTxt.Size = new System.Drawing.Size(156, 24);
            this.priceTxt.TabIndex = 77;
            this.priceTxt.Text = "0";
            this.priceTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.panel7.Controls.Add(this.encoderPos);
            this.panel7.Controls.Add(this.date);
            this.panel7.Controls.Add(this.panel5);
            this.panel7.Controls.Add(this.encoderLbl);
            this.panel7.Location = new System.Drawing.Point(5, 62);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(379, 104);
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
            // cb_category
            // 
            this.cb_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_category.FormattingEnabled = true;
            this.cb_category.Items.AddRange(new object[] {
            "Beverage",
            "Add on",
            "Best Seller",
            "Side Dish",
            "Tipid Meal",
            "Special Meal",
            "Main Dishes"});
            this.cb_category.Location = new System.Drawing.Point(445, 9);
            this.cb_category.Name = "cb_category";
            this.cb_category.Size = new System.Drawing.Size(123, 26);
            this.cb_category.TabIndex = 209;
            this.cb_category.SelectedIndexChanged += new System.EventHandler(this.cb_category_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(348, 12);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 18);
            this.label14.TabIndex = 208;
            this.label14.Text = "CATEGORY";
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
            this.product_data.Location = new System.Drawing.Point(402, 110);
            this.product_data.Name = "product_data";
            this.product_data.ReadOnly = true;
            this.product_data.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.product_data.RowHeadersVisible = false;
            this.product_data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.product_data.Size = new System.Drawing.Size(571, 162);
            this.product_data.TabIndex = 0;
            this.product_data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.product_data_CellClick);
            // 
            // ordered_products
            // 
            this.ordered_products.AllowUserToAddRows = false;
            this.ordered_products.AllowUserToDeleteRows = false;
            this.ordered_products.AllowUserToResizeColumns = false;
            this.ordered_products.AllowUserToResizeRows = false;
            this.ordered_products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ordered_products.BackgroundColor = System.Drawing.Color.MintCream;
            this.ordered_products.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ordered_products.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.ordered_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordered_products.Location = new System.Drawing.Point(402, 322);
            this.ordered_products.Name = "ordered_products";
            this.ordered_products.ReadOnly = true;
            this.ordered_products.RowHeadersVisible = false;
            this.ordered_products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ordered_products.Size = new System.Drawing.Size(571, 214);
            this.ordered_products.TabIndex = 205;
            // 
            // TotalTB
            // 
            this.TotalTB.BackColor = System.Drawing.SystemColors.Window;
            this.TotalTB.Enabled = false;
            this.TotalTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTB.Location = new System.Drawing.Point(65, 7);
            this.TotalTB.Name = "TotalTB";
            this.TotalTB.Size = new System.Drawing.Size(113, 29);
            this.TotalTB.TabIndex = 208;
            this.TotalTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.ForeColor = System.Drawing.Color.White;
            this.Total.Location = new System.Drawing.Point(8, 12);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(51, 24);
            this.Total.TabIndex = 207;
            this.Total.Text = "Total";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.panel10.Controls.Add(this.label4);
            this.panel10.Location = new System.Drawing.Point(402, 277);
            this.panel10.Margin = new System.Windows.Forms.Padding(2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(571, 43);
            this.panel10.TabIndex = 209;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(187, 12);
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
            this.checkout.Location = new System.Drawing.Point(457, 0);
            this.checkout.Name = "checkout";
            this.checkout.Size = new System.Drawing.Size(114, 44);
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
            this.panel2.Location = new System.Drawing.Point(402, 530);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(571, 44);
            this.panel2.TabIndex = 210;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.panel3.Controls.Add(this.cb_category);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Location = new System.Drawing.Point(402, 62);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(571, 43);
            this.panel3.TabIndex = 211;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(8, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(214, 20);
            this.label7.TabIndex = 74;
            this.label7.Text = "AVAILABLE PRODUCTS ";
            // 
            // prodcategory
            // 
            this.prodcategory.Enabled = false;
            this.prodcategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodcategory.Location = new System.Drawing.Point(103, 55);
            this.prodcategory.Name = "prodcategory";
            this.prodcategory.ReadOnly = true;
            this.prodcategory.Size = new System.Drawing.Size(156, 24);
            this.prodcategory.TabIndex = 213;
            this.prodcategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(984, 590);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.product_data);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.ordered_products);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.paymentpanel.ResumeLayout(false);
            this.paymentpanel.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityTxt)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.product_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordered_products)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.ComboBox cb_category;
        private System.Windows.Forms.Label discountTypelbl;
        public System.Windows.Forms.ComboBox cb_discountType;
        private System.Windows.Forms.CheckBox discountCheck;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox prodcategory;
    }
}