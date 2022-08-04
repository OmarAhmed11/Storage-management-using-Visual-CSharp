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
    public partial class PurchaseItem : Form
    {
        Context context;
        int p_id;
        public PurchaseItem()
        {
            InitializeComponent();
            context = new Context();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
            comboBox1.DataSource = context.category.ToList();
            comboBox2.DisplayMember = "Name";
            comboBox2.ValueMember = "Id";
            comboBox2.DataSource = context.supplier.ToList();

            comboBox3.DisplayMember = "Name";
            comboBox3.ValueMember = "Id";
            comboBox3.DataSource = context.storage.ToList();
            //dataGridView1.DataSource = context.category.ToList();
            show_product();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox2.Text == string.Empty || textBox3.Text == string.Empty || textBox5.Text == string.Empty)
            {
                textBox2.Text = "Required";
                textBox2.ForeColor = Color.Red;
                textBox3.Text = "Required";
                textBox3.ForeColor = Color.Red;
                textBox5.Text = "Required";
                textBox5.ForeColor = Color.Red;
                return;

            }
            
            if (radioButton1.Checked)
           {
                var qury = (from c in context.category
               where c.Id == (int)comboBox1.SelectedValue
               select c).FirstOrDefault();
                ////add product
                Product p = new Product();
                p.Name = textBox2.Text;
                p.Price = int.Parse(textBox3.Text);
                p.Production_Date = Convert.ToDateTime(dateTimePicker1.Value);
                p.Expire_Date = Convert.ToDateTime(dateTimePicker2.Value);
                p.Quantity = int.Parse(textBox5.Text);
                p.category = qury;

                // new code 
                var qury2 =
                  (from c in context.supplier
                   where c.Id == (int)comboBox2.SelectedValue
                   select c).FirstOrDefault();
                Supplier_Invoice si = new Supplier_Invoice();
                si.Date = DateTime.Now;
                si.Supplier = qury2;
               

                Supplier_Invoice_Product sip = new Supplier_Invoice_Product();
                sip.Quantity = int.Parse(textBox5.Text);
                sip.Product_Id = p.Id;
                sip.Supplier_Invoice_Id = si.Id;
               

                ProductStorage ps = new ProductStorage();
                ps.Storage_Id = int.Parse(comboBox3.SelectedValue.ToString());
                ps.Product_Id = p.Id;
                ps.Quantity = int.Parse(textBox5.Text);

                context.supplier_invoice_product.Add(sip);
                context.supplier_invoice.Add(si);
                context.product.Add(p);
                context.productstorage.Add(ps);


                context.SaveChanges();
                show_product();
                //dataGridView1.DataSource = context.product.ToList();
            }
            else
            {
                
                int storageId = int.Parse(comboBox3.SelectedValue.ToString());

                Product prod = context.product.Where(p => p.Id == p_id).FirstOrDefault();
                prod.Quantity += int.Parse(textBox5.Text);


                ProductStorage prodStorage = context.productstorage.Where(p => p.Product_Id == p_id && p.Storage_Id == storageId).FirstOrDefault();
                prodStorage.Quantity += int.Parse(textBox5.Text);

                Supplier_Invoice si = new Supplier_Invoice();
                var qury =
                 (from c in context.supplier
                  where c.Id == (int)comboBox2.SelectedValue
                  select c).FirstOrDefault();
                si.Supplier = qury;
                si.Date = DateTime.Now;

                Supplier_Invoice_Product sip = new Supplier_Invoice_Product();
                sip.Supplier_Invoice_Id = si.Id;
                sip.Product_Id = p_id;
                sip.Quantity = int.Parse(textBox5.Text);

                int price = int.Parse(textBox3.Text);
                
               

                context.supplier_invoice.Add(si);
                context.supplier_invoice_product.Add(sip);
                context.SaveChanges();
                show_product();
            }

        }
        private void show_product()
        {
            dataGridView1.DataSource = (from p in context.product
                                        select new { p.Id, p.Name, p.Price, p.Production_Date, p.Quantity, p.Expire_Date, catname = p.category.Name, cat_id = p.category.Id }).ToList();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox2.Text = row.Cells[1].Value.ToString();
                textBox3.Text = row.Cells[2].Value.ToString();
                //var production_date=(DateTime)dataGridView1.CurrentRow.Cells[3].Value;
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells[3].Value);
                textBox5.Text = row.Cells[4].Value.ToString();
                dateTimePicker2.Value = Convert.ToDateTime(row.Cells[5].Value);
                comboBox1.Text = row.Cells[6].Value.ToString();
                p_id = int.Parse(row.Cells[0].Value.ToString());

            }
        }
        private void button2_Click(object sender, EventArgs e)

        {
            Product qury = context.product.Where(i => i.Id == p_id).FirstOrDefault();
            qury.Name = textBox2.Text;
            qury.Price = int.Parse(textBox3.Text);
            qury.Production_Date = dateTimePicker1.Value;
            qury.Quantity = int.Parse(textBox5.Text);
            qury.Expire_Date = dateTimePicker2.Value;
            qury.category.Name = comboBox1.Text;
            //qury.category.Id = categoryID;
            context.SaveChanges();
            show_product();

            calculate_total_price();

        }
        private void button3_Click(object sender, EventArgs e)
        {
            var p_id = (int)dataGridView1.CurrentRow.Cells[0].Value;
            var qury =
               (from p in context.product
                where p.Id == p_id
                select p).FirstOrDefault();
            context.product.Remove(qury);
            context.SaveChanges();

            show_product();
            calculate_total_price();

        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            calculate_total_price();
        }
        private void calculate_total_price()
        {
            Double totalPrice = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                totalPrice += Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
            }
            textBox1.Text = totalPrice.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.ForeColor = Color.Black;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.ForeColor = Color.Black;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.ForeColor = Color.Black;
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked && !isChecked)
                radioButton1.Checked = false;
            else
            {
                radioButton1.Checked = true;
                isChecked = false;
            }
        }
        bool isChecked = false;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            isChecked = radioButton1.Checked;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
