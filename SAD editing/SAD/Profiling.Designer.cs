namespace SAD
{
    partial class Profiling
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
            this.btn_supplier = new System.Windows.Forms.Button();
            this.btn_staff = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Back = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_supplier
            // 
            this.btn_supplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btn_supplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_supplier.ForeColor = System.Drawing.Color.Transparent;
            this.btn_supplier.Location = new System.Drawing.Point(211, 94);
            this.btn_supplier.Name = "btn_supplier";
            this.btn_supplier.Size = new System.Drawing.Size(189, 89);
            this.btn_supplier.TabIndex = 60;
            this.btn_supplier.Text = "SUPPLIER";
            this.btn_supplier.UseVisualStyleBackColor = false;
            this.btn_supplier.Click += new System.EventHandler(this.btn_supplier_Click);
            // 
            // btn_staff
            // 
            this.btn_staff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btn_staff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_staff.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_staff.ForeColor = System.Drawing.Color.Transparent;
            this.btn_staff.Location = new System.Drawing.Point(18, 94);
            this.btn_staff.Name = "btn_staff";
            this.btn_staff.Size = new System.Drawing.Size(176, 89);
            this.btn_staff.TabIndex = 59;
            this.btn_staff.Text = "STAFF";
            this.btn_staff.UseVisualStyleBackColor = false;
            this.btn_staff.Click += new System.EventHandler(this.btn_staff_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(20, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 37);
            this.label3.TabIndex = 19;
            this.label3.Text = "PROFILING";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.Back);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-9, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 79);
            this.panel1.TabIndex = 61;
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Tomato;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(330, 3);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(100, 73);
            this.Back.TabIndex = 86;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Profiling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 245);
            this.Controls.Add(this.btn_supplier);
            this.Controls.Add(this.btn_staff);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Profiling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profiling";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_supplier;
        private System.Windows.Forms.Button btn_staff;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Back;
    }
}