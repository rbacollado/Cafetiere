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
            this.label15 = new System.Windows.Forms.Label();
            this.Archive = new System.Windows.Forms.Button();
            this.supplier_update = new System.Windows.Forms.Button();
            this.supplier_add = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.records = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.records)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.supplier_update);
            this.panel1.Controls.Add(this.supplier_add);
            this.panel1.Controls.Add(this.Back);
            this.panel1.Location = new System.Drawing.Point(-109, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1078, 55);
            this.panel1.TabIndex = 115;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(121, 5);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(231, 41);
            this.label15.TabIndex = 125;
            this.label15.Text = "S U P P L I E R";
            // 
            // Archive
            // 
            this.Archive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.Archive.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Archive.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Archive.ForeColor = System.Drawing.Color.White;
            this.Archive.Location = new System.Drawing.Point(12, 61);
            this.Archive.Name = "Archive";
            this.Archive.Size = new System.Drawing.Size(86, 32);
            this.Archive.TabIndex = 124;
            this.Archive.Text = "Archive";
            this.Archive.UseVisualStyleBackColor = false;
            this.Archive.Click += new System.EventHandler(this.Archive_Click);
            // 
            // supplier_update
            // 
            this.supplier_update.BackColor = System.Drawing.Color.Goldenrod;
            this.supplier_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.supplier_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.supplier_update.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier_update.ForeColor = System.Drawing.Color.White;
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
            this.supplier_add.BackColor = System.Drawing.Color.SeaGreen;
            this.supplier_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.supplier_add.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier_add.ForeColor = System.Drawing.Color.White;
            this.supplier_add.Location = new System.Drawing.Point(440, 12);
            this.supplier_add.Name = "supplier_add";
            this.supplier_add.Size = new System.Drawing.Size(101, 37);
            this.supplier_add.TabIndex = 116;
            this.supplier_add.Text = "ADD";
            this.supplier_add.UseVisualStyleBackColor = false;
            this.supplier_add.Click += new System.EventHandler(this.supplier_add_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Tomato;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Back.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.White;
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
            this.dtgv.Location = new System.Drawing.Point(12, 95);
            this.dtgv.MultiSelect = false;
            this.dtgv.Name = "dtgv";
            this.dtgv.ReadOnly = true;
            this.dtgv.RowHeadersVisible = false;
            this.dtgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv.Size = new System.Drawing.Size(780, 197);
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
            this.records.Location = new System.Drawing.Point(12, 341);
            this.records.MultiSelect = false;
            this.records.Name = "records";
            this.records.ReadOnly = true;
            this.records.RowHeadersVisible = false;
            this.records.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.records.Size = new System.Drawing.Size(780, 222);
            this.records.TabIndex = 116;
            this.records.SelectionChanged += new System.EventHandler(this.records_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 41);
            this.label1.TabIndex = 126;
            this.label1.Text = "TRANSACTIONS";
            // 
            // Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(804, 575);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Archive);
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
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.DataGridView records;
        private System.Windows.Forms.Button Archive;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
    }
}