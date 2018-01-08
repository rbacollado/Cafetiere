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
    public partial class Staff : Form
    {
        MySqlConnection conn;
        public Staff()
        {
            InitializeComponent();
            conn = new MySqlConnection("SERVER=localhost; DATABASE=Cafetiere; uid=root; pwd=root;");
        }
        public Profiling prevForm { get; set; }

        private void loadAll()
        {
            string query = "SELECT * FROM Staff";

            conn.Open();

            MySqlCommand comm = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);

            conn.Close();

            DataTable dt = new DataTable();

            adp.Fill(dt);

            dtgv.DataSource = dt;
            dtgv.Columns["staff_id"].Visible = false;
            dtgv.Columns["firstname"].HeaderText = "Firstname";
            dtgv.Columns["lastname"].HeaderText = "Lastname";
            dtgv.Columns["address"].HeaderText = "Address";
            dtgv.Columns["contact"].HeaderText = "Contact Number";
            dtgv.Columns["username"].Visible = false;
            dtgv.Columns["password"].Visible = false;
            dtgv.Columns["usertype"].HeaderText = "User Type";
            dtgv.Columns["userstatus"].Visible = false;
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            loadAll();
            btn_update.Enabled = false;
            btn_update.BackColor = Color.Gray;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Staff" +
                "(firstname, lastname, address, contact, usertype, username, password, userstatus)" + " VALUES('" + txt_fname.Text + "','" + txt_lname.Text + "','" + txt_address.Text + "','" + mtxt_contact.Text + "','" + cb_usertype.Text + "','" + txt_username.Text + "','" + txt_pass.Text + "', 'Active')";
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
                conn.Open();
                MySqlCommand comm = new MySqlCommand(query, conn);
                comm.ExecuteNonQuery();
                conn.Close();
                loadAll();
            }

        }
        private int selected_staff_id;

        private void dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex > -1)
            {
                selected_staff_id = int.Parse(dtgv.Rows[e.RowIndex].Cells["staff_id"].Value.ToString());
                txt_fname.Text = dtgv.Rows[e.RowIndex].Cells["firstname"].Value.ToString();
                txt_lname.Text = dtgv.Rows[e.RowIndex].Cells["lastname"].Value.ToString();
                txt_address.Text = dtgv.Rows[e.RowIndex].Cells["address"].Value.ToString();
                mtxt_contact.Text = dtgv.Rows[e.RowIndex].Cells["contact"].Value.ToString();
                cb_usertype.Text = dtgv.Rows[e.RowIndex].Cells["usertype"].Value.ToString();
                txt_username.Clear();
                txt_username.Enabled = false;
                txt_username.BackColor = Color.Gray;
                txt_pass.Clear();
                txt_pass.BackColor = Color.Gray;
                txt_pass.Enabled = false;
                txt_confpass.Clear();
                txt_confpass.BackColor = Color.Gray;
                txt_confpass.Enabled = false;
                btn_add.Enabled = false;
                btn_update.Enabled = true;
                btn_update.BackColor = Color.Gold;
                btn_add.BackColor = Color.Gray;
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Staff " +
               "SET firstname = '" + txt_fname.Text + "'," + "lastname = '" + txt_lname.Text + "', " + 
               "address = '" + txt_address.Text + "', " + "contact = '" + mtxt_contact.Text + "', " + "usertype = '" + cb_usertype.Text +
               "' WHERE staff_id = '" + selected_staff_id + "';";



            conn.Open();
            MySqlCommand comm = new MySqlCommand(query, conn);
            comm.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("User Updated!", "Update User", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadAll();
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
            txt_confpass.Clear();
            txt_username.Enabled = true;
            txt_username.BackColor = Color.White;
            txt_pass.Enabled = true;
            txt_pass.BackColor = Color.White;
            txt_confpass.Enabled = true;
            txt_confpass.BackColor = Color.White;
            btn_add.Enabled = true;
            btn_update.Enabled = false;
            btn_update.BackColor = Color.Gray;
            btn_add.BackColor = Color.PaleGreen;
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Staff " +
              "WHERE staff_id = '" + selected_staff_id + "';";

            conn.Open();
            MySqlCommand comm = new MySqlCommand(query, conn);
            comm.ExecuteNonQuery();
            conn.Close();

            loadAll();
        }
    }
}
