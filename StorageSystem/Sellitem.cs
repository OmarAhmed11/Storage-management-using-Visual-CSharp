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
    public partial class Sellitem : Form
    {
        Context context;
        int productId;
        public Sellitem()
        {
            InitializeComponent();
            context = new Context();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
            comboBox1.DataSource = context.customer.ToList();

            comboBox2.DisplayMember = "Name";
            comboBox2.ValueMember = "Id";
            comboBox2.DataSource = context.storage.ToList();


     
            dataGridView1.DataSource = context.product.ToList();
        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int storageId = int.Parse(comboBox2.SelectedValue.ToString());
            var prod = from ps in context.storage
                       join s in context.productstorage
                       on ps.Id equals s.Storage_Id
                       join p in context.product
                       on s.Product_Id equals p.Id
                       where ps.Id == storageId
                       select p;

            dataGridView1.DataSource = prod.ToList();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            int quan = int.Parse(textBox1.Text);
            int storageId = int.Parse(comboBox2.SelectedValue.ToString());

            ProductStorage prodStore = context.productstorage
                .Where(p => p.Product_Id == productId && p.Storage_Id == storageId).FirstOrDefault();
            int OldQun = prodStore.Quantity;

            var product_qury =
                (from p in context.product
                where p.Id == productId
                select p).FirstOrDefault();
            var productQuan = product_qury.Quantity;

            if (OldQun >= quan && productQuan >= quan)
            {
                OldQun -= quan;
                prodStore.Quantity = OldQun - quan;

                product_qury.Quantity -= int.Parse(textBox1.Text);
                context.SaveChanges();

                var query1 = (from c in context.customer
                             where c.ID == (int)comboBox1.SelectedValue
                             select c).FirstOrDefault();
                int cid = int.Parse(comboBox1.SelectedValue.ToString());
                
                Customer_Invoice CI = new Customer_Invoice()
                {
                    date = DateTime.Now,
                    Customer = query1
                    
                };
                context.customer_invoice.Add(CI);
                context.SaveChanges();

                var query2 = (from ci in context.customer_invoice
                              where ci.Customer.ID == (int)comboBox1.SelectedValue
                              select ci.ID).FirstOrDefault();
                Customer_Invoice_Product CIP = new Customer_Invoice_Product()
                {
                    Customer_Invoice_Id = query2,
                    Quantity = quan,
                    Product_Id = productId,
                    //TotalPrice
                };
                context.customer_invoice_product.Add(CIP);

                context.SaveChanges();
                dataGridView1.DataSource = context.product.ToList();
            }
            else
            {
                MessageBox.Show("can't order this product from this storage There is not enough quantity!");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            productId = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }
    }
}
