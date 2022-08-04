using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorageSystem
{
    public partial class Invoice2 : Form
    {
       
        Context context = new Context();
        public Invoice2()
        {
            InitializeComponent();
            var query = from customer in context.customer
                        join cust_invoice in context.customer_invoice on customer equals cust_invoice.Customer
                        select new { cust_invoice.ID, cust_invoice.date, customer.Name, customer.Phone };
            dataGridView1.DataSource = query.ToList();
            dataGridView1.Columns[3].Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Date")
            {
                dateTimePicker1.Visible = true;
                textBox1.Visible = false;
            }
            else
            {
                dateTimePicker1.Visible = false;
                textBox1.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Customer_Invoice> empty = new List<Customer_Invoice>();
            if (comboBox1.Text == "Invoice Id")
            {
                int id = Convert.ToInt32(textBox1.Text);
                var qyery1 = from customer in context.customer
                             join cust_invoice in context.customer_invoice on customer equals cust_invoice.Customer
                             where cust_invoice.ID == id
                             select new { cust_invoice.ID, cust_invoice.date, customer.Name, customer.Phone };
                dataGridView1.DataSource = empty;
                dataGridView1.DataSource = qyery1.ToList();
                dataGridView1.Columns[3].Visible = false;
            }
            if (comboBox1.Text == "Customer Name")
            {
                var qyery1 = from customer in context.customer
                             join cust_invoice in context.customer_invoice on customer equals cust_invoice.Customer
                             where customer.Name == textBox1.Text
                             select new { cust_invoice.ID, cust_invoice.date, customer.Name, customer.Phone };
                dataGridView1.DataSource = empty;
                dataGridView1.DataSource = qyery1.ToList();
                dataGridView1.Columns[3].Visible = false;
            }
            if (comboBox1.Text == "Date")
            {
                var date_month = dateTimePicker1.Value.Month;
                var date_year = dateTimePicker1.Value.Year;
                var qyery1 = from customer in context.customer
                             join cust_invoice in context.customer_invoice on customer equals cust_invoice.Customer
                             where cust_invoice.date.Year == date_year && cust_invoice.date.Month == date_month
                             select new { cust_invoice.ID, cust_invoice.date, customer.Name, customer.Phone };
                dataGridView1.DataSource = empty;
                dataGridView1.DataSource = qyery1.ToList();
                dataGridView1.Columns[3].Visible = false;
            }

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var selectedInvoiceId = dataGridView1.CurrentRow.Cells[0].Value;
            textBox2.Text = selectedInvoiceId.ToString();
            int invoice_id = Convert.ToInt32(selectedInvoiceId.ToString());
            var selectedInvoiceDate = dataGridView1.CurrentRow.Cells[1].Value;
            textBox3.Text = selectedInvoiceDate.ToString();
            var selectedInvoiceCustomerName = dataGridView1.CurrentRow.Cells[2].Value;
            textBox4.Text = selectedInvoiceCustomerName.ToString();
            var selectedInvoiceCustomerPhone = dataGridView1.CurrentRow.Cells[3].Value;
            textBox5.Text = selectedInvoiceCustomerPhone.ToString();
            var query2 = from invoice in context.customer_invoice
                         join invoice_product in context.customer_invoice_product on invoice.ID equals invoice_product.Customer_Invoice_Id
                         join product in context.product on invoice_product.Product_Id equals product.Id
                         where invoice.ID == invoice_id
                         select new { invoice_product.Product_Id, product.Name, invoice_product.Quantity, product.Price, total_price = invoice_product.Quantity * product.Price };
            dataGridView2.DataSource = query2.ToList();

        }

        private void Invoice2_Load(object sender, EventArgs e)
        {

        }
    }
}
