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
    public partial class Reports : Form
    {
        MySqlConnection conn;

        public Form prevForm { get; set; }

        public Reports()
        {
            InitializeComponent();
            conn = new MySqlConnection("SERVER=localhost; DATABASE=cafetiere; uid=root; pwd=root;");

            salesLoad();
        }
        
        public void filterData()
        {
            string filterquery = "SELECT orderID, concat(firstname, ' ',lastname) as Staffname, orderDate, orderTotal, orderPayment, orderDiscount, orderDiscountType, orderChange FROM person "
                            + "INNER JOIN staff ON person.personid = staff.person_personid "
                            + "INNER JOIN `order` ON staff.staffid = `order`.staff_staffid "
                            + " WHERE date(orderDate) BETWEEN '" + start_filter.Text + "' AND '" + end_filter.Text + "';";
            conn.Open();
            MySqlCommand comm = new MySqlCommand(filterquery, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable dt_filter = new DataTable();
            adp.Fill(dt_filter);

            sales_report.DataSource = dt_filter;

            sales_report.DataSource = dt_filter;
            sales_report.Columns["orderID"].Visible = false;
            sales_report.Columns["StaffName"].HeaderText = "Staff";
            sales_report.Columns["orderDate"].HeaderText = "Sales Date";
            sales_report.Columns["orderTotal"].HeaderText = "Sales Total";
            sales_report.Columns["orderPayment"].HeaderText = "Payment";
            sales_report.Columns["orderChange"].HeaderText = "Change";
            sales_report.Columns["orderDiscount"].HeaderText = "Discount %";
            sales_report.Columns["orderDiscountType"].HeaderText = "Discount Type";

        }

        private void sales_report_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int orderID;

                int selected_id = int.Parse(sales_report.Rows[e.RowIndex].Cells["orderID"].Value.ToString());
                orderID = selected_id;

                String orderLinequery = "SELECT pname, pcategory, orderPrice, orderQuantity, orderSubtotal, orderType FROM products " +
                                        "INNER JOIN orderline ON products.productID = orderline.productID WHERE  orderline.orderID = " + orderID + ";";


                conn.Open();
                MySqlCommand comm = new MySqlCommand(orderLinequery, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                conn.Close();

                DataTable recipe = new DataTable();
                adp.Fill(recipe);

                sales_details.DataSource = recipe;

                sales_details.Columns["pname"].HeaderText = "Name";
                sales_details.Columns["pcategory"].HeaderText = "Category";
                sales_details.Columns["orderPrice"].HeaderText = "Price";
                sales_details.Columns["orderQuantity"].HeaderText = "Order Quantity";
                sales_details.Columns["orderSubtotal"].HeaderText = "Subtotal";
                sales_details.Columns["orderType"].HeaderText = "Order Type";
            }
        }

        private void salesLoad()
        {
            string query = "SELECT orderID, concat(firstname, ' ',lastname) as Staffname, orderDate, orderTotal, orderPayment, orderDiscount, orderDiscountType, orderChange FROM person " +
                           "INNER JOIN staff ON person.personid = staff.person_personid " +
                           "INNER JOIN `order` ON staff.staffid = `order`.staff_staffid;";

            conn.Open();

            MySqlCommand comm = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);

            conn.Close();

            DataTable dt = new DataTable();

            adp.Fill(dt);

            sales_report.DataSource = dt;
            sales_report.Columns["orderID"].Visible= false;
            sales_report.Columns["StaffName"].HeaderText = "Staff";
            sales_report.Columns["orderDate"].HeaderText = "Sales Date";
            sales_report.Columns["orderTotal"].HeaderText = "Sales Total";
            sales_report.Columns["orderPayment"].HeaderText = "Payment";
            sales_report.Columns["orderChange"].HeaderText = "Change";
            sales_report.Columns["orderDiscount"].HeaderText = "Discount %";
            sales_report.Columns["orderDiscountType"].HeaderText = "Discount Type";
            
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            

            start_filter.Format = DateTimePickerFormat.Custom;
            start_filter.CustomFormat = "yyyy-MM-dd";

            end_filter.Format = DateTimePickerFormat.Custom;
            end_filter.CustomFormat = "yyyy-MM-dd";
        }

        private void Back_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Close();
        }

        private void start_filter_ValueChanged(object sender, EventArgs e)
        {
            filterData();
        }

        private void end_filter_ValueChanged(object sender, EventArgs e)
        {
            filterData();
        }
        
    }
}
