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
    public partial class Supplier : Form
    {
        MySqlConnection conn;
        public Form prevForm { get; set; }

        public Supplier()
        {
            InitializeComponent();
            conn = new MySqlConnection("SERVER=localhost; DATABASE=Cafetiere; uid=root; pwd=root;");
        }

        private void loadAll()
        {
            string query = "SELECT * FROM person , supplier WHERE person.personid = supplier.person_personid";

            conn.Open();

            MySqlCommand comm = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);

            conn.Close();

            DataTable dt = new DataTable();

            adp.Fill(dt);

            dtgv.DataSource = dt;
            dtgv.Columns["personid"].Visible = false;
            dtgv.Columns["supplierID"].Visible = false;
            dtgv.Columns["person_type"].Visible = false;
            dtgv.Columns["person_personid"].Visible = false;
           
            dtgv.Columns["firstname"].HeaderText = "Firstname";
            dtgv.Columns["lastname"].HeaderText = "Lastname";
            dtgv.Columns["address"].HeaderText = "Address";
            dtgv.Columns["contact"].HeaderText = "Contact Number";
            dtgv.Columns["email"].HeaderText = "Email";
            dtgv.Columns["organization"].HeaderText = "Organization";
            dtgv.Columns["date_added"].HeaderText = "Date Added";
            dtgv.Columns["date_modified"].HeaderText = "Date Modified";

        }

        private void Back_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Close();
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            loadAll();   
        }


        private void supplier_add_Click(object sender, EventArgs e)
        {
            Supplier_Add addsupplier= new Supplier_Add();
            addsupplier.prevForm = this;
            addsupplier.Show();
            this.Hide();
        }

        private void supplier_update_Click(object sender, EventArgs e)
        {
            Supplier_Update updatesupplier= new Supplier_Update();
            updatesupplier.prevForm = this;
            updatesupplier.Show();
            this.Hide();
        }

        public class selected_data
        {
            public static int selected_user_id;
        }

        private void dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int selected_id = int.Parse(dtgv.Rows[e.RowIndex].Cells["personid"].Value.ToString());
                selected_data.selected_user_id = selected_id;
            }

            string query = "SELECT CONCAT(firstname,' ' ,lastname) as ContactPerson, purchaseOrderDate FROM person " +
                            "INNER JOIN supplier on person.personid = supplier.person_personid " +
                            "INNER JOIN purchaseorder on supplier.supplierID = purchaseorder.supplier_supplierID " +
                            "WHERE personid = " + selected_data.selected_user_id + " ";
            conn.Open();
            MySqlCommand comm = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);
            records.DataSource = dt;

        }

        private void Back_Click_1(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Close();
        }
    }
}
