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
    public partial class RuanForm : Form
    {
        public RuanForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 F1 = new Form1();
            F1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stat clsStat = new Stat();
            TestNumber tstNum = new TestNumber();
            AddMax AM = new AddMax();
            string max;
            int n = Convert.ToInt16(textBox2.Text);
            if (tstNum.test(n))
            {
                int[] arrlist = AM.generate(n);
                max = Convert.ToString(clsStat.addMax(arrlist));
                MessageBox.Show("The maximum value for the list is: " + max);
            }
            else
            {
                MessageBox.Show("Please choose a number between 5 and 20");
            }
        }
    }
}
