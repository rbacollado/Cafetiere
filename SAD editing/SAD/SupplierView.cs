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
    public partial class SupplierView : Form
    {
        MySqlConnection conn;

        public Form prevForm { get; set; }

        public SupplierView()
        {
            InitializeComponent();
            conn = new MySqlConnection("SERVER=localhost; DATABASE=Cafetiere; uid=root; pwd=root;");
        }

        private Timer tm = new Timer();

        void tm_Tick(object sender, EventArgs e)
        {
            timeText.Text = DateTime.Now.ToLongTimeString();
        }
        private void SupplierView_Load(object sender, EventArgs e)
        {
            tm.Tick += new EventHandler(tm_Tick);
            tm.Interval = 1000;
            tm.Enabled = true;

            timeText.Text = DateTime.Now.ToLongTimeString();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Close();
        }
    }
}
