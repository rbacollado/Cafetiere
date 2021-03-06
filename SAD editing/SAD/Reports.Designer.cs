﻿namespace SAD
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
            this.sales_report = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.end_filter = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.start_filter = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.sales_details = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.print = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sales_report)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sales_details)).BeginInit();
            this.SuspendLayout();
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.panel15.Controls.Add(this.label15);
            this.panel15.Controls.Add(this.Back);
            this.panel15.Location = new System.Drawing.Point(-3, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(993, 62);
            this.panel15.TabIndex = 62;
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Back.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.Back.Location = new System.Drawing.Point(868, 0);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(94, 59);
            this.Back.TabIndex = 98;
            this.Back.Text = "BACK";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // sales_report
            // 
            this.sales_report.AllowUserToAddRows = false;
            this.sales_report.AllowUserToDeleteRows = false;
            this.sales_report.AllowUserToResizeColumns = false;
            this.sales_report.AllowUserToResizeRows = false;
            this.sales_report.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sales_report.BackgroundColor = System.Drawing.Color.MintCream;
            this.sales_report.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.sales_report.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.sales_report.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sales_report.Location = new System.Drawing.Point(18, 141);
            this.sales_report.Name = "sales_report";
            this.sales_report.ReadOnly = true;
            this.sales_report.RowHeadersVisible = false;
            this.sales_report.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sales_report.Size = new System.Drawing.Size(494, 412);
            this.sales_report.TabIndex = 207;
            this.sales_report.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sales_report_CellClick);
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
            this.panel3.Size = new System.Drawing.Size(1061, 44);
            this.panel3.TabIndex = 208;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label2.Location = new System.Drawing.Point(420, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 18);
            this.label2.TabIndex = 68;
            this.label2.Text = "End:";
            // 
            // end_filter
            // 
            this.end_filter.Location = new System.Drawing.Point(465, 13);
            this.end_filter.Name = "end_filter";
            this.end_filter.Size = new System.Drawing.Size(146, 20);
            this.end_filter.TabIndex = 67;
            this.end_filter.ValueChanged += new System.EventHandler(this.end_filter_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label1.Location = new System.Drawing.Point(220, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 18);
            this.label1.TabIndex = 66;
            this.label1.Text = "Start:";
            // 
            // start_filter
            // 
            this.start_filter.Location = new System.Drawing.Point(269, 13);
            this.start_filter.Name = "start_filter";
            this.start_filter.Size = new System.Drawing.Size(146, 20);
            this.start_filter.TabIndex = 65;
            this.start_filter.ValueChanged += new System.EventHandler(this.start_filter_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label6.Location = new System.Drawing.Point(126, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Filter:";
            // 
            // sales_details
            // 
            this.sales_details.AllowUserToAddRows = false;
            this.sales_details.AllowUserToDeleteRows = false;
            this.sales_details.AllowUserToResizeColumns = false;
            this.sales_details.AllowUserToResizeRows = false;
            this.sales_details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sales_details.BackgroundColor = System.Drawing.Color.MintCream;
            this.sales_details.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.sales_details.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.sales_details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sales_details.Location = new System.Drawing.Point(518, 141);
            this.sales_details.Name = "sales_details";
            this.sales_details.ReadOnly = true;
            this.sales_details.RowHeadersVisible = false;
            this.sales_details.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sales_details.Size = new System.Drawing.Size(420, 412);
            this.sales_details.TabIndex = 209;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 28);
            this.label3.TabIndex = 210;
            this.label3.Text = "SALES DETAILS";
            // 
            // print
            // 
            this.print.BackColor = System.Drawing.Color.Ivory;
            this.print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.print.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print.ForeColor = System.Drawing.Color.Black;
            this.print.Location = new System.Drawing.Point(859, 108);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(79, 29);
            this.print.TabIndex = 100;
            this.print.Text = "PRINT";
            this.print.UseVisualStyleBackColor = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(391, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(218, 41);
            this.label15.TabIndex = 99;
            this.label15.Text = "R E P O R T S";
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(953, 565);
            this.Controls.Add(this.print);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sales_details);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.sales_report);
            this.Controls.Add(this.panel15);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sales_report)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sales_details)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.DataGridView sales_report;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker end_filter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker start_filter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView sales_details;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.Label label15;
    }
}