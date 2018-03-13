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
    public partial class Staff_Archive : Form
    {

        MySqlConnection conn;

        public Form prevForm { get; set; }

        public Staff_Archive()
        {
            InitializeComponent();
            conn = new MySqlConnection("SERVER=localhost; DATABASE=cafetiere; uid=root; pwd=root;");
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Close();
        }

        private void Staff_Archive_Load(object sender, EventArgs e)
        {
            staff();
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

            archive_staff.DataSource = dt_filter;
            archive_staff.Columns["personid"].Visible = false;
            archive_staff.Columns["staffid"].Visible = false;
            archive_staff.Columns["person_type"].Visible = false;
            archive_staff.Columns["person_personid"].Visible = false;
            archive_staff.Columns["username"].Visible = false;
            archive_staff.Columns["password"].Visible = false;
            archive_staff.Columns["firstname"].HeaderText = "Firstname";
            archive_staff.Columns["lastname"].HeaderText = "Lastname";
            archive_staff.Columns["address"].HeaderText = "Address";
            archive_staff.Columns["contact"].HeaderText = "Contact Number";
            archive_staff.Columns["email"].HeaderText = "Email";
            archive_staff.Columns["position"].HeaderText = "Position";
            archive_staff.Columns["status"].HeaderText = "Status";
            archive_staff.Columns["date_added"].HeaderText = "Date Added";
            archive_staff.Columns["date_modified"].HeaderText = "Date Modified";
        }

        private void archive_staff_SelectionChanged(object sender, EventArgs e)
        {
            this.archive_staff.ClearSelection();
        }
    }
}
