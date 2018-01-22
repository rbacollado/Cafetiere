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
    public partial class Profiling : Form
    {
        MySqlConnection conn;
        public Profiling()
        {
            InitializeComponent();
            conn = new MySqlConnection("SERVER=localhost; DATABASE=Cafetiere; uid=root; pwd=root;");
        }
        public MainMenu prevForm { get; set; }

        private void Back_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Close();
        }

        private void btn_supplier_Click(object sender, EventArgs e)
        {
            Supplier supplier = new Supplier();
            supplier.prevForm = this;
            supplier.Show();
            this.Hide();
        }

        private void btn_staff_Click_1(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            staff.prevForm = this;
            staff.Show();
            this.Hide();
        }
    }
}
