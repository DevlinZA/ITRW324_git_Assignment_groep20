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
    public partial class frmJaco : Form
    {
        clMIN cmin = new clMIN();
        TestNumber tstNum = new TestNumber();

        
        

        public frmJaco()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if( tstNum.test(Convert.ToInt16(txt1.Text)))
            {
                cmin.numGen(Convert.ToInt16(txt1.Text));
            }else
            {
                MessageBox.Show(" Skies die getal is nie tussen 5 en 20 nie");
            }
            
        }
    }
}
