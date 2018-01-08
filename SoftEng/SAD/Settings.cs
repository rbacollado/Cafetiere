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
    public partial class Settings : Form
    {
        MySqlConnection conn;
        public Settings()
        {
            InitializeComponent();
            conn = new MySqlConnection("SERVER=localhost; DATABASE=Cafetiere; uid=root; pwd=root;");
        }
        public MainMenu prevForm { get; set; }

        private void btn_updateUser_Click(object sender, EventArgs e)
        {
            if (SAD.Login.DisplayUserDetails.username == txt_username.Text)
            {
                MessageBox.Show("Username did not change.", "Same Username", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_username.Clear();
            }
            else if (SAD.Login.DisplayUserDetails.usertype.ToLower() == "staff" && txt_username.Text.ToLower() == "admin")
            {
                MessageBox.Show("Sorry, you can't use this username.", "Confirm Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_username.Clear();
            }
            else
            {
                string q = "SELECT * FROM Staff WHERE username = '" + txt_username.Text + "';";
                conn.Open();
                MySqlCommand comm = new MySqlCommand(q, conn);
                comm.ExecuteNonQuery();
                conn.Close();
                DataTable dt = new DataTable();
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                adp.Fill(dt);


                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("Username Already Exist!", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    string query = "UPDATE Staff SET username = '" + txt_username.Text + "'WHERE staff_id = '" + SAD.Login.DisplayUserDetails.staff_id + "';";
                    conn.Open();
                    MySqlCommand comm2 = new MySqlCommand(query, conn);
                    comm2.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Username Updated!", "Update Username", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_username.Clear();

                }

            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Close();
        }

        private void btn_updatePass_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Staff " +
           "SET password = '" + txt_newpass.Text + "'WHERE staff_id = '" + SAD.Login.DisplayUserDetails.staff_id + "';";

            if (txt_oldpass.Text != SAD.Login.DisplayUserDetails.password)
            {
                MessageBox.Show("Incorrect Old Password!", "Confirm Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_oldpass.Clear();
                txt_newpass.Clear();
                txt_confpass.Clear();
            }
            else if (SAD.Login.DisplayUserDetails.password == txt_newpass.Text)
            {
                MessageBox.Show("Password did not change.", "Same Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_oldpass.Clear();
                txt_newpass.Clear();
                txt_confpass.Clear();
            }

            else if (txt_newpass.Text != txt_confpass.Text)
            {
                MessageBox.Show("The password confirmation does not match!", "Confirm Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_oldpass.Clear();
                txt_newpass.Clear();
                txt_confpass.Clear();
            }
            else
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand(query, conn);
                comm.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Password Updated!", "Update Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_username.Clear();
                txt_oldpass.Clear();
                txt_newpass.Clear();
                txt_confpass.Clear();
            }
        }
    }
}
