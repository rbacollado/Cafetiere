﻿using System;
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
    public partial class PurchaseOrder_create : Form
    {
        MySqlConnection conn;

        public Form prevForm { get; set; }

        public PurchaseOrder_create()
        {
            InitializeComponent();
            conn = new MySqlConnection("SERVER=localhost; DATABASE=cafetiere; uid=root; pwd=root;");
        }

        DataTable POrder = new DataTable();
        private void PurchaseOrder_create_Load(object sender, EventArgs e)
        {
            encoderLbl.Text = SAD.Login.DisplayUserDetails.name;
            encoderPos.Text = SAD.Login.DisplayUserDetails.usertype;

            POrder.Columns.Add("id", typeof(string));
            POrder.Columns.Add("Name", typeof(string));
            POrder.Columns.Add("Price", typeof(string));
            POrder.Columns.Add("Quantity", typeof(int));
            POrder.Columns.Add("ExpiryDate", typeof(string));
            POrder.Columns.Add("Subtotal", typeof(string));

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
       
        public void load_suppliers()
        {
            String query = "SELECT firstname, lastname, organization FROM person " +
                           "INNER JOIN supplier ON person.personid =  supplier.person_personid WHERE supplierID = "+ selected_supplierid + "";

            MySqlCommand comm = new MySqlCommand(query, conn);
            comm.CommandText = query;

            conn.Open();
            MySqlDataReader dataread = comm.ExecuteReader();

            while (dataread.Read())
            {
                supplier_txt.Text = (dataread["organization"].ToString());
            }
            conn.Close();
        }

        private void supplier_txt_MouseClick(object sender, MouseEventArgs e)
        {
            
            String query = "SELECT supplierID, firstname, lastname, organization FROM person " +
                           "INNER JOIN supplier ON person.personid = supplier.person_personid" ;
            conn.Open();
            MySqlCommand comm = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);

            supplier_data.DataSource = dt;
            supplier_data.Columns["supplierID"].Visible = false;
            supplier_data.Columns["firstname"].HeaderText = "First Name";
            supplier_data.Columns["lastname"].HeaderText = "Last Name";
            supplier_data.Columns["organization"].HeaderText = "Organization";

            if (supplier_data.Rows.Count < 1)
            {
                MessageBox.Show("No Supplier Available!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Supplier_Add add = new Supplier_Add();
                add.Show();
                add.prevForm = this;
                this.Hide();
            }
            else
            {
                supplierpanel.Visible = true;
                supplierpanel.Enabled = true;
                iQuantity_txt.Visible = false;
               

                supplierpanel.Size = new Size(389, 435);
                supplierpanel.Location = new Point(0, 124);
            }

        }

        public static int selected_supplierid;
        private void supplier_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                selected_supplierid = int.Parse(supplier_data.Rows[e.RowIndex].Cells["supplierID"].Value.ToString());

                supplierpanel.Visible = false;
                supplierpanel.Enabled = false;
                iQuantity_txt.Visible = true;
 
                load_suppliers();
               
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Boolean duplicate_item = false;
            int iditem = 0;

            // Check if items in the items_ordered datagrid
            for (int i = 0; i < items_ordered.Rows.Count; i++)
            {
                if ( (iName_txt.Text == items_ordered.Rows[i].Cells["Name"].Value.ToString()) &&  (iExpiry_txt.Text == items_ordered.Rows[i].Cells["ExpiryDate"].Value.ToString() || "0000-00-00" == items_ordered.Rows[i].Cells["ExpiryDate"].Value.ToString())  )
                {
                    duplicate_item = true;
                    iditem = i;
                }
            }

            if (supplier_txt.Text == "" || iName_txt.Text == "" || iPrice_txt.Text == "" || iQuantity_txt.Text == "" )
            {
                MessageBox.Show("Please complete purchase order details!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (duplicate_item == true)
            {
                string iQuantity = items_ordered.Rows[iditem].Cells["Quantity"].Value.ToString();
                string iPrice = items_ordered.Rows[iditem].Cells["Price"].Value.ToString();
                items_ordered.Rows[iditem].Cells["Quantity"].Value = int.Parse(iQuantity_txt.Text) + int.Parse(iQuantity);

                decimal number = decimal.Parse(iPrice) * int.Parse(items_ordered.Rows[iditem].Cells["Quantity"].Value.ToString());
                items_ordered.Rows[iditem].Cells["Subtotal"].Value = number.ToString();
                total();
                
            }
            else
            {
                string expiry;
                
                if (iExpiry_txt.Visible == true && label9.Visible == true)
                {
                    expiry = iExpiry_txt.Text;
                }
                else
                {
                    expiry = "0000-00-00";
                    
                }

                POrder.Rows.Add(selected_supplierid, iName_txt.Text, iPrice_txt.Text, iQuantity_txt.Text, expiry, subtotal_txt.Text);
                items_ordered.DataSource = POrder;
                items_ordered.Columns["id"].Visible = false;
                total();

            }

        }
        public void total()
        {
            // Total
            decimal total = 0;
            for (int i = 0; i <= items_ordered.Rows.Count - 1; i++)
            {
                total += (decimal.Parse(items_ordered.Rows[i].Cells["Subtotal"].Value.ToString()));

            }
            TotalTB.Text = total.ToString();
            
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
       
        public void clear_shit()
        {
            supplier_txt.Text = "";
            iName_txt.Text = "";
            iPrice_txt.Text = "0";
            subtotal_txt.Text = "0";
            iQuantity_txt.Text = "1";
            iQuantity_txt.Enabled = false;
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear_shit();
        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            if (items_ordered.SelectedRows.Count  > 0 )
            {
                string suppquery = "SELECT supplierID FROM supplier WHERE organization = '" + supplier_txt.Text +"'";
                conn.Open();

                MySqlCommand comm1 = new MySqlCommand(suppquery, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm1);
                DataTable supplierdata = new DataTable();
                adp.Fill(supplierdata);

                string supplierid = supplierdata.Rows[0][0].ToString();

                conn.Close();


                string orderquery = "INSERT INTO purchaseorder (supplier_supplierID, staff_staffid, purchaseOrderDate, purchaseOrderTotal, deliverystatus) "
                        + "VALUES('"+ int.Parse(supplierid) + "','"+ SAD.Login.DisplayUserDetails.staff_id +"', current_timestamp(), '" + decimal.Parse(TotalTB.Text) + "', 'Not yet delivered')";
                conn.Open();
                MySqlCommand comm = new MySqlCommand(orderquery, conn);
                comm.ExecuteNonQuery();
                conn.Close();


                for (int i = 0; i <= items_ordered.Rows.Count - 1; i++)
                {
                    
                    string itemid = items_ordered.Rows[i].Cells["id"].Value.ToString();
                    string itemName = items_ordered.Rows[i].Cells["Name"].Value.ToString();
                    string itemPrice = items_ordered.Rows[i].Cells["Price"].Value.ToString();
                    string itemQuantity = items_ordered.Rows[i].Cells["Quantity"].Value.ToString();
                    string itemExipiry = items_ordered.Rows[i].Cells["ExpiryDate"].Value.ToString();
                    string subtotal = items_ordered.Rows[i].Cells["Subtotal"].Value.ToString();
                    

                    string orderline_query = "INSERT INTO purchaseorder_line(purchaseOrder_purchaseOrderID, item_itemID, POLineItemName, POLinePrice, POLineQuantity, itemExipiryDate, POLineSubtotal, stocked_in)" +
                                             "VALUES((SELECT max(purchaseOrderID) from purchaseorder), '" + int.Parse(itemid) + "' ,'" + itemName + "', '" + double.Parse(itemPrice) + "','" + int.Parse(itemQuantity) +
                                             "','" + itemExipiry + "','" + decimal.Parse(subtotal) + "', 'No');";
                    conn.Open();
                    MySqlCommand orderline_comm = new MySqlCommand(orderline_query, conn);
                    orderline_comm.ExecuteNonQuery();
                    conn.Close();
                }
                MessageBox.Show("Item Order added!");
                clear_shit();
                prevForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please add data to the table before saving.");
            }
           
        }

        private void iName_txt_MouseClick(object sender, MouseEventArgs e)
        {
            String queryitems = "SELECT itemsID, name, price, unit, amount, expirable FROM items, supplier, supplier_has_items " +
                             "WHERE itemsID = items_itemsID AND supplier_supplierid = supplierid AND supplierid = " + selected_supplierid + ";";

            conn.Open();
            MySqlCommand commitems = new MySqlCommand(queryitems, conn);
            MySqlDataAdapter adpitems = new MySqlDataAdapter(commitems);
            conn.Close();
            DataTable dtitems = new DataTable();
            adpitems.Fill(dtitems);

            dtgv_items.DataSource = dtitems;
            dtgv_items.Columns["itemsID"].Visible = false;
            dtgv_items.Columns["name"].HeaderText = "Name";
            dtgv_items.Columns["price"].HeaderText = "Price";
            dtgv_items.Columns["unit"].HeaderText = "Unit";
            dtgv_items.Columns["amount"].HeaderText = "Amount";
            dtgv_items.Columns["expirable"].HeaderText = "Expirable";


            if (supplier_txt.Text == "")
            {
                MessageBox.Show("Choose a supplier first!");
            }
            else if (dtgv_items.Rows.Count > 0)
            {
                
                item_panel.Visible = true;
                item_panel.Enabled = true;
                item_panel.Size = new Size(383, 432);
                item_panel.Location = new Point(3, 124);
            }
            else
            {
                MessageBox.Show("No items Found");
                Item_Add add = new Item_Add();
                add.Show();
                add.prevForm = this;
                this.Hide();
            }
            
        }
        
        public int idselected;
        private void dtgv_items_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                idselected = int.Parse(dtgv_items.Rows[e.RowIndex].Cells["itemsID"].Value.ToString());

                item_panel.Visible = false;
                item_panel.Enabled = false;
                item_details();
            }
        }

        public void item_details()
        {
            String loaditemdetails = "SELECT itemsID,name,price,unit,amount,expirable FROM items where itemsID = " + idselected + " ";

            MySqlCommand commitemdetails = new MySqlCommand(loaditemdetails, conn);
            commitemdetails.CommandText = loaditemdetails;

            conn.Open();
            MySqlDataReader drditemdetails = commitemdetails.ExecuteReader();

            while (drditemdetails.Read())
            {
                iName_txt.Text = (drditemdetails["name"].ToString());
                iPrice_txt.Text = (drditemdetails["price"].ToString());
                subtotal_txt.Text = iPrice_txt.Text;
                iQuantity_txt.Value = 1;

                string exp_stat = (drditemdetails["expirable"].ToString());
                if (exp_stat == "ye")
                {
                    iExpiry_txt.Visible = true;
                    label9.Visible = true;

                }

                else
                {
                    iExpiry_txt.Visible = false;
                    label9.Visible = false;

                }
                //Validation = true;

                iQuantity_txt.Enabled = true;
            }
            conn.Close();
        }

        private void btn_additem_Click(object sender, EventArgs e)
        {
            Item_Add add = new Item_Add();
            add.Show();
            add.prevForm = this;
            this.Hide();
        }

        private void supplier_btn_Click(object sender, EventArgs e)
        {
            Supplier_Add add = new Supplier_Add();
            add.Show();
            add.prevForm = this;
            this.Hide();
        }
    }
}
