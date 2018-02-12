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

            dtgv.DataSource = dt;
            dtgv.Columns["productID"].Visible = false;
            dtgv.Columns["pname"].HeaderText = "Name";
            dtgv.Columns["pcategory"].HeaderText = "Category";
            dtgv.Columns["pprice"].HeaderText = "Price (₱)";
            dtgv.Columns["pstatus"].HeaderText = "Availability";
            dtgv.Columns["pquantity"].HeaderText = "Quantity";
            dtgv.Columns["pcost"].HeaderText = "Cost";
            dtgv.Columns["category_category_id"].Visible = false;
            dtgv.Columns[0].Width = 50;
            dtgv.Columns[1].Width = 150;
            dtgv.Columns[2].Width = 120;
            dtgv.Columns[4].Width = 135;
            dtgv.Columns[5].Width = 110;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Close();
        }

        private int selected_product_id;
       /* private void dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                selected_product_id = int.Parse(dtgv.Rows[e.RowIndex].Cells["productID"].Value.ToString());
                txt_pname.Text = dtgv.Rows[e.RowIndex].Cells["pname"].Value.ToString();
                txt_pprice.Text = dtgv.Rows[e.RowIndex].Cells["pprice"].Value.ToString();
                nud_pquantity.Text = dtgv.Rows[e.RowIndex].Cells["pquantity"].Value.ToString();
                txt_pcost.Text = dtgv.Rows[e.RowIndex].Cells["pcost"].Value.ToString();

                btn_add.Enabled = false;
                btn_add.BackColor = Color.Gray;
                btn_update.Enabled = true;
                btn_update.BackColor = Color.Gold;
            }
        }*/

        private void btn_add_Click_1(object sender, EventArgs e)
        {
            Product_Add addproduct = new Product_Add();
            addproduct.prevForm = this;
            addproduct.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Category_Add addcategory = new Category_Add();
            addcategory.prevForm = this;
            addcategory.Show();
            this.Hide();
        }
    }
}
