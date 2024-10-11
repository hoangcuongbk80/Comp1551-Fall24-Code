using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4
{
    

    // Manager class inherits from Employee
    class Manager : Employee
    {
        public int TeamSize;

        // Constructor for Manager class
        public Manager(string name, int age, double salary, int teamSize)
            : base(name, age, salary)
        { // Calling the base class constructor
            TeamSize = teamSize;
        }

        // Method specific to Manager
        public void ConductMeeting()
        {
            Console.WriteLine($"{Name} is conducting a meeting with {TeamSize} team members.");
        }
    }

    // Developer class inherits from Employee
    class Developer : Employee
    {
        public string ProgrammingLanguage;

        // Constructor for Developer class
        public Developer(string name, int age, double salary, string programmingLanguage)
            : base(name, age, salary)
        { // Calling the base class constructor
            ProgrammingLanguage = programmingLanguage;
        }

        // Method specific to Developer
        public void WriteCode()
        {
            Console.WriteLine($"{Name} is writing code in {ProgrammingLanguage}.");
        }
    }
    class Employee
    {
        // Common attributes for all employees
        public string Name;
        public int Age;
        public double Salary;
        // Constructor for Employee class
        public Employee(string name, int age, double salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }
        // Method to display employee information
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Salary: ${Salary}");
        }
    }
    // Main program to demonstrate inheritance
    class TestEmployee
    {
        static void Main(string[] args)
        {
            // Creating a Manager object
            Manager manager = new Manager("Alice", 40, 80000, 10);
            manager.DisplayInfo(); // Inherited from Employee
            manager.ConductMeeting(); // Specific to Manager

            Console.WriteLine();

            // Creating a Developer object
            Developer developer = new Developer("Bob", 30, 60000, "C#");
            developer.DisplayInfo(); // Inherited from Employee
            developer.WriteCode(); // Specific to Developer
        }
    }
}

