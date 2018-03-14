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
    public partial class Staff_Add : Form
    {
        MySqlConnection conn;
        public Form prevForm { get; set; }

        public Staff_Add()
        {
            InitializeComponent();
            conn = new MySqlConnection("SERVER=localhost; DATABASE=Cafetiere; uid=root; pwd=root;");
        }

        private void Staff_Add_Load(object sender, EventArgs e)
        {

        }

       


        private void Back_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Close();
        }

        private void btn_add_Click_1(object sender, EventArgs e)
        {
            if (txt_fname.Text == "" || txt_lname.Text == "" || txt_address.Text == "" || mtxt_contact.Text == "" || cb_usertype.Text == "" || txt_username.Text == "" || txt_pass.Text == "")
            {
                MessageBox.Show("Please Complete the Registration!", "Incomplete Registration", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cb_usertype.Text.ToLower() == "staff" && txt_username.Text.ToLower() == "admin")
            {
                MessageBox.Show("Sorry, you can't use this username.", "Confirm Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_pass.Text != txt_confpass.Text)
            {
                MessageBox.Show("The password confirmation does not match!", "Confirm Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string query = "INSERT INTO person(firstname, lastname, address, contact, email, person_type)"
                    + "VALUES('" + txt_fname.Text + "','" + txt_lname.Text + "','" + txt_address.Text + "','" + mtxt_contact.Text + "','" + txt_email.Text + "','STAFF')";

                string query1 = "INSERT INTO staff (person_personid, position, username, password, status, date_added, date_modified)" +
                                "VALUES( (SELECT MAX(personid) from person) ,'" + cb_usertype.Text + "','" + txt_username.Text + "','" + txt_pass.Text + "','Active', current_timestamp(), current_timestamp() )";
                conn.Open();
                MySqlCommand comm = new MySqlCommand(query, conn);
                comm.ExecuteNonQuery();

                MySqlCommand comm1 = new MySqlCommand(query1, conn);
                comm1.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Staff added!");

                this.Close();
                prevForm.ShowDialog();

            }
        }

        private void btn_clear_Click_1(object sender, EventArgs e)
        {
            txt_fname.Clear();
            txt_lname.Clear();
            txt_address.Clear();
            mtxt_contact.Clear();
            cb_usertype.Text = "";
            txt_username.Clear();
            txt_pass.Clear();
            txt_confpass.Clear();
            txt_username.Enabled = true;
            txt_username.BackColor = Color.White;
            txt_pass.Enabled = true;
            txt_pass.BackColor = Color.White;
            txt_confpass.Enabled = true;
            txt_confpass.BackColor = Color.White;
            btn_add.Enabled = true;
            btn_add.BackColor = Color.PaleGreen;
        }
    }
}
