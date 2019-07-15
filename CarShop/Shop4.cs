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
using System.IO;

namespace CarShop
{
    public partial class Shop4 : Form
    {
        public Shop4()
        {
            InitializeComponent();
        }

        private void Shop4_Load(object sender, EventArgs e)
        {
            User_showname.Text = LoginPage.WelcomeName;
        }

        private void username_show_Click(object sender, EventArgs e)
        {
            HomepageNL hml = new HomepageNL();
            hml.Show();

            this.Close();
        }

        private void User_showname_Click(object sender, EventArgs e)
        {

        }

        private void drop_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CartBTN_NL_Click(object sender, EventArgs e)
        {
            Cart cc = new Cart();
            cc.Show();

            this.Close();
        }

        private void paymentBTN_NL_Click(object sender, EventArgs e)
        {
            Payment pyt = new Payment();
            pyt.Show();

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CollectionLP2 clp2 = new CollectionLP2(); clp2.Show(); this.Close();
        }

        string connectionString = @"Data Source= DESKTOP-T0AU0AG\ABIOYE; Initial Catalog=Csharp; Integrated Security=True;";

        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                int qty = Convert.ToInt32(textBox2.Text);
                if (qty == 0)
                    MessageBox.Show("Quantity should be more than 0");
                else
                {
                    bool exists = false;
                    //command click to check if item already added to cart
                    using (SqlCommand cmd = new SqlCommand("select count(*) from [CartDetails] where Brand = @Brand", sqlcon))
                    {
                        sqlcon.Open();
                        cmd.Parameters.AddWithValue("Brand", label6.Text.Trim());
                        exists = (int)cmd.ExecuteScalar() > 0;
                    }
                    // if exists, show a message error
                    if (exists)
                        MessageBox.Show("Item Already Exist in Cart", "Hello!!!");
                    else
                        using (SqlConnection sqlcn = new SqlConnection(connectionString))
                        {
                            SqlCommand sqlcmd = new SqlCommand("CartDetailsProc", sqlcn);
                            sqlcmd.CommandType = CommandType.StoredProcedure;

                            sqlcmd.Parameters.AddWithValue("@Brand", label6.Text.Trim());
                            sqlcmd.Parameters.AddWithValue("@Quantity", textBox2.Text.Trim());
                            sqlcmd.Parameters.AddWithValue("@Price", label5.Text.Trim());
                            sqlcmd.Parameters.AddWithValue("@Image", SqlDbType.VarBinary).Value = imageToByteArray(pictureBox2.Image);

                            sqlcn.Open();
                            sqlcmd.ExecuteNonQuery();
                            MessageBox.Show("2016 Model X P90D, Added to Cart", "CART");

                            sqlcn.Close();

                        }

                }
            }
                
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
    }
}
