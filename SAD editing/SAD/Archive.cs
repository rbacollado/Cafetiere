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
    public partial class Archive : Form
    {
        MySqlConnection conn;

        public Form prevForm { get; set; }

        public Archive()
        {
            InitializeComponent();
            conn = new MySqlConnection("SERVER=localhost; DATABASE=cafetiere; uid=root; pwd=root;");
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Close();
        }

        private void Archive_Load(object sender, EventArgs e)
        {
            staff();
            supplier();
        }

        public void staff()
        {
            string filterquery = "SELECT* FROM person , staff WHERE person.personid = staff.person_personid AND status = 'Inactive'";
            conn.Open();
            MySqlCommand comm = new MySqlCommand(filterquery, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable dt_filter = new DataTable();
            adp.Fill(dt_filter);

            staff_archive.DataSource = dt_filter;
            staff_archive.Columns["personid"].Visible = false;
            staff_archive.Columns["staffid"].Visible = false;
            staff_archive.Columns["person_type"].Visible = false;
            staff_archive.Columns["person_personid"].Visible = false;
            staff_archive.Columns["username"].Visible = false;
            staff_archive.Columns["password"].Visible = false;
            staff_archive.Columns["firstname"].HeaderText = "Firstname";
            staff_archive.Columns["lastname"].HeaderText = "Lastname";
            staff_archive.Columns["address"].HeaderText = "Address";
            staff_archive.Columns["contact"].HeaderText = "Contact Number";
            staff_archive.Columns["email"].HeaderText = "Email";
            staff_archive.Columns["position"].HeaderText = "Position";
            staff_archive.Columns["status"].HeaderText = "Status";
            staff_archive.Columns["date_added"].HeaderText = "Date Added";
            staff_archive.Columns["date_modified"].HeaderText = "Date Modified";
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

            supplier_archive.DataSource = dt_filter;
            supplier_archive.Columns["personid"].Visible = false;
            supplier_archive.Columns["supplierID"].Visible = false;
            supplier_archive.Columns["person_type"].Visible = false;
            supplier_archive.Columns["person_personid"].Visible = false;
            supplier_archive.Columns["firstname"].HeaderText = "Firstname";
            supplier_archive.Columns["lastname"].HeaderText = "Lastname";
            supplier_archive.Columns["address"].HeaderText = "Address";
            supplier_archive.Columns["contact"].HeaderText = "Contact Number";
            supplier_archive.Columns["email"].HeaderText = "Email";
            supplier_archive.Columns["organization"].HeaderText = "Organization";
            supplier_archive.Columns["status"].HeaderText = "Status";
            supplier_archive.Columns["date_added"].HeaderText = "Date Added";
            supplier_archive.Columns["date_modified"].HeaderText = "Date Modified";
        }

        private void staff_archive_SelectionChanged(object sender, EventArgs e)
        {
            this.staff_archive.ClearSelection();
        }

        private void supplier_archive_SelectionChanged(object sender, EventArgs e)
        {
            this.supplier_archive.ClearSelection();
        }
    }
}
