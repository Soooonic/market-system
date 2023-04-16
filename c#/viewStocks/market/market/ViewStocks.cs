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
    public partial class ViewStocks : Form
    {
        public ViewStocks()
        {
            InitializeComponent();
        }

        private void ViewStocks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'supermarketDataSet.stock' table. You can move, or remove it, as needed.
            this.stockTableAdapter.Fill(this.supermarketDataSet.stock);

        }
    }
}
