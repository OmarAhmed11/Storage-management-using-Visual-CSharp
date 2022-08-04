using StorageSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Storage
{
    public partial class Form1 : Form
    {
        Category model = new Category();
        Context context;
        public int Category_id;
        public Form1()
        {
            InitializeComponent();
            context = new Context();
            dataGridView1.DataSource = context.category.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            clear();
        }
        void clear()
        {
            textBox2.Text = "";
            button1.Text = "Add";
            button2.Text = "Update";
           
            
            model.Id = 0;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clear();
            var category = context.category;
            category.Add(new Category() { Name = textBox2.Text });
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var category = context.category;

            //category.Add(new Category() { Name = textBox2.Text });

            //context.SaveChanges();
            string Name = textBox2.Text;
            Category cate = new Category()
            {
                Name = Name
            };
            context.category.Add(cate);
            context.SaveChanges();

            dataGridView1.DataSource = context.category.ToList();

        }
        //Update
        private void button2_Click(object sender, EventArgs e)
        {
            Category categ = (from s in context.category where s.Id == Category_id select s).FirstOrDefault();

            categ.Name = textBox2.Text;;
            context.SaveChanges();
            dataGridView1.DataSource = context.category.ToList();
        }
       
        
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox2.Text = row.Cells[1].Value.ToString();
               
                Category_id = int.Parse(row.Cells[0].Value.ToString());

            }
        }

        
    }
}
