using System;
using System.Collections.Generic;
using System.Linq;


namespace CS009_LINQ
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
    class Program
    {
        /// <summary>
        /// Deferred or Lazy Operators:  These query operators are used for deferred execution. 
        /// For example – select, SelectMany, where, Take, Skip, etc. are belongs to Deferred or Lazy Operators category.
        /// Immediate or Greedy Operators: These query operators are used for immediate execution. 
        /// For Example – count, average, min, max, First, Last, ToArray, ToList, etc. are belongs to the Immediate or Greedy Operators category.
        /// </summary>
        public static void Main()
        {
            List<Employee> listEmployees = new List<Employee>
            {
                new Employee { ID= 1001, Name = "Priyanka", Salary = 80000 },
                new Employee { ID= 1002, Name = "Anurag", Salary = 90000 },
                new Employee { ID= 1003, Name = "Preety", Salary = 80000 }
            };
            // In the below statement the LINQ Query is only defined and not executed
            // If the query is executed here, then the result should not display Santosh
            IEnumerable<Employee> result = from emp in listEmployees
                                           where emp.Salary == 80000
                                           select emp;
            // Adding a new employee with Salary = 80000 to the collection listEmployees
            listEmployees.Add(new Employee { ID = 1004, Name = "Santosh", Salary = 80000 });
            // The LINQ query is actually executed when we iterate thru using a for each loop
            // This is proved because Santosh is also included in the result
            foreach (Employee emp in result)
            {
                Console.WriteLine($" {emp.ID} {emp.Name} {emp.Salary}");
            }
            Console.ReadKey();
        }
        // public static void Main()
        // {
        //     List<Employee> listEmployees = new List<Employee>
        //     {
        //         new Employee { ID= 1001, Name = "Priyanka", Salary = 80000 },
        //         new Employee { ID= 1002, Name = "Anurag", Salary = 90000 },
        //         new Employee { ID= 1003, Name = "Preety", Salary = 80000 }
        //     };
        //     // In the following statement, the LINQ Query is executed immediately as we are
        //     // Using the ToList() method which is a greedy operator which forces the query 
        //     // to be executed immediately
        //     IEnumerable<Employee> result = (from emp in listEmployees
        //                                    where emp.Salary == 80000
        //                                    select emp).ToList();

        //     // Adding a new employee with Salary = 80000 to the collection listEmployees
        //     // will not have any effect on the result as the query is already executed
        //     listEmployees.Add(new Employee { ID = 1004, Name = "Santosh", Salary = 80000 });

        //     // The above LINQ query is executed at the time of its creation.
        //     // This is proved because Santosh is not included in the result
        //     foreach (Employee emp in result)
        //     {
        //         Console.WriteLine($" {emp.ID} {emp.Name} {emp.Salary}");
        //     }
        //     Console.ReadKey();
        // }
    }
}
