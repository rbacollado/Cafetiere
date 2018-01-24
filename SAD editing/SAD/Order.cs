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
       
        public Order()
        {
            InitializeComponent();
            conn = new MySqlConnection("SERVER=localhost; DATABASE=cafetiere; uid=root; pwd=root;"); 
        }
        public MainMenu prevForm { get; set; }

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

        }

        public void load_products()
        {
            String query = "SELECT productID , pname, pprice, pquantity FROM products WHERE productID = " + selected_user_id +" ";

            MySqlCommand comm = new MySqlCommand(query, conn);
            comm.CommandText = query;

            conn.Open();
            MySqlDataReader dataread = comm.ExecuteReader();

            while (dataread.Read())
            {
                prodname.Text = (dataread["pname"].ToString());
                priceTxt.Text = (dataread["pprice"].ToString());
                quantityTxt.Maximum = int.Parse(dataread["pquantity"].ToString());
                
                quantityTxt.Enabled = true;
                quantityTxt.Value = 1;
                subTotalTxt.Text = priceTxt.Text ;

            }
            conn.Close();

        }

        private void Back_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Close();
        }

        private void prod_MouseClick(object sender, MouseEventArgs e)
        {
            String query = "SELECT productID, pname, pprice, pquantity FROM products";
            conn.Open();
            MySqlCommand comm = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);

            product_data.DataSource = dt;
            product_data.Columns["productID"].Visible = false;
            product_data.Columns["pname"].HeaderText = "Name";
            product_data.Columns["pprice"].HeaderText = "Price";
            product_data.Columns["pquantity"].HeaderText = "Quantity";

            product_data.Columns["pprice"].DefaultCellStyle.Format = "c";

            if (product_data.Rows.Count < 1)
            {
                MessageBox.Show("Products Unavailable" ,"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                productpanel.Visible = true;
                productpanel.Enabled = true;


                productpanel.Size = new Size(380, 421);
                productpanel.Location = new Point(11, 160);
            }
        }

        public static int selected_user_id;
        private void product_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                selected_user_id = int.Parse(product_data.Rows[e.RowIndex].Cells["productID"].Value.ToString());
              
                productpanel.Visible = false;
                productpanel.Enabled = false;
                load_products();
            }
        }       
        
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
                if ( selected_user_id == int.Parse(ordered_products.Rows[i].Cells["id"].Value.ToString()) && ordertype == ordered_products.Rows[i].Cells["OrderType"].Value.ToString() )
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
                if (quantityTxt.Maximum < ( quantityTxt.Value + int.Parse( ordered_products.Rows[idprod].Cells["Quantity"].Value.ToString()) ) ) 
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
                    order.Rows.Add(selected_user_id, prodname.Text, priceTxt.Text, quantityTxt.Text, subTotalTxt.Text, ordertype);
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
                TotalTB.Text = total.ToString("C");
                totalDue.Text = total.ToString();
            }catch(Exception)
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
            try
            {
                if (ordered_products.SelectedRows.Count <= 0)
                {
                    MessageBox.Show("Please order first!");
                }
                else
                {
                    int row = ordered_products.CurrentCell.RowIndex;
                    ordered_products.Rows.RemoveAt(row);

                    total();
                
                }
            }catch (Exception exception)
            {
                MessageBox.Show("An error has occured. Please Try Again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
                paymentpanel.Visible = true;
                paymentpanel.Enabled = true;

                dinein.Visible = false;
                takeout.Visible = false;

                paymentpanel.Size = new Size(380, 441);
                paymentpanel.Location = new Point(0, 97);
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
            }
            else
            {
                changetxt.Clear();
            }
        }

        private void discountTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                
                /*if (!(string.IsNullOrEmpty(discountTxt.Text)))
                {
                    converted_discount = Convert.ToInt32(discountTxt.Text);
                    converted_total = Convert.ToInt32(totalDue.Text);

                    discounted = ((converted_discount * converted_total) / 100);
                }
                else
                {
                    changetxt.Clear();
                }*/

            }
            catch (Exception)
            {
                MessageBox.Show("An error has occured. Please Try Again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            DialogResult verify_payment;

            verify_payment = MessageBox.Show("Are you sure?", "Verification", MessageBoxButtons.YesNo);
            
            if (verify_payment == DialogResult.Yes)
            {
                
                string query_order = "INSERT INTO `order`(order_staff_id, orderDate, orderTotal, orderDiscount)" 
                        + " VALUES((SELECT staff_id FROM staff WHERE CONCAT(firstname, ' ' , lastname) LIKE '%" + SAD.Login.DisplayUserDetails.name + "%'), current_timestamp(),'"
                        + decimal.Parse(totalDue.Text) + "','" + double.Parse(discountTxt.Text) + "')";
                conn.Open();
                MySqlCommand comm = new MySqlCommand(query_order, conn);
                comm.ExecuteNonQuery();
                conn.Close();

                for(int i = 0; i <= ordered_products.Rows.Count - 1; i++)
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
            }
        }

        
    }
}
