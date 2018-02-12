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
            //inventory();
        }

        private void inventory()
        {
            String inventoryquery = "SELECT * FROM items;";
            conn.Open();
            MySqlCommand comm = new MySqlCommand(inventoryquery, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable dt_log = new DataTable();
            adp.Fill(dt_log);

            inventory_dtgv.DataSource = dt_log;

            inventory_dtgv.Columns["itemID"].Visible = false;
            inventory_dtgv.Columns["purchaseorder_line_POLineID"].Visible = false;
            inventory_dtgv.Columns["itemName"].HeaderText = "Name";
            inventory_dtgv.Columns["itemQuantity"].HeaderText = "Quantity";
            inventory_dtgv.Columns["itemAmount"].HeaderText = "Amount";
            inventory_dtgv.Columns["itemUnit"].HeaderText = "Unit";
            inventory_dtgv.Columns["itemStatus"].HeaderText = "Status";
            inventory_dtgv.Columns["itemType"].HeaderText = "Type";
            inventory_dtgv.Columns["itemExpiry"].HeaderText = "Expiration Date";
            inventory_dtgv.Columns["itemStockedIn"].HeaderText = "Date";
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
