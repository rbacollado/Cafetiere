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
        }


        private void Back_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Close();
        }

        

        private void txt_pcost_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && txt_pcost.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txt_pprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && txt_pprice.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click_1(object sender, EventArgs e)
        {
            if (txt_pname.Text == "" || cb_category.Text == "" || txt_pprice.Text == "" || nud_pquantity.Text == "" || txt_pcost.Text == "")
            {
                MessageBox.Show("Please Complete the Product Information!", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                string q = "SELECT pname FROM Products WHERE pname = '" + txt_pname.Text + "';";
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
                    string query = "INSERT INTO Products(pname, pcategory, pprice, pstatus, pquantity, pcost, category_category_id)" + " VALUES('" + txt_pname.Text + "','" + cb_category.Text + "','" + txt_pprice.Text + "', 'Available' ,'" + nud_pquantity.Text + "','" + txt_pcost.Text + "', (select max(category_id) from category))";
                    conn.Open();
                    MySqlCommand comm2 = new MySqlCommand(query, conn);
                    comm2.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Product added!");

                    this.Close();
                    prevForm.ShowDialog();

                }
            }
        }

        

        private void Product_Add_Load(object sender, EventArgs e)
        {
            categoryCmbData();
        }

        private void txt_pprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_pprice_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && txt_pprice.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txt_pcost_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && txt_pcost.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        public void categoryCmbData()
        {
            cb_category.Items.Clear();
            string query = "SELECT category_id, category_name FROM category";
            cb_category.DataSource = getData(query);
            cb_category.DisplayMember = "category_name";
            cb_category.ValueMember = "category_id";

            cb_category_SelectedIndexChanged(null, null);
        }

        public DataTable getData(string query)
        {
            MySqlCommand comm = new MySqlCommand(query, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(comm);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        private void cb_category_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
