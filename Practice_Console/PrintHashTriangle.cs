using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Console
{
    internal class PrintHashTriangle
    {
        public static void Staircase(int n)
        {

            int spaceCount = n - 1;
            int hashCount = 1;

            for (int i = 0; i < n; i++)
            {
                string printHashWithSpace = "";
                for (int j = 0; j < spaceCount; j++)
                {
                    printHashWithSpace += " ";
                }

                for (int k = 0; k < hashCount; k++)
                {
                    printHashWithSpace += "#";
                }
                hashCount++;
                spaceCount--;
                Console.WriteLine(printHashWithSpace);

            }
        }
    }
}
