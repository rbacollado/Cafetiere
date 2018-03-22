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
            this.btn_products = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.prodInv = new System.Windows.Forms.DataGridView();
            this.add_panel = new System.Windows.Forms.Panel();
            this.close_panel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.batch_items = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.product_recipe = new System.Windows.Forms.DataGridView();
            this.add = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodInv)).BeginInit();
            this.add_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.batch_items)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_recipe)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.btn_products);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Location = new System.Drawing.Point(-285, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1412, 64);
            this.panel1.TabIndex = 3;
            // 
            // btn_products
            // 
            this.btn_products.BackColor = System.Drawing.Color.Transparent;
            this.btn_products.FlatAppearance.BorderSize = 0;
            this.btn_products.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_products.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_products.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btn_products.Location = new System.Drawing.Point(914, 6);
            this.btn_products.Name = "btn_products";
            this.btn_products.Size = new System.Drawing.Size(103, 50);
            this.btn_products.TabIndex = 244;
            this.btn_products.Text = "PRODUCTS";
            this.btn_products.UseVisualStyleBackColor = false;
            this.btn_products.Click += new System.EventHandler(this.btn_products_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(297, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 41);
            this.label1.TabIndex = 127;
            this.label1.Text = "PRODUCT INVENTORY";
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btn_close.Location = new System.Drawing.Point(1021, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(97, 61);
            this.btn_close.TabIndex = 90;
            this.btn_close.Text = "BACK";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(14, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 25);
            this.label2.TabIndex = 218;
            this.label2.Text = "PRODUCT INVENTORY";
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
            this.prodInv.Location = new System.Drawing.Point(19, 101);
            this.prodInv.MultiSelect = false;
            this.prodInv.Name = "prodInv";
            this.prodInv.ReadOnly = true;
            this.prodInv.RowHeadersVisible = false;
            this.prodInv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.prodInv.Size = new System.Drawing.Size(802, 393);
            this.prodInv.TabIndex = 219;
            this.prodInv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.prodInv_CellClick);
            // 
            // add_panel
            // 
            this.add_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.add_panel.Controls.Add(this.close_panel);
            this.add_panel.Controls.Add(this.button1);
            this.add_panel.Controls.Add(this.label3);
            this.add_panel.Controls.Add(this.batch_items);
            this.add_panel.Controls.Add(this.label4);
            this.add_panel.Controls.Add(this.product_recipe);
            this.add_panel.Location = new System.Drawing.Point(765, 439);
            this.add_panel.Name = "add_panel";
            this.add_panel.Size = new System.Drawing.Size(56, 55);
            this.add_panel.TabIndex = 245;
            this.add_panel.Visible = false;
            this.add_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.add_panel_Paint);
            // 
            // close_panel
            // 
            this.close_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.close_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.close_panel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.close_panel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.close_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_panel.ForeColor = System.Drawing.Color.Transparent;
            this.close_panel.Location = new System.Drawing.Point(764, 0);
            this.close_panel.Name = "close_panel";
            this.close_panel.Size = new System.Drawing.Size(38, 37);
            this.close_panel.TabIndex = 248;
            this.close_panel.Text = "X";
            this.close_panel.UseVisualStyleBackColor = false;
            this.close_panel.Click += new System.EventHandler(this.close_panel_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.button1.Location = new System.Drawing.Point(657, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 25);
            this.button1.TabIndex = 247;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(404, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 25);
            this.label3.TabIndex = 246;
            this.label3.Text = "BATCH INGREDIENTS";
            // 
            // batch_items
            // 
            this.batch_items.AllowUserToAddRows = false;
            this.batch_items.AllowUserToDeleteRows = false;
            this.batch_items.AllowUserToResizeColumns = false;
            this.batch_items.AllowUserToResizeRows = false;
            this.batch_items.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.batch_items.BackgroundColor = System.Drawing.Color.White;
            this.batch_items.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.batch_items.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.batch_items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.batch_items.Location = new System.Drawing.Point(409, 64);
            this.batch_items.MultiSelect = false;
            this.batch_items.Name = "batch_items";
            this.batch_items.ReadOnly = true;
            this.batch_items.RowHeadersVisible = false;
            this.batch_items.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.batch_items.Size = new System.Drawing.Size(377, 285);
            this.batch_items.TabIndex = 245;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(10, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 25);
            this.label4.TabIndex = 244;
            this.label4.Text = "PRODUCT RECIPE";
            // 
            // product_recipe
            // 
            this.product_recipe.AllowUserToAddRows = false;
            this.product_recipe.AllowUserToDeleteRows = false;
            this.product_recipe.AllowUserToResizeColumns = false;
            this.product_recipe.AllowUserToResizeRows = false;
            this.product_recipe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.product_recipe.BackgroundColor = System.Drawing.Color.White;
            this.product_recipe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.product_recipe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.product_recipe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.product_recipe.Location = new System.Drawing.Point(15, 64);
            this.product_recipe.MultiSelect = false;
            this.product_recipe.Name = "product_recipe";
            this.product_recipe.ReadOnly = true;
            this.product_recipe.RowHeadersVisible = false;
            this.product_recipe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.product_recipe.Size = new System.Drawing.Size(377, 285);
            this.product_recipe.TabIndex = 243;
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.Transparent;
            this.add.FlatAppearance.BorderSize = 0;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.add.Location = new System.Drawing.Point(692, 73);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(129, 25);
            this.add.TabIndex = 246;
            this.add.Text = "ADD QUANTITY";
            this.add.UseVisualStyleBackColor = false;
            this.add.Visible = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // Product_Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(833, 506);
            this.Controls.Add(this.add);
            this.Controls.Add(this.add_panel);
            this.Controls.Add(this.prodInv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Product_Inventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product_Inventory";
            this.Load += new System.EventHandler(this.Product_Inventory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodInv)).EndInit();
            this.add_panel.ResumeLayout(false);
            this.add_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.batch_items)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_recipe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView prodInv;
        private System.Windows.Forms.Panel add_panel;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView product_recipe;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView batch_items;
        private System.Windows.Forms.Button close_panel;
        private System.Windows.Forms.Button btn_products;
    }
}