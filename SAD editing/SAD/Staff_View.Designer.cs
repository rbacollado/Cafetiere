namespace SAD
{
    partial class Staff_View
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
            this.label15 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.panel15 = new System.Windows.Forms.Panel();
            this.timeText = new System.Windows.Forms.Label();
            this.records = new System.Windows.Forms.DataGridView();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_position = new System.Windows.Forms.Label();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.records)).BeginInit();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(104, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(139, 29);
            this.label15.TabIndex = 12;
            this.label15.Text = "RECORDS";
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Tomato;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(578, 0);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(97, 67);
            this.Back.TabIndex = 98;
            this.Back.Text = "BACK";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.panel15.Controls.Add(this.timeText);
            this.panel15.Controls.Add(this.Back);
            this.panel15.Controls.Add(this.label15);
            this.panel15.Location = new System.Drawing.Point(-92, -2);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(853, 67);
            this.panel15.TabIndex = 63;
            // 
            // timeText
            // 
            this.timeText.AutoSize = true;
            this.timeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeText.ForeColor = System.Drawing.Color.White;
            this.timeText.Location = new System.Drawing.Point(456, 27);
            this.timeText.Name = "timeText";
            this.timeText.Size = new System.Drawing.Size(45, 24);
            this.timeText.TabIndex = 211;
            this.timeText.Text = "time";
            // 
            // records
            // 
            this.records.AllowUserToAddRows = false;
            this.records.AllowUserToDeleteRows = false;
            this.records.AllowUserToResizeColumns = false;
            this.records.AllowUserToResizeRows = false;
            this.records.BackgroundColor = System.Drawing.Color.MintCream;
            this.records.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.records.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.records.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.records.Location = new System.Drawing.Point(12, 121);
            this.records.Name = "records";
            this.records.ReadOnly = true;
            this.records.RowHeadersVisible = false;
            this.records.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.records.Size = new System.Drawing.Size(556, 444);
            this.records.TabIndex = 208;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_name.Location = new System.Drawing.Point(11, 83);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(104, 24);
            this.lbl_name.TabIndex = 209;
            this.lbl_name.Text = "staff name";
            // 
            // lbl_position
            // 
            this.lbl_position.AutoSize = true;
            this.lbl_position.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_position.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_position.Location = new System.Drawing.Point(200, 83);
            this.lbl_position.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_position.Name = "lbl_position";
            this.lbl_position.Size = new System.Drawing.Size(125, 24);
            this.lbl_position.TabIndex = 210;
            this.lbl_position.Text = "staff position";
            // 
            // Staff_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(580, 577);
            this.Controls.Add(this.lbl_position);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.records);
            this.Controls.Add(this.panel15);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Staff_View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff_View";
            this.Load += new System.EventHandler(this.Staff_View_Load);
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.records)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.DataGridView records;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_position;
        private System.Windows.Forms.Label timeText;
    }
}