using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee

{
    class Program
    {
        static void Main(string[] args)
        {

            Employee employ1 = new Employee("Adeyemi", "Joshua", 3500.50M);
            Employee employ2 = new Employee("Dare", "Badmus", 900.25M);

            Console.WriteLine ("Employee 1 First Name is : {0}", employ1.FirstName);
            Console.WriteLine();

            Console.WriteLine("Employee 1 Last Name is: {0}", employ1.LastName);
            Console.WriteLine();
            Console.WriteLine("Employee 1 Salary is: {0:C}", employ1.Salary);
            Console.WriteLine();
            Console.WriteLine("Employee 2 First Name is: {0}", employ2.FirstName);
            Console.WriteLine();
            Console.WriteLine("Employee 2 Last Name is: {0}", employ2.LastName);
            Console.WriteLine();
            Console.WriteLine("Employee 2 Salary is: {0:C}", employ2.Salary);

            Console.WriteLine();
            Console.WriteLine("Salary After 10% raise");

            employ1.Salary = employ1.Salary * 1.1M;
            employ2.Salary = employ2.Salary * 1.1M;
            Console.WriteLine("Employee 1 new salary: {0:C}", employ1.Salary);
            Console.WriteLine("Employee 2 new salary: {0:C}", employ2.Salary);


            Console.ReadLine();



        }
    }
}