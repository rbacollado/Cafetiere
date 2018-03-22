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
            loadBatch();
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
                
            }
        }

        

        public void loadBatch()
        {
            string batchingredientsQuery = "SELECT batchIngredient_id, log_stockout, ingredientName, ingredientDescription, ingredientQuantity, CONCAT(ingredientAmount, ' ' ,ingredientUnit) as measurement, batch_ingredient_date FROM batch_ingredients;";

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
            batch_items.Columns["measurement"].HeaderText = "Item Measurement";
            batch_items.Columns["batch_ingredient_date"].HeaderText = "Date";
        }

        private void show_recipe_Click(object sender, EventArgs e)
        {
            show_panel.Visible = true;
            show_panel.Enabled = true;

            show_panel.Size = new Size(802, 393);
            show_panel.Location = new Point(19, 101);
        }
        
        private void close_panel_Click(object sender, EventArgs e)
        {
            show_panel.Visible = false;
            show_panel.Enabled = false;
        }

        private void show_add_Click(object sender, EventArgs e)
        {
            qty_panel.Visible = true;
            qty_panel.Enabled = true;

            qty_panel.Size = new Size(295, 213);
            qty_panel.Location = new Point(274, 153);
        }

        private void add_qty_Click(object sender, EventArgs e)
        {

        }

        private void prod_quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
