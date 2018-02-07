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
            this.inventory_report = new System.Windows.Forms.Button();
            this.sales_report = new System.Windows.Forms.Button();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sales)).BeginInit();
            this.SuspendLayout();
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.panel15.Controls.Add(this.Back);
            this.panel15.Controls.Add(this.label15);
            this.panel15.Location = new System.Drawing.Point(-3, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(853, 50);
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
            this.Back.Size = new System.Drawing.Size(94, 50);
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
            this.sales.Location = new System.Drawing.Point(21, 98);
            this.sales.Name = "sales";
            this.sales.ReadOnly = true;
            this.sales.RowHeadersVisible = false;
            this.sales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sales.Size = new System.Drawing.Size(486, 445);
            this.sales.TabIndex = 207;
            // 
            // inventory_report
            // 
            this.inventory_report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.inventory_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventory_report.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold);
            this.inventory_report.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.inventory_report.Location = new System.Drawing.Point(138, 56);
            this.inventory_report.Name = "inventory_report";
            this.inventory_report.Size = new System.Drawing.Size(98, 36);
            this.inventory_report.TabIndex = 209;
            this.inventory_report.Text = "INVENTORY";
            this.inventory_report.UseVisualStyleBackColor = false;
            // 
            // sales_report
            // 
            this.sales_report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.sales_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sales_report.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold);
            this.sales_report.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sales_report.Location = new System.Drawing.Point(40, 56);
            this.sales_report.Name = "sales_report";
            this.sales_report.Size = new System.Drawing.Size(92, 36);
            this.sales_report.TabIndex = 208;
            this.sales_report.Text = "SALES";
            this.sales_report.UseVisualStyleBackColor = false;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(530, 555);
            this.Controls.Add(this.inventory_report);
            this.Controls.Add(this.sales_report);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView sales;
        private System.Windows.Forms.Button inventory_report;
        private System.Windows.Forms.Button sales_report;
    }
}