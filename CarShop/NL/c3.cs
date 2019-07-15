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
    public partial class c3 : Form
    {
        public c3()
        {
            InitializeComponent();
        }

        private void drop_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginPage lgp = new LoginPage();
            lgp.Show();

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CollectionsNL cln = new CollectionsNL();
            cln.Show();

            this.Show();
        }

        private void Homebtn_NL_Click(object sender, EventArgs e)
        {
            HomepageNL hml = new HomepageNL();
            hml.Show();

            this.Close();
        }

        private void lucidVideoBtn_Click(object sender, EventArgs e)
        {
            videoVixen vvv = new videoVixen();
            vvv.Show();

            this.Close();
        }

        private void CartBTN_NL_Click(object sender, EventArgs e)
        {
            LoginPage lgp = new LoginPage();
            lgp.Show();

            this.Close();
        }

        private void paymentBTN_NL_Click(object sender, EventArgs e)
        {
            LoginPage lgp = new LoginPage();
            lgp.Show();

            this.Close();
        }

        private void LoginBTN_Click(object sender, EventArgs e)
        {
            LoginPage lgp = new LoginPage();
            lgp.Show();

            this.Close();
        }

        private void SIGNUpBTN_Click(object sender, EventArgs e)
        {
            
        }

        private void drop_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Homebtn_NL_Click_1(object sender, EventArgs e)
        {
            HomepageNL hml = new HomepageNL();
            hml.Show();

            this.Close();
        }

        private void lucidVideoBtn_Click_1(object sender, EventArgs e)
        {
            videoVixen vvv = new videoVixen();
            vvv.Show();

            this.Close();
        }

        private void CartBTN_NL_Click_1(object sender, EventArgs e)
        {
            LoginPage lgp = new LoginPage();
            lgp.Show();

            this.Close();

        }

        private void paymentBTN_NL_Click_1(object sender, EventArgs e)
        {
            LoginPage lgp = new LoginPage();
            lgp.Show();

            this.Close();
        }

        private void LoginBTN_Click_1(object sender, EventArgs e)
        {
            LoginPage lgp = new LoginPage();
            lgp.Show();

            this.Close();
        }

        private void SIGNUpBTN_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LoginPage lgp = new LoginPage();
            lgp.Show();

            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            CollectionsNL clm = new CollectionsNL();
            clm.Show();

            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
