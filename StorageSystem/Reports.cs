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
    public partial class Reports : Form
    {
        Context Rep;
        int catId;
        public Reports()
        {
            InitializeComponent();
            Rep = new Context();

 

            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
            comboBox1.DataSource = Rep.category.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Rep.product.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string SupplierName = textBox1.Text;
            var query = Rep.supplier.Where(item => item.Name == SupplierName);
            dataGridView1.DataSource = query.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int getNum = int.Parse(textBox2.Text);
            var query = Rep.product.Where(x => x.Quantity <= getNum);
            dataGridView1.DataSource = query.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        { 

            catId = int.Parse(comboBox1.SelectedValue.ToString());
            var query = from prod in Rep.product
                        where prod.category.Id == catId
                        select prod;
            dataGridView1.DataSource = query.ToList();

        }

    }
}
