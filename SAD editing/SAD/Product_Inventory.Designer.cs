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
            this.btn_prodINV = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.prodInv = new System.Windows.Forms.DataGridView();
            this.show_panel = new System.Windows.Forms.Panel();
            this.close_panel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.batch_items = new System.Windows.Forms.DataGridView();
            this.show_recipe = new System.Windows.Forms.Button();
            this.show_add = new System.Windows.Forms.Button();
            this.qty_panel = new System.Windows.Forms.Panel();
            this.add_qty = new System.Windows.Forms.Button();
            this.lbl_prod = new System.Windows.Forms.Label();
            this.close_add = new System.Windows.Forms.Button();
            this.prod_quantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodInv)).BeginInit();
            this.show_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.batch_items)).BeginInit();
            this.qty_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.btn_prodINV);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Location = new System.Drawing.Point(-285, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1412, 64);
            this.panel1.TabIndex = 3;
            // 
            // btn_prodINV
            // 
            this.btn_prodINV.BackColor = System.Drawing.Color.Transparent;
            this.btn_prodINV.FlatAppearance.BorderSize = 0;
            this.btn_prodINV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_prodINV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prodINV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btn_prodINV.Location = new System.Drawing.Point(903, 7);
            this.btn_prodINV.Name = "btn_prodINV";
            this.btn_prodINV.Size = new System.Drawing.Size(103, 57);
            this.btn_prodINV.TabIndex = 246;
            this.btn_prodINV.Text = "PRODUCT";
            this.btn_prodINV.UseVisualStyleBackColor = false;
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
            // show_panel
            // 
            this.show_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.show_panel.Controls.Add(this.close_panel);
            this.show_panel.Controls.Add(this.label3);
            this.show_panel.Controls.Add(this.batch_items);
            this.show_panel.Location = new System.Drawing.Point(692, 183);
            this.show_panel.Name = "show_panel";
            this.show_panel.Size = new System.Drawing.Size(111, 311);
            this.show_panel.TabIndex = 245;
            this.show_panel.Visible = false;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(16, 36);
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
            this.batch_items.Location = new System.Drawing.Point(21, 64);
            this.batch_items.MultiSelect = false;
            this.batch_items.Name = "batch_items";
            this.batch_items.ReadOnly = true;
            this.batch_items.RowHeadersVisible = false;
            this.batch_items.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.batch_items.Size = new System.Drawing.Size(765, 285);
            this.batch_items.TabIndex = 245;
            // 
            // show_recipe
            // 
            this.show_recipe.BackColor = System.Drawing.Color.Transparent;
            this.show_recipe.FlatAppearance.BorderSize = 0;
            this.show_recipe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.show_recipe.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_recipe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.show_recipe.Location = new System.Drawing.Point(650, 75);
            this.show_recipe.Name = "show_recipe";
            this.show_recipe.Size = new System.Drawing.Size(171, 25);
            this.show_recipe.TabIndex = 247;
            this.show_recipe.Text = "BATCH INGREDIENTS";
            this.show_recipe.UseVisualStyleBackColor = false;
            this.show_recipe.Click += new System.EventHandler(this.show_recipe_Click);
            // 
            // show_add
            // 
            this.show_add.BackColor = System.Drawing.Color.Transparent;
            this.show_add.FlatAppearance.BorderSize = 0;
            this.show_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.show_add.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.show_add.Location = new System.Drawing.Point(517, 75);
            this.show_add.Name = "show_add";
            this.show_add.Size = new System.Drawing.Size(127, 25);
            this.show_add.TabIndex = 249;
            this.show_add.Text = "ADD QUANTITY";
            this.show_add.UseVisualStyleBackColor = false;
            this.show_add.Click += new System.EventHandler(this.show_add_Click);
            // 
            // qty_panel
            // 
            this.qty_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.qty_panel.Controls.Add(this.label4);
            this.qty_panel.Controls.Add(this.prod_quantity);
            this.qty_panel.Controls.Add(this.add_qty);
            this.qty_panel.Controls.Add(this.lbl_prod);
            this.qty_panel.Controls.Add(this.close_add);
            this.qty_panel.Location = new System.Drawing.Point(274, 153);
            this.qty_panel.Name = "qty_panel";
            this.qty_panel.Size = new System.Drawing.Size(295, 213);
            this.qty_panel.TabIndex = 250;
            // 
            // add_qty
            // 
            this.add_qty.BackColor = System.Drawing.Color.Transparent;
            this.add_qty.FlatAppearance.BorderSize = 0;
            this.add_qty.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_qty.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_qty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.add_qty.Location = new System.Drawing.Point(152, 173);
            this.add_qty.Name = "add_qty";
            this.add_qty.Size = new System.Drawing.Size(127, 25);
            this.add_qty.TabIndex = 250;
            this.add_qty.Text = "ADD ";
            this.add_qty.UseVisualStyleBackColor = false;
            this.add_qty.Click += new System.EventHandler(this.add_qty_Click);
            // 
            // lbl_prod
            // 
            this.lbl_prod.AutoSize = true;
            this.lbl_prod.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prod.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_prod.Location = new System.Drawing.Point(36, 66);
            this.lbl_prod.Name = "lbl_prod";
            this.lbl_prod.Size = new System.Drawing.Size(126, 25);
            this.lbl_prod.TabIndex = 219;
            this.lbl_prod.Text = "prod name";
            // 
            // close_add
            // 
            this.close_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.close_add.FlatAppearance.BorderSize = 0;
            this.close_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.close_add.Location = new System.Drawing.Point(254, 0);
            this.close_add.Name = "close_add";
            this.close_add.Size = new System.Drawing.Size(41, 38);
            this.close_add.TabIndex = 91;
            this.close_add.Text = "X";
            this.close_add.UseVisualStyleBackColor = false;
            // 
            // prod_quantity
            // 
            this.prod_quantity.BackColor = System.Drawing.Color.White;
            this.prod_quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prod_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prod_quantity.ForeColor = System.Drawing.Color.Black;
            this.prod_quantity.Location = new System.Drawing.Point(152, 116);
            this.prod_quantity.Multiline = true;
            this.prod_quantity.Name = "prod_quantity";
            this.prod_quantity.Size = new System.Drawing.Size(95, 25);
            this.prod_quantity.TabIndex = 251;
            this.prod_quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.prod_quantity_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(36, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 25);
            this.label4.TabIndex = 252;
            this.label4.Text = "Quantity:";
            // 
            // Product_Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(833, 506);
            this.Controls.Add(this.qty_panel);
            this.Controls.Add(this.show_add);
            this.Controls.Add(this.show_recipe);
            this.Controls.Add(this.show_panel);
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
            this.show_panel.ResumeLayout(false);
            this.show_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.batch_items)).EndInit();
            this.qty_panel.ResumeLayout(false);
            this.qty_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView prodInv;
        private System.Windows.Forms.Panel show_panel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView batch_items;
        private System.Windows.Forms.Button close_panel;
        private System.Windows.Forms.Button show_recipe;
        private System.Windows.Forms.Button show_add;
        private System.Windows.Forms.Panel qty_panel;
        private System.Windows.Forms.Label lbl_prod;
        private System.Windows.Forms.Button close_add;
        private System.Windows.Forms.Button btn_prodINV;
        private System.Windows.Forms.Button add_qty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox prod_quantity;
    }
}