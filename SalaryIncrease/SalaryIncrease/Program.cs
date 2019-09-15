using System;
using System.Collections.Generic;

namespace SalaryIncrease
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered?");
            int n = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Employee #" + i);
                Console.Write("Id:");
                int id = int.Parse(Console.ReadLine());
                if (list.Exists(x => x.Id == id))
                {
                    Console.WriteLine("Id exist!");
                    i--;
                }
                else
                {
                    Console.Write("Name:");
                    string name = Console.ReadLine();
                    Console.Write("Salary:");
                    double salary = double.Parse(Console.ReadLine());

                    list.Add(new Employee(id, name, salary));
                    Console.Clear();

                }

            }

            Console.WriteLine("Enter the employee ID that will have salary increase: ");
            Employee aux = list.Find(x => x.Id == int.Parse((Console.ReadLine())));
            if (aux != null)
            {
                Console.WriteLine("Enter the percentage: ");
                double increase = double.Parse(Console.ReadLine());
                aux.Salary += aux.Salary * (increase / 100);

                Console.WriteLine("Updated");

            }
            else
            {
                Console.WriteLine("This Id does not exist!"); ;
            }
            foreach (Employee employee in list)
            {
                Console.Write(employee);
            }

        }
    }
}
