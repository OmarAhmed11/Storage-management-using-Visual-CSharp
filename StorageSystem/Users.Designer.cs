
namespace StorageSystem
{
    partial class Users
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.add_CustomerORsupplier_gb = new System.Windows.Forms.GroupBox();
            this.choose_type_err_lbl = new System.Windows.Forms.Label();
            this.name_txt_box = new System.Windows.Forms.TextBox();
            this.customer_r_btn = new System.Windows.Forms.RadioButton();
            this.seller_r_btn = new System.Windows.Forms.RadioButton();
            this.phone_eror_lbl = new System.Windows.Forms.Label();
            this.name_lbl = new System.Windows.Forms.Label();
            this.name_eror_lbl = new System.Windows.Forms.Label();
            this.phone_lbl = new System.Windows.Forms.Label();
            this.C_S_btn = new System.Windows.Forms.Button();
            this.phone_txt_box = new System.Windows.Forms.TextBox();
            this.suplier_gb = new System.Windows.Forms.GroupBox();
            this.suppliers_gv = new System.Windows.Forms.DataGridView();
            this.customers_gb = new System.Windows.Forms.GroupBox();
            this.customers_gv = new System.Windows.Forms.DataGridView();
            this.add_process = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.add_CustomerORsupplier_gb.SuspendLayout();
            this.suplier_gb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suppliers_gv)).BeginInit();
            this.customers_gb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customers_gv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.add_CustomerORsupplier_gb);
            this.panel1.Controls.Add(this.suplier_gb);
            this.panel1.Controls.Add(this.customers_gb);
            this.panel1.Controls.Add(this.add_process);
            this.panel1.Location = new System.Drawing.Point(88, 17);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 524);
            this.panel1.TabIndex = 0;
            // 
            // add_CustomerORsupplier_gb
            // 
            this.add_CustomerORsupplier_gb.Controls.Add(this.choose_type_err_lbl);
            this.add_CustomerORsupplier_gb.Controls.Add(this.name_txt_box);
            this.add_CustomerORsupplier_gb.Controls.Add(this.customer_r_btn);
            this.add_CustomerORsupplier_gb.Controls.Add(this.seller_r_btn);
            this.add_CustomerORsupplier_gb.Controls.Add(this.phone_eror_lbl);
            this.add_CustomerORsupplier_gb.Controls.Add(this.name_lbl);
            this.add_CustomerORsupplier_gb.Controls.Add(this.name_eror_lbl);
            this.add_CustomerORsupplier_gb.Controls.Add(this.phone_lbl);
            this.add_CustomerORsupplier_gb.Controls.Add(this.C_S_btn);
            this.add_CustomerORsupplier_gb.Controls.Add(this.phone_txt_box);
            this.add_CustomerORsupplier_gb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_CustomerORsupplier_gb.Location = new System.Drawing.Point(44, 274);
            this.add_CustomerORsupplier_gb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.add_CustomerORsupplier_gb.Name = "add_CustomerORsupplier_gb";
            this.add_CustomerORsupplier_gb.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.add_CustomerORsupplier_gb.Size = new System.Drawing.Size(556, 246);
            this.add_CustomerORsupplier_gb.TabIndex = 12;
            this.add_CustomerORsupplier_gb.TabStop = false;
            this.add_CustomerORsupplier_gb.Text = "add customer or supplier";
            // 
            // choose_type_err_lbl
            // 
            this.choose_type_err_lbl.AutoSize = true;
            this.choose_type_err_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choose_type_err_lbl.ForeColor = System.Drawing.Color.Red;
            this.choose_type_err_lbl.Location = new System.Drawing.Point(331, 32);
            this.choose_type_err_lbl.Name = "choose_type_err_lbl";
            this.choose_type_err_lbl.Size = new System.Drawing.Size(118, 25);
            this.choose_type_err_lbl.TabIndex = 9;
            this.choose_type_err_lbl.Text = "choose type";
            this.choose_type_err_lbl.Visible = false;
            // 
            // name_txt_box
            // 
            this.name_txt_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_txt_box.Location = new System.Drawing.Point(94, 81);
            this.name_txt_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.name_txt_box.Name = "name_txt_box";
            this.name_txt_box.Size = new System.Drawing.Size(214, 30);
            this.name_txt_box.TabIndex = 4;
            this.name_txt_box.MouseClick += new System.Windows.Forms.MouseEventHandler(this.name_txt_box_MouseClick);
            this.name_txt_box.TextChanged += new System.EventHandler(this.name_txt_box_TextChanged);
            // 
            // customer_r_btn
            // 
            this.customer_r_btn.AutoSize = true;
            this.customer_r_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_r_btn.Location = new System.Drawing.Point(94, 27);
            this.customer_r_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customer_r_btn.Name = "customer_r_btn";
            this.customer_r_btn.Size = new System.Drawing.Size(113, 29);
            this.customer_r_btn.TabIndex = 0;
            this.customer_r_btn.TabStop = true;
            this.customer_r_btn.Text = "customer";
            this.customer_r_btn.UseVisualStyleBackColor = true;
            this.customer_r_btn.CheckedChanged += new System.EventHandler(this.customer_r_btn_CheckedChanged);
            // 
            // seller_r_btn
            // 
            this.seller_r_btn.AutoSize = true;
            this.seller_r_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seller_r_btn.Location = new System.Drawing.Point(210, 27);
            this.seller_r_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.seller_r_btn.Name = "seller_r_btn";
            this.seller_r_btn.Size = new System.Drawing.Size(105, 29);
            this.seller_r_btn.TabIndex = 1;
            this.seller_r_btn.TabStop = true;
            this.seller_r_btn.Text = "Supplier";
            this.seller_r_btn.UseVisualStyleBackColor = true;
            this.seller_r_btn.CheckedChanged += new System.EventHandler(this.seller_r_btn_CheckedChanged);
            // 
            // phone_eror_lbl
            // 
            this.phone_eror_lbl.AutoSize = true;
            this.phone_eror_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_eror_lbl.ForeColor = System.Drawing.Color.Red;
            this.phone_eror_lbl.Location = new System.Drawing.Point(331, 146);
            this.phone_eror_lbl.Name = "phone_eror_lbl";
            this.phone_eror_lbl.Size = new System.Drawing.Size(161, 25);
            this.phone_eror_lbl.TabIndex = 8;
            this.phone_eror_lbl.Text = "enter valid phone";
            this.phone_eror_lbl.Visible = false;
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_lbl.Location = new System.Drawing.Point(15, 81);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(67, 25);
            this.name_lbl.TabIndex = 2;
            this.name_lbl.Text = "name:";
            // 
            // name_eror_lbl
            // 
            this.name_eror_lbl.AutoSize = true;
            this.name_eror_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_eror_lbl.ForeColor = System.Drawing.Color.Red;
            this.name_eror_lbl.Location = new System.Drawing.Point(331, 81);
            this.name_eror_lbl.Name = "name_eror_lbl";
            this.name_eror_lbl.Size = new System.Drawing.Size(155, 25);
            this.name_eror_lbl.TabIndex = 7;
            this.name_eror_lbl.Text = "enter valid name";
            this.name_eror_lbl.Visible = false;
            // 
            // phone_lbl
            // 
            this.phone_lbl.AutoSize = true;
            this.phone_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_lbl.Location = new System.Drawing.Point(9, 139);
            this.phone_lbl.Name = "phone_lbl";
            this.phone_lbl.Size = new System.Drawing.Size(73, 25);
            this.phone_lbl.TabIndex = 3;
            this.phone_lbl.Text = "phone:";
            // 
            // C_S_btn
            // 
            this.C_S_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_S_btn.Location = new System.Drawing.Point(136, 187);
            this.C_S_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.C_S_btn.Name = "C_S_btn";
            this.C_S_btn.Size = new System.Drawing.Size(173, 42);
            this.C_S_btn.TabIndex = 6;
            this.C_S_btn.Text = "add customer";
            this.C_S_btn.UseVisualStyleBackColor = true;
            this.C_S_btn.Click += new System.EventHandler(this.C_S_btn_Click);
            // 
            // phone_txt_box
            // 
            this.phone_txt_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_txt_box.Location = new System.Drawing.Point(94, 139);
            this.phone_txt_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.phone_txt_box.Name = "phone_txt_box";
            this.phone_txt_box.Size = new System.Drawing.Size(214, 30);
            this.phone_txt_box.TabIndex = 5;
            this.phone_txt_box.TextChanged += new System.EventHandler(this.phone_txt_box_TextChanged);
            // 
            // suplier_gb
            // 
            this.suplier_gb.Controls.Add(this.suppliers_gv);
            this.suplier_gb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suplier_gb.Location = new System.Drawing.Point(343, 4);
            this.suplier_gb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.suplier_gb.Name = "suplier_gb";
            this.suplier_gb.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.suplier_gb.Size = new System.Drawing.Size(258, 263);
            this.suplier_gb.TabIndex = 11;
            this.suplier_gb.TabStop = false;
            this.suplier_gb.Text = "suppliers";
            // 
            // suppliers_gv
            // 
            this.suppliers_gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.suppliers_gv.Location = new System.Drawing.Point(0, 31);
            this.suppliers_gv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.suppliers_gv.Name = "suppliers_gv";
            this.suppliers_gv.RowHeadersWidth = 51;
            this.suppliers_gv.Size = new System.Drawing.Size(258, 225);
            this.suppliers_gv.TabIndex = 1;
            // 
            // customers_gb
            // 
            this.customers_gb.Controls.Add(this.customers_gv);
            this.customers_gb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customers_gb.Location = new System.Drawing.Point(44, 4);
            this.customers_gb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customers_gb.Name = "customers_gb";
            this.customers_gb.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customers_gb.Size = new System.Drawing.Size(258, 263);
            this.customers_gb.TabIndex = 10;
            this.customers_gb.TabStop = false;
            this.customers_gb.Text = "customers";
            // 
            // customers_gv
            // 
            this.customers_gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customers_gv.Location = new System.Drawing.Point(0, 31);
            this.customers_gv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customers_gv.Name = "customers_gv";
            this.customers_gv.RowHeadersWidth = 51;
            this.customers_gv.Size = new System.Drawing.Size(258, 225);
            this.customers_gv.TabIndex = 0;
            // 
            // add_process
            // 
            this.add_process.AutoSize = true;
            this.add_process.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_process.ForeColor = System.Drawing.Color.Lime;
            this.add_process.Location = new System.Drawing.Point(360, 459);
            this.add_process.Name = "add_process";
            this.add_process.Size = new System.Drawing.Size(0, 25);
            this.add_process.TabIndex = 9;
            this.add_process.Visible = false;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Users";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.add_CustomerORsupplier_gb.ResumeLayout(false);
            this.add_CustomerORsupplier_gb.PerformLayout();
            this.suplier_gb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.suppliers_gv)).EndInit();
            this.customers_gb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customers_gv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button C_S_btn;
        private System.Windows.Forms.TextBox phone_txt_box;
        private System.Windows.Forms.TextBox name_txt_box;
        private System.Windows.Forms.Label phone_lbl;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.RadioButton seller_r_btn;
        private System.Windows.Forms.RadioButton customer_r_btn;
        private System.Windows.Forms.Label phone_eror_lbl;
        private System.Windows.Forms.Label name_eror_lbl;
        private System.Windows.Forms.Label add_process;
        private System.Windows.Forms.GroupBox suplier_gb;
        private System.Windows.Forms.DataGridView suppliers_gv;
        private System.Windows.Forms.GroupBox customers_gb;
        private System.Windows.Forms.DataGridView customers_gv;
        private System.Windows.Forms.GroupBox add_CustomerORsupplier_gb;
        private System.Windows.Forms.Label choose_type_err_lbl;
    }
}