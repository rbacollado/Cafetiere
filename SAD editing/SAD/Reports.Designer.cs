namespace SAD
{
    partial class Reports
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
            this.panel15 = new System.Windows.Forms.Panel();
            this.Back = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.sales = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.end_filter = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.start_filter = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sales)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.panel15.Controls.Add(this.Back);
            this.panel15.Controls.Add(this.label15);
            this.panel15.Location = new System.Drawing.Point(-3, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(853, 62);
            this.panel15.TabIndex = 62;
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.Back.Location = new System.Drawing.Point(442, 0);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(94, 59);
            this.Back.TabIndex = 98;
            this.Back.Text = "BACK";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(38, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(137, 29);
            this.label15.TabIndex = 12;
            this.label15.Text = "REPORTS";
            // 
            // sales
            // 
            this.sales.AllowUserToAddRows = false;
            this.sales.AllowUserToDeleteRows = false;
            this.sales.AllowUserToResizeColumns = false;
            this.sales.AllowUserToResizeRows = false;
            this.sales.BackgroundColor = System.Drawing.Color.MintCream;
            this.sales.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.sales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.sales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sales.Location = new System.Drawing.Point(21, 119);
            this.sales.Name = "sales";
            this.sales.ReadOnly = true;
            this.sales.RowHeadersVisible = false;
            this.sales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sales.Size = new System.Drawing.Size(486, 424);
            this.sales.TabIndex = 207;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.end_filter);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.start_filter);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(-99, 56);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(729, 57);
            this.panel3.TabIndex = 208;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label2.Location = new System.Drawing.Point(391, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 18);
            this.label2.TabIndex = 68;
            this.label2.Text = "End:";
            // 
            // end_filter
            // 
            this.end_filter.Location = new System.Drawing.Point(436, 26);
            this.end_filter.Name = "end_filter";
            this.end_filter.Size = new System.Drawing.Size(146, 20);
            this.end_filter.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label1.Location = new System.Drawing.Point(191, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 18);
            this.label1.TabIndex = 66;
            this.label1.Text = "Start:";
            // 
            // start_filter
            // 
            this.start_filter.Location = new System.Drawing.Point(240, 26);
            this.start_filter.Name = "start_filter";
            this.start_filter.Size = new System.Drawing.Size(146, 20);
            this.start_filter.TabIndex = 65;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label6.Location = new System.Drawing.Point(115, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Filter:";
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(530, 555);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.sales);
            this.Controls.Add(this.panel15);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sales)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView sales;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker end_filter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker start_filter;
        private System.Windows.Forms.Label label6;
    }
}