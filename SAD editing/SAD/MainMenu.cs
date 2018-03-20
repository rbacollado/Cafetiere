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

            btnDash.BackColor = Color.FromArgb(192, 57, 43);

            if (SAD.Login.DisplayUserDetails.usertype.ToLower() == "staff")
            {
                btn_profiling.Enabled = false;
                btn_product.Enabled = false;
                btn_profiling.BackColor = Color.Gray;
                btn_product.BackColor = Color.Gray;
            }

            logDate();
            restock();
            notif_expiry();
            item_list();
        }

        public void item_list()
        {
            String itemsquery = "SELECT itemsID, name, description, price, unit, amount FROM items ";
            conn.Open();
            MySqlCommand comm = new MySqlCommand(itemsquery, conn);
            comm.CommandText = itemsquery;
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable dt_log = new DataTable();
            adp.Fill(dt_log);

            items_list.DataSource = dt_log;

            items_list.Columns["itemsID"].Visible = false;
            items_list.Columns["name"].HeaderText = "Name";
            items_list.Columns["description"].HeaderText = "Description";
            items_list.Columns["price"].HeaderText = "Price";
            items_list.Columns["unit"].HeaderText = "Unit";
            items_list.Columns["amount"].HeaderText = "Amount";
            
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
            btnDash.BackColor = Color.FromArgb(192, 57, 43);
            btn_orders.BackColor = Color.FromArgb(51, 51, 51);
            btn_profiling.BackColor = Color.FromArgb(51, 51, 51);
            restock_items.Visible = true;
            sales_panel.Visible = false;
            profiling_panel.Visible = false;
            panel3.Visible = true;
            items_list.Visible = true;
        }

        private void btn_profiling_Click(object sender, EventArgs e)
        {
            profiling_panel.Visible = true;
            profiling_panel.Enabled = true;
            panel3.Visible = false;
            items_list.Visible = false;
            sales_panel.Visible = false;
            btn_profiling.BackColor = Color.FromArgb(192, 57, 43);
            btnDash.BackColor = Color.FromArgb(51, 51, 51);
            btn_orders.BackColor = Color.FromArgb(51, 51, 51);
            restock_items.Visible = false;
            profiling_panel.Size = new Size(640, 529);
            profiling_panel.Location = new Point(139, 91);
        }

        private void btn_orders_Click(object sender, EventArgs e)
        {
            sales_panel.Visible = true;
            sales_panel.Enabled = true;
            profiling_panel.Visible = false;
            panel3.Visible = false;
            items_list.Visible = false;
            btn_orders.BackColor = Color.FromArgb(192, 57, 43);
            btn_profiling.BackColor = Color.FromArgb(51, 51, 51);
            btnDash.BackColor = Color.FromArgb(51, 51, 51);
            sales_panel.Size = new Size(640, 529);
            sales_panel.Location = new Point(139, 91);

        }
        
        private void btn_product_Click(object sender, EventArgs e)
        {
            Product_Inventory prod = new Product_Inventory();
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

        private void items_list_SelectionChanged(object sender, EventArgs e)
        {
            this.items_list.ClearSelection();
        }

        private void MainMenu_VisibleChanged(object sender, EventArgs e)
        {
            logDate();
            restock();
            item_list();

            btnDash.BackColor = Color.FromArgb(192, 57, 43);
            btn_orders.BackColor = Color.FromArgb(51, 51, 51);
            btn_profiling.BackColor = Color.FromArgb(51, 51, 51);
            restock_items.Visible = true;
            sales_panel.Visible = false;
            profiling_panel.Visible = false;
            panel3.Visible = true;
            items_list.Visible = true;
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
