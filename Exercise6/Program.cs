using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create an array of strings and create a simple LINQ query which displays the names to screen
namespace Exercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Mary", "Jesica", "Michael", "Sarah", "Margaret", "John" };

            var query1 = names
                .OrderBy(x => x)
                .Where(x => x.StartsWith("M"));


            foreach (string name in query1)
            {
                Console.WriteLine(name);
            }

            Console.ReadKey(); 
        }
    }
}
