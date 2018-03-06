namespace SAD
{
    partial class Product_Inventory
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
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.prodInv = new System.Windows.Forms.DataGridView();
            this.qtypanel = new System.Windows.Forms.Panel();
            this.updateqty = new System.Windows.Forms.Button();
            this.nud_prodqty = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.prodLabel = new System.Windows.Forms.Label();
            this.close_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodInv)).BeginInit();
            this.qtypanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_prodqty)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-285, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1228, 64);
            this.panel1.TabIndex = 3;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btn_close.Location = new System.Drawing.Point(847, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(97, 61);
            this.btn_close.TabIndex = 90;
            this.btn_close.Text = "BACK";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Gold;
            this.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.Black;
            this.btn_add.Location = new System.Drawing.Point(690, 3);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(136, 60);
            this.btn_add.TabIndex = 89;
            this.btn_add.Text = "Update Quantity";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label1.Location = new System.Drawing.Point(297, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRODUCT INVENTORY";
            // 
            // prodInv
            // 
            this.prodInv.AllowUserToAddRows = false;
            this.prodInv.AllowUserToDeleteRows = false;
            this.prodInv.AllowUserToResizeColumns = false;
            this.prodInv.AllowUserToResizeRows = false;
            this.prodInv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.prodInv.BackgroundColor = System.Drawing.Color.White;
            this.prodInv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prodInv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.prodInv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prodInv.Location = new System.Drawing.Point(12, 73);
            this.prodInv.MultiSelect = false;
            this.prodInv.Name = "prodInv";
            this.prodInv.ReadOnly = true;
            this.prodInv.RowHeadersVisible = false;
            this.prodInv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.prodInv.Size = new System.Drawing.Size(634, 328);
            this.prodInv.TabIndex = 110;
            this.prodInv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.prodInv_CellClick);
            // 
            // qtypanel
            // 
            this.qtypanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.qtypanel.Controls.Add(this.close_btn);
            this.qtypanel.Controls.Add(this.panel2);
            this.qtypanel.Controls.Add(this.updateqty);
            this.qtypanel.Controls.Add(this.nud_prodqty);
            this.qtypanel.Location = new System.Drawing.Point(198, 120);
            this.qtypanel.Name = "qtypanel";
            this.qtypanel.Size = new System.Drawing.Size(239, 164);
            this.qtypanel.TabIndex = 111;
            // 
            // updateqty
            // 
            this.updateqty.BackColor = System.Drawing.Color.Gold;
            this.updateqty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updateqty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateqty.ForeColor = System.Drawing.Color.Black;
            this.updateqty.Location = new System.Drawing.Point(67, 104);
            this.updateqty.Name = "updateqty";
            this.updateqty.Size = new System.Drawing.Size(109, 25);
            this.updateqty.TabIndex = 111;
            this.updateqty.Text = "Update";
            this.updateqty.UseVisualStyleBackColor = false;
            this.updateqty.Click += new System.EventHandler(this.updateqty_Click_1);
            // 
            // nud_prodqty
            // 
            this.nud_prodqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_prodqty.Location = new System.Drawing.Point(79, 69);
            this.nud_prodqty.Name = "nud_prodqty";
            this.nud_prodqty.Size = new System.Drawing.Size(85, 29);
            this.nud_prodqty.TabIndex = 110;
            this.nud_prodqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.panel2.Controls.Add(this.prodLabel);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 48);
            this.panel2.TabIndex = 209;
            // 
            // prodLabel
            // 
            this.prodLabel.AutoSize = true;
            this.prodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodLabel.ForeColor = System.Drawing.Color.White;
            this.prodLabel.Location = new System.Drawing.Point(42, 13);
            this.prodLabel.Name = "prodLabel";
            this.prodLabel.Size = new System.Drawing.Size(146, 24);
            this.prodLabel.TabIndex = 111;
            this.prodLabel.Text = " Product name";
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.Color.Firebrick;
            this.close_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_btn.ForeColor = System.Drawing.Color.Black;
            this.close_btn.Location = new System.Drawing.Point(67, 135);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(109, 25);
            this.close_btn.TabIndex = 210;
            this.close_btn.Text = "Close";
            this.close_btn.UseVisualStyleBackColor = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // Product_Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(658, 413);
            this.Controls.Add(this.qtypanel);
            this.Controls.Add(this.prodInv);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Product_Inventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product_Inventory";
            this.Load += new System.EventHandler(this.Product_Inventory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodInv)).EndInit();
            this.qtypanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud_prodqty)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView prodInv;
        private System.Windows.Forms.Panel qtypanel;
        private System.Windows.Forms.Button updateqty;
        private System.Windows.Forms.NumericUpDown nud_prodqty;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label prodLabel;
        private System.Windows.Forms.Button close_btn;
    }
}