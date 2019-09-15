using System.Globalization;

namespace SalaryIncrease
{
    class Employee
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(int id,string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public override string ToString()
        {

            return Id
                + ", "
                +Name
                + ", "
                +Salary.ToString("F2",CultureInfo.InvariantCulture)
                +"\n";

        }


    }
}
