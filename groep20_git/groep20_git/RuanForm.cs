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
            AddMax AM = new AddMax(Convert.ToInt16(textBox2.Text));
        }
    }
}
