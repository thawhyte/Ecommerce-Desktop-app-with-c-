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

namespace CarShop
{
    public partial class Payment : Form
    {
        string connectionString = @"Data Source= DESKTOP-T0AU0AG\ABIOYE; Initial Catalog=Csharp; Integrated Security=True;";
        public Payment()
        {
            InitializeComponent();
        }

        private void drop_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void username_show_Click(object sender, EventArgs e)
        {
            HomepageNL hml = new HomepageNL();
            hml.Show();

            this.Close();
        }

        private void CollectionBTN_NL_Click(object sender, EventArgs e)
        {
            CollectionLP cml = new CollectionLP();
            cml.Show();

            this.Close();
        }

        private void Homebtn_NL_Click(object sender, EventArgs e)
        {
            MainHome hml = new MainHome();
            hml.Show();

            this.Close();
        }

        private void CartBTN_NL_Click(object sender, EventArgs e)
        {
            Cart crat = new Cart();
            crat.Show();

            this.Close();
        }


        private void username_show_Click_1(object sender, EventArgs e)
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

        private void Payment_Load(object sender, EventArgs e)
        {
            //master card error text
            errorcard.Visible = false;
            //CVC error text
            cvcerror.Visible = false;
            //Logged in name
            label6.Text= LoginPage.WelcomeName;
            //pin
            label10.Visible = false;


                decimal amount = Cart.Amount;
                pay_cart.Text = amount.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int txb1lgt = textBox1.TextLength;
            int txbcvv = textBox3.TextLength;
            int crdpn = CardPin_bx.TextLength;
            if (textBox1.Text == "" || txb1lgt < 16 || textBox3.Text == "" || txbcvv > 3  || crdpn > 4
                || CardPin_bx.Text=="" || Month.Text == "" || Year.Text=="")
            {
                MessageBox.Show("Payment Error","Error");
            }
            else
            {
                Success scs = new Success();
                scs.Show();
                TruncateTable();
                this.Close();
            }
        }


        //Payment Made then cart table is truncated
        public void TruncateTable()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand("Truncate Table CartDetails ", con);
                con.Open();
                bool Deleted = com.ExecuteNonQuery() > 0;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if ((new Regex(@"^(?:5[1-5][0-9]{14})$")).IsMatch(textBox1.Text.Trim()))
            {
                errorcard.Visible = false;
            }
            else if (textBox1.Text == "")
            {
                errorcard.Visible = false;
            }
            else
            {
                errorcard.Visible = true;
            }
        }

       

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int lgt = textBox3.TextLength;
            if ((new Regex(@"^-?\d*$")).IsMatch(textBox3.Text.Trim()))
            {
                cvcerror.Visible = false;
            }
            
            else
            {
                cvcerror.Visible = true;
            }
            //
            if (lgt >= 4)
            {
                cvcerror.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CardPin_bx.Text = CardPin_bx.Text + "1";
        }

        

        private void button18_Click(object sender, EventArgs e)
        {
            CardPin_bx.Text = CardPin_bx.Text + "5";
        }

        

        private void button17_Click(object sender, EventArgs e)
        {
            CardPin_bx.Text = CardPin_bx.Text + "4";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            CardPin_bx.Text = CardPin_bx.Text + "9";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            CardPin_bx.Text = CardPin_bx.Text + "6";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            CardPin_bx.Text = CardPin_bx.Text + "0";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CardPin_bx.Text = CardPin_bx.Text + "7";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CardPin_bx.Text = CardPin_bx.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CardPin_bx.Text = CardPin_bx.Text + "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CardPin_bx.Text = CardPin_bx.Text + "2";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            CardPin_bx.Text = "";
        }
        //max lenght method

        public virtual int MaxLength { get; set; }

        private void CardPin_bx_TextChanged(object sender, EventArgs e)
        {
            if (CardPin_bx.TextLength > 4)
            {
                label10.Visible = true;
            }
            else
            {
                label10.Visible = false;
            }
            //card pin textbox Readonly
            this.CardPin_bx.ReadOnly = true;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Month_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
