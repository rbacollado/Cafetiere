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
    public partial class Login : Form
    {
        MySqlConnection conn;

        public class DisplayUserDetails
        {
            public static int staff_id;
            public static string name;
            public static string usertype;
            public static string username;
            public static string password;
        }

        public Login()
        {
            InitializeComponent();
            conn = new MySqlConnection("SERVER=localhost; DATABASE=Cafetiere; uid=root; pwd=root;");
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string user = txt_user.Text;
            string pass = txt_pass.Text;
            string query = "SELECT * FROM Staff WHERE username = '" + user + "' AND password = '" + pass + "'";
            conn.Open();

            MySqlCommand comm = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);

            conn.Close();

            DataTable dt = new DataTable();

            adp.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                int id = int.Parse(dt.Rows[0][0].ToString());
                string fname = dt.Rows[0][1].ToString();
                string lname = dt.Rows[0][2].ToString();
                string usertype = dt.Rows[0][5].ToString();
                string username = dt.Rows[0][6].ToString();
                string password = dt.Rows[0][7].ToString();

                DisplayUserDetails.staff_id = id;
                DisplayUserDetails.name = lname + ", " + fname;
                DisplayUserDetails.usertype = usertype;
                DisplayUserDetails.username = username;
                DisplayUserDetails.password = password;

                MessageBox.Show("Welcome " + lname + ", " + fname + "!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainMenu mainmenu = new MainMenu();
                mainmenu.prevForm = this;
                mainmenu.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Wrong Username/Password", "Invalid Credentials!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txt_user.Clear();
            txt_pass.Clear();
        }
    

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
