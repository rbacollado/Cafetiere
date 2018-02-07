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
    public partial class PurchaseOrder_create : Form
    {
        MySqlConnection conn;

        public MainMenu prevForm { get; set; }

        public PurchaseOrder_create()
        {
            InitializeComponent();
            conn = new MySqlConnection("SERVER=localhost; DATABASE=cafetiere; uid=root; pwd=root;");
        }

        DataTable POrder = new DataTable();
        private void PurchaseOrder_create_Load(object sender, EventArgs e)
        {
            encoderLbl.Text = SAD.Login.DisplayUserDetails.name;
            encoderPos.Text = SAD.Login.DisplayUserDetails.usertype;

            POrder.Columns.Add("id", typeof(string));
            POrder.Columns.Add("Item Name", typeof(string));
            POrder.Columns.Add("Item Price", typeof(string));
            POrder.Columns.Add("Item Quantity", typeof(int));
            POrder.Columns.Add("Item Expiry", typeof(string));
            POrder.Columns.Add("Item Subtotal", typeof(int));

            DateTime now = DateTime.Today;
            date.Text = now.ToString("MM/dd/yy");

            /*iExpiry_txt.Format = DateTimePickerFormat.Custom;
            iExpiry_txt.CustomFormat = "dd-MM-yyyy";*/

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Close();
        }

        public void load_suppliers()
        {
            String query = "SELECT firstname, lastname, organization FROM person " +
                           "INNER JOIN supplier ON person.personid =  supplier.person_personid WHERE supplierID = "+ selected_supplierid + "";

            MySqlCommand comm = new MySqlCommand(query, conn);
            comm.CommandText = query;

            conn.Open();
            MySqlDataReader dataread = comm.ExecuteReader();

            while (dataread.Read())
            {
                supplier_txt.Text = (dataread["organization"].ToString());
            }
            conn.Close();
        }

        private void supplier_txt_MouseClick(object sender, MouseEventArgs e)
        {
            
            String query = "SELECT supplierID, firstname, lastname, organization FROM person " +
                           "INNER JOIN supplier ON person.personid = supplier.person_personid" ;
            conn.Open();
            MySqlCommand comm = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);

            supplier_data.DataSource = dt;
            supplier_data.Columns["supplierID"].Visible = false;
            supplier_data.Columns["firstname"].HeaderText = "First Name";
            supplier_data.Columns["lastname"].HeaderText = "Last Name";
            supplier_data.Columns["organization"].HeaderText = "organization";

            if (supplier_data.Rows.Count < 1)
            {
                MessageBox.Show("No Supplier Available!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                supplierpanel.Visible = true;
                supplierpanel.Enabled = true;
                iQuantity_txt.Visible = false;

                supplierpanel.Size = new Size(383, 415);
                supplierpanel.Location = new Point(3, 124);
            }

        }

        public static int selected_supplierid;
        private void supplier_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                selected_supplierid = int.Parse(supplier_data.Rows[e.RowIndex].Cells["supplierID"].Value.ToString());

                supplierpanel.Visible = false;
                supplierpanel.Enabled = false;
                iQuantity_txt.Visible = true;
                load_suppliers();
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Boolean duplicate_item = false;
            int iditem = 0;

            // Check if items in the items_ordered datagrid
            for (int i = 0; i < items_ordered.Rows.Count; i++)
            {
                if ( (iExpiry_txt.Text) == (items_ordered.Rows[i].Cells["Item Expiry"].Value.ToString()) )
                {
                    duplicate_item = true;
                    iditem = 1;
                }
            }

            if (supplier_txt.Text == "" || iName_txt.Text == "" || iPrice_txt.Text == "" || iQuantity_txt.Text == "" || iExpiry_txt.Text == "")
            {
                MessageBox.Show("Please input item details!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (duplicate_item == true)
            {
                items_ordered.Rows[iditem].Cells["Item Quantity"].Value = int.Parse(iQuantity_txt.Text) + int.Parse(items_ordered.Rows[iditem].Cells["Item Quantity"].Value.ToString());

                decimal subtotal = decimal.Parse(items_ordered.Rows[iditem].Cells["Item Price"].Value.ToString()) * int.Parse(items_ordered.Rows[iditem].Cells["Item Quantity"].Value.ToString());
                items_ordered.Rows[iditem].Cells["Subtotal"].Value = subtotal.ToString();

            }
            else
            {
                POrder.Rows.Add(selected_supplierid, iName_txt.Text, iPrice_txt.Text, iQuantity_txt.Text, iExpiry_txt.Text, subtotal_txt.Text);
                items_ordered.DataSource = POrder;
                items_ordered.Columns["id"].Visible = false;
            }

        }

        private void iQuantity_txt_ValueChanged(object sender, EventArgs e)
        {
            string iprice = iPrice_txt.Text;
            string iquantity = iQuantity_txt.Value.ToString();
            int parseQuantity = int.Parse(iquantity);

            decimal parsePrice = decimal.Parse(iprice);
            decimal subtotal = parsePrice * parseQuantity;
            string string_subtotal = subtotal.ToString();

            subtotal_txt.Text = string_subtotal;
        }
        
        private void iPrice_txt_TextChanged(object sender, EventArgs e)
        { 
            if (iPrice_txt.Text == "")
            {
                iQuantity_txt.Enabled = false;
            }
            else
            {
                iQuantity_txt.Enabled = true;
            }
            
        }
    }
}
