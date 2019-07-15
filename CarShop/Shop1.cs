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
    public partial class Shop1 : Form
    {
        public Shop1()
        {
            InitializeComponent();
        }

        string connectionString = @"Data Source= DESKTOP-T0AU0AG\ABIOYE; Initial Catalog=Csharp; Integrated Security=True;";

        private void Homebtn_NL_Click(object sender, EventArgs e)
        {
            MainHome hml = new MainHome();
            hml.Show();

            this.Close();
        }

        private void CartBTN_NL_Click(object sender, EventArgs e)
        {
            Cart cart = new Cart();
            cart.Show();

            this.Show();
        }

        private void paymentBTN_NL_Click(object sender, EventArgs e)
        {
            Payment pyt = new Payment();
            pyt.Show();

            this.Close();
        }

        private void username_show_Click(object sender, EventArgs e)
        {
            HomepageNL hml = new HomepageNL();
            hml.Show();

            this.Close();
        }

        private void drop_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Shop1_Load(object sender, EventArgs e)
        {
            User_showname.Text = LoginPage.WelcomeName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CollectionLP clp = new CollectionLP();
            clp.Show();
            this.Close();
        }



        private void From_PictureBox_Load_Paint(object sender, PaintEventArgs e)
        {

        }
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
                        cmd.Parameters.AddWithValue("Brand", Brand.Text.Trim());
                        exists = (int)cmd.ExecuteScalar() > 0;
                    }
                    // if exists, show a message error
                    if (exists)
                        MessageBox.Show("Item Already Exist in Cart","Hello!!!");
                    else
                        using (SqlConnection sqlcn = new SqlConnection(connectionString))
                        {
                            SqlCommand sqlcmd = new SqlCommand("CartDetailsProc", sqlcn);
                            sqlcmd.CommandType = CommandType.StoredProcedure;
                            
                            sqlcmd.Parameters.AddWithValue("@Brand", Brand.Text.Trim());
                            sqlcmd.Parameters.AddWithValue("@Quantity", textBox2.Text.Trim());
                            sqlcmd.Parameters.AddWithValue("@Price", Price.Text.Trim());
                            sqlcmd.Parameters.AddWithValue("@Image", SqlDbType.VarBinary).Value = imageToByteArray(CarImage.Image);
                            
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
    }
}
