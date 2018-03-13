namespace SAD
{
    partial class InventoryLog
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_filter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.end_filter = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.start_filter = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.inventory_log = new System.Windows.Forms.DataGridView();
            this.print = new System.Windows.Forms.Button();
            this.log_id = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventory_log)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-8, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 59);
            this.panel1.TabIndex = 61;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btn_close.Location = new System.Drawing.Point(677, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(97, 59);
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
            this.label3.Location = new System.Drawing.Point(23, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "INVENTORY LOG";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.panel3.Controls.Add(this.print);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.cmb_filter);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.end_filter);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.start_filter);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(-28, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(820, 58);
            this.panel3.TabIndex = 63;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label4.Location = new System.Drawing.Point(461, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 18);
            this.label4.TabIndex = 124;
            this.label4.Text = "Activity:";
            // 
            // cmb_filter
            // 
            this.cmb_filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_filter.FormattingEnabled = true;
            this.cmb_filter.Items.AddRange(new object[] {
            "All",
            "Stock in (Wet Market)",
            "Stock in (Purchased)",
            "Stock out(Manual)"});
            this.cmb_filter.Location = new System.Drawing.Point(533, 19);
            this.cmb_filter.Name = "cmb_filter";
            this.cmb_filter.Size = new System.Drawing.Size(121, 21);
            this.cmb_filter.TabIndex = 123;
            this.cmb_filter.SelectedIndexChanged += new System.EventHandler(this.cmb_filter_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label2.Location = new System.Drawing.Point(245, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 18);
            this.label2.TabIndex = 68;
            this.label2.Text = "End:";
            // 
            // end_filter
            // 
            this.end_filter.Location = new System.Drawing.Point(290, 26);
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
            this.label1.Location = new System.Drawing.Point(44, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 18);
            this.label1.TabIndex = 66;
            this.label1.Text = "Start:";
            // 
            // start_filter
            // 
            this.start_filter.Location = new System.Drawing.Point(93, 26);
            this.start_filter.Name = "start_filter";
            this.start_filter.Size = new System.Drawing.Size(146, 20);
            this.start_filter.TabIndex = 65;
            this.start_filter.ValueChanged += new System.EventHandler(this.datetime_filter_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label6.Location = new System.Drawing.Point(40, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Filter:";
            // 
            // inventory_log
            // 
            this.inventory_log.AllowUserToAddRows = false;
            this.inventory_log.AllowUserToDeleteRows = false;
            this.inventory_log.AllowUserToResizeColumns = false;
            this.inventory_log.AllowUserToResizeRows = false;
            this.inventory_log.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.inventory_log.BackgroundColor = System.Drawing.Color.White;
            this.inventory_log.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.inventory_log.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.inventory_log.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventory_log.GridColor = System.Drawing.SystemColors.Control;
            this.inventory_log.Location = new System.Drawing.Point(19, 128);
            this.inventory_log.Name = "inventory_log";
            this.inventory_log.ReadOnly = true;
            this.inventory_log.RowHeadersVisible = false;
            this.inventory_log.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.inventory_log.Size = new System.Drawing.Size(717, 478);
            this.inventory_log.TabIndex = 209;
            this.inventory_log.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inventory_log_CellContentClick);
            // 
            // print
            // 
            this.print.BackColor = System.Drawing.Color.Ivory;
            this.print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.print.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print.ForeColor = System.Drawing.Color.Black;
            this.print.Location = new System.Drawing.Point(683, 13);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(93, 32);
            this.print.TabIndex = 99;
            this.print.Text = "PRINT";
            this.print.UseVisualStyleBackColor = false;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // log_id
            // 
            this.log_id.BackColor = System.Drawing.Color.White;
            this.log_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.log_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_id.ForeColor = System.Drawing.Color.Black;
            this.log_id.Location = new System.Drawing.Point(725, 178);
            this.log_id.Multiline = true;
            this.log_id.Name = "log_id";
            this.log_id.Size = new System.Drawing.Size(23, 27);
            this.log_id.TabIndex = 65;
            // 
            // InventoryLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(760, 633);
            this.Controls.Add(this.log_id);
            this.Controls.Add(this.inventory_log);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InventoryLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InventoryLog";
            this.Load += new System.EventHandler(this.InventoryLog_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventory_log)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.DateTimePicker start_filter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker end_filter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView inventory_log;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_filter;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.TextBox log_id;
    }
}