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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

<<<<<<< HEAD
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            RuanForm RF = new RuanForm();
            RF.Show();

=======
        private void button4_Click(object sender, EventArgs e)
        {
            frmMedian frm = new frmMedian();
            frm.Show();
>>>>>>> 15f1e71e3df21d2631724d6b2ace1291cb3bd0c7
        }
    }
}
