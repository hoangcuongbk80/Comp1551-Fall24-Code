// Add -> Project Reference
using Lecture3;

namespace Comp1551_Su2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi Comp1551!");
            MyBook CShape = new MyBook("C#", "Cuong", 1999);
            MyBook Java = new MyBook("Cuong", 1999);
            Console.Read();
        }
    }
}
