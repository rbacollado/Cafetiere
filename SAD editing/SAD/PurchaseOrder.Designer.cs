namespace SAD
{
    partial class PurchaseOrder
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
            this.item_ordered = new System.Windows.Forms.DataGridView();
            this.items_delivered = new System.Windows.Forms.DataGridView();
            this.items_stockin = new System.Windows.Forms.DataGridView();
            this.add_purchase = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timeText = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.item_ordered)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.items_delivered)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.items_stockin)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.timeText);
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-1, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(951, 64);
            this.panel1.TabIndex = 62;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btn_close.Location = new System.Drawing.Point(838, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(82, 61);
            this.btn_close.TabIndex = 64;
            this.btn_close.Text = "BACK";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(26, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "PURCHASE ORDER";
            // 
            // item_ordered
            // 
            this.item_ordered.AllowUserToAddRows = false;
            this.item_ordered.AllowUserToDeleteRows = false;
            this.item_ordered.AllowUserToResizeColumns = false;
            this.item_ordered.AllowUserToResizeRows = false;
            this.item_ordered.BackgroundColor = System.Drawing.Color.MintCream;
            this.item_ordered.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.item_ordered.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.item_ordered.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.item_ordered.Location = new System.Drawing.Point(12, 95);
            this.item_ordered.Name = "item_ordered";
            this.item_ordered.ReadOnly = true;
            this.item_ordered.RowHeadersVisible = false;
            this.item_ordered.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.item_ordered.Size = new System.Drawing.Size(421, 566);
            this.item_ordered.TabIndex = 207;
            // 
            // items_delivered
            // 
            this.items_delivered.AllowUserToAddRows = false;
            this.items_delivered.AllowUserToDeleteRows = false;
            this.items_delivered.AllowUserToResizeColumns = false;
            this.items_delivered.AllowUserToResizeRows = false;
            this.items_delivered.BackgroundColor = System.Drawing.Color.MintCream;
            this.items_delivered.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.items_delivered.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.items_delivered.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.items_delivered.Location = new System.Drawing.Point(439, 95);
            this.items_delivered.Name = "items_delivered";
            this.items_delivered.ReadOnly = true;
            this.items_delivered.RowHeadersVisible = false;
            this.items_delivered.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.items_delivered.Size = new System.Drawing.Size(465, 229);
            this.items_delivered.TabIndex = 208;
            // 
            // items_stockin
            // 
            this.items_stockin.AllowUserToAddRows = false;
            this.items_stockin.AllowUserToDeleteRows = false;
            this.items_stockin.AllowUserToResizeColumns = false;
            this.items_stockin.AllowUserToResizeRows = false;
            this.items_stockin.BackgroundColor = System.Drawing.Color.MintCream;
            this.items_stockin.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.items_stockin.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.items_stockin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.items_stockin.Location = new System.Drawing.Point(439, 350);
            this.items_stockin.Name = "items_stockin";
            this.items_stockin.ReadOnly = true;
            this.items_stockin.RowHeadersVisible = false;
            this.items_stockin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.items_stockin.Size = new System.Drawing.Size(465, 311);
            this.items_stockin.TabIndex = 209;
            // 
            // add_purchase
            // 
            this.add_purchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.add_purchase.FlatAppearance.BorderSize = 0;
            this.add_purchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_purchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_purchase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.add_purchase.Location = new System.Drawing.Point(12, 66);
            this.add_purchase.Name = "add_purchase";
            this.add_purchase.Size = new System.Drawing.Size(89, 31);
            this.add_purchase.TabIndex = 211;
            this.add_purchase.Text = "CREATE";
            this.add_purchase.UseVisualStyleBackColor = false;
            this.add_purchase.Click += new System.EventHandler(this.add_purchase_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(43)))), ((int)(((byte)(73)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(439, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(465, 40);
            this.panel2.TabIndex = 212;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "DELIVERED";
            // 
            // timeText
            // 
            this.timeText.AutoSize = true;
            this.timeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeText.ForeColor = System.Drawing.Color.White;
            this.timeText.Location = new System.Drawing.Point(696, 20);
            this.timeText.Name = "timeText";
            this.timeText.Size = new System.Drawing.Size(45, 24);
            this.timeText.TabIndex = 65;
            this.timeText.Text = "time";
            // 
            // PurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 690);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.add_purchase);
            this.Controls.Add(this.items_stockin);
            this.Controls.Add(this.items_delivered);
            this.Controls.Add(this.item_ordered);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PurchaseOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PurchaseOrder";
            this.Load += new System.EventHandler(this.PurchaseOrder_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.item_ordered)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.items_delivered)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.items_stockin)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView item_ordered;
        private System.Windows.Forms.DataGridView items_delivered;
        private System.Windows.Forms.DataGridView items_stockin;
        private System.Windows.Forms.Button add_purchase;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label timeText;
    }
}