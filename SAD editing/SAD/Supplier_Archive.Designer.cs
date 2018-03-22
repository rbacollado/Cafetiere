namespace SAD
{
    partial class Supplier_Archive
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
            this.btn_close = new System.Windows.Forms.Button();
            this.archive_supplier = new System.Windows.Forms.DataGridView();
            this.restore = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.archive_supplier)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Location = new System.Drawing.Point(-45, -9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 74);
            this.panel1.TabIndex = 64;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(57, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(321, 41);
            this.label15.TabIndex = 126;
            this.label15.Text = "SUPPLIER ARCHIVE";
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btn_close.Location = new System.Drawing.Point(696, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(112, 59);
            this.btn_close.TabIndex = 64;
            this.btn_close.Text = "BACK";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // archive_supplier
            // 
            this.archive_supplier.AllowUserToAddRows = false;
            this.archive_supplier.AllowUserToDeleteRows = false;
            this.archive_supplier.AllowUserToResizeColumns = false;
            this.archive_supplier.AllowUserToResizeRows = false;
            this.archive_supplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.archive_supplier.BackgroundColor = System.Drawing.Color.MintCream;
            this.archive_supplier.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.archive_supplier.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.archive_supplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.archive_supplier.Location = new System.Drawing.Point(12, 101);
            this.archive_supplier.Name = "archive_supplier";
            this.archive_supplier.ReadOnly = true;
            this.archive_supplier.RowHeadersVisible = false;
            this.archive_supplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.archive_supplier.Size = new System.Drawing.Size(737, 278);
            this.archive_supplier.TabIndex = 210;
            this.archive_supplier.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.archive_supplier_CellClick);
            // 
            // restore
            // 
            this.restore.BackColor = System.Drawing.Color.Transparent;
            this.restore.FlatAppearance.BorderSize = 0;
            this.restore.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.restore.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.restore.Location = new System.Drawing.Point(12, 71);
            this.restore.Name = "restore";
            this.restore.Size = new System.Drawing.Size(129, 25);
            this.restore.TabIndex = 248;
            this.restore.Text = "RESTORE";
            this.restore.UseVisualStyleBackColor = false;
            this.restore.Click += new System.EventHandler(this.restore_Click);
            // 
            // Supplier_Archive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(761, 391);
            this.Controls.Add(this.restore);
            this.Controls.Add(this.archive_supplier);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Supplier_Archive";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supplier_Archive";
            this.Load += new System.EventHandler(this.Supplier_Archive_Load);
            this.VisibleChanged += new System.EventHandler(this.Supplier_Archive_VisibleChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.archive_supplier)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.DataGridView archive_supplier;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button restore;
    }
}