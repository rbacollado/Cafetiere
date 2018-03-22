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
    public partial class Inventory_Stockin : Form
    {
        MySqlConnection conn;

        public Form prevForm { get; set; }

        public Inventory_Stockin()
        {
            InitializeComponent();
            conn = new MySqlConnection("SERVER=localhost; DATABASE=cafetiere; uid=root; pwd=root; Allow Zero Datetime=true");

            OrderWM.Columns.Add("Name", typeof(string));
            OrderWM.Columns.Add("Description", typeof(string));
            OrderWM.Columns.Add("Price", typeof(string));
            OrderWM.Columns.Add("Quantity", typeof(int));
            OrderWM.Columns.Add("Type", typeof(string));
            OrderWM.Columns.Add("ExpiryDate", typeof(string));
            OrderWM.Columns.Add("Subtotal", typeof(string));

            itemload();
        }

        DataTable OrderWM = new DataTable();

        private void Inventory_Stockin_Load(object sender, EventArgs e)
        {
            encoderLbl.Text = SAD.Login.DisplayUserDetails.name;
            encoderPos.Text = SAD.Login.DisplayUserDetails.usertype;
            
            DateTime now = DateTime.Today;
            date.Text = now.ToString("MM/dd/yy");

            iExpiry_txt.Format = DateTimePickerFormat.Custom;
            iExpiry_txt.CustomFormat = "yyyy-MM-dd";

           

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Close();
        }

        public void total()
        {
            // Total
            decimal total = 0;
            for (int i = 0; i <= items_purchased.Rows.Count - 1; i++)
            {
                total += (decimal.Parse(items_purchased.Rows[i].Cells["Subtotal"].Value.ToString()));

            }
            TotalTB.Text = total.ToString();

        }

        private void iName_txt_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (item_data.Rows.Count < 1)
            {
                MessageBox.Show("No items Found");
                Item_Add add = new Item_Add();
                add.Show();
                add.prevForm = this;
                this.Hide();  
            }
            else
            {
                btn_remove.Visible = false;

                label12.Visible = false;
                cmb_type.Visible = false;

                item_panel.Visible = true;
                item_panel.Enabled = true;
                label5.Visible = false;
                iDesc_txt.Visible = false;
                item_panel.Size = new Size(523, 423);
                item_panel.Location = new Point(3, 124);

                item_data.Columns["name"].Width = 110;
                item_data.Columns["description"].Width = 80;
                item_data.Columns["price"].Width = 50;
                item_data.Columns["ItemMeasurement"].Width = 80;
               
            
            }
        }

       public void itemload()
        {
            String queryitems = "SELECT itemsID, name, description, price, CONCAT(amount, ' ',unit) as ItemMeasurement FROM items; ";

            conn.Open();
            MySqlCommand commitems = new MySqlCommand(queryitems, conn);
            MySqlDataAdapter adpitems = new MySqlDataAdapter(commitems);
            conn.Close();
            DataTable dtitems = new DataTable();
            adpitems.Fill(dtitems);

            item_data.DataSource = dtitems;
            item_data.Columns["itemsID"].Visible = false;
            item_data.Columns["name"].HeaderText = "Name";
            item_data.Columns["description"].HeaderText = "Description";
            item_data.Columns["price"].HeaderText = "Price";
            item_data.Columns["ItemMeasurement"].HeaderText = "Measurement";
          
        }
        public int item_idselected;
        private void item_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                item_idselected = int.Parse(item_data.Rows[e.RowIndex].Cells["itemsID"].Value.ToString());

                item_panel.Visible = false;
                item_panel.Enabled = false;
                label5.Visible = true;
                iDesc_txt.Visible = true;
                btn_remove.Visible = true;
                item_details();
            }
        }

        public void item_details()
        {
            String loaditemdetails = "SELECT itemsID,name,description,price, CONCAT(amount, ' ',unit) as ItemMeasurement,expirable FROM items where itemsID = " + item_idselected + ";";

            MySqlCommand commitemdetails = new MySqlCommand(loaditemdetails, conn);
            commitemdetails.CommandText = loaditemdetails;

            conn.Open();
            MySqlDataReader drditemdetails = commitemdetails.ExecuteReader();

            while (drditemdetails.Read())
            {
                iName_txt.Text = (drditemdetails["name"].ToString());
                iDesc_txt.Text = (drditemdetails["description"].ToString());
                iPrice_txt.Text = (drditemdetails["price"].ToString());
                subtotal_txt.Text = iPrice_txt.Text;
                iQuantity_txt.Value = 1;

                string exp_stat = (drditemdetails["expirable"].ToString());
                if (exp_stat == "ye")
                {
                    iExpiry_txt.Visible = true;
                    label9.Visible = true;
                    label12.Visible = true;
                    cmb_type.Visible = true;
                }

                else
                {
                    iExpiry_txt.Visible = false;
                    label9.Visible = false;
                    label12.Visible = false;
                    cmb_type.Visible = false;
                }

                iQuantity_txt.Enabled = true;
            }
            conn.Close();
        }
        
        private void btn_add_Click(object sender, EventArgs e)
        {
            Boolean duplicate_item = false;
            int iditem = 0;
            
            string expiry;
            string type;
            
            // Check if items in the items_ordered datagrid
            for (int i = 0; i < items_purchased.Rows.Count; i++)
            {
                if ((iName_txt.Text == items_purchased.Rows[i].Cells["Name"].Value.ToString()) && (iDesc_txt.Text == items_purchased.Rows[i].Cells["Description"].Value.ToString()) && (iExpiry_txt.Text == items_purchased.Rows[i].Cells["ExpiryDate"].Value.ToString() || "0000-00-00" == items_purchased.Rows[i].Cells["ExpiryDate"].Value.ToString()) )
                {
                    duplicate_item = true;
                    iditem = i;
                }
            }

            if (iExpiry_txt.Visible == true && label9.Visible == true  && label12.Visible == true && cmb_type.Visible == true)
            {
                if (iName_txt.Text == "" || iPrice_txt.Text == "" || iQuantity_txt.Text == "" || cmb_type.Text == "")
                {
                    MessageBox.Show("Please complete order details!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (duplicate_item == true)
                {
                    string iQuantity = items_purchased.Rows[iditem].Cells["Quantity"].Value.ToString();
                    string iPrice = items_purchased.Rows[iditem].Cells["Price"].Value.ToString();
                    items_purchased.Rows[iditem].Cells["Quantity"].Value = int.Parse(iQuantity_txt.Text) + int.Parse(iQuantity);

                    decimal number = decimal.Parse(iPrice) * int.Parse(items_purchased.Rows[iditem].Cells["Quantity"].Value.ToString());
                    items_purchased.Rows[iditem].Cells["Subtotal"].Value = number.ToString();
                    total();

                }
                else
                {
                    expiry = iExpiry_txt.Text;
                    type = cmb_type.Text;

                    OrderWM.Rows.Add(iName_txt.Text,iDesc_txt.Text,iPrice_txt.Text, iQuantity_txt.Text, type, expiry, subtotal_txt.Text);
                    items_purchased.DataSource = OrderWM;

                    total();
                }
            }
            else
            {
                if (iName_txt.Text == "" || iPrice_txt.Text == "" || iQuantity_txt.Text == "")
                {
                    MessageBox.Show("Please complete order details!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (duplicate_item == true)
                {
                    string iQuantity = items_purchased.Rows[iditem].Cells["Quantity"].Value.ToString();
                    string iPrice = items_purchased.Rows[iditem].Cells["Price"].Value.ToString();
                    items_purchased.Rows[iditem].Cells["Quantity"].Value = int.Parse(iQuantity_txt.Text) + int.Parse(iQuantity);

                    decimal number = decimal.Parse(iPrice) * int.Parse(items_purchased.Rows[iditem].Cells["Quantity"].Value.ToString());
                    items_purchased.Rows[iditem].Cells["Subtotal"].Value = number.ToString();
                    total();

                }
                else
                {
                    expiry = "0000-00-00";
                    type = "Non-Ingredient";

                    OrderWM.Rows.Add(iName_txt.Text, iDesc_txt.Text, iPrice_txt.Text, iQuantity_txt.Text, type, expiry, subtotal_txt.Text);
                    items_purchased.DataSource = OrderWM;

                    total();
                }
            }
            
        }

        private void iPrice_txt_TextChanged(object sender, EventArgs e)
        {
            if (iPrice_txt.Text == "")
            {
                iQuantity_txt.Enabled = false;
            }
            else
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(iPrice_txt.Text, "[^0-9.]"))
                {
                    MessageBox.Show("Please enter only numbers.");
                    iPrice_txt.Text = iPrice_txt.Text.Remove(iPrice_txt.Text.Length - 1);
                }
                else
                {
                    iQuantity_txt.Enabled = true;

                    string iprice = iPrice_txt.Text;
                    string iquantity = iQuantity_txt.Value.ToString();
                    int parseQuantity = int.Parse(iquantity);

                    decimal parsePrice = decimal.Parse(iprice);
                    decimal subtotal = parsePrice * parseQuantity;
                    string string_subtotal = subtotal.ToString();

                    subtotal_txt.Text = string_subtotal;
                }
            }
        }

        private void btn_item_Click(object sender, EventArgs e)
        {
            Item_Add add = new Item_Add();
            add.Show();
            add.prevForm = this;
            this.Hide();
        }

        public void clear_shit()
        {
            iName_txt.Text = "";
            iDesc_txt.Text = "";
            iPrice_txt.Text = "0";
            subtotal_txt.Text = "0";
            iQuantity_txt.Text = "1";
            iQuantity_txt.Enabled = false;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear_shit();
        }
        
        private void stockin_btn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you Sure?", "", MessageBoxButtons.YesNo);
            string item_name;
            string item_description;
            int item_quantity;
            string item_expiry;
            string item_type;
            
            if (items_purchased.Rows.Count < 1)
            {
                MessageBox.Show("Nothing to stock in!");
            }
            else
            {
                if (dialogResult == DialogResult.Yes)
                {
                    for (int i = 0; i <= items_purchased.Rows.Count - 1; i++)
                    {
                        item_name = items_purchased.Rows[i].Cells["Name"].Value.ToString();
                        item_description = items_purchased.Rows[i].Cells["Description"].Value.ToString();
                        item_quantity = Int32.Parse(items_purchased.Rows[i].Cells["Quantity"].Value.ToString());
                        item_expiry = items_purchased.Rows[i].Cells["ExpiryDate"].Value.ToString();
                        item_type = items_purchased.Rows[i].Cells["Type"].Value.ToString();

                        string duplicateItemsquery = "SELECT itemExpiry from items_inventory WHERE itemExpiry = '" + item_expiry +
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
                                                          " WHERE item_ID = (SELECT itemsID FROM items WHERE name ='" + item_name + "' AND description = '" + item_description + "') AND itemExpiry = '" + item_expiry + "';";

                            conn.Open();
                            MySqlCommand comm_itemquantity = new MySqlCommand(addItemQuantityquery, conn);
                            comm_itemquantity.ExecuteNonQuery();
                            conn.Close();
                        }
                        else
                        {
                            string addNewItemQuery = "INSERT INTO items_inventory (item_ID, itemQuantity, itemStatus, itemType, itemStockedIn, itemExpiry) " +
                                                       "VALUES((SELECT itemsID from items WHERE name = '" + item_name + "' AND description = '" + item_description + "'), " + item_quantity + ", 'Available', '" + item_type + "', current_timestamp(), '" + item_expiry + "');";
                            conn.Open();
                            MySqlCommand comm_NewItem = new MySqlCommand(addNewItemQuery, conn);
                            comm_NewItem.ExecuteNonQuery();
                            conn.Close();
                        }

                        string inventorylogQuery = "INSERT INTO inventorylog (staff_staffid,itemName,quantity,logdate,logType,remarks) " +
                                                   "VALUES(" + SAD.Login.DisplayUserDetails.staff_id + ",'" + item_name + "'," + item_quantity + ", current_timestamp(), 'Stock in (Wet Market)', 'Stocked in by " + SAD.Login.DisplayUserDetails.name + "');";
                        conn.Open();
                        MySqlCommand comm_inventorylog = new MySqlCommand(inventorylogQuery, conn);
                        comm_inventorylog.ExecuteNonQuery();
                        conn.Close();

                    }
                    MessageBox.Show("Items successfully stocked in!");
                    prevForm.ShowDialog();
                    this.Close();
                }
                

            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (items_purchased.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Please order first!");
            }
            else
            {
                int row = items_purchased.CurrentCell.RowIndex;
                items_purchased.Rows.RemoveAt(row);
                total();
            }
        }

        private void iQuantity_txt_ValueChanged(object sender, EventArgs e)
        {
            string iprice = iPrice_txt.Text;
            string iquantity = iQuantity_txt.Value.ToString();
            int parseQuantity = int.Parse(iquantity);

            decimal parsePrice = decimal.Parse(iprice);
            decimal subtotal = parsePrice * parseQuantity;
            string string_subtotal = subtotal.ToString();

            subtotal_txt.Text = string_subtotal;
        }

        private void iDesc_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void iPrice_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
