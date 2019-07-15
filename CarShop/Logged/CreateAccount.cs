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
using System.Text.RegularExpressions;
using System.Net;
using System.Collections.Specialized;
using System.IO;

namespace CarShop
{
    public partial class CreateAccount : Form
    {
        public static string WelcomeName = "";
        string connectionString = @"Data Source= DESKTOP-T0AU0AG\ABIOYE; Initial Catalog=Csharp; Integrated Security=True;";
            
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            LoginPage lpg = new LoginPage();
            lpg.Show();

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

        private void CollectionBTN_NL_Click(object sender, EventArgs e)
        {
            CollectionsNL clr = new CollectionsNL();
            clr.Show();

            this.Close();
        }

        private void lucidVideoBtn_Click(object sender, EventArgs e)
        {
            videoVixen vv = new videoVixen();
            vv.Show();

            this.Close();
        }

        private void CartBTN_NL_Click(object sender, EventArgs e)
        {
            LoginPage lpg = new LoginPage();
            lpg.Show();

            this.Close();
        }

        private void CreateAccount_btn_Click(object sender, EventArgs e)
        {
            bool exists = false;

            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                if (username_reg_txt.Text == "" || Firstname_txt.Text == "" || LastName_txt.Text == ""
                    || passsword_crt_txt.Text == "" || contact_txt.Text == "" || confirm_pass_txt.Text == "")
                    MessageBox.Show("Please fill mandatory inputs.", "Important Message");
                else if (passsword_crt_txt.Text != confirm_pass_txt.Text)
                    MessageBox.Show("Passwords Do not Match.", "Important Message");
                else if (username_reg_txt.Text == passsword_crt_txt.Text)
                    MessageBox.Show("Username cannot be the same as Password");

                else
                {
                    // create a command to check if the username exists
                    using (SqlCommand cmd = new SqlCommand("select count(*) from [Registration] where UserName = @username", sqlcon))
                    {
                        sqlcon.Open();
                        cmd.Parameters.AddWithValue("UserName", username_reg_txt.Text.Trim());
                        exists = (int)cmd.ExecuteScalar() > 0;
                    }

                    // if exists, show a message error
                    if (exists)
                        MessageBox.Show("Username already exist");
                    //errorUsername.SetError(username_reg_txt, "This username has been using by another user.");
                    else
                    {
                       // sqlcon.Open();
                        SqlCommand sqlcmd = new SqlCommand("UserAdd", sqlcon);
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        sqlcmd.Parameters.AddWithValue("@FirstName", Firstname_txt.Text.Trim());
                        sqlcmd.Parameters.AddWithValue("@LastName", LastName_txt.Text.Trim());
                        sqlcmd.Parameters.AddWithValue("@Country", Country_txt.Text.Trim());
                        sqlcmd.Parameters.AddWithValue("@state", state_txt.Text.Trim());
                        sqlcmd.Parameters.AddWithValue("@contact_Address", contact_txt.Text.Trim());
                        sqlcmd.Parameters.AddWithValue("@telephone", Telphone_txt.Text.Trim());
                        sqlcmd.Parameters.AddWithValue("@username", username_reg_txt.Text.Trim());
                        sqlcmd.Parameters.AddWithValue("@password", passsword_crt_txt.Text.Trim());
                        sqlcmd.ExecuteNonQuery();
                        MessageBox.Show("Registration Succesul");
                        clear();

                        this.Close();

                        LoginPage lpg = new LoginPage();
                        lpg.Show();
                    }
                }
            }

            //SMS API during registration
            //String result;
            //string apiKey = "bi4w1Xv5D2E-1k5nFDqdbon4OtaXw2gx0yLTRwOnmz";
            //string numbers = Telphone_txt.Text; // in a comma seperated list
            //string message = "Hello, welcome to Car Shop, your username is {0}" + username_reg_txt.Text + "and password is {1}" + passsword_crt_txt.Text;
            //string send = "Car Shop";

            //String url = "https://api.txtlocal.com/send/?apikey=" + apiKey + "&numbers=" + numbers + "&message=" + message + "&sender=" + send;
            //refer to parameters to complete correct url string

            //StreamWriter myWriter = null;
            //HttpWebRequest objRequest = (HttpWebRequest)WebRequest.Create(url);

            //objRequest.Method = "POST";
            //objRequest.ContentLength = Encoding.UTF8.GetByteCount(url);
            //objRequest.ContentType = "application/x-www-form-urlencoded";
            //try
            //{
            //    myWriter = new StreamWriter(objRequest.GetRequestStream());
            //    myWriter.Write(url);
            //}
            //catch (Exception ex)
            //{
            //    return e.Message;

            //}
            //finally
            //{
            //    myWriter.Close();
            //}

            //HttpWebResponse objResponse = (HttpWebResponse)objRequest.GetResponse();
            //using (StreamReader sr = new StreamReader(objResponse.GetResponseStream()))
            //{
            //    result = sr.ReadToEnd();
            //    Close and clean up the StreamReader
            //    sr.Close();
            //}
            //return result;

        }
        void clear()
        {
            Firstname_txt.Text = LastName_txt.Text = Country_txt.Text = state_txt.Text = contact_txt.Text = Telphone_txt.Text = username_reg_txt.Text = passsword_crt_txt.Text = confirm_pass_txt.Text = "";
        }

