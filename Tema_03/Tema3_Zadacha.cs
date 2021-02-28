using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema3_Zadacha
{
    class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public double Salary { get; set; }

        public Employee(string name, int age, double salary)
        {
            this.Name = name;
            this.Age = age;
            this.Salary = salary;
        }

        public void IncreaseSalary(double bonus)
        {
            if (this.Age <= 30)
            {
                this.Salary += this.Salary * (bonus / 2 * 0.01);
            }
            else
            {
                this.Salary += this.Salary * (bonus * 0.01);
            }
        }

        public override string ToString()
        {
            return this.Name + " get " + Math.Round(this.Salary, 2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());
            var employees = new List<Employee>();

            for (int i = 0; i < lines; i++)
            {
                var cmdArgs = Console.ReadLine().Split();
                var employee = new Employee(cmdArgs[0] + " " + cmdArgs[1],
                        int.Parse(cmdArgs[2]),
                        double.Parse(cmdArgs[3]));
                employees.Add(employee);
            }
            var bonus = double.Parse(Console.ReadLine());
            employees.ForEach(item => item.IncreaseSalary(bonus));
            employees.ForEach(item => Console.WriteLine(item.ToString()));
            //foreach (var item in employees)
            //{
            //    item.IncreaseSalary(bonus);
            //    Console.WriteLine("{0} gets {1} leva", item.Name, Math.Round(item.Salary, 2));
            //}
        }
    }
}
