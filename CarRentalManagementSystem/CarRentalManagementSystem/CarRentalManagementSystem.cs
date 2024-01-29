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
    public partial class CarRentalManagementSystem : Form
    {
        public CarRentalManagementSystem()
        {
            InitializeComponent();
        }

        private void CarRentalManagementSystem_Load(object sender, EventArgs e)
        {
            timer1.Start();
            circularProgressBar1.Value = 0;
            labPercentage.Text = circularProgressBar1.Value.ToString() + "%";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (circularProgressBar1.Value < 100)
            {
                circularProgressBar1.Value += 5;
                labPercentage.Text = circularProgressBar1.Value.ToString() + "%"; ;

            }
            else
            {
                timer1.Stop();
                this.Hide();

                Login l = new Login();
                l.ShowDialog();

            }

        }
    }
}
