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
    public partial class Supplier_Update : Form
    {
        MySqlConnection conn;
        public Form prevForm { get; set; }

        public Supplier_Update()
        {
            InitializeComponent();
            conn = new MySqlConnection("SERVER=localhost; DATABASE=Cafetiere; uid=root; pwd=root;");
        }

        private void Back_Click(object sender, EventArgs e)
        {
            prevForm.ShowDialog();
            this.Close();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_fname.Clear();
            txt_lname.Clear();
            txt_address.Clear();
            mtxt_contact.Clear();
            txt_organization.Clear();
        }

        public int supplierid = SAD.Supplier.selected_data.selected_user_id;

        private void Supplier_Update_Load(object sender, EventArgs e)
        {
            String query = "SELECT firstname, lastname, address, contact, email, organization, status FROM person, supplier " +
                            "WHERE person.personid = supplier.person_personid AND personid = " + supplierid;

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
                txt_organization.Text = (drd["organization"].ToString());

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

        private void update_supplier_Click(object sender, EventArgs e)
        {
            if (txt_fname.Text == "" || txt_lname.Text == "" || txt_address.Text == "" || mtxt_contact.Text == "" || txt_organization.Text == "")
            {
                MessageBox.Show("Please Complete the Registration!", "Incomplete Registration", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                string query = "UPDATE person set firstname = '" + txt_fname.Text + "', lastname = '" + txt_lname.Text + "', address = '" + txt_address.Text
                                + "', contact = '" + mtxt_contact.Text + "', email = '" + txt_email.Text + "' WHERE personid = " + supplierid;

                string query1 = "UPDATE supplier set organization = '" + txt_organization.Text + "',status = '" + statusval + "', date_modified = current_timestamp() WHERE person_personid = " + supplierid;

                conn.Open();
                MySqlCommand comm = new MySqlCommand(query, conn);
                comm.ExecuteNonQuery();

                MySqlCommand comm1 = new MySqlCommand(query1, conn);
                comm1.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Supplier updated!");

                this.Close();
                prevForm.ShowDialog();

            }
        }
    }
}
