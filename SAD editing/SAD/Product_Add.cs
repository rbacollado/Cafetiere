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
            IngredientUsed.Columns.Add("Price", typeof(string));
            IngredientUsed.Columns.Add("Quantity", typeof(string));
            IngredientUsed.Columns.Add("Unit", typeof(string));
           
        }

        DataTable IngredientUsed = new DataTable();

        private void Product_Add_Load(object sender, EventArgs e)
        {
            loadingredients();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Close();
        }

        private void ingredientname_txt_MouseClick(object sender, MouseEventArgs e)
        {
            if (item_data.Rows.Count < 1)
            {
                MessageBox.Show("No Ingredients Available!");
                
            }
            else
            {
                ingredient_panel.Visible = true;
                ingredient_panel.Enabled = true;
                add_btn.Visible = false;
                ingredient_panel.Size = new Size(440, 281);
                ingredient_panel.Location = new Point(3, 203);

                item_data.Columns["name"].Width = 160;
                item_data.Columns["price"].Width = 80;
            }
        }

        public void loadingredients()
        {
            String queryitems = "SELECT itemInvID, name, price FROM items, items_inventory " +
                                "WHERE items.itemsID = items_inventory.item_ID AND itemStatus = 'Available'";

            conn.Open();
            MySqlCommand commitems = new MySqlCommand(queryitems, conn);
            MySqlDataAdapter adpitems = new MySqlDataAdapter(commitems);
            conn.Close();
            DataTable dtitems = new DataTable();
            adpitems.Fill(dtitems);

            item_data.DataSource = dtitems;
            item_data.Columns["itemInvID"].Visible = false;
            item_data.Columns["name"].HeaderText = "Name";
            item_data.Columns["price"].HeaderText = "Price";
           
        }

        public int item_idselected;
        private void item_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                item_idselected = int.Parse(item_data.Rows[e.RowIndex].Cells["itemInvID"].Value.ToString());

                ingredient_panel.Visible = false;
                ingredient_panel.Enabled = false;
                add_btn.Visible = true;
                ingredient_details();
            }
        }

        public void ingredient_details()
        {
            String loaditemdetails = "SELECT itemInvID, name, price FROM items, items_inventory " +
                                     "WHERE items.itemsID = items_inventory.item_ID AND itemStatus = 'Available' AND itemInvID = " + item_idselected + ";";

            MySqlCommand commitemdetails = new MySqlCommand(loaditemdetails, conn);
            commitemdetails.CommandText = loaditemdetails;

            conn.Open();
            MySqlDataReader drditemdetails = commitemdetails.ExecuteReader();

            while (drditemdetails.Read())
            {
                ingredientname_txt.Text = drditemdetails["name"].ToString();
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
                IngredientUsed.Rows.Add(ingredientname_txt.Text, ingredientprice_txt.Text, ingredientquantity_txt.Text, cmb_unit.Text);
                ingredient_used.DataSource = IngredientUsed;

                getCost();
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
                if (ingredient_used.SelectedRows.Count > 0)
                {

                    string addproductQuery = "INSERT INTO products(pname, pcategory, pprice, pcost)" +
                                                 "VALUES('" + pname_txt.Text + "','" + cmb_category.Text + "','" + decimal.Parse(pprice_txt.Text) + "','" + decimal.Parse(pcost_txt.Text) + "')";
                    conn.Open();
                    MySqlCommand productComm = new MySqlCommand(addproductQuery, conn);
                    productComm.ExecuteNonQuery();
                    conn.Close();

                    string insertproductInv = "INSERT INTO product_inventory(product_ID, prodQuantity, product_status)" + 
                                                " VALUES((SELECT MAX(productID) from Products), 0, 'Not Available')";
                    conn.Open();
                    MySqlCommand productInvcomm = new MySqlCommand(insertproductInv, conn);
                    productInvcomm.ExecuteNonQuery();
                    conn.Close();

                    for (int i = 0; i <= ingredient_used.Rows.Count - 1; i++)
                    {

                        string ingredientname = ingredient_used.Rows[i].Cells["Name"].Value.ToString();

                        string queryitem = "SELECT itemInvID FROM items_inventory " +
                                           "WHERE item_id = (SELECT itemsID from items where name = '" + ingredientname + "') AND itemStatus = 'Available';";
                        conn.Open();
                        MySqlCommand commitems = new MySqlCommand(queryitem, conn);
                        MySqlDataAdapter adpitems = new MySqlDataAdapter(commitems);
                        conn.Close();
                        DataTable dt_items = new DataTable();
                        adpitems.Fill(dt_items);

                        string itemid = dt_items.Rows[0][0].ToString();
                        string ingredientName = ingredient_used.Rows[i].Cells["Name"].Value.ToString();
                        string ingredientPrice = ingredient_used.Rows[i].Cells["Price"].Value.ToString();
                        string recipeQuantity = ingredient_used.Rows[i].Cells["Quantity"].Value.ToString();
                        string recipeUnit = ingredient_used.Rows[i].Cells["Unit"].Value.ToString();


                        string addingredientQuery = "INSERT INTO ingredients(items_inventory_itemInvID, ingredientName, ingredientprice)" +
                                                 "VALUES('" + int.Parse(itemid) + "' ,'" + ingredientName + "','" + decimal.Parse(ingredientPrice) + "')";
                        conn.Open();
                        MySqlCommand ingredientComm = new MySqlCommand(addingredientQuery, conn);
                        ingredientComm.ExecuteNonQuery();
                        conn.Close();

                        string addrecipeQuery = "INSERT INTO recipe(ingredients_ingredientsID, products_productID, recipeQuantity, recipeUnit)" +
                                                 "VALUES((SELECT max(ingredientsID) FROM ingredients), (SELECT max(productID) FROM products), '" + int.Parse(recipeQuantity) + "','" + recipeUnit + "')";
                        conn.Open();
                        MySqlCommand recipeComm = new MySqlCommand(addrecipeQuery, conn);
                        recipeComm.ExecuteNonQuery();
                        conn.Close();

                    }
                    MessageBox.Show("Product added!");

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
}
