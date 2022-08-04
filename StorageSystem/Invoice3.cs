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
    public partial class Invoice3 : Form
    {
        Context context = new Context();
        public Invoice3()
        {
            InitializeComponent();
            var query = from supplier in context.supplier
                        join supp_invoice in context.supplier_invoice on supplier equals supp_invoice.Supplier
                        select new { supp_invoice.Id, supp_invoice.Date, supplier.Name, supplier.Phone };
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
            List<Supplier_Invoice> empty = new List<Supplier_Invoice>();
            if (comboBox1.Text == "Invoice Id")
            {
                int id = Convert.ToInt32(textBox1.Text);
                var qyery1 = from supplier in context.supplier
                             join supp_invoice in context.supplier_invoice on supplier equals supp_invoice.Supplier
                             where supp_invoice.Id == id
                             select new { supp_invoice.Id, supp_invoice.Date, supplier.Name };
                dataGridView1.DataSource = empty;
                dataGridView1.DataSource = qyery1.ToList();
            }
            if (comboBox1.Text == "Supplier Name")
            {
                var qyery1 = from supplier in context.supplier
                             join supp_invoice in context.supplier_invoice on supplier equals supp_invoice.Supplier
                             where supplier.Name == textBox1.Text
                             select new { supp_invoice.Id, supp_invoice.Date, supplier.Name };
                dataGridView1.DataSource = empty;
                dataGridView1.DataSource = qyery1.ToList();
            }
            if (comboBox1.Text == "Date")
            {
                var date_month = dateTimePicker1.Value.Month;
                var date_year = dateTimePicker1.Value.Year;
                var qyery1 = from supplier in context.supplier
                             join supp_invoice in context.supplier_invoice on supplier equals supp_invoice.Supplier
                             where supp_invoice.Date.Year == date_year && supp_invoice.Date.Month == date_month
                             select new { supp_invoice.Id, supp_invoice.Date, supplier.Name };
                dataGridView1.DataSource = empty;
                dataGridView1.DataSource = qyery1.ToList();
            }

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var selectedInvoiceId = dataGridView1.CurrentRow.Cells[0].Value;
            textBox2.Text = selectedInvoiceId.ToString();
            int invoice_id = Convert.ToInt32(selectedInvoiceId.ToString());
            var selectedInvoiceDate = dataGridView1.CurrentRow.Cells[1].Value;
            textBox3.Text = selectedInvoiceDate.ToString();
            var selectedInvoiceSupplierName = dataGridView1.CurrentRow.Cells[2].Value;
            textBox4.Text = selectedInvoiceSupplierName.ToString();
            var selectedInvoiceSupplierPhone = dataGridView1.CurrentRow.Cells[3].Value;
            textBox5.Text = selectedInvoiceSupplierPhone.ToString();
            var query2 = from invoice in context.supplier_invoice
                         join invoice_product in context.supplier_invoice_product on invoice.Id equals invoice_product.Supplier_Invoice_Id
                         join product in context.product on invoice_product.Product_Id equals product.Id
                         where invoice.Id == invoice_id
                         select new { invoice_product.Product_Id, product.Name, invoice_product.Quantity, product.Price, total_price = invoice_product.Quantity * product.Price };
            dataGridView2.DataSource = query2.ToList();

        }


    }
}
