using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Console
{
    internal class PrintCount
    {
        public static void PrintNumberCount()
        {

            List<int> arrTotal;
            arrTotal = new List<int>();
            List<string> nums = new List<string> { "", "", "1", "2", "", "", "1", "2", "3", "", "" };
            int i, j;
            int maxNum = 0;
            int counter = 0;

            for (i = 0; i < nums.Count; i++)
            {
                if (nums[i] != "")
                {
                    for (j = i + 1; j < nums.Count; j++)
                    {
                        if (nums[j] == "")
                        {
                            i = j - 1;

                            if (counter > 0)
                            {
                                arrTotal.Add(maxNum);
                            }
                            counter = 0;
                            break;

                        }
                        else
                        {
                            if (Convert.ToInt32(nums[j]) > Convert.ToInt32(nums[i]))
                            {
                                maxNum = Convert.ToInt32(nums[j]);
                                counter++;
                            }

                        }


                    }
                }

            }

            for (int k = 0; k < arrTotal.Count; k++)
            {
                Console.WriteLine(arrTotal[k].ToString());
            }



        }
    }
}
