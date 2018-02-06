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

        public Form prevForm { get; set; }

        public Staff()
        {
            InitializeComponent();
            conn = new MySqlConnection("SERVER=localhost; DATABASE=Cafetiere; uid=root; pwd=root;");
        }

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

        private void staff_add_Click(object sender, EventArgs e)
        {
            Staff_Add addstaff = new Staff_Add();
            addstaff.prevForm = this;
            addstaff.Show();
            this.Hide();
        }

        public class selected_data
        {
            public static int selected_user_id;
        }
        
        private void dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int selected_id = int.Parse(dtgv.Rows[e.RowIndex].Cells["personid"].Value.ToString());
                selected_data.selected_user_id = selected_id;
            }

            string query = "SELECT firstname, lastname, orderDate, orderType FROM person " +
                            "INNER JOIN staff ON person.personid = staff.person_personid " +
                            "INNER JOIN `order` ON staff.staffid = `order`.staff_staffid " +
                            "INNER JOIN orderline ON `order`.orderID = orderline.orderID " +
                            "WHERE personid = " + selected_data.selected_user_id + " ";
            conn.Open();
            MySqlCommand comm = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);
            records.DataSource = dt;

        }

        private void staff_update_Click(object sender, EventArgs e)
        {
            Staff_Update updatestaff = new Staff_Update();
            updatestaff.prevForm = this;
            updatestaff.Show();
            this.Hide();
        }

        private void staff_view_Click(object sender, EventArgs e)
        {
            Staff_View viewstaff = new Staff_View();
            viewstaff.prevForm = this;
            viewstaff.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
