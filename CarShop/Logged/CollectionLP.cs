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
    public partial class CollectionLP : Form
    {
        public CollectionLP()
        {
            InitializeComponent();
        }

        private void username_show_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to log out?";
            string title = "Log out";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                HomepageNL hml = new HomepageNL();
                hml.Show();

                this.Close();

            }
            else
            {
                // Do something  
            }
        }

        private void Homebtn_NL_Click(object sender, EventArgs e)
        {
            MainHome mh = new MainHome();
            mh.Show();

            this.Close();
        }

        private void CollectionBTN_NL_Click(object sender, EventArgs e)
        {

        }

        private void CartBTN_NL_Click(object sender, EventArgs e)
        {
            Cart crt = new Cart();
            crt.Show();

            this.Close();
        }

        private void paymentBTN_NL_Click(object sender, EventArgs e)
        {
            Payment pay = new Payment();
            pay.Show();

            this.Close();
        }

        private void drop_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CollectionLP_Load(object sender, EventArgs e)
        {
            User_showname.Text = LoginPage.WelcomeName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Shop1 sh = new Shop1();
            sh.Show();

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Shop2 sh = new Shop2();
            sh.Show();

            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Shop3 sh = new Shop3(); sh.Show(); this.Close();
        }

        private void Next_btn_Click(object sender, EventArgs e)
        {
            CollectionLP2 clp2 = new CollectionLP2();
            clp2.Show();

            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
