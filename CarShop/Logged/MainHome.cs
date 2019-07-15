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
    public partial class MainHome : Form
    {
        public MainHome()
        {
            InitializeComponent();
        }

        private void drop_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        }

        private void CollectionBTN_NL_Click(object sender, EventArgs e)
        {
            CollectionLP clp = new CollectionLP();
            clp.Show();

            this.Close();
        }

        private void CartBTN_NL_Click(object sender, EventArgs e)
        {
            Cart crt = new Cart();
            crt.Show();

            this.Close();
        }

        private void paymentBTN_NL_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            payment.Show();

            this.Close();
        }

        private void MainHome_Load(object sender, EventArgs e)
        {
            User_showname.Text = LoginPage.WelcomeName;
        }

        //Image slider
        private int imageNumber = 1;

        private void LoadNextImage()
        {
            if (imageNumber == 10)
            {
                imageNumber = 1;
            }
            pictureslider.ImageLocation = string.Format(@"images\{0}.jpg", imageNumber);
            imageNumber++;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
