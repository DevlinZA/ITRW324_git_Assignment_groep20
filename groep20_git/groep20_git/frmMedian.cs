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
            string list = "";
            string median;
            int n = Convert.ToInt16(textBox1.Text);
            int[] arrlist = cls.generate(n);

            for (int i = 0; i < n; i++)
            {
                list += arrlist[i] + "\r\n";
            }

            median = Convert.ToString(cls.calcMedian(arrlist));

            MessageBox.Show("The list is: \r\n" + list + "\r\n The median is " + median);
        }
    }
}
