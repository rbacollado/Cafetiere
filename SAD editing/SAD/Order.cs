using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using MySql.Data.MySqlClient;

namespace SAD
{
    public partial class Order : Form
    {
        MySqlConnection conn;

        public MainMenu prevForm { get; set; }


        public Order()
        {
            InitializeComponent();
            conn = new MySqlConnection("SERVER=localhost; DATABASE=cafetiere; uid=root; pwd=root;");


        }



        DataTable order = new DataTable();

        private void Order_Load(object sender, EventArgs e)
        {


            encoderLbl.Text = SAD.Login.DisplayUserDetails.name;
            encoderPos.Text = SAD.Login.DisplayUserDetails.usertype;





            DateTime now = DateTime.Today;
            date.Text = now.ToString("MM/dd/yy");



            discountTxt.BackColor = Color.Gray;
            discountTxt.Enabled = false;

            loadprodInv_data();




        }

       
        private void Back_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Close();
        }

        private void cb_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadSelectedCategory();
        }

        public void loadSelectedCategory()
        {
            if (cb_category.Text == "Show All")
            {
                String query = "SELECT productID, pname, pcategory, pprice FROM products;";
                conn.Open();
                MySqlCommand comm = new MySqlCommand(query, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                conn.Close();
                DataTable dt = new DataTable();
                adp.Fill(dt);

                product_data.DataSource = dt;
                product_data.Columns["productID"].Visible = false;
                product_data.Columns["pname"].HeaderText = "Name";
                product_data.Columns["pcategory"].HeaderText = "Category";
                product_data.Columns["pprice"].HeaderText = "Price";
            }
            else
            {
                String query = "SELECT productID, pname, pcategory, pprice FROM products WHERE pcategory = '" + cb_category.Text + "';";
                conn.Open();
                MySqlCommand comm = new MySqlCommand(query, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                conn.Close();
                DataTable dt = new DataTable();
                adp.Fill(dt);

                product_data.DataSource = dt;
                product_data.Columns["productID"].Visible = false;
                product_data.Columns["pname"].HeaderText = "Name";
                product_data.Columns["pcategory"].HeaderText = "Category";
                product_data.Columns["pprice"].HeaderText = "Price";
            }
            
        }

        public void loadprodInv_data()
        {
            String query = "SELECT productID, pname, pcategory, pprice FROM products;";
            conn.Open();
            MySqlCommand comm = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);

            product_data.DataSource = dt;
            product_data.Columns["productID"].Visible = false;
            product_data.Columns["pname"].HeaderText = "Name";
            product_data.Columns["pcategory"].HeaderText = "Category";
            product_data.Columns["pprice"].HeaderText = "Price";
    
            
            product_data.Columns["pprice"].DefaultCellStyle.Format = "c";
            product_data.Columns["pprice"].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("en-PH");


        }

        public static int selected_user_id;
        private void product_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                selected_user_id = int.Parse(product_data.Rows[e.RowIndex].Cells["productID"].Value.ToString());
                prodname.Text = product_data.Rows[e.RowIndex].Cells["pname"].Value.ToString();
                prod_category.Text = product_data.Rows[e.RowIndex].Cells["pcategory"].Value.ToString();
                prod_category.Text = product_data.Rows[e.RowIndex].Cells["pcategory"].Value.ToString();
                priceTxt.Text = product_data.Rows[e.RowIndex].Cells["pprice"].Value.ToString();


            }



        }

        string pname;
        string type;
        int current;
        int countrow;
        int countrow2;




        private void btn_add_Click(object sender, EventArgs e)
        {
            string ordertype = "";
            bool isChecked = dinein.Checked;
            bool found = false;
            
           
            if (prodname.Text == String.Empty || priceTxt.Text == String.Empty || quantityTxt.Enabled == false)
            {
                MessageBox.Show("Please choose an item", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (quantityTxt.Value == 0)
            {
                MessageBox.Show("Please specify the quantity", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dinein.Checked == false && takeout.Checked == false)
            {
                MessageBox.Show("Please specify the Order type", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Takeout or Dinein


                if (isChecked)
                {
                    ordertype = dinein.Text;
                }
                else
                {

                    ordertype = takeout.Text;

                    string price = priceTxt.Text;
                    string quantity = quantityTxt.Value.ToString();

                    int parseQuantity = int.Parse(quantity);
                    decimal parsePrice = decimal.Parse(price);

                    decimal subtotal_takeout = parsePrice + 10 * parseQuantity;
                    string string_subtotaltakeout = subtotal_takeout.ToString();

                    takeout_subtotal.Text = string_subtotaltakeout;

                }


                if (product_data.Rows.Count > 0)
                {
                    // add items to another datagrid 

                    foreach (DataGridViewRow row in ordered_products.Rows)
                    {
                        
                        pname = row.Cells["Name"].Value.ToString();
                        type = row.Cells["OrderType"].Value.ToString();

                        if ((prodname.Text == pname) && (type == ordertype) )
                        {
                            // update quantity if item is already in the datagrid
                            row.Cells["Quantity"].Value = (Convert.ToString(Convert.ToInt32(row.Cells["Quantity"].Value) + Convert.ToInt32(quantityTxt.Text)));
                            if (type == "Dine In")
                            {
                                row.Cells["Subtotal"].Value = (Convert.ToString(Convert.ToDecimal(row.Cells["Price"].Value) * Convert.ToInt32(row.Cells["Quantity"].Value)));
                            }
                            else
                            {
                                row.Cells["Subtotal"].Value = Convert.ToString(takeout_subtotal.Text);
                            }
                           
                            found = true;
                            
                        }

                    }
                    
                    if (!found)
                    {
                       
                        if (ordertype == "Take Out")
                        {
                            int row = 0;
                            ordered_products.Rows.Add();
                            row = ordered_products.Rows.Count - 1;


                            ordered_products["ProdID", row].Value = product_data.CurrentRow.Cells["productID"].Value.ToString();
                            ordered_products["Name", row].Value = prodname.Text;
                            ordered_products["Price", row].Value = priceTxt.Text;
                            ordered_products["Quantity", row].Value = quantityTxt.Text;
                            ordered_products["Subtotal", row].Value = takeout_subtotal.Text;
                            ordered_products["OrderType", row].Value = ordertype;
                          
                        }
                        else if (ordertype == "Dine In")
                        {
                            int row = 0;
                            ordered_products.Rows.Add();
                            row = ordered_products.Rows.Count - 1;


                            ordered_products["ProdID", row].Value = product_data.CurrentRow.Cells["productID"].Value.ToString();
                            ordered_products["Name", row].Value = prodname.Text;
                            ordered_products["Price", row].Value = priceTxt.Text;
                            ordered_products["Quantity", row].Value = quantityTxt.Text;
                            ordered_products["Subtotal", row].Value = subTotalTxt.Text;
                            ordered_products["OrderType", row].Value = ordertype;
                           
                        }
                            
                    }
                    
                }

                else
                {
                    if (ordertype == "Take Out")
                    {
                        int row = 0;
                        ordered_products.Rows.Add();
                        row = ordered_products.Rows.Count - 1;


                        ordered_products["ProdID", row].Value = Convert.ToInt32(product_data.CurrentRow.Cells["productID"].ToString());
                        ordered_products["Name", row].Value = prodname.Text;
                        ordered_products["Price", row].Value = priceTxt.Text;
                        ordered_products["Quantity", row].Value = quantityTxt.Text;
                        ordered_products["Subtotal", row].Value = takeout_subtotal.Text;
                        ordered_products["OrderType", row].Value = ordertype;
                      
                    }
                    else if (ordertype == "Dine In")
                    {
                        int row = 0;
                        ordered_products.Rows.Add();
                        row = ordered_products.Rows.Count - 1;


                        ordered_products["ProdID", row].Value = Convert.ToInt32(product_data.CurrentRow.Cells["productID"].ToString());
                        ordered_products["Name", row].Value = prodname.Text;
                        ordered_products["Price", row].Value = priceTxt.Text;
                        ordered_products["Quantity", row].Value = quantityTxt.Text;
                        ordered_products["Subtotal", row].Value = subTotalTxt.Text;
                        ordered_products["OrderType", row].Value = ordertype;
                   
                    }
                       
                    
                }

                //total
                foreach (DataGridViewRow row in ordered_products.Rows)
                {
                    decimal sum = 0;
                    countrow = ordered_products.Rows.Count;

                    for (int i = 0; i < countrow; i++)
                    {
                        sum += Convert.ToDecimal(ordered_products.Rows[i].Cells[4].Value);
                    }
                    TotalTB.Text = Convert.ToString(sum);
                }
                
            }
            
            
        }



        private void quantityTxt_ValueChanged(object sender, EventArgs e)
        {
            string price = priceTxt.Text;
            string quantity = quantityTxt.Value.ToString();

            int parseQuantity = int.Parse(quantity);
            decimal parsePrice = decimal.Parse(price);

            decimal subtotal = parsePrice * parseQuantity;
            string string_subtotal = subtotal.ToString();

            subTotalTxt.Text = string_subtotal;

            if (parseQuantity == quantityTxt.Maximum)
            {
                quantityTxt.ForeColor = System.Drawing.Color.Red;

            }
            else
            {
                quantityTxt.ForeColor = System.Drawing.Color.Black;
            }

        }

        private void btn_remove_Click(object sender, EventArgs e)
        {

            if (ordered_products.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Please order first!");
            }
            else
            {
                if (ordered_products.SelectedRows.Count <= 0)
                {
                    MessageBox.Show("Please order first!");
                }
                else
                {
                    int rows = ordered_products.CurrentCell.RowIndex;
                    ordered_products.Rows.RemoveAt(rows);

                    // Total
                    decimal total = 0;
                    for (int i = 0; i <= ordered_products.Rows.Count - 1; i++)
                    {
                        total += (decimal.Parse(ordered_products.Rows[i].Cells["Subtotal"].Value.ToString()));

                    }
                    TotalTB.Text = total.ToString();

                }

                /*int row = ordered_products.CurrentCell.RowIndex;
                ordered_products.Rows.RemoveAt(row);
                total();*/

            }

        }



        private void btn_clear_Click(object sender, EventArgs e)
        {
            prodname.Text = "";
            priceTxt.Text = "0";
            subTotalTxt.Text = "0";
            quantityTxt.Text = "0";
            quantityTxt.Enabled = false;
            dinein.Checked = false;
            takeout.Checked = false;
        }

        private void checkout_Click(object sender, EventArgs e)
        {
            if (ordered_products.SelectedRows.Count > 0)
            {
                DialogResult verify_payment;

                verify_payment = MessageBox.Show("Are you sure?", "Verification", MessageBoxButtons.YesNo);

                if (verify_payment == DialogResult.Yes)
                {
                    totalDue.Text = TotalTB.Text;
                    paymentpanel.Visible = true;
                    paymentpanel.Enabled = true;
                    paymentpanel.Size = new Size(390, 455);
                    paymentpanel.Location = new Point(0, 112);

                    prodname.Text = "";
                    priceTxt.Text = "";
                    subTotalTxt.Text = "0";
                    priceTxt.Text = "0";

                    dinein.Checked = false;
                    takeout.Checked = false;
                    
                }

            }
            else
            {
                MessageBox.Show("Please add desired products !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void amountPaid_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void amountPaid_TextChanged(object sender, EventArgs e)
        {

            if (!(string.IsNullOrEmpty(amountPaid.Text)))
            {
                decimal totaldue = decimal.Parse(amountPaid.Text) - decimal.Parse(totalDue.Text);

                changetxt.Text = totaldue.ToString();

                if (Convert.ToDecimal(changetxt.Text) < 0)
                {
                    changetxt.Clear();
                }
            }
            else
            {
                changetxt.Clear();
            }
        }

        private void discountTxt_TextChanged(object sender, EventArgs e)
        {
          
            if (discountTxt.Text == "")
            {
                totalDue.Text = TotalTB.Text;
            }
            else
            {
                decimal discount = decimal.Parse(totalDue.Text) * (decimal.Parse(discountTxt.Text) / (decimal)100);
                decimal totaldue = decimal.Parse(totalDue.Text) - discount;
                totaldue = Math.Round(totaldue, 2, MidpointRounding.AwayFromZero);
                totalDue.Text = totaldue.ToString();
            }

        }
        private void backbtnSales_Click(object sender, EventArgs e)
        {
            paymentpanel.Visible = false;
            paymentpanel.Enabled = false;

            dinein.Visible = true;
            takeout.Visible = true;



        }

        private void pay_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                if (discountTypelbl.Visible == false && cb_discountType.Visible == false && discountlbl.Visible == false && discountTxt.Visible == false)
                {
                    if (amountPaid.Text == "" || cmb_queue.Text == "")
                    {
                        MessageBox.Show("Please fill up the required information!");
                    }
                    else if (changetxt.Text == "")
                    {
                        MessageBox.Show("Insufficient Payment!");
                    }
                    else
                    {
                        string discountType;
                        string discount;

                        if (discountTypelbl.Visible == false && cb_discountType.Visible == false && discountlbl.Visible == false && discountTxt.Visible == false)
                        {
                            discountType = "No Discount";
                            discount = "0";
                        }
                        else
                        {
                            discountType = cb_discountType.Text;
                            discount = discountTxt.Text;
                        }


                        string query_order = "INSERT INTO `order`(staff_staffid, orderDate, orderTotal, orderPayment, orderDiscount, orderDiscountType, orderChange, waitingNumber)"
                                + " VALUES((SELECT staff.staffid FROM staff INNER JOIN person ON person.personid = staff.person_personid AND CONCAT(person.firstname, ' ' , person.lastname) LIKE '%" + SAD.Login.DisplayUserDetails.name + "%'), "
                                + "current_timestamp(),'" + decimal.Parse(totalDue.Text) + "','" + decimal.Parse(amountPaid.Text) + "','" + double.Parse(discount) + "','" + discountType + "','" + decimal.Parse(changetxt.Text) + "','" + cmb_queue.Text + "')";



                        conn.Open();
                        MySqlCommand comm = new MySqlCommand(query_order, conn);
                        comm.ExecuteNonQuery();
                        conn.Close();

                        for (int i = 0; i <= ordered_products.Rows.Count - 1; i++)
                        {
                            string orderedname = ordered_products.Rows[i].Cells["Name"].Value.ToString();

                            string prod_query = "SELECT productID from products WHERE pname = '" + orderedname + "'";
                            conn.Open();
                            MySqlCommand command = new MySqlCommand(prod_query, conn);
                            MySqlDataAdapter adp = new MySqlDataAdapter(command);
                            conn.Close();

                            DataTable prod_datas = new DataTable();
                            adp.Fill(prod_datas);
                            string prod_data = prod_datas.Rows[0][0].ToString();

                            string prodID = ordered_products.Rows[i].Cells["ProdID"].Value.ToString();
                            string pprice = ordered_products.Rows[i].Cells["Price"].Value.ToString();
                            string pquantity = ordered_products.Rows[i].Cells["Quantity"].Value.ToString();
                            string subtotal = ordered_products.Rows[i].Cells["Subtotal"].Value.ToString();
                            string ordertype = ordered_products.Rows[i].Cells["OrderType"].Value.ToString();

                            if (ordertype == "Take Out")
                            {
                                string updateItemQuantity = "UPDATE items_inventory SET itemQuantity = itemQuantity - 1 WHERE itemType = 'Non-Ingredient';";

                                conn.Open();
                                MySqlCommand comm_ItemQuantity = new MySqlCommand(updateItemQuantity, conn);
                                comm_ItemQuantity.ExecuteNonQuery();
                                conn.Close();
                            }

                            string batch_query = "INSERT INTO batch(batch_name, batch_produced, batch_date)" +
                                                     "VALUES('" + orderedname + "','" + int.Parse(pquantity) + "', current_timestamp());";
                            conn.Open();
                            MySqlCommand batch_comm = new MySqlCommand(batch_query, conn);
                            batch_comm.ExecuteNonQuery();
                            conn.Close();

                            string orderline_query = "INSERT INTO orderline(orderID, productID, batch_id, orderType, orderPrice, orderQuantity, orderSubtotal)" +
                                                     "VALUES( (SELECT max(orderID) from `order`),'" + int.Parse(prod_data) + "',(SELECT max(batch_id) FROM batch),'" + ordertype + "','" + double.Parse(pprice) +
                                                     "','" + int.Parse(pquantity) + "','" + decimal.Parse(subtotal) + "');";
                            conn.Open();
                            MySqlCommand orderline_comm = new MySqlCommand(orderline_query, conn);
                            orderline_comm.ExecuteNonQuery();
                            conn.Close();


                            prodname.Text = "";
                            priceTxt.Text = "";
                            MessageBox.Show("Order added!");
                            subTotalTxt.Text = "0";
                            priceTxt.Text = "0";
                            paymentpanel.Visible = false;
                            paymentpanel.Enabled = false;
                            discountCheck.Checked = false;
                            totalDue.Clear();
                            amountPaid.Clear();
                            changetxt.Clear();
                            discountTxt.Clear();
                            quantityTxt.Text = "0";
                            quantityTxt.Enabled = false;


                            dinein.Checked = false;
                            takeout.Checked = false;
                            this.Show();

                        }

                    }
                }
                else
                {
                    if (amountPaid.Text == "" || discountTxt.Text == "" || cb_discountType.Text == "" || cmb_queue.Text == "")
                    {
                        MessageBox.Show("Please fill up the required information!");
                    }
                    else if (changetxt.Text == "")
                    {
                        MessageBox.Show("Insufficient Payment!");
                    }
                    else
                    {


                        string discountType;
                        string discount;

                        if (discountTypelbl.Visible == false && cb_discountType.Visible == false && discountlbl.Visible == false && discountTxt.Visible == false)
                        {
                            discountType = "No Discount";
                            discount = "0";
                        }
                        else
                        {
                            discountType = cb_discountType.Text;
                            discount = discountTxt.Text;
                        }


                        string query_order = "INSERT INTO `order`(staff_staffid, orderDate, orderTotal, orderPayment, orderDiscount, orderDiscountType, orderChange, waitingNumber)"
                                + " VALUES((SELECT staff.staffid FROM staff INNER JOIN person ON person.personid = staff.person_personid AND CONCAT(person.firstname, ' ' , person.lastname) LIKE '%" + SAD.Login.DisplayUserDetails.name + "%'), "
                                + "current_timestamp(),'" + decimal.Parse(totalDue.Text) + "','" + decimal.Parse(amountPaid.Text) + "','" + double.Parse(discount) + "','" + discountType + "','" + decimal.Parse(changetxt.Text) + "','" + cmb_queue.Text + "')";


                        conn.Open();
                        MySqlCommand comm = new MySqlCommand(query_order, conn);
                        comm.ExecuteNonQuery();
                        conn.Close();

                        for (int i = 0; i <= ordered_products.Rows.Count - 1; i++)
                        {
                            string orderedname = ordered_products.Rows[i].Cells["Name"].Value.ToString();

                            string prod_query = "SELECT productID from products WHERE pname = '" + orderedname + "'";
                            conn.Open();
                            MySqlCommand command = new MySqlCommand(prod_query, conn);
                            MySqlDataAdapter adp = new MySqlDataAdapter(command);
                            conn.Close();
                            DataTable prod_datas = new DataTable();
                            adp.Fill(prod_datas);
                            string prod_data = prod_datas.Rows[0][0].ToString();

                            string prodID = ordered_products.Rows[i].Cells["ProdID"].Value.ToString();
                            string pprice = ordered_products.Rows[i].Cells["Price"].Value.ToString();
                            string pquantity = ordered_products.Rows[i].Cells["Quantity"].Value.ToString();
                            string subtotal = ordered_products.Rows[i].Cells["Subtotal"].Value.ToString();
                            string ordertype = ordered_products.Rows[i].Cells["OrderType"].Value.ToString();

                            string batch_query = "INSERT INTO batch(batch_name, batch_produced, batch_date)" +
                                                     "VALUES('" + orderedname + "','" + int.Parse(pquantity) + "', current_timestamp());";
                            conn.Open();
                            MySqlCommand batch_comm = new MySqlCommand(batch_query, conn);
                            batch_comm.ExecuteNonQuery();
                            conn.Close();

                            string orderline_query = "INSERT INTO orderline(orderID, productID, batch_id, orderType, orderPrice, orderQuantity, orderSubtotal)" +
                                                      "VALUES( (SELECT max(orderID) from `order`),'" + int.Parse(prod_data) + "',(SELECT max(batch_id) FROM batch),'" + ordertype + "','" + double.Parse(pprice) +
                                                      "','" + int.Parse(pquantity) + "','" + decimal.Parse(subtotal) + "');";
                            conn.Open();
                            MySqlCommand orderline_comm = new MySqlCommand(orderline_query, conn);
                            orderline_comm.ExecuteNonQuery();
                            conn.Close();




                            prodname.Text = "";
                            priceTxt.Text = "";
                            MessageBox.Show("Order added!");

                            subTotalTxt.Text = "0";
                            priceTxt.Text = "0";
                            paymentpanel.Visible = false;
                            paymentpanel.Enabled = false;
                            discountCheck.Checked = false;
                            totalDue.Clear();
                            amountPaid.Clear();
                            changetxt.Clear();
                            discountTxt.Clear();
                            quantityTxt.Text = "0";
                            quantityTxt.Enabled = false;

                            dinein.Checked = false;
                            takeout.Checked = false;
                            this.Show();
                        }
                    }
                }
            }
            
        }
        
        private void cb_discountType_SelectedIndexChanged(object sender, EventArgs e)
        {


            discountTxt.BackColor = Color.White;
            discountTxt.Enabled = true;
        }

        private void discountTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void discountCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (discountCheck.Checked)
            {
                discountlbl.Visible = true;
                discountTypelbl.Visible = true;
                discountTxt.Visible = true;
                cb_discountType.Visible = true;
                discountTypelbl.Location = new Point(14, 242);
                cb_discountType.Location = new Point(180, 235);
                discountlbl.Location = new Point(14, 287);
                discountTxt.Location = new Point(180, 283);

                amountPaidlbl.Location = new Point(14, 160);
                amountPaid.Location = new Point(180, 156);
                changelbl.Location = new Point(14, 197);
                changetxt.Location = new Point(180, 193);

            }
            else
            {
                discountlbl.Visible = false;
                discountTypelbl.Visible = false;
                discountTxt.Visible = false;
                cb_discountType.Visible = false;
                amountPaidlbl.Location = new Point(14, 160);
                amountPaid.Location = new Point(180, 156);
                changelbl.Location = new Point(14, 197);
                changetxt.Location = new Point(180, 193);
            }


        }

        private void takeout_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
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
