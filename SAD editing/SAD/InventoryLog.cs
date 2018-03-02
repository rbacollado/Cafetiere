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
    public partial class InventoryLog : Form
    {
        MySqlConnection conn;

        public Form prevForm { get; set; }

        public InventoryLog()
        {
            InitializeComponent();
            conn = new MySqlConnection("SERVER=localhost; DATABASE=cafetiere; uid=root; pwd=root;");

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Close();
        }
        
        private void inventorylog()
        {
            string logquery = "SELECT logid, CONCAT(firstname, ' ', lastname) as StaffName, itemName, quantity, logdate , logtype, remarks FROM person"
                              + " INNER JOIN staff ON person.personid = staff.person_personid"
                              + " INNER JOIN inventorylog ON staff.staffid = inventorylog.staff_staffid where quantity > 0;";
            conn.Open();
            MySqlCommand comm = new MySqlCommand(logquery, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable dt_log = new DataTable();
            adp.Fill(dt_log);

            inventory_log.DataSource = dt_log;

            inventory_log.Columns["logid"].Visible = false;
            inventory_log.Columns["StaffName"].HeaderText = "Staff Name";
            inventory_log.Columns["itemName"].HeaderText = "Item";
            inventory_log.Columns["quantity"].HeaderText = "Quantity";
            inventory_log.Columns["logdate"].HeaderText = "Date";
            inventory_log.Columns["logtype"].HeaderText = "Activity";
            inventory_log.Columns["remarks"].HeaderText = "Remarks";
        }

        private void InventoryLog_Load(object sender, EventArgs e)
        {
            inventorylog();
            inventory_log.Columns["StaffName"].Width = 90;
            inventory_log.Columns["logdate"].Width = 90;
            inventory_log.Columns["quantity"].Width = 40;
            inventory_log.Columns["logtype"].Width = 90;
            inventory_log.Columns["remarks"].Width = 100;

            start_filter.Format = DateTimePickerFormat.Custom;
            start_filter.CustomFormat = "yyyy-MM-dd";

            end_filter.Format = DateTimePickerFormat.Custom;
            end_filter.CustomFormat = "yyyy-MM-dd";

        }

        private void cmb_filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_filter.Text == "All")
            {
                filterData();
            } else
            {
                string filterquery = "SELECT logid, CONCAT(firstname, ' ', lastname) as StaffName, itemName, quantity, logdate, logtype, remarks FROM person"
                                + " INNER JOIN staff ON person.personid = staff.person_personid"
                                + " INNER JOIN inventorylog ON staff.staffid = inventorylog.staff_staffid"
                                + " WHERE logtype LIKE '" + cmb_filter.Text + "' AND date(logdate) BETWEEN '" + start_filter.Text + "' AND '" + end_filter.Text + "' AND quantity > 0;";
                conn.Open();
                MySqlCommand comm = new MySqlCommand(filterquery, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                conn.Close();
                DataTable dt_filter = new DataTable();
                adp.Fill(dt_filter);

                inventory_log.DataSource = dt_filter;

                inventory_log.Columns["logid"].Visible = false;
                inventory_log.Columns["StaffName"].HeaderText = "Staff Name";
                inventory_log.Columns["itemName"].HeaderText = "Item";
                inventory_log.Columns["quantity"].HeaderText = "Quantity";
                inventory_log.Columns["logdate"].HeaderText = "Date";
                inventory_log.Columns["logtype"].HeaderText = "Activity";
            }
                     
        }
        public void filterData()
        {
            string filterquery = "SELECT logid, CONCAT(firstname, ' ', lastname) as StaffName, itemName, quantity, logdate, logtype, remarks FROM person"
                            + " INNER JOIN staff ON person.personid = staff.person_personid"
                            + " INNER JOIN inventorylog ON staff.staffid = inventorylog.staff_staffid"
                            + " WHERE date(logdate) BETWEEN '" + start_filter.Text + "' AND '" + end_filter.Text + "' AND quantity > 0 ;";
            conn.Open();
            MySqlCommand comm = new MySqlCommand(filterquery, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable dt_filter = new DataTable();
            adp.Fill(dt_filter);

            inventory_log.DataSource = dt_filter;

            inventory_log.Columns["logid"].Visible = false;
            inventory_log.Columns["StaffName"].HeaderText = "Staff Name";
            inventory_log.Columns["itemName"].HeaderText = "Item";
            inventory_log.Columns["quantity"].HeaderText = "Quantity";
            inventory_log.Columns["logdate"].HeaderText = "Date";
            inventory_log.Columns["logtype"].HeaderText = "Activity";
        }

        private void datetime_filter_ValueChanged(object sender, EventArgs e)
        {
            filterData();
        }

        private void end_filter_ValueChanged(object sender, EventArgs e)
        {
            filterData();
        }
    }
}
