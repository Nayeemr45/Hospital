using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hp2
{
    public partial class login : UserControl
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_logIn_Click(object sender, EventArgs e)
        {
            if(txt_box_login_userid.Text=="" || txt_box_login_password.Text=="")
            {
                MessageBox.Show("Please enter the value");
                txt_box_login_userid.Text = "";
                txt_box_login_password.Text = "";
                Form1.Instance.PnlContainer.Controls["login"].BringToFront();



            }
            else
            {

                string result = txt_box_login_userid.Text.Substring(0, 1);
                if (result == "a")
                {
                    MessageBox.Show("LogIn as Admin");
                    if (!Form1.Instance.PnlContainer.Controls.ContainsKey("admin_panel"))
                    {
                        admin_panel ap = new admin_panel();
                        ap.Dock = DockStyle.Fill;
                        Form1.Instance.PnlContainer.Controls.Add(ap);
                    }
                    Form1.Instance.PnlContainer.Controls["admin_panel"].BringToFront();

                }

                else if(result == "p")
                {
                    MessageBox.Show("LogIn as Patient");
                    if (!Form1.Instance.PnlContainer.Controls.ContainsKey("patient_panel"))
                    {
                        patient_panel pp = new patient_panel();
                        pp.Dock = DockStyle.Fill;
                        Form1.Instance.PnlContainer.Controls.Add(pp);
                    }
                    Form1.Instance.PnlContainer.Controls["patient_panel"].BringToFront();
                }

                else if (result == "d")
                {
                    MessageBox.Show("LogIn as Doctor");
                    if (!Form1.Instance.PnlContainer.Controls.ContainsKey("doctor_panel"))
                    {
                        doctor_panel dp = new doctor_panel();
                        dp.Dock = DockStyle.Fill;
                        Form1.Instance.PnlContainer.Controls.Add(dp);
                    }
                    Form1.Instance.PnlContainer.Controls["doctor_panel"].BringToFront();
                }

            }




            
        }

        private void btn_logIn_MouseHover(object sender, EventArgs e)
        {
            btn_logIn.BackColor = Color.Aqua;

        }

        private void btn_logIn_MouseLeave(object sender, EventArgs e)
        {
            btn_logIn.BackColor = Color.White;
        }

        private void btn_cancel_login_Click(object sender, EventArgs e)
        {
            txt_box_login_userid.Text = "";
            txt_box_login_password.Text = "";
            Form1.Instance.PnlContainer.Controls["firstpage"].BringToFront();
        }

        private void btn_cancel_login_MouseHover(object sender, EventArgs e)
        {
            btn_cancel_login.BackColor = Color.Red;

        }

        private void btn_cancel_login_MouseLeave(object sender, EventArgs e)
        {
            btn_cancel_login.BackColor = Color.White;

        }
    }
}
