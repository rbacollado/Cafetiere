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
    public partial class Supplier_Add : Form
    {
        MySqlConnection conn;
        public Form prevForm { get; set; }

        public Supplier_Add()
        {
            InitializeComponent();
            conn = new MySqlConnection("SERVER=localhost; DATABASE=Cafetiere; uid=root; pwd=root;");
        }

        
       
        private void Back_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Close();
        }

        private void btn_add_Click_1(object sender, EventArgs e)
        {
            if (txt_fname.Text == "" || txt_lname.Text == "" || txt_address.Text == "" || mtxt_contact.Text == "" || txt_organization.Text == "")
            {
                MessageBox.Show("Please Complete the Registration!", "Incomplete Registration", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string query = "INSERT INTO person(firstname, lastname, address, contact, email, person_type)"
                    + "VALUES('" + txt_fname.Text + "','" + txt_lname.Text + "','" + txt_address.Text + "','" + mtxt_contact.Text + "','" + txt_email.Text + "','SUPPLIER')";

                string query1 = "INSERT INTO supplier (person_personid, organization, status, date_added, date_modified)" +
                                "VALUES( (SELECT MAX(personid) from person) ,'" + txt_organization.Text + "', 'Active', current_timestamp(), current_timestamp() )";
                conn.Open();
                MySqlCommand comm = new MySqlCommand(query, conn);
                comm.ExecuteNonQuery();

                MySqlCommand comm1 = new MySqlCommand(query1, conn);
                comm1.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Supplier added!");

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
            txt_organization.Clear();
        }
    }
}
