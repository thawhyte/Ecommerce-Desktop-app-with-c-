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
    public partial class c1 : Form
    {
        public c1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginPage lgp = new LoginPage();
            lgp.Show();

            this.Close();
        }

        private void drop_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            LoginPage lpg = new LoginPage();
            lpg.Show();

            this.Close();
        }

        private void paymentBTN_NL_Click(object sender, EventArgs e)
        {
            LoginPage lpg = new LoginPage();
            lpg.Show();

            this.Close();
        }

        private void LoginBTN_Click(object sender, EventArgs e)
        {
            LoginPage lpg = new LoginPage();
            lpg.Show();

            this.Close();
        }

        private void SIGNUpBTN_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CollectionsNL ctn = new CollectionsNL();
            ctn.Show();

            this.Close();
        }

        private void drop_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            CollectionsNL cll = new CollectionsNL();
            cll.Show();

            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LoginPage lgp = new LoginPage();
            lgp.Show();


            this.Close();
        }

        private void Homebtn_NL_Click_1(object sender, EventArgs e)
        {
            HomepageNL hml = new HomepageNL();
            hml.Show();

            this.Close();
        }

        private void lucidVideoBtn_Click_1(object sender, EventArgs e)
        {
            videoVixen vv = new videoVixen();
            vv.Show();

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

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
