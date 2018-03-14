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
    public partial class Category_Add : Form
    {
        MySqlConnection conn;
        public Form prevForm { get; set; }
        public Category_Add()
        {
            InitializeComponent();
            conn = new MySqlConnection("SERVER=localhost; DATABASE=Cafetiere; uid=root; pwd=root;");
        }

        private void Category_Add_Load(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_cname.Text == "")
            {
                MessageBox.Show("Nothing to Add!", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                string q = "SELECT category_name FROM category WHERE category_name = '" + txt_cname.Text + "';";
                conn.Open();
                MySqlCommand comm = new MySqlCommand(q, conn);
                comm.ExecuteNonQuery();
                conn.Close();
                DataTable dt = new DataTable();
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                adp.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("Category Already Exist!", "Duplicate Category", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    string query = "INSERT INTO Category(category_name)" + " VALUES('" + txt_cname.Text + "');";
                    conn.Open();
                    MySqlCommand comm2 = new MySqlCommand(query, conn);
                    comm2.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Category added!");

                    this.Close();
                    prevForm.ShowDialog();
                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {

        }
    }
}
