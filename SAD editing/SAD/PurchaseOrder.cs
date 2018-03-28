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
    public partial class PurchaseOrder : Form
    {
        MySqlConnection conn;

        public Form prevForm { get; set; }

        private Timer tm = new Timer();

        void tm_Tick(object sender, EventArgs e)
        {
            timeText.Text = DateTime.Now.ToLongTimeString();
        }

        public PurchaseOrder()
        {
            InitializeComponent();
            conn = new MySqlConnection("SERVER=localhost; DATABASE=cafetiere; uid=root; pwd=root; Allow Zero Datetime=true");
        }

        DataTable ToBeStocked = new DataTable();
        private void PurchaseOrder_Load(object sender, EventArgs e)
        {
            tm.Tick += new EventHandler(tm_Tick);
            tm.Interval = 1000;
            tm.Enabled = true;

            timeText.Text = DateTime.Now.ToLongTimeString();

            purchasing_list();

            if (!ToBeStocked.Columns.Contains("purchaseID") || !ToBeStocked.Columns.Contains("polID") || 
                !ToBeStocked.Columns.Contains("Name") || !ToBeStocked.Columns.Contains("Description") || !ToBeStocked.Columns.Contains("Quantity") ||
                !ToBeStocked.Columns.Contains("Type") || !ToBeStocked.Columns.Contains("ExpiryDate") )
            {
                ToBeStocked.Columns.Add("purchaseID", typeof(int));
                ToBeStocked.Columns.Add("polID", typeof(int));
                ToBeStocked.Columns.Add("Name", typeof(string));
                ToBeStocked.Columns.Add("Description", typeof(string));
                ToBeStocked.Columns.Add("Quantity", typeof(int));
                ToBeStocked.Columns.Add("Type", typeof(string));
                ToBeStocked.Columns.Add("ExpiryDate", typeof(string));

                items_stockin.DataSource = ToBeStocked;
                items_stockin.Columns["purchaseID"].Visible = false;
                items_stockin.Columns["polID"].Visible = false;
            }
            
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Close();
        }

        private void add_purchase_Click(object sender, EventArgs e)
        {
            PurchaseOrder_create pocreate = new PurchaseOrder_create();
            pocreate.prevForm = this;
            pocreate.Show();
            this.Hide();
        }
        
        private void purchasing_list()
        {
            String POquery= "SELECT purchaseOrderID AS id,DATE_FORMAT(purchaseOrderDate, '%Y/%m/%d %H:%i %p') AS Date, organization AS Supplier, CONCAT(firstname, ' ',lastname) as Staff, purchaseOrderTotal as Total FROM person, purchaseorder, staff, supplier "
                            + "WHERE  person.personid = staff.person_personid AND "    +
                            " supplier.supplierID = purchaseorder.supplier_supplierID AND " +
                            " staff.staffid = purchaseorder.staff_staffid;";

            conn.Open();
            MySqlCommand comm = new MySqlCommand(POquery, conn);
            MySqlDataAdapter adp_purchase_order = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable dt_purchase_order = new DataTable();
            adp_purchase_order.Fill(dt_purchase_order);

            item_purchased.DataSource = dt_purchase_order;

            item_purchased.Columns["id"].Visible = false;
            item_purchased.Columns["date"].HeaderText = "Date";
            item_purchased.Columns["supplier"].HeaderText = "Supplier";
            item_purchased.Columns["staff"].HeaderText = "Staff";
            item_purchased.Columns["total"].HeaderText = "Total";
        }

        private void item_purchased_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex > -1)
            {
                int polineID;

                int selected_id = int.Parse(item_purchased.Rows[e.RowIndex].Cells["id"].Value.ToString());
                polineID = selected_id;

                String POLinequery = "SELECT POLineID AS polID, DATE_FORMAT(itemExipiryDate, '%Y/%m/%d %H:%i %p') AS ExipirationDate, POLineItemName as Name, POLineDescription as Description, POLinePrice as Price, POLineQuantity as Quantity, itemType as Type, POLineSubtotal as Subtotal " +
                                    "FROM purchaseorder_line, items WHERE purchaseOrder_purchaseOrderID = " + selected_id + " AND items.itemsID = purchaseorder_line.items_itemsID ;";

                conn.Open();
                MySqlCommand comm = new MySqlCommand(POLinequery, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                conn.Close();
                DataTable orderLine = new DataTable();
                adp.Fill(orderLine);

                item_poLine.DataSource = orderLine;

                item_poLine.Columns["polID"].Visible = false;
                item_poLine.Columns["ExipirationDate"].HeaderText = "Expiration Date";
                item_poLine.Columns["Name"].HeaderText = "Name";
                item_poLine.Columns["Description"].HeaderText = "Description";
                
                item_poLine.Columns["Quantity"].HeaderText = "Quantity";
                item_poLine.Columns["Type"].HeaderText = "Type";
                item_poLine.Columns["Price"].HeaderText = "Price";
                item_poLine.Columns["Subtotal"].HeaderText = "Subtotal";
            }
        }

        
        public static int polineID;
        private void item_poLine_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int selected_id = int.Parse(item_poLine.Rows[e.RowIndex].Cells["polID"].Value.ToString());
                polineID = selected_id;
                moveBtn.Visible= true;
                returnBtn.Visible = true;

            }
            else
            {
                moveBtn.Visible = false;
                returnBtn.Visible = false;
            }
        }

        private void moveBtn_Click(object sender, EventArgs e)
        {
            int id;
            int itemsID;
            string item_name;
            string item_description;
            int poID;
            int item_quantity;
            string item_expirydate;
            string item_type;
            Boolean stocked_in = false;

            String duplicatePOLinequery = "SELECT POLineID FROM purchaseorder_line "+ 
                                          "WHERE stocked_in = 'Yes' AND POLineID = " + polineID + ";";
            conn.Open();
            MySqlCommand comm2 = new MySqlCommand(duplicatePOLinequery, conn);
            MySqlDataAdapter adp2 = new MySqlDataAdapter(comm2);
            DataTable duplicate = new DataTable();
            adp2.Fill(duplicate);
            conn.Close();

            if (duplicate.Rows.Count < 1)
            {

                String POLinequery = "SELECT POLineID as id, items.name as Name, POLineDescription as Description, itemsID, purchaseOrder_purchaseOrderID, POLineQuantity as Quantity, itemType as Type, DATE_FORMAT(itemExipiryDate, '%Y/%m/%d') as Exipiration " +
                                     "FROM purchaseorder_line, items WHERE purchaseorder_line.items_itemsID = items.itemsID AND POLineID = " + polineID + "";
                MySqlCommand commPOLinequery = new MySqlCommand(POLinequery, conn);
                commPOLinequery.CommandText = POLinequery;

                conn.Open();
                MySqlDataReader dtgv_poline = commPOLinequery.ExecuteReader();
                while(dtgv_poline.Read())
                {
                    id = int.Parse(dtgv_poline["id"].ToString());
                    item_expirydate = dtgv_poline["Exipiration"].ToString();
                    itemsID = int.Parse(dtgv_poline["itemsID"].ToString());
                    item_name = dtgv_poline["Name"].ToString();
                    item_description = dtgv_poline["Description"].ToString();
                    item_type = dtgv_poline["Type"].ToString(); 
                    poID = int.Parse(dtgv_poline["purchaseOrder_purchaseOrderID"].ToString());
                    item_quantity = int.Parse(dtgv_poline["Quantity"].ToString());
                    
                    for(int i = 0; i < items_stockin.Rows.Count; i++)
                    {
                        if (id == int.Parse(items_stockin.Rows[i].Cells["polID"].Value.ToString()) && poID == int.Parse(items_stockin.Rows[i].Cells["purchaseID"].Value.ToString()) && item_quantity <= int.Parse(items_stockin.Rows[i].Cells["Quantity"].Value.ToString()))
                        {
                            stocked_in = true;
                        }
                    }
                    if (stocked_in == false)
                    {

                        ToBeStocked.Rows.Add(poID, id, item_name, item_description, item_quantity, item_type, item_expirydate);
                    }
                    else
                    {
                        MessageBox.Show("All the items already moved!");
                    }
                }
                conn.Close();
            }
            else
            {
                MessageBox.Show("Item already stocked in!");
            }
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            if (items_stockin.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Please place an item first!");
            }
            else
            {
                int row = items_stockin.CurrentCell.RowIndex;
                items_stockin.Rows.RemoveAt(row);
            }
        }

        private void stockin_btn_Click(object sender, EventArgs e)
        {
            int polid;
            int poid;
            string item_name;
            string item_description;
            int item_quantity;
            string item_expiry;
            string type;

            
            if (items_stockin.Rows.Count < 1)
            {
                MessageBox.Show("Nothing to stock in!");
            }
            else
            {
                for (int i = 0; i < items_stockin.Rows.Count; i++)
                {
                    poid = int.Parse(items_stockin.Rows[i].Cells["purchaseID"].Value.ToString());
                    polid = int.Parse(items_stockin.Rows[i].Cells["polID"].Value.ToString());
                    item_name = items_stockin.Rows[i].Cells["Name"].Value.ToString();
                    item_description = items_stockin.Rows[i].Cells["Description"].Value.ToString();
                    item_quantity = int.Parse(items_stockin.Rows[i].Cells["Quantity"].Value.ToString());
                    item_expiry = items_stockin.Rows[i].Cells["ExpiryDate"].Value.ToString();
                    type = items_stockin.Rows[i].Cells["Type"].Value.ToString();

                    string duplicateItemsquery = "SELECT itemExpiry from items_inventory  WHERE itemExpiry = '" + item_expiry + 
                                                 "' AND item_ID = (SELECT itemsID FROM items WHERE name = '" + item_name + "' AND description = '" + item_description + "');";
                    conn.Open();
                    MySqlCommand comm1 = new MySqlCommand(duplicateItemsquery, conn);
                    MySqlDataAdapter adp = new MySqlDataAdapter(comm1);
                    comm1.ExecuteNonQuery();
                    conn.Close();
                    DataTable duplicateItems = new DataTable();
                    adp.Fill(duplicateItems);

                    
                    if (duplicateItems.Rows.Count > 0)
                    {
                        string addItemQuantityquery = "UPDATE items_inventory SET itemStatus = 'Available', itemQuantity = itemQuantity + " + item_quantity + 
                                                      " WHERE item_ID = (SELECT itemsID FROM items WHERE name ='"+ item_name +"' AND description = '" + item_description + "') AND itemExpiry = '" + item_expiry + "';";

                        conn.Open();
                        MySqlCommand comm_itemquantity = new MySqlCommand(addItemQuantityquery, conn);
                        comm_itemquantity.ExecuteNonQuery();
                        conn.Close();
                    }
                    else
                    {
                        string addNewItemQuery = "INSERT INTO items_inventory (item_ID, itemQuantity, itemStatus, itemType, itemStockedIn, itemExpiry) " +
                                                       "VALUES((SELECT itemsID from items WHERE name = '"+ item_name +"' AND description = '" + item_description + "'), " + item_quantity + ", 'Available', '" + type + "', current_timestamp(), '" + item_expiry + "');";
                        conn.Open();
                        MySqlCommand comm_NewItem = new MySqlCommand(addNewItemQuery, conn);
                        comm_NewItem.ExecuteNonQuery();
                        conn.Close();
                    }
                    string updateItemStatus = "UPDATE purchaseorder_line SET stocked_in = 'Yes' WHERE purchaseOrder_purchaseOrderID = " + poid + 
                                              " AND POLineID = " + polid + ";";

                    conn.Open();
                    MySqlCommand comm_ItemStatus = new MySqlCommand(updateItemStatus, conn);
                    comm_ItemStatus.ExecuteNonQuery();
                    conn.Close();

                    string inventorylogQuery = "INSERT INTO inventorylog (staff_staffid,itemName,quantity,logdate,logType,remarks) " +
                                               "VALUES(" + SAD.Login.DisplayUserDetails.staff_id + ",'" + item_name + "'," + item_quantity + ", current_timestamp(), 'Stock in (Purchased)', 'Stocked in by "+ SAD.Login.DisplayUserDetails.name + "' );";
                    conn.Open();
                    MySqlCommand comm_inventorylog = new MySqlCommand(inventorylogQuery, conn);
                    comm_inventorylog.ExecuteNonQuery();

                    conn.Close();

                }
            }
            MessageBox.Show("Items successfully stocked in!");
            prevForm.ShowDialog();
            this.Close();
        }
        
    }
}
