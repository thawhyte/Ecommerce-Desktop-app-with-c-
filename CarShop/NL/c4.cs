﻿using System;
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
    public partial class c4 : Form
    {
        public c4()
        {
            InitializeComponent();
        }

        private void Homebtn_NL_Click(object sender, EventArgs e)
        {
            HomepageNL hml = new HomepageNL();
            hml.Show();

            this.Close();
        }

        private void drop_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lucidVideoBtn_Click(object sender, EventArgs e)
        {
            videoVixen vv = new videoVixen();
            vv.Show();

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

        private void button2_Click(object sender, EventArgs e)
        {
            collectionmore clm = new collectionmore();
            clm.Show();

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginPage lgp = new LoginPage();
            lgp.Show();

            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
