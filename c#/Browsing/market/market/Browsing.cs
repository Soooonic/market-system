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
using System.Configuration;

namespace market
{
    public partial class Browsing : Form
    {
        //static string sqlcon = "Data Source=AHMEDALI;Initial Catalog=supermarket;Integrated Security=True";
        //SqlConnection conn= new SqlConnection(sqlcon);
        public Browsing()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Browsing_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'supermarketDataSet.stock' table. You can move, or remove it, as needed.
            this.stockTableAdapter.Fill(this.supermarketDataSet.stock);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection mycon = new SqlConnection(ConfigurationManager.ConnectionStrings["mycon"].ConnectionString))
                {
                    if(mycon.State == ConnectionState.Closed)
                        mycon.Open();
                    using(DataTable dt = new DataTable("product"))
                    {
                        using(SqlCommand cmd = new SqlCommand("select *from product where pname = @pname", mycon))
                        {
                            cmd.Parameters.AddWithValue("pname",textBox1.Text);
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            adapter.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message , "message" , MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void supermarketDataSet_Initialized(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)13)
                button1.PerformClick();

        }
    }
}
