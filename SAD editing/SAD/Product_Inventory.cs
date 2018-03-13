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
            
            loadBatch();

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
            batch_items.Columns["ingredientName"].HeaderText = "Ingredient Name";
            batch_items.Columns["ingredientQuantity"].HeaderText = "Ingredient Quantity";
            batch_items.Columns["ingredientAmount"].HeaderText = "Ingredient Amount";
            batch_items.Columns["ingredientUnit"].HeaderText = "Ingredient Unit";
            batch_items.Columns["batch_ingredient_date"].HeaderText = "Date";
            
        }
        
        private void btn_close_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Close();
        }

        private void btn_products_Click(object sender, EventArgs e)
        {
            Product prod = new Product();
            prod.Show();
            prod.prevForm = this;
            this.Hide();
        }

        private void btn_use_Click(object sender, EventArgs e)
        {

        }
    }
}
