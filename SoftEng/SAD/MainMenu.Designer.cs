namespace SAD
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_settings = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_product = new System.Windows.Forms.Button();
            this.btn_inventory = new System.Windows.Forms.Button();
            this.btn_orders = new System.Windows.Forms.Button();
            this.btn_profiling = new System.Windows.Forms.Button();
            this.lbl_user = new System.Windows.Forms.Label();
            this.lbl_type = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Brown;
            this.panel1.Controls.Add(this.btn_logout);
            this.panel1.Controls.Add(this.btn_settings);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(4, -9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(625, 131);
            this.panel1.TabIndex = 60;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.Brown;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.ForeColor = System.Drawing.Color.Brown;
            this.btn_logout.Image = ((System.Drawing.Image)(resources.GetObject("btn_logout.Image")));
            this.btn_logout.Location = new System.Drawing.Point(557, 68);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(45, 28);
            this.btn_logout.TabIndex = 61;
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_settings
            // 
            this.btn_settings.BackColor = System.Drawing.Color.Transparent;
            this.btn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_settings.ForeColor = System.Drawing.Color.Brown;
            this.btn_settings.Image = ((System.Drawing.Image)(resources.GetObject("btn_settings.Image")));
            this.btn_settings.Location = new System.Drawing.Point(513, 63);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(38, 39);
            this.btn_settings.TabIndex = 60;
            this.btn_settings.UseVisualStyleBackColor = false;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(142, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(321, 31);
            this.label4.TabIndex = 13;
            this.label4.Text = "fresh ● flavorful ● delicious";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tempus Sans ITC", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(149, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 88);
            this.label3.TabIndex = 12;
            this.label3.Text = "Cafetière";
            // 
            // btn_product
            // 
            this.btn_product.BackColor = System.Drawing.Color.Transparent;
            this.btn_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_product.ForeColor = System.Drawing.Color.Transparent;
            this.btn_product.Image = ((System.Drawing.Image)(resources.GetObject("btn_product.Image")));
            this.btn_product.Location = new System.Drawing.Point(352, 291);
            this.btn_product.Name = "btn_product";
            this.btn_product.Size = new System.Drawing.Size(146, 156);
            this.btn_product.TabIndex = 64;
            this.btn_product.UseVisualStyleBackColor = false;
            // 
            // btn_inventory
            // 
            this.btn_inventory.BackColor = System.Drawing.Color.Transparent;
            this.btn_inventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inventory.ForeColor = System.Drawing.Color.Transparent;
            this.btn_inventory.Image = ((System.Drawing.Image)(resources.GetObject("btn_inventory.Image")));
            this.btn_inventory.Location = new System.Drawing.Point(125, 291);
            this.btn_inventory.Name = "btn_inventory";
            this.btn_inventory.Size = new System.Drawing.Size(157, 156);
            this.btn_inventory.TabIndex = 63;
            this.btn_inventory.UseVisualStyleBackColor = false;
            // 
            // btn_orders
            // 
            this.btn_orders.BackColor = System.Drawing.Color.Transparent;
            this.btn_orders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_orders.ForeColor = System.Drawing.Color.Transparent;
            this.btn_orders.Image = ((System.Drawing.Image)(resources.GetObject("btn_orders.Image")));
            this.btn_orders.Location = new System.Drawing.Point(351, 144);
            this.btn_orders.Name = "btn_orders";
            this.btn_orders.Size = new System.Drawing.Size(148, 141);
            this.btn_orders.TabIndex = 62;
            this.btn_orders.UseVisualStyleBackColor = false;
            this.btn_orders.Click += new System.EventHandler(this.btn_orders_Click);
            // 
            // btn_profiling
            // 
            this.btn_profiling.BackColor = System.Drawing.Color.Transparent;
            this.btn_profiling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_profiling.ForeColor = System.Drawing.Color.Transparent;
            this.btn_profiling.Image = ((System.Drawing.Image)(resources.GetObject("btn_profiling.Image")));
            this.btn_profiling.Location = new System.Drawing.Point(124, 144);
            this.btn_profiling.Name = "btn_profiling";
            this.btn_profiling.Size = new System.Drawing.Size(158, 141);
            this.btn_profiling.TabIndex = 61;
            this.btn_profiling.UseVisualStyleBackColor = false;
            this.btn_profiling.Click += new System.EventHandler(this.btn_profiling_Click);
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.BackColor = System.Drawing.Color.White;
            this.lbl_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_user.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.ForeColor = System.Drawing.Color.Black;
            this.lbl_user.Location = new System.Drawing.Point(152, 452);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(2, 24);
            this.lbl_user.TabIndex = 66;
            this.lbl_user.Click += new System.EventHandler(this.lbl_user_Click);
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.BackColor = System.Drawing.Color.MediumTurquoise;
            this.lbl_type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_type.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_type.ForeColor = System.Drawing.Color.Black;
            this.lbl_type.Location = new System.Drawing.Point(12, 452);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(2, 24);
            this.lbl_type.TabIndex = 65;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 481);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.lbl_type);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_product);
            this.Controls.Add(this.btn_inventory);
            this.Controls.Add(this.btn_orders);
            this.Controls.Add(this.btn_profiling);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_product;
        private System.Windows.Forms.Button btn_inventory;
        private System.Windows.Forms.Button btn_orders;
        private System.Windows.Forms.Button btn_profiling;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label lbl_type;
    }
}