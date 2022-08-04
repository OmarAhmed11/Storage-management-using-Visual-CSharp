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
    public partial class AddStorage : Form
    {
        Context context;
        public AddStorage()
        {
            InitializeComponent();
            context = new Context();

            var query = context.storage.ToList();
            dataGridView1.DataSource = query;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string StorageName = textBox1.Text;
            int StorageCapacity = int.Parse(textBox2.Text);
            string Address = textBox3.Text;

            Storage st = new Storage();
            st.Name = StorageName;
            st.Capacity = StorageCapacity;
            st.Address = Address;

            context.storage.Add(st);
            context.SaveChanges();

            var query = context.storage.ToList();
            dataGridView1.DataSource = query;
        }
    }
}
