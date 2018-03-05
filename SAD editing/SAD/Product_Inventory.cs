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
        }

        private void Product_Inventory_Load(object sender, EventArgs e)
        {
            loadprodInv();
            loadQTY();
            qtypanel.Visible = false;
            btn_add.Enabled = false;
            btn_add.BackColor = Color.Gray;
        }

        private void loadprodInv()
        {
            string query = "SELECT prodInv_id, pname, pcategory, prodQuantity, product_status FROM products, product_inventory " + 
                           " WHERE products.productID = product_inventory.product_ID";

            conn.Open();

            MySqlCommand comm = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);

            conn.Close();

            DataTable dt = new DataTable();

            adp.Fill(dt);

            prodInv.DataSource = dt;
            prodInv.Columns["prodInv_id"].Visible = false;
            prodInv.Columns["pname"].HeaderText = "Name";
            prodInv.Columns["pcategory"].HeaderText = "Category";
            prodInv.Columns["prodQuantity"].HeaderText = "Quantity";
            prodInv.Columns["product_status"].HeaderText = "Status";

            prodInv.Columns[0].Width = 50;
            prodInv.Columns[1].Width = 150;
            prodInv.Columns[2].Width = 120;
            prodInv.Columns[3].Width = 135;
            prodInv.Columns[4].Width = 110;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            qtypanel.Visible = true;
        }

        private void updateqty_Click(object sender, EventArgs e)
        {
            String updateqty = "UPDATE product_inventory SET prodQuantity = " + nud_prodqty.Value;
            conn.Open();
            MySqlCommand comm = new MySqlCommand(updateqty, conn);
            comm.ExecuteNonQuery();
            conn.Close();

            if (nud_prodqty.Value > 0)
            {
                String updateStatus = "UPDATE product_inventory SET product_status = 'Available'";
                conn.Open();
                MySqlCommand comm_status = new MySqlCommand(updateStatus, conn);
                comm_status.ExecuteNonQuery();
                conn.Close();
            }
            else if (nud_prodqty.Value == 0)
            {
                String updateStatus = "UPDATE product_inventory SET product_status = 'Not Available'";
                conn.Open();
                MySqlCommand comm_status = new MySqlCommand(updateStatus, conn);
                comm_status.ExecuteNonQuery();
                conn.Close();
            }

            MessageBox.Show("Quantity updated!");
            qtypanel.Visible = false;
            loadprodInv();
        }

        public static int prodInvID;
        private void prodInv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int selected_id = int.Parse(prodInv.Rows[e.RowIndex].Cells["prodInv_id"].Value.ToString());
                prodInvID = selected_id;

                nud_prodqty.Text = prodInv.Rows[e.RowIndex].Cells["prodQuantity"].Value.ToString();
                btn_add.Enabled = true;
                btn_add.BackColor = Color.Gold;
                loadQTY();
            }
        }

        public void loadQTY()
        {
            String prodInvquery = "SELECT prodQuantity FROM product_inventory WHERE prodInv_id = " + prodInvID;

            MySqlCommand comm = new MySqlCommand(prodInvquery, conn);
            comm.CommandText = prodInvquery;

            conn.Open();
            MySqlDataReader drdInv = comm.ExecuteReader();

            while (drdInv.Read())
            {

                nud_prodqty.Text = (drdInv["prodQuantity"].ToString());

            }
            conn.Close();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Close();
        }
    }
}
