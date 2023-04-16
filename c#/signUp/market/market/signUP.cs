using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace market
{
    public partial class signUP : Form
    {
        public signUP()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void signUP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'supermarketDataSet.User_table' table. You can move, or remove it, as needed.
            this.user_tableTableAdapter.Fill(this.supermarketDataSet.User_table);

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            usertableBindingSource.AddNew();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            usertableBindingSource.EndEdit();
            user_tableTableAdapter.Update(supermarketDataSet.User_table);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
