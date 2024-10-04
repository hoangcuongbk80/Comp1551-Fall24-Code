class Student
{
    public string Name;
    public int Age;
    public string Program;

    // Default Constructor
    public Student()
    {
        Name = "Unknown";
        Age = 0;
        Program = "Undeclared";
    }

    // Parameterized Constructor
    public Student(string name, int age, string program)
    {
        Name = name;
        Age = age;
        Program = program;
    }

    // Method to display student information
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Program: {Program}");
    }
}

// Main method to demonstrate constructors
class TestStudent
{
    static void Main1(string[] args)
    {
        // Using default constructor
        Student student1 = new Student();
        student1.DisplayInfo(); // Output: Name: Unknown, Age: 0, Program: Undeclared

        // Using parameterized constructor
        Student student2 = new Student("Alice", 20, "Computer Science");
        student2.DisplayInfo(); // Output: Name: Alice, Age: 20, Program: Computer Science
    }
}
