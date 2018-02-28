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

        public void filterData()
        {
            string filterquery = "SELECT concat(firstname, ' ',lastname) as Staffname, orderDate, orderTotal, orderType FROM person"
                            + " INNER JOIN staff ON person.personid = staff.person_personid"
                            + " INNER JOIN `order` ON staff.staffid = `order`.staff_staffid"
                            + " INNER JOIN orderline ON `order`.orderID = orderline.orderID"
                            + " WHERE date(orderDate) BETWEEN '" + start_filter.Text + "' AND '" + end_filter.Text + "';";
            conn.Open();
            MySqlCommand comm = new MySqlCommand(filterquery, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable dt_filter = new DataTable();
            adp.Fill(dt_filter);

            sales_report.DataSource = dt_filter;

            sales_report.Columns["StaffName"].HeaderText = "Staff Name";
            sales_report.Columns["orderTotal"].HeaderText = "Total";
            sales_report.Columns["orderType"].HeaderText = "Type";
            sales_report.Columns["orderDate"].HeaderText = "Date";
            
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

            sales_report.DataSource = dt;
            sales_report.Columns["StaffName"].HeaderText = "Staff";
            sales_report.Columns["orderTotal"].HeaderText = "Sales Total";
            sales_report.Columns["orderType"].HeaderText = "Sales Type";
            sales_report.Columns["orderDate"].HeaderText = "Sales Date";
            
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            sales_report.Columns["StaffName"].Width = 100;
            sales_report.Columns["orderDate"].Width = 150;
            sales_report.Columns["orderTotal"].Width = 120;
            sales_report.Columns["orderType"].Width = 130;

            start_filter.Format = DateTimePickerFormat.Custom;
            start_filter.CustomFormat = "yyyy-MM-dd";

            end_filter.Format = DateTimePickerFormat.Custom;
            end_filter.CustomFormat = "yyyy-MM-dd";
        }

        private void Back_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Close();
        }

        private void start_filter_ValueChanged(object sender, EventArgs e)
        {
            filterData();
        }

        private void end_filter_ValueChanged(object sender, EventArgs e)
        {
            filterData();
        }
    }
}
