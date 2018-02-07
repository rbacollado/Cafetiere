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

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_pname.Text == "" || txt_pprice.Text == "" || nud_pquantity.Text == "" || txt_pcost.Text == "")
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
                    string query = "INSERT INTO Products(pname, pprice, pstatus, pquantity, pcost)" + 
                                   " VALUES('" + txt_pname.Text + "','" + txt_pprice.Text + "', 'Available' ,'" + nud_pquantity.Text + "','" + txt_pcost.Text + "')";
                    conn.Open();
                    MySqlCommand comm2 = new MySqlCommand(query, conn);
                    comm2.ExecuteNonQuery();
                    conn.Close();
                    
                }
            }
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
    }
}
