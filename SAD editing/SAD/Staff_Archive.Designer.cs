namespace SAD
{
    partial class Staff_Archive
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
            this.label3 = new System.Windows.Forms.Label();
            this.archive_staff = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.archive_staff)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-37, -11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 74);
            this.panel1.TabIndex = 63;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btn_close.Location = new System.Drawing.Point(712, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(87, 59);
            this.btn_close.TabIndex = 64;
            this.btn_close.Text = "BACK";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(49, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "STAFF ARCHIVE";
            // 
            // archive_staff
            // 
            this.archive_staff.AllowUserToAddRows = false;
            this.archive_staff.AllowUserToDeleteRows = false;
            this.archive_staff.AllowUserToResizeColumns = false;
            this.archive_staff.AllowUserToResizeRows = false;
            this.archive_staff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.archive_staff.BackgroundColor = System.Drawing.Color.MintCream;
            this.archive_staff.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.archive_staff.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.archive_staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.archive_staff.Location = new System.Drawing.Point(12, 80);
            this.archive_staff.Name = "archive_staff";
            this.archive_staff.ReadOnly = true;
            this.archive_staff.RowHeadersVisible = false;
            this.archive_staff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.archive_staff.Size = new System.Drawing.Size(737, 299);
            this.archive_staff.TabIndex = 209;
            this.archive_staff.SelectionChanged += new System.EventHandler(this.archive_staff_SelectionChanged);
            // 
            // Staff_Archive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(761, 391);
            this.Controls.Add(this.archive_staff);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Staff_Archive";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff_Archive";
            this.Load += new System.EventHandler(this.Staff_Archive_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.archive_staff)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView archive_staff;
    }
}