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
    public partial class ShowCategory : Form
    {
        Context ShowCat;
        int id;
        public ShowCategory()
        {
            InitializeComponent();
            ShowCat = new Context();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var category = ShowCat.category;
            category.Add(new Category() { Name = textBox1.Text });
            var AllCat = ShowCat.category.ToList();
            dataGridView1.DataSource = AllCat;
            ShowCat.SaveChanges();
            var AllCat2 = ShowCat.category.ToList();
            dataGridView1.DataSource = AllCat2;

        }

        private void ShowCategory_Load(object sender, EventArgs e)
        {

            var AllCat = ShowCat.category.ToList();
            dataGridView1.DataSource = AllCat;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            
            string getCat = textBox1.Text;
            var c = ShowCat.category.Where(x => x.Id == id).FirstOrDefault();
            c.Name = getCat;
            ShowCat.SaveChanges();
            var AllCat = ShowCat.category.ToList();
            dataGridView1.DataSource = AllCat;
        }


    }
}
