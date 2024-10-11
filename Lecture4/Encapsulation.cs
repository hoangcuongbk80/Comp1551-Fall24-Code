namespace Lecture4
{
    class Person
    {
        // Private field
        private string name;
        private int age;

        // Property for 'name' with both get and set accessors
        public string Name
        {
            get
            {
                return name; // The get method retrieves the value of 'name'
            }
            set
            {
                // The set method validates the input before assigning it to 'name'
                if (!string.IsNullOrEmpty(value))
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Name cannot be empty.");
                }
            }
        }

        // Property for 'age' with validation in set accessor
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                // Ensuring age is always positive
                if (value > 0)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Age must be greater than zero.");
                }
            }
        }

        // Method to display person's details
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }
    }

    // Main program
    class TestEncap
    {
        static void Main1(string[] args)
        {
            // Create a person object
            Person person = new Person();

            // Using properties to set values (with validation)
            person.Name = "Alice";   // Setting a valid name
            person.Age = 25;         // Setting a valid age

            person.DisplayInfo();    // Output: Name: Alice, Age: 25

            // Attempting to set invalid values
            person.Name = "";        // Output: Name cannot be empty.
            person.Age = -5;         // Output: Age must be greater than zero.
        }
    }

}
