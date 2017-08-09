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
    public partial class frmMedian : Form
    {
        public frmMedian()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            clsMedian cls = new clsMedian();
            Stat clsStat = new Stat();
            string list = "";
            string median;
            TestNumber tn = new TestNumber();
            
            try
            {
                string x = textBox1.Text;
                
                
                
                int n = Convert.ToInt16(textBox1.Text);
                if (tn.test(n))
                {
                    int[] arrlist = cls.generate(n);

                    for (int i = 0; i < n; i++)
                    {
                        list += arrlist[i] + "\r\n";
                    }

                    median = Convert.ToString(clsStat.calcMedian(arrlist));

                    MessageBox.Show("The list is: \r\n" + list + "\r\n The median is " + median);
                }
                else
                {
                    MessageBox.Show("Choose a number between 5 and 20");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
