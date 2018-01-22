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

        public Login prevForm { get; set; }

        public MainMenu()
        {
            InitializeComponent();
            conn = new MySqlConnection("SERVER=localhost; DATABASE=cafetiere; uid=root; pwd=root;");
            lbl_user.Text = "Welcome! ";
            lbl_type.Text = SAD.Login.DisplayUserDetails.usertype;
            lbl_name.Text = SAD.Login.DisplayUserDetails.name;
        }

        private void btn_profiling_Click(object sender, EventArgs e)
        {
            Profiling profiling = new Profiling();
            profiling.prevForm = this;
            profiling.Show();
            this.Hide();
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

            salesLoad();

        }

        private void salesLoad()
        {
            string query = "SELECT * FROM `order`";

            conn.Open();

            MySqlCommand comm = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);

            conn.Close();

            DataTable dt = new DataTable();

            adp.Fill(dt);

            sales.DataSource = dt;
            sales.Columns["orderID"].Visible = false;
            sales.Columns["order_staff_id"].HeaderText = "Staff";
            sales.Columns["orderDate"].HeaderText = "Sales Date";
            sales.Columns["orderTotal"].HeaderText = "Sales Total";
            sales.Columns["orderDiscount"].HeaderText = "Discount";
            
            sales.Columns["order_staff_id"].Width = 50;
            sales.Columns["orderDate"].Width = 150;
            sales.Columns["orderTotal"].Width = 120;
            sales.Columns["orderDiscount"].Width = 135;
            

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
        
        private void btn_orders_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.prevForm = this;
            order.Show();
            this.Hide();
        }
        
        private void btn_product_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.prevForm = this;
            product.Show();
            this.Hide();
        }

        private void report_btn_Click(object sender, EventArgs e)
        {
            panel_reports.Visible = true;
            panel_reports.Enabled = true;

            panel_reports.Size = new Size(728, 531);
            panel_reports.Location = new Point(130, 64);
        }

        private void Back_Click(object sender, EventArgs e)
        {
            panel_reports.Visible = false;
            panel_reports.Enabled = false;
        }



    }
}
