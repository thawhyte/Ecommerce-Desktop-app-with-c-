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
    public partial class CollectionsNL : Form
    {
        public CollectionsNL()
        {
            InitializeComponent();
        }

        private void Next_btn_Click(object sender, EventArgs e)
        {
            collectionmore clmr = new collectionmore();
            clmr.Show();

            this.Close();
        }

        private void lucidVideoBtn_Click(object sender, EventArgs e)
        {
            videoVixen vvv = new videoVixen();
            vvv.Show();

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c1 c = new c1();
            c.Show();

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            c2 c = new c2();
            c.Show();

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

        private void button3_Click(object sender, EventArgs e)
        {
            c3 c = new c3();
            c.Show();

            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
