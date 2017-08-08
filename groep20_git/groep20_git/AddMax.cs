using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace groep20_git
{
    class AddMax
    {
        public AddMax(int number)
        {
            int max = 0;
            Random rand = new Random();
            int[] numbers = new int[number];
            for (int i = 0; i < number; i++)
            {
                numbers[i] = rand.Next(101);
            }
            for (int i = 0; i < number; i++)
            {
                if (max <= numbers[i])
                {
                    max = numbers[i];
                }
            }
            MessageBox.Show("The max value for the generated numbers is: " + Convert.ToString(max));
        }
    }
}
