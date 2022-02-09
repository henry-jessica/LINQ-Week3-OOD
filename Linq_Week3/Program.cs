using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Week3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 5, 3, 6, 11, 2, 15, 21, 13, 12, 10 };

            Linq(numbers);
            Lambda(numbers);

            Console.ReadKey();

        }

        private static void Lambda(int[] numbers)
        {
            var outputNumbersLambda = numbers
                .Where(n => n > 5)
                .OrderByDescending(n => n);

            Console.WriteLine("Lambda Loop");
            foreach (var n in outputNumbersLambda)
            {
                Console.WriteLine(n);
            }
        }
        private static void Linq(int[] numbers)
        {
            var outputNumbers = from number in numbers
                                where number > 5
                                orderby number descending
                                select number;
            foreach (var n in outputNumbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}
