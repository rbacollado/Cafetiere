namespace SAD
{
    partial class Product
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
            this.label1 = new System.Windows.Forms.Label();
            this.product_list = new System.Windows.Forms.DataGridView();
            this.product_update = new System.Windows.Forms.Button();
            this.product_recipe = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.create_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.show_recipe = new System.Windows.Forms.Button();
            this.show_panel = new System.Windows.Forms.Panel();
            this.close_panel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.batch_items = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.batch_dtgv = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.product_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_recipe)).BeginInit();
            this.show_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.batch_items)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.batch_dtgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.show_recipe);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-45, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1009, 59);
            this.panel1.TabIndex = 100;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btn_close.Location = new System.Drawing.Point(706, 2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(97, 59);
            this.btn_close.TabIndex = 87;
            this.btn_close.Text = "BACK";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(56, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 31);
            this.label1.TabIndex = 38;
            this.label1.Text = "PRODUCTS";
            // 
            // product_list
            // 
            this.product_list.AllowUserToAddRows = false;
            this.product_list.AllowUserToDeleteRows = false;
            this.product_list.AllowUserToResizeColumns = false;
            this.product_list.AllowUserToResizeRows = false;
            this.product_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.product_list.BackgroundColor = System.Drawing.Color.White;
            this.product_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.product_list.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.product_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.product_list.Location = new System.Drawing.Point(17, 136);
            this.product_list.MultiSelect = false;
            this.product_list.Name = "product_list";
            this.product_list.ReadOnly = true;
            this.product_list.RowHeadersVisible = false;
            this.product_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.product_list.Size = new System.Drawing.Size(352, 367);
            this.product_list.TabIndex = 108;
            this.product_list.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.product_list_CellClick);
            // 
            // product_update
            // 
            this.product_update.BackColor = System.Drawing.Color.Goldenrod;
            this.product_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.product_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.product_update.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_update.ForeColor = System.Drawing.Color.White;
            this.product_update.Location = new System.Drawing.Point(116, 62);
            this.product_update.Name = "product_update";
            this.product_update.Size = new System.Drawing.Size(88, 26);
            this.product_update.TabIndex = 118;
            this.product_update.Text = "Update";
            this.product_update.UseVisualStyleBackColor = false;
            this.product_update.Click += new System.EventHandler(this.product_update_Click);
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
            this.product_recipe.Location = new System.Drawing.Point(390, 136);
            this.product_recipe.MultiSelect = false;
            this.product_recipe.Name = "product_recipe";
            this.product_recipe.ReadOnly = true;
            this.product_recipe.RowHeadersVisible = false;
            this.product_recipe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.product_recipe.Size = new System.Drawing.Size(353, 367);
            this.product_recipe.TabIndex = 120;
            this.product_recipe.SelectionChanged += new System.EventHandler(this.product_recipe_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(385, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 25);
            this.label2.TabIndex = 121;
            this.label2.Text = "PRODUCT RECIPE";
            // 
            // create_btn
            // 
            this.create_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.create_btn.FlatAppearance.BorderSize = 0;
            this.create_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.create_btn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_btn.ForeColor = System.Drawing.Color.White;
            this.create_btn.Location = new System.Drawing.Point(22, 62);
            this.create_btn.Name = "create_btn";
            this.create_btn.Size = new System.Drawing.Size(88, 26);
            this.create_btn.TabIndex = 216;
            this.create_btn.Text = "CREATE";
            this.create_btn.UseVisualStyleBackColor = false;
            this.create_btn.Click += new System.EventHandler(this.create_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(13, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 25);
            this.label4.TabIndex = 119;
            this.label4.Text = "PRODUCT LIST";
            // 
            // show_recipe
            // 
            this.show_recipe.BackColor = System.Drawing.Color.Transparent;
            this.show_recipe.FlatAppearance.BorderSize = 0;
            this.show_recipe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.show_recipe.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_recipe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.show_recipe.Location = new System.Drawing.Point(518, 31);
            this.show_recipe.Name = "show_recipe";
            this.show_recipe.Size = new System.Drawing.Size(124, 25);
            this.show_recipe.TabIndex = 248;
            this.show_recipe.Text = "BATCH";
            this.show_recipe.UseVisualStyleBackColor = false;
            this.show_recipe.Click += new System.EventHandler(this.show_recipe_Click);
            // 
            // show_panel
            // 
            this.show_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.show_panel.Controls.Add(this.label5);
            this.show_panel.Controls.Add(this.batch_dtgv);
            this.show_panel.Controls.Add(this.close_panel);
            this.show_panel.Controls.Add(this.label3);
            this.show_panel.Controls.Add(this.batch_items);
            this.show_panel.Location = new System.Drawing.Point(17, 63);
            this.show_panel.Name = "show_panel";
            this.show_panel.Size = new System.Drawing.Size(730, 445);
            this.show_panel.TabIndex = 249;
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
            this.close_panel.Location = new System.Drawing.Point(688, 0);
            this.close_panel.Name = "close_panel";
            this.close_panel.Size = new System.Drawing.Size(42, 37);
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
            this.label3.Location = new System.Drawing.Point(468, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 25);
            this.label3.TabIndex = 246;
            this.label3.Text = "INGREDIENTS";
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
            this.batch_items.Location = new System.Drawing.Point(373, 66);
            this.batch_items.MultiSelect = false;
            this.batch_items.Name = "batch_items";
            this.batch_items.ReadOnly = true;
            this.batch_items.RowHeadersVisible = false;
            this.batch_items.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.batch_items.Size = new System.Drawing.Size(341, 366);
            this.batch_items.TabIndex = 245;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(94, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 25);
            this.label5.TabIndex = 250;
            this.label5.Text = "BATCH PRODUCTS";
            // 
            // batch_dtgv
            // 
            this.batch_dtgv.AllowUserToAddRows = false;
            this.batch_dtgv.AllowUserToDeleteRows = false;
            this.batch_dtgv.AllowUserToResizeColumns = false;
            this.batch_dtgv.AllowUserToResizeRows = false;
            this.batch_dtgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.batch_dtgv.BackgroundColor = System.Drawing.Color.White;
            this.batch_dtgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.batch_dtgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.batch_dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.batch_dtgv.Location = new System.Drawing.Point(21, 66);
            this.batch_dtgv.MultiSelect = false;
            this.batch_dtgv.Name = "batch_dtgv";
            this.batch_dtgv.ReadOnly = true;
            this.batch_dtgv.RowHeadersVisible = false;
            this.batch_dtgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.batch_dtgv.Size = new System.Drawing.Size(341, 366);
            this.batch_dtgv.TabIndex = 249;
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(759, 532);
            this.Controls.Add(this.show_panel);
            this.Controls.Add(this.create_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.product_recipe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.product_update);
            this.Controls.Add(this.product_list);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Product_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.product_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_recipe)).EndInit();
            this.show_panel.ResumeLayout(false);
            this.show_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.batch_items)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.batch_dtgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView product_list;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button product_update;
        private System.Windows.Forms.DataGridView product_recipe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button create_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button show_recipe;
        private System.Windows.Forms.Panel show_panel;
        private System.Windows.Forms.Button close_panel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView batch_items;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView batch_dtgv;
    }
}