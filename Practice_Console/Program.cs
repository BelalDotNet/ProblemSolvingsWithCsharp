using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Practice_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Program pro=new Program();

            // Console.WriteLine(pro.fizzBuzz(15));

            Console.WriteLine(pro.SimpleArraySum(6,new int[] { 2,3,4,5,6,7}));

            Console.ReadKey();
        }

        // Problem 01

        // If i is a Multiple of both 3 And 5, Print FizzBuzz
        // If i is a Multiple Of 3 But Not 5, Print Fizz
        // If i is a Multiple Of 5 But Not 3, Print Buzz
        // Otherwise Print the Value Of i.

        // Constrains 0<n<2*10p5



        public string fizzBuzz(int n)
        {

            for (int i = 1; i <=n; i++)
            {
                if (i % 3 == 0)
                {
                    if (i % 5 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    else
                    {
                        Console.WriteLine("Fizz");
                    }
                        
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }    
                else
                {
                    Console.WriteLine(i.ToString());
                }
            }
            return "";
        }


        //Problem 02
        // Given an array of integers, find the sum of its elements.
        //        Input Format

        //The first line contains an integer, , denoting the size of the array.
        //The second line contains  space-separated integers representing the array's elements.

        public int SimpleArraySum(int n, int[] ar)
        {
            int result=0;
            for (int i = 0; i < n; i++)
            {
                result += ar[i];
            }
            


            return result;
        }

        public static int simpleArraySum(List<int> ar)
        {
            return ar.Sum();
        }

    }


   
}
