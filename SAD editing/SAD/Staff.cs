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
            string query = "SELECT * FROM person , staff WHERE person.personid = staff.person_personid";

            conn.Open();

            MySqlCommand comm = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);

            conn.Close();

            DataTable dt = new DataTable();

            adp.Fill(dt);

            dtgv.DataSource = dt;
            dtgv.Columns["personid"].Visible = false;
            dtgv.Columns["staffid"].Visible = false;
            dtgv.Columns["person_type"].Visible = false;
            dtgv.Columns["person_personid"].Visible = false;
            dtgv.Columns["username"].Visible = false;
            dtgv.Columns["password"].Visible = false;

            dtgv.Columns["firstname"].HeaderText = "Firstname";
            dtgv.Columns["lastname"].HeaderText = "Lastname";
            dtgv.Columns["address"].HeaderText = "Address";
            dtgv.Columns["contact"].HeaderText = "Contact Number";
            dtgv.Columns["email"].HeaderText = "Email";
            dtgv.Columns["position"].HeaderText = "Position";
            dtgv.Columns["status"].HeaderText = "Status";
            dtgv.Columns["date_added"].HeaderText = "Date Added";
            dtgv.Columns["date_modified"].HeaderText = "Date Modified";
           

        }

        private void Staff_Load(object sender, EventArgs e)
        {
            loadAll();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Close();
        }
        
        private void show_add_Click(object sender, EventArgs e)
        {
            Staff_Add addStaff = new Staff_Add();
            addStaff.Show();
            addStaff.prevForm = this;      
            this.Hide();
        }
    }
}
