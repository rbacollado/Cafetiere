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
    public partial class Product : Form
    {
        public Form prevForm { get; set; }

        MySqlConnection conn;

        public Product()
        {
            InitializeComponent();
            conn = new MySqlConnection("SERVER=localhost; DATABASE=cafetiere; uid=root; pwd=root;");
        }

        private void Product_Load(object sender, EventArgs e)
        {
            loadAll();
        }
        
        private void loadAll()
        {
            string query = "SELECT * FROM Products";

            conn.Open();

            MySqlCommand comm = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);

            conn.Close();

            DataTable dt = new DataTable();

            adp.Fill(dt);

            product_list.DataSource = dt;
            product_list.Columns["productID"].Visible = false;
            product_list.Columns["pname"].HeaderText = "Name";
            product_list.Columns["pcategory"].HeaderText = "Category";
            product_list.Columns["pprice"].HeaderText = "Price (₱)";

            product_list.Columns["pcost"].HeaderText = "Cost";

        }

        public class selected_data
        {
            public static int prodID;
        }

        private void product_list_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int productID;

                int selected_id = int.Parse(product_list.Rows[e.RowIndex].Cells["productID"].Value.ToString());
                productID = selected_id;
                selected_data.prodID = selected_id; 

                String recipeQuery = "SELECT ingredientName, recipeQuantity, recipeUnit FROM ingredients, recipe " +
                                     "WHERE ingredients.ingredientsID = recipe.ingredients_ingredientsID AND recipe.products_productID = " + selected_id + ";";
                                   

                conn.Open();
                MySqlCommand comm = new MySqlCommand(recipeQuery, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                conn.Close();

                DataTable recipe = new DataTable();
                adp.Fill(recipe);

                product_recipe.DataSource = recipe;

                product_recipe.Columns["ingredientName"].HeaderText = "Ingredient Name";
                product_recipe.Columns["recipeQuantity"].HeaderText = "Quantity Used";
                product_recipe.Columns["recipeUnit"].HeaderText = "Unit";
               
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Close();
        }

     
        private void btn_close_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Close();
        }

        private void prodInv_btn_Click(object sender, EventArgs e)
        {
            Product_Inventory prodInv = new Product_Inventory();
            prodInv.Show();
            prodInv.prevForm = this;
            this.Hide();
        }

        private void create_btn_Click(object sender, EventArgs e)
        {
            Product_Add addproduct = new Product_Add();
            addproduct.Show();
            addproduct.prevForm = this;
            this.Hide();
        }

        private void product_recipe_SelectionChanged(object sender, EventArgs e)
        {
            this.product_recipe.ClearSelection();
        }

        private void product_update_Click(object sender, EventArgs e)
        {
            Product_Update prodUpdate = new Product_Update();
            prodUpdate.Show();
            prodUpdate.prevForm = this;
            this.Hide();
        }
    }
}
