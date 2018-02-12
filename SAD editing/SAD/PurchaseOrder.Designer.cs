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
            this.timeText = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.item_purchased = new System.Windows.Forms.DataGridView();
            this.item_poLine = new System.Windows.Forms.DataGridView();
            this.items_stockin = new System.Windows.Forms.DataGridView();
            this.add_purchase = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.stockin_btn = new System.Windows.Forms.Button();
            this.Total = new System.Windows.Forms.Label();
            this.TotalTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.moveBtn = new System.Windows.Forms.Button();
            this.returnBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.item_purchased)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item_poLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.items_stockin)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(991, 64);
            this.panel1.TabIndex = 62;
            // 
            // timeText
            // 
            this.timeText.AutoSize = true;
            this.timeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeText.ForeColor = System.Drawing.Color.White;
            this.timeText.Location = new System.Drawing.Point(580, 20);
            this.timeText.Name = "timeText";
            this.timeText.Size = new System.Drawing.Size(45, 24);
            this.timeText.TabIndex = 65;
            this.timeText.Text = "time";
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btn_close.Location = new System.Drawing.Point(734, 4);
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
            this.label3.Location = new System.Drawing.Point(22, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "PURCHASE ORDER";
            // 
            // item_purchased
            // 
            this.item_purchased.AllowUserToAddRows = false;
            this.item_purchased.AllowUserToDeleteRows = false;
            this.item_purchased.AllowUserToResizeColumns = false;
            this.item_purchased.AllowUserToResizeRows = false;
            this.item_purchased.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.item_purchased.BackgroundColor = System.Drawing.Color.White;
            this.item_purchased.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.item_purchased.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.item_purchased.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.item_purchased.GridColor = System.Drawing.SystemColors.Control;
            this.item_purchased.Location = new System.Drawing.Point(12, 92);
            this.item_purchased.Name = "item_purchased";
            this.item_purchased.ReadOnly = true;
            this.item_purchased.RowHeadersVisible = false;
            this.item_purchased.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.item_purchased.Size = new System.Drawing.Size(785, 234);
            this.item_purchased.TabIndex = 207;
            this.item_purchased.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.item_ordered_CellClick);
            this.item_purchased.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.item_purchased_RowStateChanged);
            // 
            // item_poLine
            // 
            this.item_poLine.AllowUserToAddRows = false;
            this.item_poLine.AllowUserToDeleteRows = false;
            this.item_poLine.AllowUserToResizeColumns = false;
            this.item_poLine.AllowUserToResizeRows = false;
            this.item_poLine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.item_poLine.BackgroundColor = System.Drawing.Color.White;
            this.item_poLine.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.item_poLine.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.item_poLine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.item_poLine.Location = new System.Drawing.Point(12, 357);
            this.item_poLine.Name = "item_poLine";
            this.item_poLine.ReadOnly = true;
            this.item_poLine.RowHeadersVisible = false;
            this.item_poLine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.item_poLine.Size = new System.Drawing.Size(356, 325);
            this.item_poLine.TabIndex = 208;
            this.item_poLine.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.item_poLine_CellClick);
            // 
            // items_stockin
            // 
            this.items_stockin.AllowUserToAddRows = false;
            this.items_stockin.AllowUserToDeleteRows = false;
            this.items_stockin.AllowUserToResizeColumns = false;
            this.items_stockin.AllowUserToResizeRows = false;
            this.items_stockin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.items_stockin.BackgroundColor = System.Drawing.Color.White;
            this.items_stockin.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.items_stockin.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.items_stockin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.items_stockin.Location = new System.Drawing.Point(461, 357);
            this.items_stockin.Name = "items_stockin";
            this.items_stockin.ReadOnly = true;
            this.items_stockin.RowHeadersVisible = false;
            this.items_stockin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.items_stockin.Size = new System.Drawing.Size(341, 325);
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
            this.add_purchase.Size = new System.Drawing.Size(97, 26);
            this.add_purchase.TabIndex = 211;
            this.add_purchase.Text = "CREATE";
            this.add_purchase.UseVisualStyleBackColor = false;
            this.add_purchase.Click += new System.EventHandler(this.add_purchase_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(12, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(324, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "PURCHASE ORDER DETAILS";
            // 
            // stockin_btn
            // 
            this.stockin_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.stockin_btn.FlatAppearance.BorderSize = 0;
            this.stockin_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stockin_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockin_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.stockin_btn.Location = new System.Drawing.Point(701, 680);
            this.stockin_btn.Name = "stockin_btn";
            this.stockin_btn.Size = new System.Drawing.Size(101, 26);
            this.stockin_btn.TabIndex = 214;
            this.stockin_btn.Text = "STOCK IN";
            this.stockin_btn.UseVisualStyleBackColor = false;
            this.stockin_btn.Click += new System.EventHandler(this.stockin_btn_Click);
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.ForeColor = System.Drawing.Color.White;
            this.Total.Location = new System.Drawing.Point(533, 65);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(141, 24);
            this.Total.TabIndex = 209;
            this.Total.Text = "Total Expenses";
            // 
            // TotalTB
            // 
            this.TotalTB.BackColor = System.Drawing.SystemColors.Window;
            this.TotalTB.Enabled = false;
            this.TotalTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTB.Location = new System.Drawing.Point(680, 62);
            this.TotalTB.Name = "TotalTB";
            this.TotalTB.Size = new System.Drawing.Size(115, 29);
            this.TotalTB.TabIndex = 210;
            this.TotalTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(451, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 25);
            this.label1.TabIndex = 215;
            this.label1.Text = "TO BE STOCKED IN";
            // 
            // moveBtn
            // 
            this.moveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.moveBtn.FlatAppearance.BorderSize = 0;
            this.moveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.moveBtn.Location = new System.Drawing.Point(374, 454);
            this.moveBtn.Name = "moveBtn";
            this.moveBtn.Size = new System.Drawing.Size(81, 31);
            this.moveBtn.TabIndex = 216;
            this.moveBtn.Text = "MOVE";
            this.moveBtn.UseVisualStyleBackColor = false;
            this.moveBtn.Visible = false;
            this.moveBtn.Click += new System.EventHandler(this.moveBtn_Click);
            // 
            // returnBtn
            // 
            this.returnBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.returnBtn.FlatAppearance.BorderSize = 0;
            this.returnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.returnBtn.Location = new System.Drawing.Point(374, 491);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(81, 31);
            this.returnBtn.TabIndex = 217;
            this.returnBtn.Text = "RETURN";
            this.returnBtn.UseVisualStyleBackColor = false;
            this.returnBtn.Visible = false;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // PurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(43)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(814, 718);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.moveBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.TotalTB);
            this.Controls.Add(this.stockin_btn);
            this.Controls.Add(this.add_purchase);
            this.Controls.Add(this.items_stockin);
            this.Controls.Add(this.item_poLine);
            this.Controls.Add(this.item_purchased);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PurchaseOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PurchaseOrder";
            this.Load += new System.EventHandler(this.PurchaseOrder_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.item_purchased)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item_poLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.items_stockin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView item_purchased;
        private System.Windows.Forms.DataGridView item_poLine;
        private System.Windows.Forms.DataGridView items_stockin;
        private System.Windows.Forms.Button add_purchase;
        private System.Windows.Forms.Label timeText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button stockin_btn;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.TextBox TotalTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button moveBtn;
        private System.Windows.Forms.Button returnBtn;
    }
}