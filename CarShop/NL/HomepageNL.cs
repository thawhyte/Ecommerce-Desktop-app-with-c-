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
    public partial class HomepageNL : Form
    {
        public HomepageNL()
        {
            InitializeComponent();
        }

        private void drop_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginPage lgpd = new LoginPage();
            lgpd.Show();

            this.Close();
        }

        private void LoginBTN_Click(object sender, EventArgs e)
        {
            //for the side panel to be beside the clicked button
            // SidePanel.Height = LoginBTN.Height;
            // SidePanel.Top = LoginBTN.Top;

            //for the easy navigation of the clicked button
            LoginPage lpn = new LoginPage();
            lpn.Show();

            this.Close();
        }

        private void SIGNUpBTN_Click(object sender, EventArgs e)
        {
            

        }

        private void paymentBTN_NL_Click(object sender, EventArgs e)
        {
            //for the side panel to be beside the clicked button
           // SidePanel.Height = paymentBTN_NL.Height;
          //  SidePanel.Top = paymentBTN_NL.Top;

            //for the easy navigation of the clicked button
            LoginPage lgp = new LoginPage();
            lgp.Show();

            this.Hide();
        }

        private void CartBTN_NL_Click(object sender, EventArgs e)
        {
            //for the side panel to be beside the clicked button
            //SidePanel.Height = CartBTN_NL.Height;
           // SidePanel.Top = CartBTN_NL.Top;

            //for the easy navigation of the clicked button
            LoginPage lgp = new LoginPage();
            lgp.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //for the side panel to be beside the clicked button
            //SidePanel.Height = lucidVideoBtn.Height;
            //SidePanel.Top = lucidVideoBtn.Top;

            //for the easy navigation of the clicked button
            videoVixen vnx = new videoVixen();
            vnx.Show();

            this.Hide();
        }

        private void CollectionBTN_NL_Click(object sender, EventArgs e)
        {
          //  SidePanel.Height = CollectionBTN_NL.Height;
            //SidePanel.Top = CollectionBTN_NL.Top;

            CollectionsNL clb = new CollectionsNL();
            clb.Show();


            this.Hide();
        }

        private void Homebtn_NL_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            HomepageNL hml = new HomepageNL();
            hml.Show();
            this.Close();
        }
        //Image slider
        private int imageNumber = 1;

        private void LoadNextImage()
        {
            if (imageNumber == 10)
            {
                imageNumber = 1;
            }
            pictureslider.ImageLocation = string.Format(@"images\{0}.jpg",imageNumber);
            imageNumber++;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

  

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
