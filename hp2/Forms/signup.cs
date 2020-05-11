using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hp2.Etest;

namespace hp2
{
    public partial class signup : UserControl
    {
        public signup()
        {
            InitializeComponent();
        }
        test1 t = new test1();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_signup_MouseHover(object sender, EventArgs e)
        {
            btn_signup.BackColor = Color.Aqua;
        }

        private void btn_signup_MouseLeave(object sender, EventArgs e)
        {
            btn_signup.BackColor = Color.White;
        }

        private void btn_cancel_signup_MouseHover(object sender, EventArgs e)
        {
            btn_cancel_signup.BackColor = Color.Red;
        }

        private void btn_cancel_signup_MouseLeave(object sender, EventArgs e)
        {
            btn_cancel_signup.BackColor = Color.White;

        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            t.USERID = txt_box_userid.Text;
            t.USERNAME = txt_box_name.Text;

            bool success = t.Insert(t);
            if(success==true)
            {
                MessageBox.Show("Inserted");
            }
            else
            {
                MessageBox.Show("Fail inserted");

            }
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("login"))
            {
                login lg = new login();
                lg.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(lg);
            }
            Form1.Instance.PnlContainer.Controls["login"].BringToFront();
        }

        private void btn_cancel_signup_Click(object sender, EventArgs e)
        {
            txt_box_userid.Text = "";
            txt_box_name.Text = "";
            txt_box_password.Text = "";
            txt_box_phone.Text = "";
            txt_box_address.Text = "";
            Form1.Instance.PnlContainer.Controls["firstpage"].BringToFront();
        }
    }
}
