namespace Lecture4
{
    class Vehicle
    {
        public Vehicle() { Console.WriteLine("This is a Vehicle"); }
        public void Say() { Console.WriteLine("Vehicle"); }
    }

    class Car : Vehicle { 
        public Car() { Console.WriteLine("This is a car"); }
        public new void Say() { Console.WriteLine("Car"); }
    }
    // Main program
    class Program
    {
        static void Main1(string[] args)
        {
            Car myCar = new Car();
            myCar.Say();
        }
    }

}
