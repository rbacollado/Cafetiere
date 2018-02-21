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
    public partial class Item_Add : Form
    {
        MySqlConnection conn;

        public Form prevForm { get; set; }

        public Item_Add()
        {
            InitializeComponent();
            conn = new MySqlConnection("SERVER=localhost; DATABASE=cafetiere; uid=root; pwd=root;");
        }


        public static int form;
        private void Item_Add_Load(object sender, EventArgs e)
        {
            
        }

     
        private void btn_close_Click_1(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (name.Text == "" || price.Text == "" || unit.Text == ""  )
            {
                MessageBox.Show("Please fill up all fields", "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                int amount1 = 0;
                if (amount.Text == "")
                {
                    amount1 = 0;
                }
                else
                {
                    amount1 = int.Parse(amount.Text);
                }

                string expirable1;

                if (expirable.Checked == true)
                {
                    expirable1 = "ye";
                }
                else
                {
                    expirable1 = "no";

                }

                string itemaddquery = "INSERT INTO items(name,price,unit,amount,expirable,date_added,date_modified)" +
                               "VALUES('" + name.Text + "','" + price.Text + "','" + unit.Text + "','" + amount1 + "','" + expirable1 + "', current_timestamp(),current_timestamp())";
                conn.Open();
                MySqlCommand comm = new MySqlCommand(itemaddquery, conn);
                comm.ExecuteNonQuery();
                MessageBox.Show("item added");
                conn.Close();
                this.Close();
                prevForm.ShowDialog();

                /*if (form == 1)
                {
                    prevForm.ShowDialog();
                }
                else
                {
                    prevForm.Show();
                }*/
            }
        }

      
    }
}
