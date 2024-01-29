using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalManagementSystem
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double carPrice;
            if ((double.TryParse(txtPrice.Text, out double price)))
            {
                carPrice = price;

            }
            else
            {
                MessageBox.Show("Price must be a number!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
