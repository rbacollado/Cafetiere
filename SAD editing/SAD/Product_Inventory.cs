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
    public partial class Product_Inventory : Form
    {
        public Form prevForm { get; set; }

        MySqlConnection conn;

        public Product_Inventory()
        {
            InitializeComponent();
            conn = new MySqlConnection("SERVER=localhost; DATABASE=Cafetiere; uid=root; pwd=root;");

            batch_prod.Columns.Add("ID", typeof(string));
            batch_prod.Columns.Add("Name", typeof(string));
            batch_prod.Columns.Add("Quantity", typeof(string));
            batch_prod.Columns.Add("Produced", typeof(string));
            batch_prod.Columns.Add("Date", typeof(string));
        }

        DataTable batch_prod = new DataTable();

        private void Product_Inventory_Load(object sender, EventArgs e)
        {
            
            loadprodInv();
        
        }

        
        public void loadprodInv()
        {
            string query = "SELECT productInvID, productID, pname, pcategory, product_quantity, product_status FROM products, product_inventory WHERE products.productID = product_inventory.product_ID";

            conn.Open();

            MySqlCommand comm = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);

            conn.Close();

            DataTable dt = new DataTable();

            adp.Fill(dt);

            prodInv.DataSource = dt;
            prodInv.Columns["productInvID"].Visible = false;
            prodInv.Columns["productID"].Visible = false;
            prodInv.Columns["pname"].HeaderText = "Name";
            prodInv.Columns["pcategory"].HeaderText = "Category";
            prodInv.Columns["product_quantity"].HeaderText = "Quantity";
            prodInv.Columns["product_status"].HeaderText = "Status";
            
        }

        
        private void btn_close_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Close();
        }

        public static int prodID;
        private void prodInv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int selected_invID = int.Parse(prodInv.Rows[e.RowIndex].Cells["productInvID"].Value.ToString());
                int selected_id = int.Parse(prodInv.Rows[e.RowIndex].Cells["productID"].Value.ToString());
                prodID = selected_id;

                add.Size = new Size(129, 25);
                add.Location = new Point(692, 73);
                add.Enabled = true;
                add.Visible = true;

                loadRecipe();
                loadBatch();

            }
        }

        public void loadRecipe()
        {
            String recipeQuery = "SELECT ingredientName, ingredientDesc, recipeQuantity, recipeUnit FROM ingredients, recipe " +
                                 "WHERE ingredients.ingredientsID = recipe.ingredients_ingredientsID AND recipe.products_productID = " + prodID + ";";

            
            conn.Open();
            MySqlCommand comm = new MySqlCommand(recipeQuery, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            conn.Close();

            DataTable recipe = new DataTable();
            adp.Fill(recipe);

            product_recipe.DataSource = recipe;

            product_recipe.Columns["ingredientName"].HeaderText = "Name";
            product_recipe.Columns["ingredientDesc"].HeaderText = "Desc";
            product_recipe.Columns["recipeQuantity"].HeaderText = "Quantity Used";
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

        private void add_Click(object sender, EventArgs e)
        {
            add_panel.Visible = true;
            add_panel.Enabled = true;
            
            add_panel.Size = new Size(802, 393);
            add_panel.Location = new Point(19, 101);

        }

        private void close_panel_Click(object sender, EventArgs e)
        {
            add_panel.Visible = false;
            add_panel.Enabled = false;
        }

        private void btn_products_Click(object sender, EventArgs e)
        {
            Product prod = new Product();
            prod.Show();
            prod.prevForm = this;
            this.Hide();
        }

        private void btn_productInv_Click(object sender, EventArgs e)
        {
          
        }

        private void add_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
