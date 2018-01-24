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
            string query = "SELECT orderID, concat(firstname, ' ', lastname) as StaffName , orderDate, orderTotal, orderDiscount FROM `order`, staff WHERE `order`.order_staff_id = staff.staff_id";

            conn.Open();

            MySqlCommand comm = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);

            conn.Close();

            DataTable dt = new DataTable();

            adp.Fill(dt);

            sales.DataSource = dt;
            sales.Columns["orderID"].Visible = false;
            sales.Columns["StaffName"].HeaderText = "Staff";
            sales.Columns["orderDate"].HeaderText = "Sales Date";
            sales.Columns["orderTotal"].HeaderText = "Sales Total";
            sales.Columns["orderDiscount"].HeaderText = "Discount";

            sales.Columns["StaffName"].Width = 100;
            sales.Columns["orderDate"].Width = 150;
            sales.Columns["orderTotal"].Width = 120;
            sales.Columns["orderDiscount"].Width = 130;


        }
    }
}
