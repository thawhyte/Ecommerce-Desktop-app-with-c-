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
    public partial class videoVixen : Form
    {
        public videoVixen()
        {
            InitializeComponent();
        }

        private void Homebtn_NL_Click(object sender, EventArgs e)
        {
            HomepageNL htm = new HomepageNL();
            htm.Show();

            this.Close();
        }

        private void CollectionBTN_NL_Click(object sender, EventArgs e)
        {
            CollectionsNL ctn = new CollectionsNL();
            ctn.Show();

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

        

        private void drop_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void videoVixen_Load(object sender, EventArgs e)
        {

        }
    }
}
