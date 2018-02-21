using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            //counts 1-100
            //if multiple of 3 returns fizz
            //if multiple of 5 returns buzz
            //if multiple of both, returns fizzbuzz
            Console.WriteLine("1" == "Something");
            string str = "15";
            Console.WriteLine(FizzBuzzMethod(str)); 
        }
        public static string FizzBuzzMethod(string str)
        {
            int i = int.Parse(str);
            {

                if (i % 3 == 0 && i % 5 == 0)
                {
                    return "FizzBuzz";
                }
                else if (i % 3 == 0)
                {
                    return "Fizz";
                }
                else if (i % 5 == 0)
                {
                    return "Buzz";
                }
            }
            return str;          
        }
    }
}
