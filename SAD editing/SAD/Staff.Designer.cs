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
            this.staff_update = new System.Windows.Forms.Button();
            this.staff_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.records = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.records)).BeginInit();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Tomato;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(855, -1);
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
            this.dtgv.BackgroundColor = System.Drawing.Color.White;
            this.dtgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv.Location = new System.Drawing.Point(12, 98);
            this.dtgv.MultiSelect = false;
            this.dtgv.Name = "dtgv";
            this.dtgv.ReadOnly = true;
            this.dtgv.RowHeadersVisible = false;
            this.dtgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv.Size = new System.Drawing.Size(599, 460);
            this.dtgv.TabIndex = 111;
            this.dtgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.staff_update);
            this.panel1.Controls.Add(this.staff_add);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Back);
            this.panel1.Location = new System.Drawing.Point(-14, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(972, 67);
            this.panel1.TabIndex = 109;
            // 
            // staff_update
            // 
            this.staff_update.BackColor = System.Drawing.Color.Gold;
            this.staff_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.staff_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staff_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staff_update.ForeColor = System.Drawing.Color.Black;
            this.staff_update.Location = new System.Drawing.Point(746, 17);
            this.staff_update.Name = "staff_update";
            this.staff_update.Size = new System.Drawing.Size(103, 37);
            this.staff_update.TabIndex = 117;
            this.staff_update.Text = "Update";
            this.staff_update.UseVisualStyleBackColor = false;
            this.staff_update.Click += new System.EventHandler(this.staff_update_Click);
            // 
            // staff_add
            // 
            this.staff_add.BackColor = System.Drawing.Color.YellowGreen;
            this.staff_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staff_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staff_add.Location = new System.Drawing.Point(639, 17);
            this.staff_add.Name = "staff_add";
            this.staff_add.Size = new System.Drawing.Size(101, 37);
            this.staff_add.TabIndex = 116;
            this.staff_add.Text = "Add";
            this.staff_add.UseVisualStyleBackColor = false;
            this.staff_add.Click += new System.EventHandler(this.staff_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 29);
            this.label1.TabIndex = 115;
            this.label1.Text = "STAFF";
            // 
            // records
            // 
            this.records.AllowUserToAddRows = false;
            this.records.AllowUserToDeleteRows = false;
            this.records.AllowUserToResizeColumns = false;
            this.records.AllowUserToResizeRows = false;
            this.records.BackgroundColor = System.Drawing.Color.White;
            this.records.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.records.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.records.Location = new System.Drawing.Point(617, 98);
            this.records.MultiSelect = false;
            this.records.Name = "records";
            this.records.ReadOnly = true;
            this.records.RowHeadersVisible = false;
            this.records.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.records.Size = new System.Drawing.Size(325, 460);
            this.records.TabIndex = 112;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label2.Location = new System.Drawing.Point(617, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 29);
            this.label2.TabIndex = 116;
            this.label2.Text = "RECORDS";
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 570);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.records);
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
            ((System.ComponentModel.ISupportInitialize)(this.records)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button staff_add;
        private System.Windows.Forms.Button staff_update;
        private System.Windows.Forms.DataGridView records;
        private System.Windows.Forms.Label label2;
    }
}