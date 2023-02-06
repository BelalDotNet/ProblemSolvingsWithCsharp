using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Console
{
    internal class PositiveNegativePortionOfArrayLength
    {
        public static void plusMinus(List<int> arr)
        {

            int totalPositiveNum = 0;
            int totalNegativeNum = 0;
            int withoutPosNegativeNum = 0;
            decimal positivePortion = 0;
            decimal NegativePortion = 0;
            decimal withoutPosNegativePortion = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] > 0)
                {
                    totalPositiveNum++;
                }
                else if (arr[i] < 0)
                {
                    totalNegativeNum++;
                }
                else
                {
                    withoutPosNegativeNum++;
                }

                if (i == arr.Count - 1)
                {
                    positivePortion = Convert.ToDecimal(totalPositiveNum) / Convert.ToDecimal(arr.Count);
                    NegativePortion = Convert.ToDecimal(totalNegativeNum) / Convert.ToDecimal(arr.Count);
                    withoutPosNegativePortion = Convert.ToDecimal(withoutPosNegativeNum) / Convert.ToDecimal(arr.Count);
                }

            }

            Console.WriteLine("Total Positive Portion : " + positivePortion.ToString("N6"));
            Console.WriteLine("Total Negative Portion : " + NegativePortion.ToString("N6"));
            Console.WriteLine("Total WithoutPositiveNegative Portion : " + withoutPosNegativePortion.ToString("N6"));
        }
    }
}
