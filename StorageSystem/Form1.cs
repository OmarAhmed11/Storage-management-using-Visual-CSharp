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
    public partial class Form1 : Form
    {
        private Button currentButton;
        private Form activeForm;
        public Form1()
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
            this.panelForms.Controls.Add(childForm);
            this.panelForms.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            label1.Text = childForm.Text;
        }

        private void ButtonCategory_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ShowCategory(), sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PurchaseItem(), sender);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Sellitem(), sender);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Reports(), sender);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Invoice3(), sender);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Invoice2(), sender);
        }
        private void Reset()
        {
            label1.Text = "HOME";
            currentButton = null;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Users(), sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddStorage(), sender);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }
    }
}