        private void Firstname_txt_TextChanged(object sender, EventArgs e)
        {
            
            if ((new Regex(@"^[A-Za-z]+$")).IsMatch(Firstname_txt.Text.Trim()))
            {
                pictureBox2.Visible = true;
                Fnerror.Visible = false;
            }
            else if(Firstname_txt.Text == "")
            {
                pictureBox2.Visible = false;
                Fnerror.Visible = false;
            }
            else
            {
                pictureBox2.Visible = false;
                Fnerror.Visible = true;
            }
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {
            //first name
            pictureBox2.Visible = false;
            Fnerror.Visible = false;

            //last name
            label23.Visible = false;
            pictureBox3.Visible = false;
            //country
            label24.Visible = false;
            pictureBox4.Visible = false;
            //state
            pictureBox5.Visible = false;
            label25.Visible = false;
            //username
            pictureBox5.Visible = false;
            label25.Visible = false;
            //Telephone number
            pictureBox6.Visible = false;
            label26.Visible = false;
            //password
            label28.Visible = false;
            pictureBox8.Visible = false ;
            //username
            pictureBox7.Visible = false;
            label27.Visible = false;
            //telephone
            pictureBox5.Visible = false;
            label25.Visible = false;

            //psw
            weak_lb.Visible = false;
            medium_lb.Visible = false;
            strong_lb.Visible = false;
        }

        private void LastName_txt_TextChanged(object sender, EventArgs e)
        {
            if ((new Regex(@"^[A-Za-z]+$")).IsMatch(LastName_txt.Text.Trim()))
            {
                label23.Visible = false;
                pictureBox3.Visible = true;
            }
            else if (LastName_txt.Text=="")
            {
                label23.Visible = false;
                pictureBox3.Visible = false;
            }
            else
            {
                label23.Visible = true;
                pictureBox3.Visible = false;
            }
            
        }

        private void Country_txt_TextChanged(object sender, EventArgs e)
        {
            if ((new Regex(@"^[A-Za-z]+$")).IsMatch(Country_txt.Text.Trim()))
            {
                label24.Visible = false;
                pictureBox4.Visible = true;
            }
            else if(Country_txt.Text == "")
            {
                label24.Visible = false;
                pictureBox4.Visible = false;
            }
            else
            {
                label24.Visible = true;
                pictureBox4.Visible = false;
            }
        }

        private void state_txt_TextChanged(object sender, EventArgs e)
        {
            if ((new Regex(@"^[A-Za-z]+$")).IsMatch(state_txt.Text.Trim()))
            {
                pictureBox5.Visible = true;
                label25.Visible = false;
            }
            else if (state_txt.Text =="")
            {
                pictureBox5.Visible = false;
                label25.Visible = false;
            }
            else
            {
                pictureBox5.Visible = false;
                label25.Visible = true;
            }
        }

        private void Telphone_txt_TextChanged(object sender, EventArgs e)
        {
            if ((new Regex(@"^-?\d*$")).IsMatch(Telphone_txt.Text.Trim()))
            {
                pictureBox6.Visible = true;
                label26.Visible = false;
            }
            else if(Telphone_txt.Text == "")
            {
                pictureBox6.Visible = false;
                label26.Visible = false;
            }
            else
            {
                pictureBox6.Visible = false;
                label26.Visible = true;
            }
        }

        private void username_reg_txt_TextChanged(object sender, EventArgs e)
        {
            if ((new Regex(@"^[A-Za-z]+$")).IsMatch(username_reg_txt.Text.Trim()))
            {
                pictureBox7.Visible = false;
                label27.Visible = true;
            }
            else if (username_reg_txt.Text=="")
            {
                pictureBox7.Visible = false;
                label27.Visible = false;
            }
            else
            {
                pictureBox7.Visible = true;
                label27.Visible = false;
            }
            
        }
        
        private void passsword_crt_txt_TextChanged(object sender, EventArgs e)
        {
            if ((new Regex(@"[A-Z]")).IsMatch(passsword_crt_txt.Text.Trim()))
            {
                label28.Visible = false;
                pictureBox8.Visible = true;
            }
            else if (passsword_crt_txt.Text == "")
            {
                label28.Visible = false;
                pictureBox8.Visible = false;
                strong_lb.Visible = false;
                weak_lb.Visible = false;
                medium_lb.Visible = false;
            }
            else
            {
                label28.Visible = true;
                pictureBox8.Visible = false;
            }
            //password strenght

            int lgt = passsword_crt_txt.TextLength;

            if (lgt <= 3 )
            {
                weak_lb.Visible = true;
            }
            else if (lgt > 3 && lgt <= 6)
            {
                medium_lb.Visible = true;
            }
            else if (lgt > 6)
            {
                strong_lb.Visible = true;
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
