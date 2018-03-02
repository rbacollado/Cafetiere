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

        

    }
}
