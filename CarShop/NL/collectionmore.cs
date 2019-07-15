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
    public partial class collectionmore : Form
    {
        public collectionmore()
        {
            InitializeComponent();
        }

        private void drop_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Next_btn_Click(object sender, EventArgs e)
        {
            CollectionsNL cnl = new CollectionsNL();
            cnl.Show();

            this.Close();
        }

        private void Homebtn_NL_Click(object sender, EventArgs e)
        {
            HomepageNL hmp = new HomepageNL();
            hmp.Show();

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

        private void CollectionBTN_NL_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            c4 c = new c4();
            c.Show();

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            c5 c = new c5();
            c.Show();

            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            c6 c = new c6();
            c.Show();

            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
