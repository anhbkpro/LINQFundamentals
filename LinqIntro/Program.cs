using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Employee> employees = new List<Employee>
            {
                new Employee {Id = 1, Name="Scott", HireDate= DateTime.UtcNow.AddYears(-1)},
                new Employee {Id = 2, Name="Poomnam", HireDate= DateTime.UtcNow.AddYears(-3)},
                new Employee {Id = 3, Name="Paul", HireDate= DateTime.UtcNow.AddYears(-5)},
            };

            IEnumerable<Employee> query = from e in employees
                                          where e.HireDate.Year < 2013
                                          orderby e.Name
                                          select e;

            foreach (var item in query)
            {
                Console.WriteLine("{0} {1}", item.Name, item.HireDate);
            }
        }
    }
}
