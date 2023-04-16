using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mymarketDataSet1.User_table' table. You can move, or remove it, as needed.
            this.user_tableTableAdapter1.Fill(this.mymarketDataSet1.User_table);
            // TODO: This line of code loads data into the 'mymarketDataSet.User_table' table. You can move, or remove it, as needed.
            this.user_tableTableAdapter.Fill(this.mymarketDataSet.User_table);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            usertableBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            usertableBindingSource.AddNew();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            usertableBindingSource.RemoveCurrent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            usertableBindingSource.MoveLast();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            usertableBindingSource.EndEdit();
            user_tableTableAdapter.Update(mymarketDataSet.User_table);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            usertableBindingSource1.MoveFirst();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            usertableBindingSource.MovePrevious();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            usertableBindingSource.MoveNext();
        }
    }
}
