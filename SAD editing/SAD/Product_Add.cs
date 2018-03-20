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
    public partial class Product_Add : Form
    {
        MySqlConnection conn;

        public Form prevForm { get; set; }

        public Product_Add()
        {
            InitializeComponent();
            conn = new MySqlConnection("SERVER=localhost; DATABASE=Cafetiere; uid=root; pwd=root;");

            
            IngredientUsed.Columns.Add("Name", typeof(string));
            IngredientUsed.Columns.Add("Desc", typeof(string));
            IngredientUsed.Columns.Add("Price", typeof(string));
            IngredientUsed.Columns.Add("Exp", typeof(string));
            IngredientUsed.Columns.Add("Quantity", typeof(string));
            IngredientUsed.Columns.Add("Unit", typeof(string));
           
        }

        DataTable IngredientUsed = new DataTable();

        private void Product_Add_Load(object sender, EventArgs e)
        {
            loadingredients();
            loadProducts();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Close();
        }


        private void ingredient_chk_CheckedChanged(object sender, EventArgs e)
        {

            if (ingredient_chk.Checked == true)
            {
                withIngredient_panel.Visible = true;
                withIngredient_panel.Enabled = true;
                withIngredient_panel.Size = new Size(446, 488);
                withIngredient_panel.Location = new Point(1, 64);

                label3.Visible = true;
                ingredient_used.Visible = true;
                label10.Visible = true;
                pcost_txt.Visible = true;
                create_btn.Visible = true;
                
                product_panel.Visible = false;
                product_panel.Enabled = false;
                prod_create.Visible = false;
                
            }
            else
            {
                withIngredient_panel.Visible = false;
                withIngredient_panel.Enabled = false;

                product_panel.Visible = true;
                product_panel.Enabled = true;
                prod_create.Visible = true;
                product_panel.Size = new Size(446, 488);
                product_panel.Location = new Point(1, 64);

                label3.Visible = false;
                ingredient_used.Visible = false;
                label10.Visible = false;
                pcost_txt.Visible = false;
                create_btn.Visible = false;
                
            }
            
        }

        private void prod_name_MouseClick(object sender, MouseEventArgs e)
        {
            if (product_data.Rows.Count < 1)
            {
                MessageBox.Show("No Products Available!");

            }
            else
            {
                prod_panel.Visible = true;
                prod_panel.Enabled = true;

                label14.Visible = false;
                prod_cost.Visible = false;

                label15.Visible = false;
                prod_quantity.Visible = false;

                label17.Visible = false;
                prod_unit.Visible = false;

                prod_panel.Size = new Size(418, 370);
                prod_panel.Location = new Point(11, 52);

                product_data.Columns["name"].Width = 160;
                product_data.Columns["price"].Width = 80;
            }
        }

        public void loadProducts()
        {
            String queryprod = "SELECT itemInvID, name, description, itemExpiry, price FROM items, items_inventory " +
                                "WHERE items.itemsID = items_inventory.item_ID AND itemStatus = 'Available' AND itemType = 'Product'";

            conn.Open();
            MySqlCommand commprod = new MySqlCommand(queryprod, conn);
            MySqlDataAdapter adpprod = new MySqlDataAdapter(commprod);
            conn.Close();
            DataTable dtitems = new DataTable();
            adpprod.Fill(dtitems);

            product_data.DataSource = dtitems;
            product_data.Columns["itemInvID"].Visible = false;
            product_data.Columns["name"].HeaderText = "Name";
            product_data.Columns["description"].HeaderText = "Desc";
            product_data.Columns["itemExpiry"].HeaderText = "Expiration";
            product_data.Columns["price"].HeaderText = "Price";


        }

        public int prod_idselected;
        private void product_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                prod_idselected = int.Parse(product_data.Rows[e.RowIndex].Cells["itemInvID"].Value.ToString());

                prod_panel.Visible = false;
                prod_panel.Enabled = false;

                label14.Visible = true;
                prod_cost.Visible = true;

                label15.Visible = true;
                prod_quantity.Visible = true;

                label17.Visible = true;
                prod_unit.Visible = true;

                prod_details();
            }
        }

        public void prod_details()
        {
            String loadproddetails = "SELECT itemInvID, name, description, DATE_FORMAT(itemExpiry, '%Y-%m-%d') as itemExpiry, price FROM items, items_inventory " +
                                     "WHERE items.itemsID = items_inventory.item_ID AND itemStatus = 'Available' AND itemType = 'Product' AND itemInvID = " + prod_idselected + ";";

            MySqlCommand comproddetails = new MySqlCommand(loadproddetails, conn);
            comproddetails.CommandText = loadproddetails;

            conn.Open();
            MySqlDataReader drdproddetails = comproddetails.ExecuteReader();

            while (drdproddetails.Read())
            {
                prod_name.Text = drdproddetails["name"].ToString();
                prod_expiry.Text = drdproddetails["itemExpiry"].ToString();
                prod_description.Text = drdproddetails["description"].ToString();
                prod_cost.Text = drdproddetails["price"].ToString();

            }
            conn.Close();
        }

        private void prod_create_Click(object sender, EventArgs e)
        {
            string q = "SELECT pname FROM Products WHERE pname = '" + pname_txt.Text + "';";
            conn.Open();
            MySqlCommand comm = new MySqlCommand(q, conn);
            comm.ExecuteNonQuery();
            conn.Close();
            DataTable dt = new DataTable();
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            adp.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("Product Already Exist!", "Duplicate Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (prod_name.Text == "" || prod_description.Text == "" || prod_cost.Text == "" || prod_cmb.Text == "" ||
                prod_quantity.Text == "" || prod_price.Text == "" || prod_unit.Text == "")
                {
                    MessageBox.Show("Please complete product details!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string addproductQuery = "INSERT INTO products(pname, pcategory, pprice, pcost)" +
                                                     "VALUES('" + prod_name.Text + "','" + prod_cmb.Text + "','" + decimal.Parse(prod_price.Text) + "','" + decimal.Parse(prod_cost.Text) + "')";
                    conn.Open();
                    MySqlCommand productComm = new MySqlCommand(addproductQuery, conn);
                    productComm.ExecuteNonQuery();
                    conn.Close();

                    string insertproductInv = "INSERT INTO product_inventory(product_ID, product_quantity, product_status)" +
                                                        " VALUES((SELECT MAX(productID) from Products), 0, 'Not Available')";
                    conn.Open();
                    MySqlCommand productInvcomm = new MySqlCommand(insertproductInv, conn);
                    productInvcomm.ExecuteNonQuery();
                    conn.Close();


                    string queryProduct = "SELECT itemInvID FROM items_inventory " +
                                        "WHERE item_id = (SELECT itemsID from items where name = '" + prod_name.Text + "' AND description = '" + prod_description.Text + "' ) AND itemExpiry = '" + prod_expiry.Text + "' AND itemStatus = 'Available';";

                    conn.Open();
                    MySqlCommand commprod = new MySqlCommand(queryProduct, conn);
                    MySqlDataAdapter adpprod = new MySqlDataAdapter(commprod);
                    conn.Close();
                    DataTable dt_prod = new DataTable();
                    adpprod.Fill(dt_prod);

                    string itemid = dt_prod.Rows[0][0].ToString();

                    string addingredientQuery = "INSERT INTO ingredients(items_inventory_itemInvID, ingredientName, ingredientDesc, ingredientprice) " +
                                                         "VALUES(" + int.Parse(itemid) + ", '" + prod_name.Text + "', '" + prod_description.Text + "', '" + decimal.Parse(prod_cost.Text) + "');";
                    conn.Open();
                    MySqlCommand ingredientComm = new MySqlCommand(addingredientQuery, conn);
                    ingredientComm.ExecuteNonQuery();
                    conn.Close();

                    string addrecipeQuery = "INSERT INTO recipe(ingredients_ingredientsID, products_productID, recipeQuantity, recipeUnit)" +
                                                        "VALUES((SELECT max(ingredientsID) from ingredients), (SELECT max(productID) FROM products), '" + int.Parse(prod_quantity.Text) + "','" + prod_unit.Text + "');";
                    conn.Open();
                    MySqlCommand recipeComm = new MySqlCommand(addrecipeQuery, conn);
                    recipeComm.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Product added!");

                    this.Close();
                    prevForm.ShowDialog();
                }
            }
        }

        private void ingredientname_txt_MouseClick(object sender, MouseEventArgs e)
        {
            if (item_data.Rows.Count < 1)
            {
                MessageBox.Show("No Ingredients Available!");
                
            }
            else
            {
                ingredients_panel.Visible = true;
                ingredients_panel.Enabled = true;
                add_btn.Visible = false;
                label8.Visible = false;
                ingredientdesc_txt.Visible = false;
                ingredients_panel.Size = new Size(440, 281);
                ingredients_panel.Location = new Point(3, 203);

                item_data.Columns["name"].Width = 160;
                item_data.Columns["price"].Width = 80;
            }
        }

        public void loadingredients()
        {
            String queryitems = "SELECT itemInvID, name, description, price FROM items, items_inventory " +
                                "WHERE items.itemsID = items_inventory.item_ID AND itemStatus = 'Available' AND itemType = 'Ingredient'";

            conn.Open();
            MySqlCommand commitems = new MySqlCommand(queryitems, conn);
            MySqlDataAdapter adpitems = new MySqlDataAdapter(commitems);
            conn.Close();
            DataTable dtitems = new DataTable();
            adpitems.Fill(dtitems); 

            item_data.DataSource = dtitems;
            item_data.Columns["itemInvID"].Visible = false;
            item_data.Columns["name"].HeaderText = "Name";
            item_data.Columns["description"].HeaderText = "Description";
            item_data.Columns["price"].HeaderText = "Price";
           
        }

        public int item_idselected;
        private void item_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                item_idselected = int.Parse(item_data.Rows[e.RowIndex].Cells["itemInvID"].Value.ToString());

                ingredients_panel.Visible = false;
                ingredients_panel.Enabled = false;
                add_btn.Visible = true;
                label8.Visible = true;
                ingredientdesc_txt.Visible = true;
                ingredient_details();
            }
        }

        public void ingredient_details()
        {
            String loaditemdetails = "SELECT itemInvID, name, description, DATE_FORMAT(itemExpiry, '%Y-%m-%d') as itemExpiry, price FROM items, items_inventory " +
                                     "WHERE items.itemsID = items_inventory.item_ID AND itemStatus = 'Available' AND itemType = 'Ingredient' AND itemInvID = " + item_idselected + ";";

            MySqlCommand commitemdetails = new MySqlCommand(loaditemdetails, conn);
            commitemdetails.CommandText = loaditemdetails;

            conn.Open();
            MySqlDataReader drditemdetails = commitemdetails.ExecuteReader();

            while (drditemdetails.Read())
            {
                ingredientname_txt.Text = drditemdetails["name"].ToString();
                ingredientdesc_txt.Text = drditemdetails["description"].ToString();
                ingredient_expiry.Text = drditemdetails["itemExpiry"].ToString();
                ingredientprice_txt.Text = drditemdetails["price"].ToString();
 
            }
            conn.Close();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
          
            if ( ingredientquantity_txt.Text == "" || cmb_unit.Text == "")
            {
                MessageBox.Show("Please complete product details!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                IngredientUsed.Rows.Add(ingredientname_txt.Text, ingredientdesc_txt.Text, ingredientprice_txt.Text, ingredient_expiry.Text, ingredientquantity_txt.Text, cmb_unit.Text);
                ingredient_used.DataSource = IngredientUsed;

                getCost();
            }

        }

        

        public void getCost()
        {
            // Total
            decimal cost = 0;
            for (int i = 0; i <= ingredient_used.Rows.Count - 1; i++)
            {
                cost += (decimal.Parse(ingredient_used.Rows[i].Cells["Price"].Value.ToString()));
            }

            pcost_txt.Text = cost.ToString();
        }

        private void create_btn_Click(object sender, EventArgs e)
        {
            string q = "SELECT pname FROM Products WHERE pname = '" + pname_txt.Text + "';";
            conn.Open();
            MySqlCommand comm = new MySqlCommand(q, conn);
            comm.ExecuteNonQuery();
            conn.Close();
            DataTable dt = new DataTable();
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            adp.Fill(dt);
            
            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("Product Already Exist!", "Duplicate Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (pname_txt.Text == "" || cmb_category.Text == "" || pprice_txt.Text == "" || pcost_txt.Text == "")
                {
                    MessageBox.Show("Please complete product details!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (ingredient_used.SelectedRows.Count > 0)
                    {
                        string prodname = pname_txt.Text;
                        string prodcategory = cmb_category.Text;
                        decimal parsePrice = decimal.Parse(pprice_txt.Text);
                        decimal parseCost = decimal.Parse(pcost_txt.Text);

                        string addproductQuery = "INSERT INTO products(pname, pcategory, pprice, pcost)" +
                                                     " VALUES('" + prodname + "','" + prodcategory + "','" + parsePrice + "','" + parseCost + "')";
                        conn.Open();
                        MySqlCommand productComm = new MySqlCommand(addproductQuery, conn);
                        productComm.ExecuteNonQuery();
                        conn.Close();

                        string insertproductInv = "INSERT INTO product_inventory(product_ID, product_quantity, product_status)" +
                                                    " VALUES((SELECT MAX(productID) from Products), 0, 'Not Available')";
                        conn.Open();
                        MySqlCommand productInvcomm = new MySqlCommand(insertproductInv, conn);
                        productInvcomm.ExecuteNonQuery();
                        conn.Close();

                        for (int i = 0; i <= ingredient_used.Rows.Count - 1 ; i++)
                        {

                            string ingredientname = ingredient_used.Rows[i].Cells["Name"].Value.ToString();
                            string ingredientdesc = ingredient_used.Rows[i].Cells["Desc"].Value.ToString();
                            string ingredientexp = ingredient_used.Rows[i].Cells["Exp"].Value.ToString();

                            string queryitem = "SELECT itemInvID FROM items_inventory " +
                                               "WHERE item_id = (SELECT itemsID from items where name = '" + ingredientname + "' AND description = '" + ingredientdesc + "') AND itemExpiry = '" + ingredientexp + "' AND itemStatus = 'Available';";
                            conn.Open();
                            MySqlCommand commitems = new MySqlCommand(queryitem, conn);
                            MySqlDataAdapter adpitems = new MySqlDataAdapter(commitems);
                            conn.Close();
                            DataTable dt_items = new DataTable();
                            adpitems.Fill(dt_items);

                            string itemid = dt_items.Rows[0][0].ToString();

                            string ingredientName = ingredient_used.Rows[i].Cells["Name"].Value.ToString();
                            string ingredientDesc = ingredient_used.Rows[i].Cells["Desc"].Value.ToString();
                            string ingredientPrice = ingredient_used.Rows[i].Cells["Price"].Value.ToString();
                            string recipeQuantity = ingredient_used.Rows[i].Cells["Quantity"].Value.ToString();
                            string recipeUnit = ingredient_used.Rows[i].Cells["Unit"].Value.ToString();


                            string addingredientQuery = "INSERT INTO ingredients(items_inventory_itemInvID, ingredientName, ingredientDesc, ingredientprice)" +
                                                     " VALUES('" + int.Parse(itemid) + "' ,'" + ingredientName + "','" + ingredientDesc + "','" + decimal.Parse(ingredientPrice) + "')";
                            conn.Open();
                            MySqlCommand ingredientComm = new MySqlCommand(addingredientQuery, conn);
                            ingredientComm.ExecuteNonQuery();
                            conn.Close();

                            string addrecipeQuery = "INSERT INTO recipe(ingredients_ingredientsID, products_productID, recipeQuantity, recipeUnit)" +
                                                     " VALUES((SELECT max(ingredientsID) FROM ingredients), (SELECT max(productID) FROM products), '" + int.Parse(recipeQuantity) + "','" + recipeUnit + "')";
                            conn.Open();
                            MySqlCommand recipeComm = new MySqlCommand(addrecipeQuery, conn);
                            recipeComm.ExecuteNonQuery();
                            conn.Close();

                        }
                        MessageBox.Show("Product added!");

                        IngredientUsed.Rows.Clear();

                        this.Close();
                        prevForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Please add data to the table before saving.");
                    }
                } 
               

            }

        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (ingredient_used.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Please select an ingredient first!");
            }
            else
            {
                int row = ingredient_used.CurrentCell.RowIndex;
                ingredient_used.Rows.RemoveAt(row);

                getCost();

            }

        }

        private void ingredientdesc_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void ingredientprice_txt_TextChanged(object sender, EventArgs e)
        {
           
        }

       
        // Validations
        private void ingredientprice_txt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void prod_quantity_KeyPress(object sender, KeyPressEventArgs e)
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

        private void ingredientquantity_txt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void prod_price_KeyPress(object sender, KeyPressEventArgs e)
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

        private void prod_cost_KeyPress(object sender, KeyPressEventArgs e)
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

        private void prod_description_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void pprice_txt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void ingredientdesc_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void product_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
