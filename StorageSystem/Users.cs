using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorageSystem
{
    public partial class Users : Form
    {
        Context context;
        public Users()
        {
            InitializeComponent();
            context = new Context();
            show_customers_suppliers();
        }

        private void seller_r_btn_CheckedChanged(object sender, EventArgs e)
        {
            choose_type_err_lbl.Visible = false;
            add_process.Visible = false;
            if (seller_r_btn.Checked)
                C_S_btn.Text = "add seller";
            else
                C_S_btn.Text = "add customer";
        }

        private void name_txt_box_TextChanged(object sender, EventArgs e)
        {
            string battern = "[a-zA-Zأ-ى]";
            var regex = new Regex(battern);
            if (regex.IsMatch(name_txt_box.Text) || name_txt_box.Text == string.Empty)
            {
                name_eror_lbl.Visible = false;
                C_S_btn.Enabled = true;
            }
            else
            {
                C_S_btn.Enabled = false;
                name_eror_lbl.Visible = true;
            }

        }

        private void phone_txt_box_TextChanged(object sender, EventArgs e)
        {
            var battern = "[0][1][015]";
            var regex = new Regex(battern);
            if (phone_txt_box.Text == string.Empty || regex.IsMatch(phone_txt_box.Text))
            {

                C_S_btn.Enabled = true;
                phone_eror_lbl.Visible = false;

            }
            else
            {
                phone_eror_lbl.Visible = true;
                C_S_btn.Enabled = false;

            }
        }

        private void C_S_btn_Click(object sender, EventArgs e)
        {
            if (!is_valid_length())
            {
                phone_eror_lbl.Visible = true;
                return;
            }

            if (customer_r_btn.Checked)
            {
                //custoemr
                context.customer.Add(new StorageSystem.Customer()
                {
                    Name = name_txt_box.Text,
                    Phone = phone_txt_box.Text
                });
                context.SaveChanges();
                add_process.Text = "Customer added";
                add_process.Visible = true;
                name_txt_box.Text = "";
                phone_txt_box.Text = "";

            }
            else if (seller_r_btn.Checked)
            {
                context.supplier.Add(new StorageSystem.Supplier()
                {
                    Name = name_txt_box.Text,
                    Phone = int.Parse(phone_txt_box.Text)
                });
                context.SaveChanges();
                add_process.Text = "Supplier added";
                add_process.Visible = true;
                name_txt_box.Text = "";
                phone_txt_box.Text = "";

            }
            else
            {
                choose_type_err_lbl.Visible = true;
            }
            show_customers_suppliers();
        }

        private void name_txt_box_MouseClick(object sender, MouseEventArgs e)
        {
            add_process.Visible = false;
        }

        private void customer_r_btn_CheckedChanged(object sender, EventArgs e)
        {
            add_process.Visible = false;
            choose_type_err_lbl.Visible = false;
        }

        private void show_customers_suppliers()
        {
            var customers =
                from c in context.customer
                select new { c.Name, c.Phone };

            customers_gv.DataSource = customers.ToList();

            var suppliers =
                from s in context.supplier
                select new { s.Name, s.Phone };

            suppliers_gv.DataSource = suppliers.ToList();
        }
        private bool is_valid_length()
        {
            return phone_txt_box.Text.Length == 11;
        }

    }
}
