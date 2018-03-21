namespace SAD
{
    partial class Product_Batch
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_products = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.product_recipe = new System.Windows.Forms.DataGridView();
            this.batch_items = new System.Windows.Forms.DataGridView();
            this.stockin_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.product_recipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.batch_items)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Location = new System.Drawing.Point(-231, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1412, 65);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(243, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 41);
            this.label1.TabIndex = 127;
            this.label1.Text = "PRODUCT BATCH";
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btn_close.Location = new System.Drawing.Point(971, 4);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(97, 61);
            this.btn_close.TabIndex = 90;
            this.btn_close.Text = "BACK";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(406, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 25);
            this.label4.TabIndex = 242;
            this.label4.Text = "PRODUCT RECIPE";
            // 
            // cmb_products
            // 
            this.cmb_products.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_products.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_products.FormattingEnabled = true;
            this.cmb_products.Items.AddRange(new object[] {
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
            this.cmb_products.Location = new System.Drawing.Point(651, 89);
            this.cmb_products.Name = "cmb_products";
            this.cmb_products.Size = new System.Drawing.Size(177, 25);
            this.cmb_products.TabIndex = 241;
            this.cmb_products.SelectedIndexChanged += new System.EventHandler(this.cmb_products_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(7, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 25);
            this.label3.TabIndex = 239;
            this.label3.Text = "BATCH INGREDIENTS";
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
            this.product_recipe.Location = new System.Drawing.Point(411, 114);
            this.product_recipe.MultiSelect = false;
            this.product_recipe.Name = "product_recipe";
            this.product_recipe.ReadOnly = true;
            this.product_recipe.RowHeadersVisible = false;
            this.product_recipe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.product_recipe.Size = new System.Drawing.Size(417, 332);
            this.product_recipe.TabIndex = 238;
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
            this.batch_items.Location = new System.Drawing.Point(12, 114);
            this.batch_items.MultiSelect = false;
            this.batch_items.Name = "batch_items";
            this.batch_items.ReadOnly = true;
            this.batch_items.RowHeadersVisible = false;
            this.batch_items.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.batch_items.Size = new System.Drawing.Size(393, 332);
            this.batch_items.TabIndex = 237;
            // 
            // stockin_btn
            // 
            this.stockin_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.stockin_btn.FlatAppearance.BorderSize = 0;
            this.stockin_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stockin_btn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockin_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.stockin_btn.Location = new System.Drawing.Point(982, 640);
            this.stockin_btn.Name = "stockin_btn";
            this.stockin_btn.Size = new System.Drawing.Size(68, 26);
            this.stockin_btn.TabIndex = 215;
            this.stockin_btn.Text = "USE";
            this.stockin_btn.UseVisualStyleBackColor = false;
            // 
            // Product_Batch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(833, 487);
            this.Controls.Add(this.stockin_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_products);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.product_recipe);
            this.Controls.Add(this.batch_items);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Product_Batch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product_Batch";
            this.Load += new System.EventHandler(this.Product_Batch_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.product_recipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.batch_items)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_products;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView product_recipe;
        private System.Windows.Forms.DataGridView batch_items;
        private System.Windows.Forms.Button stockin_btn;
    }
}