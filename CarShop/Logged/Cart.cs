using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace CarShop
{
    public partial class Cart : Form
    {
        public static decimal Amount = 0;
        public Cart()
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
            MainHome hml = new MainHome();
            hml.Show();

            this.Close();
        }

        private void CollectionBTN_NL_Click(object sender, EventArgs e)
        {
            CollectionLP cln = new CollectionLP();
            cln.Show();

            this.Close();
        }

        private void paymentBTN_NL_Click(object sender, EventArgs e)
        {
            Payment pay = new Payment();
            pay.Show();

            this.Close();
        }
        
        string connectionString = @"Data Source= DESKTOP-T0AU0AG\ABIOYE; Initial Catalog=Csharp; Integrated Security=True;";
        
        private void Cart_Load(object sender, EventArgs e)
        {
            User_showname.Text = LoginPage.WelcomeName;

            //for the cart Display

            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                try
                {
                    string qry = "SELECT * FROM CartDetails";
                    SqlCommand cmd = new SqlCommand(qry, sqlcon);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    //dataGridView1.RowTemplate.Height = 500;
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        row.Height = 120;
                    }


                    DataGridViewImageColumn image = new DataGridViewImageColumn();
                    image = (DataGridViewImageColumn)dataGridView1.Columns[5];
                    image.ImageLayout = DataGridViewImageCellLayout.Stretch;

                    
                    da.Dispose();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (sqlcon.State == ConnectionState.Open)
                    {
                        sqlcon.Close();
                    }
                }
            }
            
        }

        DataTable table = new DataTable();
        int selectedRow;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // delete datagridview row selected row
                selectedRow = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows.RemoveAt(selectedRow);
            }
            catch (Exception)
            {
                MessageBox.Show("Your Cart is Empty");
                TruncateTable();
            }
        }

        public void TruncateTable()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand("Truncate Table CartDetails ", con);
                con.Open();
                bool Deleted = com.ExecuteNonQuery() > 0;
            }
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            Total_txt.Text = (from DataGridViewRow row in dataGridView1.Rows
                              where row.Cells[4].FormattedValue.ToString() != string.Empty
                              select Convert.ToDecimal(row.Cells[4].FormattedValue)).Sum().ToString();
            

            
            Amount = Convert.ToDecimal(Total_txt.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal total = Convert.ToDecimal(string.Format("{0:c}", Total_txt.Text));
            if (total >= 1)
            {
                Payment pyt = new Payment();
                pyt.Show();
                this.Close();
            }
            else if(total < 1)
                MessageBox.Show("You need to add atleast one item to cart ");
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
