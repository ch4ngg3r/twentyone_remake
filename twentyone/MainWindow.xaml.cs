using System;
using System.Windows;

namespace twentyone
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        class Employee(string name, string position, decimal salary)
        {
            public string Name { get; set; } = name;
            public string Position { get; set; } = position;
            public decimal Salary { get; set; } = salary;

            public virtual void GetInfo()
            {
                Console.WriteLine($"Name: {Name}, Position: {Position}, Salary: {Salary}");
            }
        }

        class Manager(string name, decimal salary, int numberOfSubordinates) : Employee(name, "Manager", salary)
        {
            public int NumberOfSubordinates { get; set; } = numberOfSubordinates;

            public override void GetInfo()
            {
                base.GetInfo();
                Console.WriteLine(NumberOfSubordinates);
            }
        }

        class Developer(string name, decimal salary, string programmingLanguage) : Employee(name, "Developer", salary)
        {
            public string ProgrammingLanguage { get; set; } = programmingLanguage;

            public override void GetInfo()
            {
                base.GetInfo();
                Console.WriteLine(ProgrammingLanguage);
            }
        }

        public static void Main()
        {
            Employee[] employees = new Employee[]
            {
                new Manager("Alice", 80000m, 5),
                new Developer("Bob", 60000m, "C#"),
                new Developer("Charlie", 65000m, "Java"),
                new Manager("David", 90000m, 3)
            };

            foreach (var employee in employees)
            {
                employee.GetInfo();
                Console.WriteLine();
            }
        }
    }
}