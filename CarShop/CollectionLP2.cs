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
    public partial class CollectionLP2 : Form
    {
        public CollectionLP2()
        {
            InitializeComponent();
        }

        private void drop_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void username_show_Click(object sender, EventArgs e)
        {
            HomepageNL hml = new HomepageNL(); hml.Show();
            this.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Shop4 sh = new Shop4(); sh.Show(); this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Shop5 sh = new Shop5(); sh.Show(); this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Shop6 sh = new Shop6();
            sh.Show();
            this.Close();
        }

        private void Next_btn_Click(object sender, EventArgs e)
        {
            CollectionLP clp = new CollectionLP();
            clp.Show();

            this.Close();
        }

        private void Homebtn_NL_Click(object sender, EventArgs e)
        {
            MainHome hm = new MainHome(); hm.Show(); this.Close();
        }

        private void CartBTN_NL_Click(object sender, EventArgs e)
        {
            Cart cart = new Cart();
            cart.Show(); this.Close();
        }

        private void paymentBTN_NL_Click(object sender, EventArgs e)
        {
            Payment pyt = new Payment();
            pyt.Show();
            this.Close();
        }

        private void CollectionLP2_Load(object sender, EventArgs e)
        {
            User_showname.Text = LoginPage.WelcomeName;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
