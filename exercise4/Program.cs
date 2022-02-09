using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Deferred Executation
namespace exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {1,2,3,6,10,12,8 };

            var query = numbers
                .Select(n => DoubleIt(n));
            Console.WriteLine("Before the foreach loop"); 

            foreach (int n in query)
            {
                Console.WriteLine(n);
            }

            Console.ReadKey(); 
        }

        private static int DoubleIt(int value)
        {
            Console.WriteLine("About to double the number" + value.ToString());
            return value * 2;
        }
    }
}
