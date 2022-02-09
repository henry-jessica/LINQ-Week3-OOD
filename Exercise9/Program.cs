using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Use the following code to create a list of customers. Create a LINQ query which extracts customers where city is Dublin
namespace Exercise9
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Customer c1 = new Customer() { Name = "Joao", City = "Dublin" };
            Customer c2 = new Customer() { Name = "Mary", City = "Galway" };
            Customer c3 = new Customer() { Name = "Jessica", City = "Sligo" };
            Customer c4 = new Customer() { Name = "Zoe", City = "Dublin" };

            List<Customer> customers = new List<Customer>() { c1, c2, c3, c4 };

            var query1 = customers
                .Where(x => x.City.ToLower() == "dublin" || x.City.ToLower() == "galway")  //Question 10 - Dublin or Galway 
                .OrderBy(x => x.Name); //Order by name 


            foreach (var name in query1)
            {
                Console.WriteLine(name.Name);
            }

            Console.ReadKey();

        }
    }

    class Customer
    {
        public string Name { get; set; }
        public string City { get; set; }
    }

}
