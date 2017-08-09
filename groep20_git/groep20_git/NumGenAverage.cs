using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace groep20_git
{
    class NumGenAverage
    {
        private int[] ranNums;
        private Random ran = new Random();
        private double Answer;
        public double randomAvg(int inputNumber)
        {
            double avgSum = 0;
            ranNums = new int[inputNumber - 1];
            for (int i = 0; i < ranNums.Length; i++)
            {
                ranNums[i] = ran.Next();
            }

            for (int i = 0; i < ranNums.Length; i++)
            {
                avgSum = avgSum + ranNums[i];
            }

            Answer = avgSum / inputNumber;
            return Answer;
        }

    }
}
