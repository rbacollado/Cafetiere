using System;
using System.Globalization;
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
            
        }

        private void InventoryTransaction_Load(object sender, EventArgs e)
        {
            inventory_status();
            loadTobeRemoved();
            total();

            DateTime now = DateTime.Today;
            date_lbl.Text = now.ToString("MM-dd-yyyy");
        }

        public void total()
        {
            // Total
            decimal total = 0;
            for (int i = 0; i <= inventory_dtgv.Rows.Count - 1; i++)
            {
                total += (decimal.Parse(inventory_dtgv.Rows[i].Cells["Cost"].Value.ToString()));

            }
            TotalTB.Text = total.ToString();

        }

        private void inventory_dtgv_SelectionChanged(object sender, EventArgs e)
        {
            this.inventory_dtgv.ClearSelection();
            item_expires();
            restock();
        }

        public void restock()
        {
            String restockquery = "SELECT itemInvID, item_ID, name, itemQuantity, itemStatus, itemType, date_format(itemExpiry, '%m/%d/%y') as itemExpiry FROM items " +
                                  "INNER JOIN items_inventory ON items.itemsID = items_inventory.item_ID AND itemStatus like 'Unavailable' AND (itemExpiry > current_date() OR itemExpiry = '0000-00-00');";

            MySqlCommand comm_restock = new MySqlCommand(restockquery, conn);
            comm_restock.CommandText = restockquery;
            conn.Open();
            MySqlDataReader drd_restock = comm_restock.ExecuteReader();

            while (drd_restock.Read())
            {
                int itemInvID = int.Parse(drd_restock["itemInvID"].ToString());

                for (int i = 0; i < inventory_dtgv.Rows.Count; i++)
                {
                    if (itemInvID == int.Parse(inventory_dtgv.Rows[i].Cells["itemInvID"].Value.ToString()))
                    {
                        inventory_dtgv.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                        inventory_dtgv.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                    }
                }
            }
            conn.Close();
        }

        public void item_expires()
        {
            String query_expired = "SELECT itemInvID, date_format(itemExpiry, '%m /%d /%y') as itemExpiry FROM items_inventory " +
                                    "WHERE (itemType = 'Ingredient' OR itemType = 'Product') AND current_date() > itemExpiry;";

            MySqlCommand comm_expired = new MySqlCommand(query_expired, conn);
            comm_expired.CommandText = query_expired;
            conn.Open();
            MySqlDataReader drd_expire = comm_expired.ExecuteReader();

            while (drd_expire.Read())
            {
                int itemInvID = int.Parse(drd_expire["itemInvID"].ToString());
                
                for (int i = 0; i < inventory_dtgv.Rows.Count ; i++)
                {
                    if (itemInvID == int.Parse(inventory_dtgv.Rows[i].Cells["itemInvID"].Value.ToString()))
                    {
                        inventory_dtgv.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        inventory_dtgv.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                    }
                }
            }
            conn.Close();
        }

        private void inventory_status()
        {

            String inventoryquery = "SELECT itemInvID, item_ID, name, description, CONCAT(amount,' ',unit) as itemMeasurement , price as Cost, itemQuantity, itemStatus, itemType, date_format(itemExpiry, '%m/%d/%y') as itemExpiry , date_format(itemStockedIn, '%m/%d/%y') as itemStockedIn FROM items " +
                                    "INNER JOIN items_inventory ON items.itemsID = items_inventory.item_ID;";
            conn.Open();
            MySqlCommand comm = new MySqlCommand(inventoryquery, conn);
            comm.CommandText = inventoryquery;
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            conn.Close();

            DataTable dt_log = new DataTable();
            adp.Fill(dt_log);

            inventory_dtgv.DataSource = dt_log;

            inventory_dtgv.Columns["item_ID"].Visible = false;
            inventory_dtgv.Columns["itemInvID"].Visible = false;
            inventory_dtgv.Columns["name"].HeaderText = "Name";
            inventory_dtgv.Columns["description"].HeaderText = "Description";
            inventory_dtgv.Columns["itemMeasurement"].HeaderText = "Item Measurement";
            inventory_dtgv.Columns["Cost"].HeaderText = "Cost";
            inventory_dtgv.Columns["itemQuantity"].HeaderText = "Qty";
            inventory_dtgv.Columns["itemStatus"].HeaderText = "Status";
            inventory_dtgv.Columns["itemType"].HeaderText = "Type";
            inventory_dtgv.Columns["itemExpiry"].HeaderText = "Expiration Date";
            inventory_dtgv.Columns["itemStockedIn"].HeaderText = "Date";
            item_expires();
            restock();
        }

        public static int itemInvID;
        private void inventory_dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int selected_id = int.Parse(inventory_dtgv.Rows[e.RowIndex].Cells["itemInvID"].Value.ToString());
                itemInvID = selected_id;

                item_name.Text = inventory_dtgv.Rows[e.RowIndex].Cells["name"].Value.ToString();
                itemAmount.Text = inventory_dtgv.Rows[e.RowIndex].Cells["itemMeasurement"].Value.ToString();
                itemCost.Text = inventory_dtgv.Rows[e.RowIndex].Cells["cost"].Value.ToString();
                itemQuantity.Text = inventory_dtgv.Rows[e.RowIndex].Cells["itemQuantity"].Value.ToString();
                itemStatus.Text = inventory_dtgv.Rows[e.RowIndex].Cells["itemStatus"].Value.ToString();
                itemType.Text = inventory_dtgv.Rows[e.RowIndex].Cells["itemType"].Value.ToString();
                itemExpiry.Text = inventory_dtgv.Rows[e.RowIndex].Cells["itemExpiry"].Value.ToString();

                show_SOpanel.Visible = true;
                pictureBox5.Visible = true;
                loadTobeRemoved();

            }
        }

       
        public void loadTobeRemoved()
        {
            String inventoryquery = "SELECT name, description, unit, amount, itemQuantity FROM items, items_inventory WHERE items_inventory.itemInvID = " + itemInvID + " " +
                                    "AND items.itemsID = items_inventory.item_ID;";

            MySqlCommand comm = new MySqlCommand(inventoryquery, conn);
            comm.CommandText = inventoryquery;

            conn.Open();
            MySqlDataReader drdInv = comm.ExecuteReader();

            while (drdInv.Read())
            {
                
                txt_name.Text = (drdInv["name"].ToString());
                txt_description.Text = (drdInv["description"].ToString());
                txt_quantity.Text = (drdInv["itemQuantity"].ToString());                
                txt_amount.Text = (drdInv["amount"].ToString());
                txt_unit.Text = (drdInv["unit"].ToString());
                
            }
            conn.Close(); 
        }

        private void txt_quantity_ValueChanged(object sender, EventArgs e)
        {
            /*string quantity = txt_quantity.Value.ToString();

            int parseQuantity = int.Parse(quantity);
            
            if (txt_quantity.Text == quantity)
            {
                txt_quantity.ForeColor = System.Drawing.Color.Red;

            }
            else
            {
                txt_quantity.ForeColor = System.Drawing.Color.Black;
            }*/
        }

        private void btn_stockout_Click(object sender, EventArgs e)
        {
            if (cmb_remarks.Text == "")
            {
                MessageBox.Show("Please select a remark.");
            }
            else
            {
                if (cmb_remarks.Text == "Used for Products")
                {
                    String remove = "UPDATE items_inventory SET itemQuantity = itemQuantity - " + int.Parse(txt_quantity.Text) + " WHERE itemInvID = " + itemInvID + ";";
                    conn.Open();
                    MySqlCommand commremove = new MySqlCommand(remove, conn);
                    commremove.ExecuteNonQuery();
                    conn.Close();

                    String updateStatus = "UPDATE items_inventory SET itemStatus = 'Unavailable' WHERE itemQuantity = 0;";
                    conn.Open();
                    MySqlCommand commupdate = new MySqlCommand(updateStatus, conn);
                    commupdate.ExecuteNonQuery();
                    conn.Close();
                    
                    String addtoBatchIngredients = "INSERT INTO batch_ingredients (log_stockout, ingredientName, ingredientDescription, ingredientQuantity, ingredientAmount, ingredientUnit, batch_ingredient_date) " +
                                            "VALUES( (SELECT max(logid) FROM inventorylog),'" + txt_name.Text + "','" + txt_description.Text + "'," + txt_quantity.Text +  "," + txt_amount.Text + ",'" + txt_unit.Text + "', current_timestamp() );";
                    conn.Open();
                    MySqlCommand commAddBatch = new MySqlCommand(addtoBatchIngredients, conn);
                    commAddBatch.ExecuteNonQuery();
                    conn.Close();

                    String updateLogquery = "INSERT INTO inventorylog (staff_staffid,itemName,quantity,logdate,logType,remarks) " +
                                            "VALUES(" + SAD.Login.DisplayUserDetails.staff_id + ",'" + txt_name.Text + "','" + txt_quantity.Text + "', current_timestamp(), 'Stock out(Manual)', '" + cmb_remarks.Text + "' );";
                    conn.Open();
                    MySqlCommand comm_inventorylog = new MySqlCommand(updateLogquery, conn);
                    comm_inventorylog.ExecuteNonQuery();
                    conn.Close();

                }
                else
                {
                    String removequery = "UPDATE items_inventory SET itemQuantity = itemQuantity - " + int.Parse(txt_quantity.Text) + " WHERE itemInvID = " + itemInvID + ";";
                    conn.Open();
                    MySqlCommand comm_Remove = new MySqlCommand(removequery, conn);
                    comm_Remove.ExecuteNonQuery();
                    conn.Close();

                    String updateAvail = "UPDATE items_inventory SET itemStatus = 'Unavailable' WHERE itemQuantity = 0;";
                    conn.Open();
                    MySqlCommand comm_Avail = new MySqlCommand(updateAvail, conn);
                    comm_Avail.ExecuteNonQuery();
                    conn.Close();

                    String updateLogquery = "INSERT INTO inventorylog (staff_staffid,itemName,quantity,logdate,logType,remarks) " +
                                            "VALUES(" + SAD.Login.DisplayUserDetails.staff_id + ",'" + txt_name.Text + "'," + txt_quantity.Text + ", current_timestamp(), 'Stock out(Manual)', '" + cmb_remarks.Text + "' );";
                    conn.Open();
                    MySqlCommand comm_inventorylog = new MySqlCommand(updateLogquery, conn);
                    comm_inventorylog.ExecuteNonQuery();
                    conn.Close();
                }
                
                inventory_status();
                panel_stockout.Visible = false;
                panel_stockout.Enabled = false;

            }
        }

        private void show_SOpanel_Click(object sender, EventArgs e)
        {
            panel_stockout.Visible = true;
            panel_stockout.Enabled = true;
            panel_stockout.Size = new Size(349, 311);
            panel_stockout.Location = new Point(757, 337);
            
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

        private void TotalTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void TotalTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;

        }
    }
}
