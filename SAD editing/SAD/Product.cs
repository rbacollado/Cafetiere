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
        public MainMenu prevForm { get; set; }

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
            product_list.Columns["pstatus"].HeaderText = "Availability";
            product_list.Columns["pquantity"].HeaderText = "Quantity";
            product_list.Columns["pcost"].HeaderText = "Cost";
            product_list.Columns["category_category_id"].Visible = false;
            product_list.Columns[0].Width = 50;
            product_list.Columns[1].Width = 150;
            product_list.Columns[2].Width = 120;
            product_list.Columns[4].Width = 135;
            product_list.Columns[5].Width = 110;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Close();
        }

        private void btn_add_Click_1(object sender, EventArgs e)
        {
            Product_Add addproduct = new Product_Add();
            addproduct.Show();
            addproduct.prevForm = this;
            this.Hide();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Close();
        }

    }
}
