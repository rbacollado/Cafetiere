namespace SAD
{
    partial class Supplier
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
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.supplier_update = new System.Windows.Forms.Button();
            this.supplier_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.records = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.Archive = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.records)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.Archive);
            this.panel1.Controls.Add(this.supplier_update);
            this.panel1.Controls.Add(this.supplier_add);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Back);
            this.panel1.Location = new System.Drawing.Point(-109, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1078, 55);
            this.panel1.TabIndex = 115;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label6.Location = new System.Drawing.Point(16, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 18);
            this.label6.TabIndex = 124;
            this.label6.Text = "Filter:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.comboBox1.Location = new System.Drawing.Point(68, 61);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 123;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // supplier_update
            // 
            this.supplier_update.BackColor = System.Drawing.Color.Gold;
            this.supplier_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.supplier_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supplier_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier_update.ForeColor = System.Drawing.Color.Black;
            this.supplier_update.Location = new System.Drawing.Point(547, 12);
            this.supplier_update.Name = "supplier_update";
            this.supplier_update.Size = new System.Drawing.Size(103, 37);
            this.supplier_update.TabIndex = 117;
            this.supplier_update.Text = "Update";
            this.supplier_update.UseVisualStyleBackColor = false;
            this.supplier_update.Click += new System.EventHandler(this.supplier_update_Click);
            // 
            // supplier_add
            // 
            this.supplier_add.BackColor = System.Drawing.Color.YellowGreen;
            this.supplier_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supplier_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier_add.Location = new System.Drawing.Point(440, 12);
            this.supplier_add.Name = "supplier_add";
            this.supplier_add.Size = new System.Drawing.Size(101, 37);
            this.supplier_add.TabIndex = 116;
            this.supplier_add.Text = "Add";
            this.supplier_add.UseVisualStyleBackColor = false;
            this.supplier_add.Click += new System.EventHandler(this.supplier_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label1.Location = new System.Drawing.Point(121, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 29);
            this.label1.TabIndex = 115;
            this.label1.Text = "SUPPLIER";
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Tomato;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(801, 1);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(114, 54);
            this.Back.TabIndex = 87;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click_1);
            // 
            // dtgv
            // 
            this.dtgv.AllowUserToAddRows = false;
            this.dtgv.AllowUserToDeleteRows = false;
            this.dtgv.AllowUserToResizeColumns = false;
            this.dtgv.AllowUserToResizeRows = false;
            this.dtgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv.BackgroundColor = System.Drawing.Color.White;
            this.dtgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv.Location = new System.Drawing.Point(12, 82);
            this.dtgv.MultiSelect = false;
            this.dtgv.Name = "dtgv";
            this.dtgv.ReadOnly = true;
            this.dtgv.RowHeadersVisible = false;
            this.dtgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv.Size = new System.Drawing.Size(780, 210);
            this.dtgv.TabIndex = 114;
            this.dtgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_CellClick);
            this.dtgv.SelectionChanged += new System.EventHandler(this.dtgv_SelectionChanged);
            // 
            // records
            // 
            this.records.AllowUserToAddRows = false;
            this.records.AllowUserToDeleteRows = false;
            this.records.AllowUserToResizeColumns = false;
            this.records.AllowUserToResizeRows = false;
            this.records.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.records.BackgroundColor = System.Drawing.Color.White;
            this.records.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.records.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.records.Location = new System.Drawing.Point(12, 327);
            this.records.MultiSelect = false;
            this.records.Name = "records";
            this.records.ReadOnly = true;
            this.records.RowHeadersVisible = false;
            this.records.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.records.Size = new System.Drawing.Size(780, 222);
            this.records.TabIndex = 116;
            this.records.SelectionChanged += new System.EventHandler(this.records_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label2.Location = new System.Drawing.Point(12, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 29);
            this.label2.TabIndex = 117;
            this.label2.Text = "TRANSACTIONS";
            // 
            // Archive
            // 
            this.Archive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.Archive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Archive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold);
            this.Archive.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Archive.Location = new System.Drawing.Point(709, 17);
            this.Archive.Name = "Archive";
            this.Archive.Size = new System.Drawing.Size(86, 32);
            this.Archive.TabIndex = 124;
            this.Archive.Text = "Archive";
            this.Archive.UseVisualStyleBackColor = false;
            this.Archive.Click += new System.EventHandler(this.Archive_Click);
            // 
            // Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(804, 561);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.records);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Supplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supplier";
            this.Load += new System.EventHandler(this.Supplier_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.records)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button supplier_update;
        private System.Windows.Forms.Button supplier_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.DataGridView records;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Archive;
    }
}