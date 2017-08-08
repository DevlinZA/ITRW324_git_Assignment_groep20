using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace groep20_git
{
    class Stat
    {
        public double calcMedian(int[] numbers)
        {
            int numberCount = numbers.Count();
            int halfIndex = numbers.Count() / 2;
            var sortedNumbers = numbers.OrderBy(n => n);
            double median;
            if ((numberCount % 2) == 0)
            {
                median = ((sortedNumbers.ElementAt(halfIndex) + sortedNumbers.ElementAt((halfIndex - 1))) / 2);
            }
            else
            {
                median = sortedNumbers.ElementAt(halfIndex);
            }
            return median;


        }

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

        public void numGen(int num)
        {
            int minNum = 100;
            int[] numbers = new int[num];
            for (int i = 1; i < numbers.Length; i++)
            {
                numbers[i] = ran.Next(0, 100);
                if (numbers[i] < minNum)
                {
                    minNum = numbers[i];
                }
                MessageBox.Show("" + Convert.ToString(numbers[i]));
            }
            //minNum = numbers.Min();
            MessageBox.Show("Die MIN van die gegenereerde egtalle is :" + minNum);

        }


    }
}
