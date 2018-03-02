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
            this.btn_add = new System.Windows.Forms.Button();
            this.product_list = new System.Windows.Forms.DataGridView();
            this.staff_update = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.product_recipe = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.product_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_recipe)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.btn_close);
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
            this.label1.Location = new System.Drawing.Point(57, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 31);
            this.label1.TabIndex = 38;
            this.label1.Text = "MENU";
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.Black;
            this.btn_add.Location = new System.Drawing.Point(18, 63);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(76, 26);
            this.btn_add.TabIndex = 86;
            this.btn_add.Text = "Add ";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click_1);
            // 
            // product_list
            // 
            this.product_list.AllowUserToAddRows = false;
            this.product_list.AllowUserToDeleteRows = false;
            this.product_list.BackgroundColor = System.Drawing.Color.White;
            this.product_list.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.product_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.product_list.Location = new System.Drawing.Point(17, 136);
            this.product_list.MultiSelect = false;
            this.product_list.Name = "product_list";
            this.product_list.ReadOnly = true;
            this.product_list.RowHeadersVisible = false;
            this.product_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.product_list.Size = new System.Drawing.Size(352, 464);
            this.product_list.TabIndex = 108;
            // 
            // staff_update
            // 
            this.staff_update.BackColor = System.Drawing.Color.Gold;
            this.staff_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.staff_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staff_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staff_update.ForeColor = System.Drawing.Color.Black;
            this.staff_update.Location = new System.Drawing.Point(100, 63);
            this.staff_update.Name = "staff_update";
            this.staff_update.Size = new System.Drawing.Size(88, 26);
            this.staff_update.TabIndex = 118;
            this.staff_update.Text = "Update";
            this.staff_update.UseVisualStyleBackColor = false;
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
            // product_recipe
            // 
            this.product_recipe.AllowUserToAddRows = false;
            this.product_recipe.AllowUserToDeleteRows = false;
            this.product_recipe.BackgroundColor = System.Drawing.Color.White;
            this.product_recipe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.product_recipe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.product_recipe.Location = new System.Drawing.Point(390, 136);
            this.product_recipe.MultiSelect = false;
            this.product_recipe.Name = "product_recipe";
            this.product_recipe.ReadOnly = true;
            this.product_recipe.RowHeadersVisible = false;
            this.product_recipe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.product_recipe.Size = new System.Drawing.Size(347, 464);
            this.product_recipe.TabIndex = 120;
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
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(755, 612);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.product_recipe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.staff_update);
            this.Controls.Add(this.product_list);
            this.Controls.Add(this.btn_add);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView product_list;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button staff_update;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView product_recipe;
        private System.Windows.Forms.Label label2;
    }
}