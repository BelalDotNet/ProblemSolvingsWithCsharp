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

            //Program pro=new Program();

            // Console.WriteLine(pro.fizzBuzz(15));

            // Console.WriteLine(pro.SimpleArraySum(6,new int[] { 2,3,4,5,6,7}));
            //List<int> pointTabl = compareTriplets(new List<int> { 10, 15, 20 }, new List<int> { 10, 50, 60 });
            //Console.WriteLine(pointTabl[0].ToString() + pointTabl[1].ToString());

             solve(13.70, 20, 8);

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

        //Problem 03
        //The first line contains 3 space-separated integers, a[0], a[1], and a[2], the respective values in triplet a.
        //The second line contains 3 space-separated integers, b[0], b[1], and b[2], the respective values in triplet b.
        //        Example

        //a = [1, 2, 3]
        //b = [3, 2, 1]
        //        For elements *0*, Bob is awarded a point because a[0] .
        //For the equal elements a[1] and b[1], no points are earned.
        //Finally, for elements 2, a[2] > b[2] so Alice receives a point.
        //The return array is [1, 1] with Alice's score first and Bob's second.

        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            int alicePoint=0;
            int bobsPoint=0;

            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i] )
                {
                    alicePoint += 1;
                }
                else if (a[i] == b[i] )
                {
                    continue;
                }
                else
                {
                    bobsPoint += 1;
                }
            } 
            List<int> ComparePoint = new List<int>() {alicePoint, bobsPoint};

            return ComparePoint;
        }


        //Problem 04 
        //Complete the solve function in the editor below.

        //int meal_cost: the cost of food before tip and tax
        //int tip_percent: the tip percentage
        //int tax_percent: the tax percentage 
        //A tip of 15% * 100 = 15, and the taxes are 8% * 100 = 8. Print the value and return from the function.

        public static void solve(double meal_cost, int tip_percent, int tax_percent)
        {

            double baseCost = meal_cost;
            double tipCost = (meal_cost * tip_percent) / 100;
            double taxCost = (meal_cost * tax_percent) / 100;

            double total_Cost =Math.Round(baseCost + tipCost + taxCost);
            Console.WriteLine(total_Cost.ToString());

        }
    }


   
}
