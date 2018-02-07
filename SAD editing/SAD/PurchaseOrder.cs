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
    public partial class PurchaseOrder : Form
    {
        MySqlConnection conn;

        public Form prevForm { get; set; }

        private Timer tm = new Timer();

        void tm_Tick(object sender, EventArgs e)
        {
            timeText.Text = DateTime.Now.ToLongTimeString();
        }

        public PurchaseOrder()
        {
            InitializeComponent();
            conn = new MySqlConnection("SERVER=localhost; DATABASE=cafetiere; uid=root; pwd=root;");
        }

        private void PurchaseOrder_Load(object sender, EventArgs e)
        {
            tm.Tick += new EventHandler(tm_Tick);
            tm.Interval = 1000;
            tm.Enabled = true;

            timeText.Text = DateTime.Now.ToLongTimeString();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Close();
        }

        private void add_purchase_Click(object sender, EventArgs e)
        {

        }

        
    }
}
