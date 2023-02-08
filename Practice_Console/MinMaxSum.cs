using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Console
{
    internal class MinMaxSum
    {
        public static void miniMaxSum(List<int> arr)
        {
            long min = 0;
            long max = 0;
            arr.Sort();

            for (int i = 0; i < arr.Count() - 1; i++)
            {
                min += arr[i];
            }
            for (int i = 1; i < arr.Count; i++)
            {
                max += arr[i];
            }

            Console.WriteLine(min + " " + max);
        }

    }

}
