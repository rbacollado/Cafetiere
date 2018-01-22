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
            btn_update.Enabled = false;
            btn_update.BackColor = Color.Gray;
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
            dtgv.Columns["pname"].HeaderText = "Product Name";
            dtgv.Columns["pprice"].HeaderText = "Product Price (₱)";
            dtgv.Columns["pstatus"].HeaderText = "Availability";
            dtgv.Columns["pquantity"].HeaderText = "Product Quantity";
            dtgv.Columns["pcost"].HeaderText = "Product Cost";
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
                    string query = "INSERT INTO Products(pname, pprice, pstatus, pquantity, pcost)" + " VALUES('" + txt_pname.Text + "','" + txt_pprice.Text + "', 'Available' ,'" + nud_pquantity.Text + "','" + txt_pcost.Text + "')";
                    conn.Open();
                    MySqlCommand comm2 = new MySqlCommand(query, conn);
                    comm2.ExecuteNonQuery();
                    conn.Close();
                    loadAll();
                }
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Products SET pname = '" + txt_pname.Text + "'," + "pprice = '" + txt_pprice.Text + "'," + "pquantity = '" + nud_pquantity.Text + "'," + "pcost = '" + txt_pcost.Text + "'," + " WHERE productID = '" + selected_product_id + "';";
            conn.Open();
            MySqlCommand comm2 = new MySqlCommand(query, conn);
            comm2.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Product Updated!", "Update Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadAll();
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

        private int selected_product_id;
        private void dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
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
        }
    }
}
