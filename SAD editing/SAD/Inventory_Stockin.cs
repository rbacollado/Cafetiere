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
    public partial class Inventory_Stockin : Form
    {
        MySqlConnection conn;

        public Form prevForm { get; set; }

        public Inventory_Stockin()
        {
            InitializeComponent();
            conn = new MySqlConnection("SERVER=localhost; DATABASE=cafetiere; uid=root; pwd=root;");
        }

        DataTable OrderWM = new DataTable();
        private void Inventory_Stockin_Load(object sender, EventArgs e)
        {
            encoderLbl.Text = SAD.Login.DisplayUserDetails.name;
            encoderPos.Text = SAD.Login.DisplayUserDetails.usertype;

            //OrderWM.Columns.Add("id", typeof(string));
            OrderWM.Columns.Add("Name", typeof(string));
            OrderWM.Columns.Add("Price", typeof(string));
            OrderWM.Columns.Add("Quantity", typeof(int));
            OrderWM.Columns.Add("ExpiryDate", typeof(string));
            OrderWM.Columns.Add("Subtotal", typeof(string));

            DateTime now = DateTime.Today;
            date.Text = now.ToString("MM/dd/yy");

            iExpiry_txt.Format = DateTimePickerFormat.Custom;
            iExpiry_txt.CustomFormat = "yyyy-MM-dd";
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Close();
        }

        public void total()
        {
            // Total
            decimal total = 0;
            for (int i = 0; i <= items_ordered.Rows.Count - 1; i++)
            {
                total += (decimal.Parse(items_ordered.Rows[i].Cells["Subtotal"].Value.ToString()));

            }
            TotalTB.Text = total.ToString();

        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            Boolean duplicate_item = false;
            int iditem = 0;

            // Check if items in the items_ordered datagrid
            for (int i = 0; i < items_ordered.Rows.Count; i++)
            {
                if ((iName_txt.Text == items_ordered.Rows[i].Cells["Name"].Value.ToString()) && iExpiry_txt.Text == items_ordered.Rows[i].Cells["ExpiryDate"].Value.ToString())
                {
                    duplicate_item = true;
                    iditem = i;
                }
            }

            if ( iName_txt.Text == "" || iPrice_txt.Text == "" || iQuantity_txt.Text == "")
            {
                MessageBox.Show("Please complete order details!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (duplicate_item == true)
            {
                string iQuantity = items_ordered.Rows[iditem].Cells["Quantity"].Value.ToString();
                string iPrice = items_ordered.Rows[iditem].Cells["Price"].Value.ToString();
                items_ordered.Rows[iditem].Cells["Quantity"].Value = int.Parse(iQuantity_txt.Text) + int.Parse(iQuantity);

                decimal number = decimal.Parse(iPrice) * int.Parse(items_ordered.Rows[iditem].Cells["Quantity"].Value.ToString());
                items_ordered.Rows[iditem].Cells["Subtotal"].Value = number.ToString();
                total();

            }
            else
            {

                OrderWM.Rows.Add(iName_txt.Text, iPrice_txt.Text, iQuantity_txt.Text, iExpiry_txt.Text , subtotal_txt.Text);
                items_ordered.DataSource = OrderWM;
                //items_ordered.Columns["id"].Visible = false;
                total();
            }
        }

        private void iPrice_txt_TextChanged(object sender, EventArgs e)
        {
            if (iPrice_txt.Text == "")
            {
                iQuantity_txt.Enabled = false;
            }
            else
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(iPrice_txt.Text, "[^0-9.]"))
                {
                    MessageBox.Show("Please enter only numbers.");
                    iPrice_txt.Text = iPrice_txt.Text.Remove(iPrice_txt.Text.Length - 1);
                }
                else
                {
                    iQuantity_txt.Enabled = true;

                    string iprice = iPrice_txt.Text;
                    string iquantity = iQuantity_txt.Value.ToString();
                    int parseQuantity = int.Parse(iquantity);

                    decimal parsePrice = decimal.Parse(iprice);
                    decimal subtotal = parsePrice * parseQuantity;
                    string string_subtotal = subtotal.ToString();

                    subtotal_txt.Text = string_subtotal;
                }
            }
        }

        public void clear_shit()
        {
            iName_txt.Text = "";
            iPrice_txt.Text = "0";
            subtotal_txt.Text = "0";
            iQuantity_txt.Text = "1";
            iQuantity_txt.Enabled = false;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear_shit();
        }
        
        private void stockin_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
