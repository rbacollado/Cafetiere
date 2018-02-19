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
            String logquery = "SELECT logid, CONCAT(firstname, ' ', lastname) as StaffName, itemName, quantity, logdate , logtype FROM person"
                              + " INNER JOIN staff ON person.personid = staff.person_personid"
                              + " INNER JOIN inventorylog ON staff.staffid = inventorylog.staff_staffid;";
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
        }

        private void InventoryLog_Load(object sender, EventArgs e)
        {
            inventorylog();

            datetime_filter.Format = DateTimePickerFormat.Custom;
            datetime_filter.CustomFormat = "yyyy-MM-dd";

        }

        private void datetime_filter_ValueChanged(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT logid, CONCAT(firstname, ' ' , lastname) as StaffName, itemName, quantity, logtype, logdate FROM person"
                              + " INNER JOIN staff ON person.personid = staff.person_personid"
                              + " INNER JOIN inventorylog ON staff.staffid = inventorylog.staff_staffid"
                              + " WHERE logdate like '%" + datetime_filter.Value + "%';";
            cmd.Parameters.Add(datetime_filter.Text, MySqlDbType.DateTime).Value = datetime_filter.Value;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            inventory_log.DataSource = dt;
            conn.Close();
        }
    }
}
