using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace groep20_git
{
    public partial class AverageForm : Form
    {
        public AverageForm()
        {
            InitializeComponent();
        }

        private void btnGetAverage_Click(object sender, EventArgs e)
        {
            int amountNums = Convert.ToInt32(txtNum.Text);
            Stat numGen = new Stat();

            TestNumber tester = new TestNumber();
            if (tester.test(amountNums) == true)
            {
            MessageBox.Show("The average of " + txtNum.Text + " numbers is: " + numGen.randomAvg(amountNums));
            }

            else
            MessageBox.Show("Number out off bounds");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
