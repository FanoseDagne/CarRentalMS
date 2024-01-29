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
    public partial class Rent : Form
    {
        public Rent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double carFees;
            if ((double.TryParse(txtFees.Text, out double fees)))
            {
                carFees = fees;

            }
            else
            {
                MessageBox.Show("Fee must be a number!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
