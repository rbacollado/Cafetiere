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
            this.dinein = new System.Windows.Forms.RadioButton();
            this.paymentpanel = new System.Windows.Forms.Panel();
            this.discountTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pay = new System.Windows.Forms.Button();
            this.backbtnSales = new System.Windows.Forms.Button();
            this.changetxt = new System.Windows.Forms.TextBox();
            this.amountPaid = new System.Windows.Forms.TextBox();
            this.totalDue = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.takeout = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.encoderPos = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.encoderLbl = new System.Windows.Forms.Label();
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
            this.productpanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.product_data = new System.Windows.Forms.DataGridView();
            this.ordered_products = new System.Windows.Forms.DataGridView();
            this.TotalTB = new System.Windows.Forms.TextBox();
            this.Total = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.checkout = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.paymentpanel.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityTxt)).BeginInit();
            this.productpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.product_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordered_products)).BeginInit();
            this.panel10.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(787, 54);
            this.panel1.TabIndex = 101;
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Tomato;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(639, 3);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(103, 51);
            this.Back.TabIndex = 85;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.panel6.Controls.Add(this.dinein);
            this.panel6.Controls.Add(this.paymentpanel);
            this.panel6.Controls.Add(this.takeout);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.panel7);
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
            this.panel6.Location = new System.Drawing.Point(11, 63);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(381, 541);
            this.panel6.TabIndex = 204;
            // 
            // dinein
            // 
            this.dinein.AutoSize = true;
            this.dinein.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dinein.ForeColor = System.Drawing.Color.White;
            this.dinein.Location = new System.Drawing.Point(197, 397);
            this.dinein.Name = "dinein";
            this.dinein.Size = new System.Drawing.Size(94, 28);
            this.dinein.TabIndex = 212;
            this.dinein.Text = "Dine In";
            this.dinein.UseVisualStyleBackColor = true;
            // 
            // paymentpanel
            // 
            this.paymentpanel.BackColor = System.Drawing.Color.Brown;
            this.paymentpanel.Controls.Add(this.discountTxt);
            this.paymentpanel.Controls.Add(this.label8);
            this.paymentpanel.Controls.Add(this.pay);
            this.paymentpanel.Controls.Add(this.backbtnSales);
            this.paymentpanel.Controls.Add(this.changetxt);
            this.paymentpanel.Controls.Add(this.amountPaid);
            this.paymentpanel.Controls.Add(this.totalDue);
            this.paymentpanel.Controls.Add(this.label11);
            this.paymentpanel.Controls.Add(this.label10);
            this.paymentpanel.Controls.Add(this.label9);
            this.paymentpanel.Controls.Add(this.label6);
            this.paymentpanel.Location = new System.Drawing.Point(350, 434);
            this.paymentpanel.Name = "paymentpanel";
            this.paymentpanel.Size = new System.Drawing.Size(35, 56);
            this.paymentpanel.TabIndex = 208;
            this.paymentpanel.Visible = false;
            // 
            // discountTxt
            // 
            this.discountTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountTxt.Location = new System.Drawing.Point(186, 128);
            this.discountTxt.Name = "discountTxt";
            this.discountTxt.Size = new System.Drawing.Size(126, 29);
            this.discountTxt.TabIndex = 93;
            this.discountTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.discountTxt.TextChanged += new System.EventHandler(this.discountTxt_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(18, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 25);
            this.label8.TabIndex = 92;
            this.label8.Text = "Discount (%)";
            // 
            // pay
            // 
            this.pay.BackColor = System.Drawing.Color.LightGreen;
            this.pay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pay.ForeColor = System.Drawing.Color.Black;
            this.pay.Location = new System.Drawing.Point(91, 327);
            this.pay.Name = "pay";
            this.pay.Size = new System.Drawing.Size(91, 36);
            this.pay.TabIndex = 91;
            this.pay.Text = "Pay";
            this.pay.UseVisualStyleBackColor = false;
            this.pay.Click += new System.EventHandler(this.pay_Click);
            // 
            // backbtnSales
            // 
            this.backbtnSales.BackColor = System.Drawing.Color.Tomato;
            this.backbtnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbtnSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtnSales.ForeColor = System.Drawing.Color.Black;
            this.backbtnSales.Location = new System.Drawing.Point(217, 327);
            this.backbtnSales.Name = "backbtnSales";
            this.backbtnSales.Size = new System.Drawing.Size(93, 36);
            this.backbtnSales.TabIndex = 90;
            this.backbtnSales.Text = "Back";
            this.backbtnSales.UseVisualStyleBackColor = false;
            this.backbtnSales.Click += new System.EventHandler(this.backbtnSales_Click);
            // 
            // changetxt
            // 
            this.changetxt.Enabled = false;
            this.changetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changetxt.Location = new System.Drawing.Point(186, 218);
            this.changetxt.Name = "changetxt";
            this.changetxt.Size = new System.Drawing.Size(126, 29);
            this.changetxt.TabIndex = 89;
            this.changetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // amountPaid
            // 
            this.amountPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountPaid.Location = new System.Drawing.Point(186, 173);
            this.amountPaid.Name = "amountPaid";
            this.amountPaid.Size = new System.Drawing.Size(126, 29);
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
            this.totalDue.Size = new System.Drawing.Size(126, 29);
            this.totalDue.TabIndex = 87;
            this.totalDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(18, 218);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 25);
            this.label11.TabIndex = 79;
            this.label11.Text = "Change";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(18, 173);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 25);
            this.label10.TabIndex = 78;
            this.label10.Text = "Amount paid";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(16, 82);
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
            this.label6.Location = new System.Drawing.Point(-214, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1044, 33);
            this.label6.TabIndex = 75;
            this.label6.Text = "                                    PAYMENT                                      " +
    "                        ";
            // 
            // takeout
            // 
            this.takeout.AutoSize = true;
            this.takeout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.takeout.ForeColor = System.Drawing.Color.White;
            this.takeout.Location = new System.Drawing.Point(48, 397);
            this.takeout.Name = "takeout";
            this.takeout.Size = new System.Drawing.Size(113, 28);
            this.takeout.TabIndex = 211;
            this.takeout.TabStop = true;
            this.takeout.Text = "Take Out";
            this.takeout.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(1, 361);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(429, 24);
            this.label12.TabIndex = 210;
            this.label12.Text = "Order Type                                                    ";
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
            this.panel7.Size = new System.Drawing.Size(380, 94);
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
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Ivory;
            this.btn_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.Black;
            this.btn_clear.Location = new System.Drawing.Point(242, 469);
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
            this.btn_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove.ForeColor = System.Drawing.Color.Black;
            this.btn_remove.Location = new System.Drawing.Point(136, 469);
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
            this.btn_add.Location = new System.Drawing.Point(48, 468);
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
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(-4, 282);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(417, 24);
            this.label13.TabIndex = 82;
            this.label13.Text = " SubTotal                                                     ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(480, 24);
            this.label2.TabIndex = 75;
            this.label2.Text = "Product Details                                                       ";
            // 
            // subTotalTxt
            // 
            this.subTotalTxt.Enabled = false;
            this.subTotalTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalTxt.Location = new System.Drawing.Point(80, 319);
            this.subTotalTxt.Name = "subTotalTxt";
            this.subTotalTxt.ReadOnly = true;
            this.subTotalTxt.Size = new System.Drawing.Size(191, 29);
            this.subTotalTxt.TabIndex = 81;
            this.subTotalTxt.Text = "0";
            this.subTotalTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // prodname
            // 
            this.prodname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodname.Location = new System.Drawing.Point(80, 134);
            this.prodname.Name = "prodname";
            this.prodname.ReadOnly = true;
            this.prodname.Size = new System.Drawing.Size(191, 26);
            this.prodname.TabIndex = 80;
            this.prodname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.prodname.MouseClick += new System.Windows.Forms.MouseEventHandler(this.prod_MouseClick);
            this.prodname.TextChanged += new System.EventHandler(this.prodname_TextChanged);
            // 
            // quantityTxt
            // 
            this.quantityTxt.Enabled = false;
            this.quantityTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityTxt.Location = new System.Drawing.Point(80, 241);
            this.quantityTxt.Name = "quantityTxt";
            this.quantityTxt.Size = new System.Drawing.Size(191, 29);
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
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(-4, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(434, 24);
            this.label5.TabIndex = 78;
            this.label5.Text = " Quantity                                                         ";
            // 
            // priceTxt
            // 
            this.priceTxt.Enabled = false;
            this.priceTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTxt.Location = new System.Drawing.Point(80, 166);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.ReadOnly = true;
            this.priceTxt.Size = new System.Drawing.Size(191, 29);
            this.priceTxt.TabIndex = 77;
            this.priceTxt.Text = "0";
            this.priceTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // productpanel
            // 
            this.productpanel.BackColor = System.Drawing.Color.Brown;
            this.productpanel.Controls.Add(this.label7);
            this.productpanel.Controls.Add(this.product_data);
            this.productpanel.Location = new System.Drawing.Point(366, 561);
            this.productpanel.Name = "productpanel";
            this.productpanel.Size = new System.Drawing.Size(161, 20);
            this.productpanel.TabIndex = 86;
            this.productpanel.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(93, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 31);
            this.label7.TabIndex = 207;
            this.label7.Text = "PRODUCTS";
            // 
            // product_data
            // 
            this.product_data.AllowUserToAddRows = false;
            this.product_data.AllowUserToDeleteRows = false;
            this.product_data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.product_data.BackgroundColor = System.Drawing.Color.White;
            this.product_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.product_data.Location = new System.Drawing.Point(17, 55);
            this.product_data.Name = "product_data";
            this.product_data.ReadOnly = true;
            this.product_data.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.product_data.RowHeadersVisible = false;
            this.product_data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.product_data.Size = new System.Drawing.Size(342, 285);
            this.product_data.TabIndex = 0;
            this.product_data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.product_data_CellClick);
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
            this.ordered_products.Location = new System.Drawing.Point(401, 111);
            this.ordered_products.Name = "ordered_products";
            this.ordered_products.ReadOnly = true;
            this.ordered_products.RowHeadersVisible = false;
            this.ordered_products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ordered_products.Size = new System.Drawing.Size(317, 409);
            this.ordered_products.TabIndex = 205;
            // 
            // TotalTB
            // 
            this.TotalTB.BackColor = System.Drawing.SystemColors.Window;
            this.TotalTB.Enabled = false;
            this.TotalTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTB.Location = new System.Drawing.Point(69, 14);
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
            this.Total.Location = new System.Drawing.Point(12, 19);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(51, 24);
            this.Total.TabIndex = 207;
            this.Total.Text = "Total";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.panel10.Controls.Add(this.label4);
            this.panel10.Location = new System.Drawing.Point(401, 63);
            this.panel10.Margin = new System.Windows.Forms.Padding(2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(318, 43);
            this.panel10.TabIndex = 209;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(36, 9);
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
            this.checkout.Location = new System.Drawing.Point(202, 12);
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
            this.panel2.Location = new System.Drawing.Point(401, 525);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(318, 68);
            this.panel2.TabIndex = 210;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(730, 615);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.productpanel);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.ordered_products);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.paymentpanel.ResumeLayout(false);
            this.paymentpanel.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityTxt)).EndInit();
            this.productpanel.ResumeLayout(false);
            this.productpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.product_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordered_products)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Panel productpanel;
        private System.Windows.Forms.DataGridView product_data;
        private System.Windows.Forms.Label label7;
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
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox changetxt;
        private System.Windows.Forms.TextBox amountPaid;
        private System.Windows.Forms.TextBox totalDue;
        private System.Windows.Forms.Button pay;
        private System.Windows.Forms.Button backbtnSales;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton dinein;
        private System.Windows.Forms.RadioButton takeout;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox discountTxt;
        private System.Windows.Forms.Label label8;
    }
}