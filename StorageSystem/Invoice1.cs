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
    public partial class Invoice1 : Form
    {
        private Form activeForm;
        public Invoice1()
        {
            InitializeComponent();
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.BringToFront();
            childForm.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Invoice2(), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Invoice3(), sender);
        }

        private void Invoice1_Load(object sender, EventArgs e)
        {

        }
    }
}
