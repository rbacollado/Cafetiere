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
    public partial class Product_Batch : Form
    {
        public Form prevForm { get; set; }

        MySqlConnection conn;

        public Product_Batch()
        {
            InitializeComponent();

            conn = new MySqlConnection("SERVER=localhost; DATABASE=Cafetiere; uid=root; pwd=root;");
            
        }
        
        private void Product_Batch_Load(object sender, EventArgs e)
        {
            loadBatch();
            load_recipe();
        }

        public void load_recipe()
        {

            String queryrecipe = "SELECT * FROM products";

            MySqlCommand commrecipe = new MySqlCommand(queryrecipe, conn);
            commrecipe.CommandText = queryrecipe;
            conn.Open();
            MySqlDataReader drd_recipe = commrecipe.ExecuteReader();

            cmb_products.Items.Clear();
            while (drd_recipe.Read())
            {
                cmb_products.Items.Add(drd_recipe["pname"].ToString());
            }
            conn.Close();

        }

        private void cmb_products_SelectedIndexChanged(object sender, EventArgs e)
        {
            string recipequery = "SELECT recipeID, ingredientName, recipeQuantity, recipeUnit FROM products, recipe, ingredients " +
                                 "WHERE pname = '" + cmb_products.Text + "' AND products.productID = recipe.products_productID " +
                                 "AND ingredients.ingredientsID = recipe.ingredients_ingredientsID;";
            conn.Open();
            MySqlCommand comm = new MySqlCommand(recipequery, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable dt_filter = new DataTable();

            adp.Fill(dt_filter);

            product_recipe.DataSource = dt_filter;
            product_recipe.Columns["recipeID"].Visible = false;
            product_recipe.Columns["ingredientName"].HeaderText = "Name";
            product_recipe.Columns["recipeQuantity"].HeaderText = "Qty";
            product_recipe.Columns["recipeUnit"].HeaderText = "Unit";
            
        }

        public void loadBatch()
        {
            string batchingredientsQuery = "SELECT * FROM batch_ingredients;";

            conn.Open();

            MySqlCommand batch_ingredientcomm = new MySqlCommand(batchingredientsQuery, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(batch_ingredientcomm);

            conn.Close();

            DataTable dt_batch = new DataTable();

            adp.Fill(dt_batch);

            batch_items.DataSource = dt_batch;
            batch_items.Columns["batchIngredient_id"].Visible = false;
            batch_items.Columns["log_stockout"].Visible = false;
            batch_items.Columns["ingredientName"].HeaderText = "Name";
            batch_items.Columns["ingredientDescription"].HeaderText = "Desc";
            batch_items.Columns["ingredientQuantity"].HeaderText = "Qty";
            batch_items.Columns["ingredientAmount"].HeaderText = "Amt";
            batch_items.Columns["ingredientUnit"].HeaderText = "Unit";
            batch_items.Columns["batch_ingredient_date"].HeaderText = "Date";

        }
        
        private void btn_close_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Close();
        }
        
        private void use_btn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
