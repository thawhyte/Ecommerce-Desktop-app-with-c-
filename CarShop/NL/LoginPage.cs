using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CarShop
{
    public partial class LoginPage : Form
    {
        string connectionString = @"Data Source= DESKTOP-T0AU0AG\ABIOYE; Initial Catalog=Csharp; Integrated Security=True;";

        public static string WelcomeName = "";

        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void drop_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void paymentBTN_NL_Click(object sender, EventArgs e)
        {
            LoginPage lgp = new LoginPage();
            lgp.Show();

            this.Close();
        }

        private void CartBTN_NL_Click(object sender, EventArgs e)
        {
            LoginPage lgp = new LoginPage();
            lgp.Show();

            this.Close();
        }

        private void lucidVideoBtn_Click(object sender, EventArgs e)
        {
            videoVixen vvv = new videoVixen();
            vvv.Show();

            this.Close();
        }

        private void CollectionBTN_NL_Click(object sender, EventArgs e)
        {
            CollectionsNL cln = new CollectionsNL();
            cln.Show();

            this.Close();
        }

        private void Homebtn_NL_Click(object sender, EventArgs e)
        {
            HomepageNL hml = new HomepageNL();
            hml.Show();

            this.Close();
        }

        private void CreateAccount_btn_Click(object sender, EventArgs e)
        {
            CreateAccount ctn = new CreateAccount();
            ctn.Show();

            this.Close();
        }

        private void signIn_Btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();

                string newcon = "select * from Registration where username ='" + Username_Sign_btn.Text.Trim() +
                    "' and password ='" + PasswordLog_txt.Text.Trim() + "'";

                SqlDataAdapter sqldpt = new SqlDataAdapter(newcon, sqlcon);
                DataTable dtb = new DataTable();
                sqldpt.Fill(dtb);


                if (dtb.Rows.Count >= 1)
                {
                    WelcomeName = Username_Sign_btn.Text;

                    MainHome wc = new MainHome();
                    this.Close();

                    wc.Show();
                }
                else if (Username_Sign_btn.Text == "" || PasswordLog_txt.Text == "")
                    MessageBox.Show("Username or Password cannot be blank","Login Error");
                else
                {
                    MessageBox.Show("Invalid Username or Password", "Login Error");
                }


            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LoginBTN_Click(object sender, EventArgs e)
        {

        }

        private void PasswordLog_txt_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void PasswordLog_txt_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
