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
           
            Console.WriteLine(pro.fizzBuzz(15));

            Console.ReadKey();
        }

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
    }


   
}
