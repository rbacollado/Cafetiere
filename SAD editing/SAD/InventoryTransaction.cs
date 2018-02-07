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
    public partial class InventoryTransaction : Form
    {
        MySqlConnection conn;

        public Form prevForm { get; set; }

        public InventoryTransaction()
        {
            InitializeComponent();
            conn = new MySqlConnection("SERVER=localhost; DATABASE=cafetiere; uid=root; pwd=root;");
            txt_staffposition.Text = SAD.Login.DisplayUserDetails.usertype;
            txt_staffname.Text = SAD.Login.DisplayUserDetails.name;

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Close();
        }

        private void btn_logs_Click(object sender, EventArgs e)
        {
            InventoryLog logs = new InventoryLog();
            logs.prevForm = this;
            logs.Show();
            this.Hide();
        }

        private void btn_PO_Click(object sender, EventArgs e)
        {
            PurchaseOrder po = new PurchaseOrder();
            po.prevForm = this;
            po.Show();
            this.Hide();
        }
    }
}
