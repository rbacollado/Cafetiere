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
    public partial class Supplier : Form
    {
        MySqlConnection conn;
        public Profiling prevForm { get; set; }

        public Supplier()
        {
            InitializeComponent();
            conn = new MySqlConnection("SERVER=localhost; DATABASE=Cafetiere; uid=root; pwd=root;");
        }

        private void loadAll()
        {
            string query = "SELECT * FROM Supplier";

            conn.Open();

            MySqlCommand comm = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);

            conn.Close();

            DataTable dt = new DataTable();

            adp.Fill(dt);

            dtgv.DataSource = dt;
            dtgv.Columns["supplierID"].Visible = false;
            dtgv.Columns["firstname"].HeaderText = "Firstname";
            dtgv.Columns["lastname"].HeaderText = "Lastname";
            dtgv.Columns["address"].HeaderText = "Address";
            dtgv.Columns["contact"].HeaderText = "Contact Number";
            dtgv.Columns["organization"].HeaderText = "Organiztion";
            dtgv.Columns["status"].HeaderText = "Status";
            dtgv.Columns["date_added"].HeaderText = "Date Added";
            dtgv.Columns["date_modified"].HeaderText = "Date Modified";
            dtgv.Columns["date_added"].Width = 135;
            dtgv.Columns["date_modified"].Width = 135;

        }

        private void Back_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_fname.Text == "" || txt_lname.Text == "" || txt_address.Text == "" || mtxt_contact.Text == "" || txt_org.Text == "" || cb_userstatus.Text == "")
            {
                MessageBox.Show("Please Complete the Registration!", "Incomplete Registration", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string query = "INSERT INTO Supplier" +
                "(firstname, lastname, address, contact, organization, status, date_added, date_modified)" + " VALUES('" + txt_fname.Text + "','" + txt_lname.Text + "','" + txt_address.Text + "','" + mtxt_contact.Text + "','" + txt_org.Text + "','" + cb_userstatus.Text + "', current_timestamp(), current_timestamp())";
                conn.Open();
                MySqlCommand comm = new MySqlCommand(query, conn);
                comm.ExecuteNonQuery();
                conn.Close();
                loadAll();
            }
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            loadAll();
            btn_update.Enabled = false;
            btn_update.BackColor = Color.Gray;
        }

        private int selected_supplier_id;

        private void dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                selected_supplier_id = int.Parse(dtgv.Rows[e.RowIndex].Cells["supplierID"].Value.ToString());
                txt_fname.Text = dtgv.Rows[e.RowIndex].Cells["firstname"].Value.ToString();
                txt_lname.Text = dtgv.Rows[e.RowIndex].Cells["lastname"].Value.ToString();
                txt_address.Text = dtgv.Rows[e.RowIndex].Cells["address"].Value.ToString();
                mtxt_contact.Text = dtgv.Rows[e.RowIndex].Cells["contact"].Value.ToString();
                txt_org.Text = dtgv.Rows[e.RowIndex].Cells["organization"].Value.ToString();
                cb_userstatus.Text = dtgv.Rows[e.RowIndex].Cells["status"].Value.ToString();
                btn_add.Enabled = false;
                btn_update.Enabled = true;
                btn_update.BackColor = Color.Gold;
                btn_add.BackColor = Color.Gray;
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "UPDATE Supplier " +
                               "SET firstname = '" + txt_fname.Text + "'," + "lastname = '" + txt_lname.Text + "', " +
                               "address = '" + txt_address.Text + "', " + "contact = '" + mtxt_contact.Text + "', " + "organization = '" + txt_org.Text + "', " +
                                "status = '" + cb_userstatus.Text + "', " + "date_modified = current_timestamp() WHERE supplierID = '" + selected_supplier_id + "';";

                conn.Open();
                MySqlCommand comm = new MySqlCommand(query, conn);
                comm.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Supplier Updated!", "Update Supplier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadAll();
            }
            catch (Exception)
            {
                //MessageBox.Show("An error has occured. Please Try Again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_fname.Clear();
            txt_lname.Clear();
            txt_address.Clear();
            mtxt_contact.Clear();
            txt_org.Clear();
            btn_add.Enabled = true;
            btn_update.Enabled = false;
            btn_update.BackColor = Color.Gray;
            btn_add.BackColor = Color.PaleGreen;
        }

    }
}
