using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace groep20_git
{
    class clsMedian
    {
        public int[] generate(int n)
        {
            Random rnd = new Random();
            int[] list = new int[n];
            for (int i = 0; i < n; i++)
            {
                list[i] = rnd.Next(0, 100);
            }
            return list;
        }

        
    }
}
