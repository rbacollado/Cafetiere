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
         

            order.Columns.Add("id", typeof(string));
            order.Columns.Add("Name", typeof(string));
            order.Columns.Add("Price", typeof(string));
            order.Columns.Add("Quantity", typeof(int));
            order.Columns.Add("Subtotal", typeof(string));
            order.Columns.Add("OrderType", typeof(string));

            DateTime now = DateTime.Today;
            date.Text = now.ToString("MM/dd/yy");

            discountTxt.BackColor = Color.Gray;
            discountTxt.Enabled = false;

            loadprod_data();
<<<<<<< HEAD
=======

>>>>>>> 520095aa666c1d60bdbfe2a40c33b0879c08b890

        }

        
        private void Back_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Close();
        }

        public void loadprod_data()
        {
            String query = "SELECT productInvID, pname, pcategory, pprice FROM product_inventory, products " +
                           "WHERE product_inventory.product_id = products.productID AND product_status = 'Available';";
            conn.Open();
            MySqlCommand comm = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);

            product_data.DataSource = dt;
            product_data.Columns["productInvID"].Visible = false;
            product_data.Columns["pname"].HeaderText = "Name";
            product_data.Columns["pcategory"].HeaderText = "Category";
            product_data.Columns["pprice"].HeaderText = "Price";
            
        }
       
        public static int selected_product;
        private void product_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                selected_product = int.Parse(product_data.Rows[e.RowIndex].Cells["productInvID"].Value.ToString());
              
                load_products();
            }
        }

        public void load_products()
        {
            String query = "SELECT productInvID, pname, pcategory, pprice, product_quantity FROM product_inventory, products " +
                            "WHERE product_inventory.product_id = products.productID AND product_status = 'Available' AND productInvID = " + selected_product + " ";

            MySqlCommand comm = new MySqlCommand(query, conn);
            comm.CommandText = query;

            conn.Open();
            MySqlDataReader dataread = comm.ExecuteReader();

            while (dataread.Read())
            {
                prodname.Text = (dataread["pname"].ToString());
                prodcategory.Text = (dataread["pcategory"].ToString());
                priceTxt.Text = (dataread["pprice"].ToString());
<<<<<<< HEAD
                quantityTxt.Maximum = int.Parse(dataread["product_quantity"].ToString());

=======

                quantityTxt.Maximum = int.Parse(dataread["pquantity"].ToString());
                
>>>>>>> 520095aa666c1d60bdbfe2a40c33b0879c08b890
                quantityTxt.Enabled = true;
                quantityTxt.Value = 1;
                subTotalTxt.Text = priceTxt.Text;

            }
            conn.Close();

        }

<<<<<<< HEAD
        private void cb_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filterquery = "SELECT productInvID, pname, pcategory, pprice, product_quantity FROM product_inventory, products " +
                                 "WHERE product_inventory.product_id = products.productID AND product_status = 'Available' AND pcategory = '"+ cb_category.Text +"';";
=======
        private void Back_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Close();
        }

        

        public void loadprod_data()
        {
            String query = "SELECT productID, pname, pprice, pquantity FROM products";
>>>>>>> 520095aa666c1d60bdbfe2a40c33b0879c08b890
            conn.Open();
            MySqlCommand comm = new MySqlCommand(filterquery, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable dt_filter = new DataTable();
            adp.Fill(dt_filter);

            product_data.DataSource = dt_filter;
            product_data.Columns["productInvID"].Visible = false;
            product_data.Columns["pname"].HeaderText = "Name";
            product_data.Columns["pcategory"].HeaderText = "Category";
            product_data.Columns["pprice"].HeaderText = "Price";
<<<<<<< HEAD
            
        }

=======
            product_data.Columns["pquantity"].HeaderText = "Quantity";


            product_data.Columns["pprice"].DefaultCellStyle.Format = "c";

        }

        public static int selected_user_id;
        private void product_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                selected_user_id = int.Parse(product_data.Rows[e.RowIndex].Cells["productID"].Value.ToString());
                load_products();
            }
        }       
        
