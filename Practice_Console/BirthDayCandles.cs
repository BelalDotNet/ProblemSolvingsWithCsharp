using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Console
{
    internal class BirthDayCandles
    {
        public static int birthdayCakeCandles(List<int> candles)
        {
            var maxElement = candles.Max();
            var maxCount = candles.Count(x => x == maxElement);
            return maxCount;
        }
    }
}
