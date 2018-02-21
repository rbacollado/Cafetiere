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
    public partial class Staff_Update : Form
    {
        MySqlConnection conn;
        public Form prevForm { get; set; }

        public Staff_Update()
        {
            InitializeComponent();
            conn = new MySqlConnection("SERVER=localhost; DATABASE=Cafetiere; uid=root; pwd=root;");
        }

        private void Staff_Update_Load(object sender, EventArgs e)
        {
            String query = "SELECT firstname, lastname, address, contact, email, position, username, password, status FROM person, staff " + 
                            "WHERE person.personid = staff.person_personid AND personid = " + staffid ;
           
            MySqlCommand comm = new MySqlCommand(query, conn);
            comm.CommandText = query;
            conn.Open();
            MySqlDataReader drd = comm.ExecuteReader();

            while (drd.Read())
            {
                txt_fname.Text = (drd["firstname"].ToString());
                txt_lname.Text = (drd["lastname"].ToString());
                txt_address.Text = (drd["address"].ToString());
                mtxt_contact.Text = (drd["contact"].ToString());
                txt_email.Text = (drd["email"].ToString());
                cb_usertype.Text = (drd["position"].ToString());
                txt_username.Text = (drd["username"].ToString());
                txt_pass.Text = (drd["password"].ToString());

                if ((drd["status"].ToString()) == "Active")
                {
                    status.Checked = true;

                }
                else if ((drd["status"].ToString()) == "Inactive")
                {
                    status.Checked = false;
                }
            }
            conn.Close();
            
        }

        private void Back_Click(object sender, EventArgs e)
        {
            prevForm.ShowDialog();
            this.Close();
        }

        public int staffid = SAD.Staff.selected_data.selected_user_id;

        private void update_staff_Click(object sender, EventArgs e)
        {
            if (txt_fname.Text == "" || txt_lname.Text == "" || txt_address.Text == "" || mtxt_contact.Text == "" || cb_usertype.Text == "" || txt_username.Text == "" || txt_pass.Text == "")
            {
                MessageBox.Show("Please Complete the Registration!", "Incomplete Registration", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cb_usertype.Text.ToLower() == "staff" && txt_username.Text.ToLower() == "admin")
            {
                MessageBox.Show("Sorry, you can't use this username.", "Confirm Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string statusval = "Inactive";

                if (status.Checked == true)
                {
                    statusval = "Active";
                }
                else
                {
                    statusval = "Inactive";
                }


                string query = "UPDATE person set firstname = '" + txt_fname.Text + "', lastname = '"+ txt_lname.Text + "', address = '" + txt_address.Text 
                                + "', contact = '" + mtxt_contact.Text + "', email = '" + txt_email.Text + "' WHERE personid = " + staffid ;

                string query1 = "UPDATE staff set position = '" + cb_usertype.Text + "', username = '" + txt_username.Text + "', password = '" + txt_pass.Text
                                + "', status = '" +  statusval + "', date_modified = current_timestamp() WHERE person_personid = " + staffid ;

                conn.Open();
                MySqlCommand comm = new MySqlCommand(query, conn);
                comm.ExecuteNonQuery();

                MySqlCommand comm1 = new MySqlCommand(query1, conn);
                comm1.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Staff updated!");

                this.Close();
                prevForm.ShowDialog();

            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_fname.Clear();
            txt_lname.Clear();
            txt_address.Clear();
            mtxt_contact.Clear();
            cb_usertype.Text = "";
            txt_username.Clear();
            txt_pass.Clear();
            
            txt_username.Enabled = true;
            txt_username.BackColor = Color.White;
            txt_pass.Enabled = true;
            txt_pass.BackColor = Color.White;
          
        }
    }
}
