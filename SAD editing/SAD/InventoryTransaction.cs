using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SAD
{
    public partial class InventoryTransaction : Form
    {
        MySqlConnection conn;

        public Form prevForm { get; set; }

        public InventoryTransaction()
        {
            InitializeComponent();
            conn = new MySqlConnection("SERVER=localhost; DATABASE=cafetiere; uid=root; pwd=root; Allow Zero Datetime=true");
            txt_staffposition.Text = SAD.Login.DisplayUserDetails.usertype;
            txt_staffname.Text = SAD.Login.DisplayUserDetails.name;

        }


        private void InventoryTransaction_Load(object sender, EventArgs e)
        {
            inventory();
        }

        private void inventory()
        {
            String inventoryquery = "SELECT itemInvID, item_ID, name, unit, amount, price as Cost, itemQuantity, itemStatus, itemType, itemExpiry, itemStockedIn FROM items " +
                                    "INNER JOIN items_inventory ON items.itemsID = items_inventory.item_ID;";
            conn.Open();
            MySqlCommand comm = new MySqlCommand(inventoryquery, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable dt_log = new DataTable();
            adp.Fill(dt_log);

            inventory_dtgv.DataSource = dt_log;

            inventory_dtgv.Columns["item_ID"].Visible = false;
            inventory_dtgv.Columns["itemInvID"].Visible = false;
            inventory_dtgv.Columns["name"].HeaderText = "Name";
            inventory_dtgv.Columns["unit"].HeaderText = "Unit";
            inventory_dtgv.Columns["amount"].HeaderText = "Amount";
            inventory_dtgv.Columns["Cost"].HeaderText = "Cost";
            inventory_dtgv.Columns["itemQuantity"].HeaderText = "Quantity";
            inventory_dtgv.Columns["itemStatus"].HeaderText = "Status";
            inventory_dtgv.Columns["itemType"].HeaderText = "Type";
            inventory_dtgv.Columns["itemExpiry"].HeaderText = "Expiration Date";
            inventory_dtgv.Columns["itemStockedIn"].HeaderText = "Date";
        }

        public static int itemInvID;
        private void inventory_dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int selected_id = int.Parse(inventory_dtgv.Rows[e.RowIndex].Cells["itemInvID"].Value.ToString());
                itemInvID = selected_id;

                show_SOpanel.Visible = true;
                pictureBox5.Visible = true;

            }
        }
        private void show_SOpanel_Click(object sender, EventArgs e)
        {

            panel_stockout.Visible = true;
            panel_stockout.Enabled = true;
            panel_stockout.Size = new Size(341, 385);
            panel_stockout.Location = new Point(738, 297);
            

        }
        
        

        private void btn_SOBack_Click(object sender, EventArgs e)
        {
            panel_stockout.Visible = false;
            panel_stockout.Enabled = false;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Close();
        }

        private void btn_logs_Click(object sender, EventArgs e)
        {
            InventoryLog logs = new InventoryLog();
            logs.prevForm = this;
            logs.Show();
            this.Hide();
        }

        private void btn_PO_Click(object sender, EventArgs e)
        {
            PurchaseOrder po = new PurchaseOrder();
            po.prevForm = this;
            po.Show();
            this.Hide();
        }

        private void stockin_btn_Click(object sender, EventArgs e)
        {
            Inventory_Stockin stockin = new Inventory_Stockin();
            stockin.prevForm = this;
            stockin.Show();
            this.Hide();
        }

        
    }
}
