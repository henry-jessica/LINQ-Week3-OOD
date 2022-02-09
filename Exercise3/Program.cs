using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Anonymous type
namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GetFilesAnonymousType();
            GetFilesAnonymousTypeLambda(); 

            Console.ReadKey();
        }

        private static void GetFilesAnonymousType()
        {
            var files = new DirectoryInfo("C:\\Windows").GetFiles();

            var query = from item in files
                        where item.Length > 10000
                        orderby item.Length, item.Name
                        select new
                        {
                            Name = item.Name,
                            Length = item.Length,
                            CreationTime = item.CreationTime
                        };

            Console.WriteLine("Filename\tsize\t\tCreation Date");

            foreach (var item in query)
            {
                Console.WriteLine("{0} \t{1} bytes, \t{2}",
                    item.Name, item.Length, item.CreationTime);

            }
        }
        private static void GetFilesAnonymousTypeLambda()
        {
            var files = new DirectoryInfo("C:\\Windows").GetFiles();

            var query = files
                .Where(f => f.Length > 10000)
                .OrderBy(f => f.Length).ThenBy(f => f.Name)
                .Select(f => new
                {
                    Name = f.Name,
                    Length = f.Length,
                    CreationTime = f.CreationTime

                });
            Console.WriteLine("Filename\tsize\t\tCreation Date");

            foreach (var item in query)
            {
                Console.WriteLine("{0} \t{1} bytes, \t{2}",
                    item.Name, item.Length, item.CreationTime);

            }


        }
    }
}