>>>>>>> 520095aa666c1d60bdbfe2a40c33b0879c08b890
        private void btn_add_Click(object sender, EventArgs e)
        {
            Boolean duplicate_prod = false;
            int idprod = 0;

            // Takeout or Dinein
            string ordertype = "";
            bool isChecked = dinein.Checked;

            if (isChecked)
            {
                ordertype = dinein.Text;
            }
            else
            {
                ordertype = takeout.Text;
            }

            // Check if products in the ordered_products datagrid
            for (int i = 0; i < ordered_products.Rows.Count; i++)
            {
                if (selected_product == int.Parse(ordered_products.Rows[i].Cells["id"].Value.ToString()) && ordertype == ordered_products.Rows[i].Cells["OrderType"].Value.ToString() )
                {
                    duplicate_prod = true;
                    idprod = i;
                }
            }

            if ( prodname.Text == "" || priceTxt.Text == "" || quantityTxt.Text == "" || !(dinein.Checked) && !(takeout.Checked))
            {
                MessageBox.Show("Please input product details!" ,"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (duplicate_prod == true)
            {
               
                if (quantityTxt.Maximum < (quantityTxt.Value + int.Parse(ordered_products.Rows[idprod].Cells["Quantity"].Value.ToString())))
                {
                    MessageBox.Show("Product Unavailable!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    ordered_products.Rows[idprod].Cells["Quantity"].Value = int.Parse(quantityTxt.Text) + int.Parse(ordered_products.Rows[idprod].Cells["Quantity"].Value.ToString());

                    decimal subtotal = decimal.Parse(ordered_products.Rows[idprod].Cells["Price"].Value.ToString()) * int.Parse(ordered_products.Rows[idprod].Cells["Quantity"].Value.ToString());
                    ordered_products.Rows[idprod].Cells["Subtotal"].Value = subtotal.ToString();

                    total();
                }
                
            }
            else
            {
                bool x = false;
                for (int i = 0; i < ordered_products.Rows.Count; i++)
                {
                    if (quantityTxt.Maximum < (quantityTxt.Value + int.Parse(ordered_products.Rows[idprod].Cells["Quantity"].Value.ToString())))
                    {
                        x = true;
                    }      
                }
                if(x == false)
                {
                    order.Rows.Add(selected_product, prodname.Text, priceTxt.Text, quantityTxt.Text, subTotalTxt.Text, ordertype);
                    ordered_products.DataSource = order;
                    ordered_products.Columns["id"].Visible = false;
                    
                    total();
                }
                else
                {
                    MessageBox.Show("Product Unavailable!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }          
            }
        }

        public void total()
        {
            try
            {
                //Total 
                decimal total = 0;
                for (int i = 0; i <= ordered_products.Rows.Count - 1; i++)
                {
                    total += (decimal.Parse(ordered_products.Rows[i].Cells["Subtotal"].Value.ToString()));

                }
                TotalTB.Text = total.ToString("");
                totalDue.Text = total.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("An error has occured. Please Try Again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
<<<<<<< HEAD
            /*if (ordered_products.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Please order first!");
            }
            else
            {
                foreach (DataGridViewRow orderedprod in this.ordered_products.Rows)
=======
            
                if (ordered_products.SelectedRows.Count <= 0)
>>>>>>> 520095aa666c1d60bdbfe2a40c33b0879c08b890
                {
                    string tempname = Convert.ToString(orderedprod.Cells["Name"].Value);
                    int tempQTY = Convert.ToInt32(orderedprod.Cells["Quantity"].Value);
                    TotalTB.Text = Convert.ToString(Convert.ToDouble(TotalTB.Text) - Convert.ToDouble(orderedprod.Cells["Price"].Value));

                    foreach (DataGridViewRow prod_data in this.product_data.Rows)
                    {

                        if (Convert.ToString(prod_data.Cells["pname"].Value) == tempname)
                        {
                            int QTY = Convert.ToInt32(prod_data.Cells["pquantity"].Value);

                            int add = QTY + tempQTY;
                            prod_data.Cells["pquantity"].Value = Convert.ToString(add);
                            ordered_products.Rows.RemoveAt(orderedprod.Index);

                        }
                    }
                }
                foreach (DataGridViewRow row in ordered_products.Rows)
                {
                    if (row.IsNewRow) continue;

                    decimal sum = 0;
                    for (int i = 0; i < ordered_products.Rows.Count; i++)
                    {
                        sum += Convert.ToDecimal(ordered_products.Rows[i].Cells["Subtotal"].Value);
                    }
                    TotalTB.Text = Convert.ToString(sum);
                }
<<<<<<< HEAD
                
            }*/
=======

            
            
>>>>>>> 520095aa666c1d60bdbfe2a40c33b0879c08b890
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            prodname.Text = "";
            priceTxt.Text = "0";
            subTotalTxt.Text = "0";
            quantityTxt.Text = "1" ;
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
                    paymentpanel.Visible = true;
                    paymentpanel.Enabled = true;
                    paymentpanel.Size = new Size(382, 441);
                    paymentpanel.Location = new Point(0, 1);

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
            /* try
             {

             }
             catch (Exception)
             {
                 MessageBox.Show("An error has occured. Please Try Again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
             }*/

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

            if (discountTypelbl.Visible == false && cb_discountType.Visible == false && discountlbl.Visible == false && discountTxt.Visible == false)
            {
                if (amountPaid.Text == "")
                {
                    MessageBox.Show("Please fill up the required information!");
                }
                else if (changetxt.Text == "")
                {
                    MessageBox.Show("Insufficient Payment!");
                }
                else
                {
                    DialogResult verify_payment;

                    verify_payment = MessageBox.Show("Are you sure?", "Verification", MessageBoxButtons.YesNo);

                    if (verify_payment == DialogResult.Yes)
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


                        string query_order = "INSERT INTO `order`(staff_staffid, orderDate, orderTotal, orderPayment, orderDiscount, orderDiscountType, orderChange)"
                                + " VALUES((SELECT staff.staffid FROM staff INNER JOIN person ON person.personid = staff.person_personid AND CONCAT(person.firstname, ' ' , person.lastname) LIKE '%" + SAD.Login.DisplayUserDetails.name + "%'), "
                                + "current_timestamp(),'" + decimal.Parse(totalDue.Text) + "','" + decimal.Parse(amountPaid.Text) + "','" + double.Parse(discount) + "','" + discountType + "','" + decimal.Parse(changetxt.Text) + "')";



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

                            string prodID = ordered_products.Rows[i].Cells["id"].Value.ToString();
                            string pprice = ordered_products.Rows[i].Cells["Price"].Value.ToString();
                            string pquantity = ordered_products.Rows[i].Cells["Quantity"].Value.ToString();
                            string subtotal = ordered_products.Rows[i].Cells["Subtotal"].Value.ToString();
                            string ordertype = ordered_products.Rows[i].Cells["OrderType"].Value.ToString();

                            string orderline_query = "INSERT INTO orderline(orderID, productID, orderType, orderPrice, orderQuantity, orderSubtotal)" +
                                                     "VALUES( (SELECT max(orderID) from `order`),'" + int.Parse(prod_data) + "','" + ordertype + "','" + double.Parse(pprice) +
                                                     "','" + int.Parse(pquantity) + "','" + decimal.Parse(subtotal) + "');";
                            conn.Open();
                            MySqlCommand orderline_comm = new MySqlCommand(orderline_query, conn);
                            orderline_comm.ExecuteNonQuery();
                            conn.Close();

                        }
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
                        quantityTxt.Value = 1;
                        quantityTxt.Enabled = false;


                        dinein.Checked = false;
                        takeout.Checked = false;
                        this.Show();

                    }

                }
            }
            else
            {
                if (amountPaid.Text == "" || discountTxt.Text == "" || cb_discountType.Text == "")
                {
                    MessageBox.Show("Please fill up the required information!");
                }
                else if (changetxt.Text == "")
                {
                    MessageBox.Show("Insufficient Payment!");
                }
                else
                {
                    DialogResult verify_payment;

                    verify_payment = MessageBox.Show("Are you sure?", "Verification", MessageBoxButtons.YesNo);

                    if (verify_payment == DialogResult.Yes)
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


                        string query_order = "INSERT INTO `order`(staff_staffid, orderDate, orderTotal, orderPayment, orderDiscount, orderDiscountType, orderChange)"
                                + " VALUES((SELECT staff.staffid FROM staff INNER JOIN person ON person.personid = staff.person_personid AND CONCAT(person.firstname, ' ' , person.lastname) LIKE '%" + SAD.Login.DisplayUserDetails.name + "%'), "
                                + "current_timestamp(),'" + decimal.Parse(totalDue.Text) + "','" + decimal.Parse(amountPaid.Text) + "','" + double.Parse(discount) + "','" + discountType + "','" + decimal.Parse(changetxt.Text) + "')";



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

                            string prodID = ordered_products.Rows[i].Cells["id"].Value.ToString();
                            string pprice = ordered_products.Rows[i].Cells["Price"].Value.ToString();
                            string pquantity = ordered_products.Rows[i].Cells["Quantity"].Value.ToString();
                            string subtotal = ordered_products.Rows[i].Cells["Subtotal"].Value.ToString();
                            string ordertype = ordered_products.Rows[i].Cells["OrderType"].Value.ToString();
    
                            string orderline_query = "INSERT INTO orderline(orderID, productID, orderType, orderPrice, orderQuantity, orderSubtotal)" +
                                                     "VALUES( (SELECT max(orderID) from `order`),'" + int.Parse(prod_data) + "','" + ordertype + "','" + double.Parse(pprice) +
                                                     "','" + int.Parse(pquantity) + "','" + decimal.Parse(subtotal) + "');";
                            conn.Open();
                            MySqlCommand orderline_comm = new MySqlCommand(orderline_query, conn);
                            orderline_comm.ExecuteNonQuery();
                            conn.Close();

                        }
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
                        quantityTxt.Value = 1;
                        quantityTxt.Enabled = false;

                        dinein.Checked = false;
                        takeout.Checked = false;
                        this.Show();
                    }
                }
            }
        }

        private void productpanel_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        public DataTable getData(string query)
        {
            MySqlCommand comm = new MySqlCommand(query, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(comm);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        
        private void paymentpanel_Paint(object sender, PaintEventArgs e)
        {
            
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
                discountTypelbl.Location = new Point(16, 135);
                cb_discountType.Location = new Point(184, 130);
                discountlbl.Location = new Point(18, 172);
                discountTxt.Location = new Point(184, 168);

                amountPaidlbl.Location = new Point(18, 214);
                amountPaid.Location = new Point(184, 212);
                changelbl.Location = new Point(18, 251);
                changetxt.Location = new Point(184, 247);

            }
            else
            {
                discountlbl.Visible = false;
                discountTypelbl.Visible = false;
                discountTxt.Visible = false;
                cb_discountType.Visible = false;
                amountPaidlbl.Location = new Point(18, 127);
                amountPaid.Location = new Point(184, 123);
                changelbl.Location = new Point(18, 164);
                changetxt.Location = new Point(184, 160);
            }
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        
        /*<<<<<<< HEAD
=======

       private void prodname_TextChanged(object sender, EventArgs e)
       {

       }

       private void product_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
       {

       }

       private void productpanel_Paint(object sender, PaintEventArgs e)
       {
           categoryCmbData();
       }

      
>>>>>>> 5bb68333316c59fd4e45917809e0f1bba3c15c49*/
    }
}
