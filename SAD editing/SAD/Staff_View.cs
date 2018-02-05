using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SAD
{
    public partial class Staff_View : Form
    {
        MySqlConnection conn;

        public Form prevForm { get; set; }


        public Staff_View()
        {
            InitializeComponent();
            conn = new MySqlConnection("SERVER=localhost; DATABASE=Cafetiere; uid=root; pwd=root;");
            

        }

        public int staffid = SAD.Staff.selected_data.selected_user_id;

        private Timer tm = new Timer();

        void tm_Tick(object sender, EventArgs e)
        {
            timeText.Text = DateTime.Now.ToLongTimeString();
        }

        private void Staff_View_Load(object sender, EventArgs e)
        {
            tm.Tick += new EventHandler(tm_Tick);
            tm.Interval = 1000;
            tm.Enabled = true;

            timeText.Text = DateTime.Now.ToLongTimeString();

            String query = "SELECT firstname, lastname, position FROM person, staff" +
                            "WHERE personid = person_personid ";

            MySqlCommand comm = new MySqlCommand(query, conn);
            comm.CommandText = query;
            conn.Open();
            MySqlDataReader drd = comm.ExecuteReader();

            while (drd.Read())
            {
                lbl_name.Text = (drd["firstname"].ToString());

                lbl_position.Text = (drd["position"].ToString());
               
            }
            conn.Close();

        }

        private void Back_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Close();
        }
    }
}
