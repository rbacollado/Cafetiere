namespace SAD
{
    partial class Staff
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
            this.Back = new System.Windows.Forms.Button();
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Archive = new System.Windows.Forms.Button();
            this.staff_update = new System.Windows.Forms.Button();
            this.staff_add = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.sales_records = new System.Windows.Forms.DataGridView();
            this.inventory_records = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sales_records)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventory_records)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Tomato;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Back.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.White;
            this.Back.Location = new System.Drawing.Point(866, 0);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(114, 67);
            this.Back.TabIndex = 87;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // dtgv
            // 
            this.dtgv.AllowUserToAddRows = false;
            this.dtgv.AllowUserToDeleteRows = false;
            this.dtgv.AllowUserToResizeColumns = false;
            this.dtgv.AllowUserToResizeRows = false;
            this.dtgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv.BackgroundColor = System.Drawing.Color.White;
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv.Location = new System.Drawing.Point(12, 91);
            this.dtgv.MultiSelect = false;
            this.dtgv.Name = "dtgv";
            this.dtgv.ReadOnly = true;
            this.dtgv.RowHeadersVisible = false;
            this.dtgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv.Size = new System.Drawing.Size(939, 177);
            this.dtgv.TabIndex = 111;
            this.dtgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_CellClick);
            this.dtgv.SelectionChanged += new System.EventHandler(this.dtgv_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.staff_update);
            this.panel1.Controls.Add(this.staff_add);
            this.panel1.Controls.Add(this.Back);
            this.panel1.Location = new System.Drawing.Point(-14, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(983, 67);
            this.panel1.TabIndex = 109;
            // 
            // Archive
            // 
            this.Archive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.Archive.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Archive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold);
            this.Archive.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Archive.Location = new System.Drawing.Point(195, 69);
            this.Archive.Name = "Archive";
            this.Archive.Size = new System.Drawing.Size(86, 24);
            this.Archive.TabIndex = 123;
            this.Archive.Text = "Archive";
            this.Archive.UseVisualStyleBackColor = false;
            this.Archive.Click += new System.EventHandler(this.Archive_Click);
            // 
            // staff_update
            // 
            this.staff_update.BackColor = System.Drawing.Color.Goldenrod;
            this.staff_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.staff_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.staff_update.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staff_update.ForeColor = System.Drawing.Color.White;
            this.staff_update.Location = new System.Drawing.Point(698, 24);
            this.staff_update.Name = "staff_update";
            this.staff_update.Size = new System.Drawing.Size(103, 37);
            this.staff_update.TabIndex = 117;
            this.staff_update.Text = "Update";
            this.staff_update.UseVisualStyleBackColor = false;
            this.staff_update.Click += new System.EventHandler(this.staff_update_Click);
            // 
            // staff_add
            // 
            this.staff_add.BackColor = System.Drawing.Color.SeaGreen;
            this.staff_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.staff_add.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staff_add.ForeColor = System.Drawing.SystemColors.Control;
            this.staff_add.Location = new System.Drawing.Point(591, 24);
            this.staff_add.Name = "staff_add";
            this.staff_add.Size = new System.Drawing.Size(101, 37);
            this.staff_add.TabIndex = 116;
            this.staff_add.Text = "Add";
            this.staff_add.UseVisualStyleBackColor = false;
            this.staff_add.Click += new System.EventHandler(this.staff_add_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label6.Location = new System.Drawing.Point(16, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 18);
            this.label6.TabIndex = 122;
            this.label6.Text = "Filter:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.comboBox1.Location = new System.Drawing.Point(68, 69);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 121;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // sales_records
            // 
            this.sales_records.AllowUserToAddRows = false;
            this.sales_records.AllowUserToDeleteRows = false;
            this.sales_records.AllowUserToResizeColumns = false;
            this.sales_records.AllowUserToResizeRows = false;
            this.sales_records.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sales_records.BackgroundColor = System.Drawing.Color.White;
            this.sales_records.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.sales_records.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sales_records.Location = new System.Drawing.Point(17, 352);
            this.sales_records.MultiSelect = false;
            this.sales_records.Name = "sales_records";
            this.sales_records.ReadOnly = true;
            this.sales_records.RowHeadersVisible = false;
            this.sales_records.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sales_records.Size = new System.Drawing.Size(485, 227);
            this.sales_records.TabIndex = 112;
            this.sales_records.SelectionChanged += new System.EventHandler(this.sales_records_SelectionChanged);
            // 
            // inventory_records
            // 
            this.inventory_records.AllowUserToAddRows = false;
            this.inventory_records.AllowUserToDeleteRows = false;
            this.inventory_records.AllowUserToResizeColumns = false;
            this.inventory_records.AllowUserToResizeRows = false;
            this.inventory_records.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.inventory_records.BackgroundColor = System.Drawing.Color.White;
            this.inventory_records.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.inventory_records.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventory_records.Location = new System.Drawing.Point(521, 352);
            this.inventory_records.MultiSelect = false;
            this.inventory_records.Name = "inventory_records";
            this.inventory_records.ReadOnly = true;
            this.inventory_records.RowHeadersVisible = false;
            this.inventory_records.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.inventory_records.Size = new System.Drawing.Size(430, 227);
            this.inventory_records.TabIndex = 117;
            this.inventory_records.SelectionChanged += new System.EventHandler(this.inventory_records_SelectionChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-14, 274);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(998, 43);
            this.panel2.TabIndex = 118;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label2.Location = new System.Drawing.Point(12, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 28);
            this.label2.TabIndex = 119;
            this.label2.Text = "SALES";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label4.Location = new System.Drawing.Point(516, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 28);
            this.label4.TabIndex = 120;
            this.label4.Text = "INVENTORY";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(19, 14);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(151, 41);
            this.label15.TabIndex = 124;
            this.label15.Text = "S T A F F";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(383, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 41);
            this.label1.TabIndex = 125;
            this.label1.Text = "R E C O R D S";
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(963, 591);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Archive);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.inventory_records);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.sales_records);
            this.Controls.Add(this.dtgv);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Staff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "v";
            this.Load += new System.EventHandler(this.Staff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sales_records)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventory_records)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button staff_add;
        private System.Windows.Forms.Button staff_update;
        private System.Windows.Forms.DataGridView sales_records;
        private System.Windows.Forms.DataGridView inventory_records;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Archive;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
    }
}