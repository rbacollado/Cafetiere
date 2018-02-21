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
            
        }

        public void logDate()
        {
            DateTime logdate;
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT max(logdate) as LastLog FROM inventorylog;";
            MySqlDataReader rdr = cmd.ExecuteReader();
            while(rdr.Read())
            {
                logdate = DateTime.Parse(rdr["LastLog"].ToString());

                logdate_lbl.Text = logdate.ToString("yyyy-MM-dd");
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

        private void btn_profiling_Click(object sender, EventArgs e)
        {
            profiling_panel.Visible = true;
            profiling_panel.Enabled = true;
            profiling_panel.Size = new Size(640, 529);
            profiling_panel.Location = new Point(139, 91);
        }

        private void btn_orders_Click(object sender, EventArgs e)
        {
            /*Order order = new Order();
            order.prevForm = this;
            order.Show();
            this.Hide();*/
        }
        
        private void btn_product_Click(object sender, EventArgs e)
        {
            /*Product product = new Product();
            product.prevForm = this;
            product.Show();
            this.Hide();*/
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

        private void btn_close_Click(object sender, EventArgs e)
        {
            profiling_panel.Visible = false;
        }
    }
}
