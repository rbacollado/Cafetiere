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
    public partial class Supplier_Archive : Form
    {

        MySqlConnection conn;

        public Form prevForm { get; set; }

        public Supplier_Archive()
        {
            InitializeComponent();
            conn = new MySqlConnection("SERVER=localhost; DATABASE=cafetiere; uid=root; pwd=root;");
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Close();
        }

        private void Supplier_Archive_Load(object sender, EventArgs e)
        {
            supplier();
        }
        public void supplier()
        {
            string filterquery = "SELECT* FROM person , supplier WHERE person.personid = supplier.person_personid AND status = 'Inactive'";
            conn.Open();
            MySqlCommand comm = new MySqlCommand(filterquery, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable dt_filter = new DataTable();
            adp.Fill(dt_filter);

            archive_supplier.DataSource = dt_filter;
            archive_supplier.Columns["personid"].Visible = false;
            archive_supplier.Columns["supplierID"].Visible = false;
            archive_supplier.Columns["person_type"].Visible = false;
            archive_supplier.Columns["person_personid"].Visible = false;
            archive_supplier.Columns["firstname"].HeaderText = "Firstname";
            archive_supplier.Columns["lastname"].HeaderText = "Lastname";
            archive_supplier.Columns["address"].HeaderText = "Address";
            archive_supplier.Columns["contact"].HeaderText = "Contact Number";
            archive_supplier.Columns["email"].HeaderText = "Email";
            archive_supplier.Columns["organization"].HeaderText = "Organization";
            archive_supplier.Columns["status"].HeaderText = "Status";
            archive_supplier.Columns["date_added"].HeaderText = "Date Added";
            archive_supplier.Columns["date_modified"].HeaderText = "Date Modified";
        }

        public static int supplierid;
        private void archive_supplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int selected_id = int.Parse(archive_supplier.Rows[e.RowIndex].Cells["supplierID"].Value.ToString());
                supplierid = selected_id;
            }
        }

        private void restore_Click(object sender, EventArgs e)
        {
            string updateStaffStatus = "UPDATE supplier SET status = 'Active' WHERE staffid = " + supplierid + ";";

            conn.Open();
            MySqlCommand comm_status = new MySqlCommand(updateStaffStatus, conn);
            comm_status.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Profile Restored!");

            prevForm.Show();
            this.Close();
        }

        
    }
}
