using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarShop
{
    public partial class Success : Form
    {
        public Success()
        {
            InitializeComponent();
        }

        private void successbtn_Click(object sender, EventArgs e)
        {
            MainHome hml = new MainHome();
            hml.Show();

            this.Close();
        }

        private void drop_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void success_btn_Click(object sender, EventArgs e)
        {
            MainHome mhn = new MainHome();
            mhn.Show();

            this.Close();
        }
    }
}
