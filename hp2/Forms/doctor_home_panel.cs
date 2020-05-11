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
    public partial class doctor_home_panel : UserControl
    {
        public doctor_home_panel()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("login"))
            {
                login lg = new login();
                lg.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(lg);
            }
            Form1.Instance.PnlContainer.Controls["login"].BringToFront();
        }
    }
}
