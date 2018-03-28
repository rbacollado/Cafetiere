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
    public partial class Product_Update : Form
    {
        MySqlConnection conn;

        public Form prevForm { get; set; }
        
        public Product_Update()
        {
            InitializeComponent();
            conn = new MySqlConnection("SERVER=localhost; DATABASE=Cafetiere; uid=root; pwd=root;");
            
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Close();
        }

        
        public int prodID = SAD.Product.selected_data.prodID;

        private void Product_Update_Load(object sender, EventArgs e)
        {
            String loadprodquery = "SELECT pname, pcategory, pprice, pcost FROM products " +
                                   "WHERE productID = " + prodID + ";";

            MySqlCommand loadprodcomm = new MySqlCommand(loadprodquery, conn);
            loadprodcomm.CommandText = loadprodquery;
            conn.Open();
            MySqlDataReader drd = loadprodcomm.ExecuteReader();

            while (drd.Read())
            {
                pname_txt.Text = drd["pname"].ToString();
                cmb_category.Text = drd["pcategory"].ToString();
                pprice_txt.Text = drd["pprice"].ToString();
                pcost_txt.Text = drd["pcost"].ToString();
                
            }
            conn.Close();
        }
        
        

        private void update_btn_Click_1(object sender, EventArgs e)
        {
            if (pname_txt.Text == "" || cmb_category.Text == "" || pprice_txt.Text == "" || pcost_txt.Text == "")
            {
                MessageBox.Show("Please Complete the Registration!", "Incomplete Registration", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string updateproduct = "UPDATE products SET pname = '" + pname_txt.Text + "', pcategory = '" + cmb_category.Text + "', pprice = '" + pprice_txt.Text + "', pcost = '" + pcost_txt.Text + "' " +
                                   "WHERE productID = " + prodID;

                conn.Open();
                MySqlCommand updatecomm = new MySqlCommand(updateproduct, conn);
                updatecomm.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Product updated!");

                this.Close();
                prevForm.ShowDialog();
            }
        }
    }
}
