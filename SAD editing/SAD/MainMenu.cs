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
    public partial class MainMenu : Form
    {
        MySqlConnection conn;

        public Form prevForm { get; set; }

        public MainMenu()
        {
            InitializeComponent();
            conn = new MySqlConnection("SERVER=localhost; DATABASE=cafetiere; uid=root; pwd=root;");
            lbl_user.Text = "Welcome! ";
            lbl_type.Text = SAD.Login.DisplayUserDetails.usertype;
            lbl_name.Text = SAD.Login.DisplayUserDetails.name;
        }
        
        private Timer tm = new Timer();

        void tm_Tick(object sender, EventArgs e)
        {
            timeText.Text = DateTime.Now.ToLongTimeString();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            tm.Tick += new EventHandler(tm_Tick);
            tm.Interval = 1000;
            tm.Enabled = true;

            timeText.Text = DateTime.Now.ToLongTimeString();
            

            if (SAD.Login.DisplayUserDetails.usertype.ToLower() == "staff")
            {
                btnDash.BackColor = Color.FromArgb(43, 192, 57);

                btn_profiling.Enabled = false;
                btn_profiling.BackColor = Color.FromArgb(192, 57, 43);
 
               
            }
           

            logDate();
            restock();
            notif_expiry();
            load_expired();
            pending_orders();
            daily_sales();
         
        }
        

        public void daily_sales()
        {
            String dailyQuery = "select SUM(orderTotal) as SalesTotal FROM `order` WHERE curdate() < orderDate ;";

            MySqlCommand comm = new MySqlCommand(dailyQuery, conn);
            comm.CommandText = dailyQuery;

            conn.Open();
            MySqlDataReader drdDaily = comm.ExecuteReader();

            while (drdDaily.Read())
            {
                string dailySales = drdDaily["SalesTotal"].ToString();

                if (dailySales.ToString() == "")
                {
                    sales_daily.Text = "None";
                }
                else
                {
                    sales_daily.Text = dailySales.ToString();
                }

            }
            conn.Close();
        }

        public void pending_orders()
        {
            String pendingQuery = "SELECT COUNT(stocked_in) as PendingItems FROM purchaseorder, purchaseorder_line " +
                                  "WHERE purchaseorder.purchaseOrderID = purchaseorder_line.purchaseOrder_purchaseOrderID AND stocked_in = 'No';";

            MySqlCommand comm = new MySqlCommand(pendingQuery, conn);
            comm.CommandText = pendingQuery;

            conn.Open();
            MySqlDataReader drdPending = comm.ExecuteReader();

            while (drdPending.Read())
            {
                string numPending = drdPending["PendingItems"].ToString();
                
                if (numPending.ToString() == "")
                {
                    pendingitems.Text = "None";
                }
                else
                {
                    pendingitems.Text = numPending.ToString();
                }
                
            }
            conn.Close();
        }

        public void load_expired()
        {
            String query_expired = "SELECT itemInvID, item_id, name, description, CONCAT(amount, ' ' ,unit) as ItemMeasurement, date_format(itemExpiry, '%m /%d /%y') as itemExpiry FROM items_inventory, items " +
                                    "WHERE (itemType = 'Ingredient' OR itemType = 'Product') AND items.itemsID = items_inventory.item_ID AND current_date() > itemExpiry;";
            conn.Open();
            MySqlCommand comm = new MySqlCommand(query_expired, conn);
            comm.CommandText = query_expired;
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable dt_expired = new DataTable();
            adp.Fill(dt_expired);

            expired_items.DataSource = dt_expired;


            expired_items.Columns["itemInvID"].Visible = false;
            expired_items.Columns["item_id"].Visible = false;
            expired_items.Columns["name"].HeaderText = "Name";
            expired_items.Columns["description"].HeaderText = "Desc";
            expired_items.Columns["ItemMeasurement"].HeaderText = "Item Measurement";
            expired_items.Columns["itemExpiry"].HeaderText = "Expiration Date";
            

        }

        public void notif_expiry()
        {
            String notifexpiryquery = "SELECT COUNT(itemInvID) as num_expired FROM items_inventory " +
                                      "WHERE current_date() > itemExpiry AND itemStatus = 'Available' AND itemType = 'Ingredient';";

            MySqlCommand comm = new MySqlCommand(notifexpiryquery, conn);
            comm.CommandText = notifexpiryquery;

            conn.Open();
            MySqlDataReader drdNotif = comm.ExecuteReader();

            while (drdNotif.Read())
            {
                string numExpired = drdNotif["num_expired"].ToString();

                if (numExpired != "0")
                {
                    MessageBox.Show("You have " + numExpired + " expired item(s).", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
            conn.Close();
        }
        
        public void restock()
        {
            String restockquery = "SELECT itemInvID, item_ID, name, itemQuantity, itemStatus, itemType, date_format(itemExpiry, '%m/%d/%y') as itemExpiry FROM items " +
                                  "INNER JOIN items_inventory ON items.itemsID = items_inventory.item_ID AND itemStatus like 'Unavailable' AND (itemExpiry > current_date() OR itemExpiry = '0000-00-00');";
            conn.Open();
            MySqlCommand comm = new MySqlCommand(restockquery, conn);
            comm.CommandText = restockquery;
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable dt_log = new DataTable();
            adp.Fill(dt_log);

            restock_items.DataSource = dt_log;

            restock_items.Columns["item_ID"].Visible = false;
            restock_items.Columns["itemInvID"].Visible = false;
            restock_items.Columns["name"].HeaderText = "Name";
            restock_items.Columns["itemQuantity"].HeaderText = "Quantity";
            restock_items.Columns["itemStatus"].HeaderText = "Status";
            restock_items.Columns["itemType"].HeaderText = "Type";
            restock_items.Columns["itemExpiry"].HeaderText = "Expiration Date";

        }

        public void logDate()
        {
           
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT max(date_format(logdate, '%m /%d /%y')) as LastLog FROM inventorylog;";
            MySqlDataReader rdr = cmd.ExecuteReader();
            while(rdr.Read())
            {
                string logdate = rdr["LastLog"].ToString();

                if (logdate.ToString() == "")
                {
                    logdate_lbl.Text = "None";
                }
                else
                {
                    logdate_lbl.Text = logdate.ToString();
                }
                
            }
            conn.Close();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Close();
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.prevForm = this;
            settings.Show();
            this.Hide();
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            if (SAD.Login.DisplayUserDetails.usertype.ToLower() == "staff")
            {
                btnDash.BackColor = Color.FromArgb(43, 192, 57);
                btn_profiling.BackColor = Color.FromArgb(192, 57, 43);
                btn_orders.BackColor = Color.FromArgb(51, 51, 51);

            }
            else
            {
                btnDash.BackColor = Color.FromArgb(43, 192, 57);
                btn_profiling.BackColor = Color.FromArgb(51, 51, 51);
                btn_orders.BackColor = Color.FromArgb(51, 51, 51);
            }
            
            restock_items.Visible = true;
            sales_panel.Visible = false;
            profiling_panel.Visible = false;

            panel3.Visible = true;
            expired_items.Visible = true;
            panel4.Visible = true;
            panel5.Visible = true;

           
        }

        private void btn_profiling_Click(object sender, EventArgs e)
        {

            if (SAD.Login.DisplayUserDetails.usertype.ToLower() == "staff")
            {
                btn_profiling.BackColor = Color.FromArgb(192, 57, 43);
                btn_profiling.Enabled = false;
            }

            profiling_panel.Visible = true;
            profiling_panel.Enabled = true;

            sales_panel.Visible = false;

            btn_profiling.BackColor = Color.FromArgb(43, 192, 57);
            btnDash.BackColor = Color.FromArgb(51, 51, 51);
            btn_orders.BackColor = Color.FromArgb(51, 51, 51);

            restock_items.Visible = false;
            profiling_panel.Size = new Size(823, 543);
            profiling_panel.Location = new Point(126, 73);

            panel3.Visible = false;
            expired_items.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
        }

        private void btn_orders_Click(object sender, EventArgs e)
        {
            if (SAD.Login.DisplayUserDetails.usertype.ToLower() == "staff")
            {
                btn_profiling.BackColor = Color.FromArgb(192, 57, 43);
                btn_profiling.Enabled = false;
            }
            else
            {
                btn_profiling.BackColor = Color.FromArgb(51, 51, 51);
            }

            btn_orders.BackColor = Color.FromArgb(43, 192, 57);
            
            sales_panel.Visible = true;
            sales_panel.Enabled = true;
            profiling_panel.Visible = false;
           
           
            btnDash.BackColor = Color.FromArgb(51, 51, 51);

            sales_panel.Size = new Size(823, 543);
            sales_panel.Location = new Point(126, 73);

            panel3.Visible = false;
            expired_items.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
        }
        
        private void btn_product_Click(object sender, EventArgs e)
        {
            Product prod = new Product();
            prod.prevForm = this;
            prod.Show();
            this.Hide();
        }

        private void report_btn_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports();
            reports.prevForm = this;
            reports.Show();
            this.Hide();
        }

        private void btn_inventory_Click(object sender, EventArgs e)
        {
            InventoryTransaction inventory = new InventoryTransaction();
            inventory.prevForm = this;
            inventory.Show();
            this.Hide();
            
        }

        private void btn_staff_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            staff.prevForm = this;
            staff.Show();
            this.Hide();
        }

        private void btn_supplier_Click(object sender, EventArgs e)
        {
            Supplier supplier = new Supplier();
            supplier.prevForm = this;
            supplier.Show();
            this.Hide();
        }
        
        private void order_btn_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.prevForm = this;
            order.Show();
            this.Hide();
        }

        private void restock_items_SelectionChanged(object sender, EventArgs e)
        {
            this.restock_items.ClearSelection();
        }

        private void expired_items_SelectionChanged(object sender, EventArgs e)
        {
            this.expired_items.ClearSelection();
        }

        private void MainMenu_VisibleChanged(object sender, EventArgs e)
        {
            logDate();
            restock();
            load_expired();
            pending_orders();
            daily_sales();
 

            btnDash.BackColor = Color.FromArgb(43, 192, 57);
            btn_profiling.BackColor = Color.FromArgb(51, 51, 51);
            btn_orders.BackColor = Color.FromArgb(51, 51, 51);
            
            restock_items.Visible = true;
            sales_panel.Visible = false;
            profiling_panel.Visible = false;


            panel3.Visible = true;
            expired_items.Visible = true;
            panel4.Visible = true;
            panel5.Visible = true;

            if (SAD.Login.DisplayUserDetails.usertype.ToLower() == "staff")
            {
                btnDash.BackColor = Color.FromArgb(43, 192, 57);
                btn_profiling.Enabled = false;
                btn_profiling.BackColor = Color.FromArgb(192, 57, 43);

            }
        }

        private void btn_item_Click(object sender, EventArgs e)
        {
            Item_Add itemadd = new Item_Add();
            itemadd.prevForm = this;
            itemadd.Show();
            this.Hide();
        }

       
    }
}
