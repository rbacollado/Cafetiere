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
    public partial class Reports : Form
    {
        MySqlConnection conn;

        public MainMenu prevForm { get; set; }

        public Reports()
        {
            InitializeComponent();
            conn = new MySqlConnection("SERVER=localhost; DATABASE=cafetiere; uid=root; pwd=root;");

            salesLoad();
        }

        private void salesLoad()
        {
            string query = "SELECT concat(firstname, ' ',lastname) as Staffname, orderDate, orderTotal, orderType FROM person " +
                           "INNER JOIN staff ON person.personid = staff.person_personid " +
                           "INNER JOIN `order` ON staff.staffid = `order`.staff_staffid " +
                           "INNER JOIN orderline ON `order`.orderID = orderline.orderID ";

            conn.Open();

            MySqlCommand comm = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);

            conn.Close();

            DataTable dt = new DataTable();

            adp.Fill(dt);

            sales.DataSource = dt;
            sales.Columns["StaffName"].HeaderText = "Staff";
            sales.Columns["orderDate"].HeaderText = "Sales Date";
            sales.Columns["orderTotal"].HeaderText = "Sales Total";
            sales.Columns["orderType"].HeaderText = "Sales Type";

            sales.Columns["StaffName"].Width = 100;
            sales.Columns["orderDate"].Width = 150;
            sales.Columns["orderTotal"].Width = 120;
            sales.Columns["orderType"].Width = 130;


        }

        private void Reports_Load(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Close();
        }
    }
}
