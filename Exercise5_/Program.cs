using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 5, 3, 6, 10, 12, 8 };

            var query1 = numbers
                .OrderByDescending(x => x);

            var query2 = query1
                .Where(x => x < 8);

            var query3 = query2
                .Select(x => DoulbeIt(x));

            foreach (var item in query3)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey(); 
        }
        private static int DoulbeIt( int x)
        {
            return x * 2;
        }
    }
}
