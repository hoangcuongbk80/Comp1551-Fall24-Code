using System.Transactions;

namespace Lecture1
{
    internal class Program
    {
        static void RunFirst()
        {
            Console.Write("Enter your first name: ");
            string firstname = Console.ReadLine();
            Console.Write("Enter your last name: ");
            string lastname = Console.ReadLine();
            Console.Write("Enter your birth year: ");
            int birthyear = Convert.ToInt32(Console.ReadLine());
            int age = 2024 - birthyear;
            Console.WriteLine("Hello {0} {1}, {2}", lastname, firstname, age);
        }
        static void GetName()
        {
            Console.Write("Your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hi " + name);
        }
        static double Sum(double a, double b, double c) 
        {
            double sum = a + b + c;
            Console.WriteLine("a+b+c={0}", sum);
            return a + b + c;
        }
        static void GetAvgGrade()
        {
            Console.Write("Java: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("C++: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("C#: ");
            double c = Convert.ToDouble(Console.ReadLine());
            double avg = Sum(a, b, c) / 3.0;
            Console.WriteLine($"Avg: {avg:F20}");
        }
        static double SquareRoot(double Result)
        {
            return (Math.Sqrt(Result));
        }
        static void QuadraticEquation(double a, double b, double c)
        {
            double x1, x2, D;
            D = Convert.ToDouble(b * b - 4 * a * c);
            if ((a != 0) & (D >= 0))
            {
                x1 = Convert.ToDouble((-b + Math.Sqrt(D)) / (2 * a));
                x2 = Convert.ToDouble((-b - Math.Sqrt(D)) / (2 * a));
                Console.WriteLine("The result is: {0} and {1}", x1, x2);
            }
            else
            {
                Console.WriteLine("No solutions");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("-------Lecture 1------");
            
            RunFirst();

            /*double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            double result = AddFloatNumber(x, y);
            Console.WriteLine(result);
            Console.Read();*/

            //GetName();

            //Sum(3, 5, 6);

            //GetAvgGrade();

            /*double Value;
            Console.WriteLine("Enter a value:");
            Value = Convert.ToDouble(Console.ReadLine());
            if (Value >= 0)
            {
                Console.WriteLine("The result is:");
                Console.WriteLine(SquareRoot(Value));
            }
            else
            {
                Console.WriteLine("Negative number does not have a real square root");
            }*/

            /*double v1, v2, v3;
            Console.WriteLine("Enter values for a, b and c:");
            v1 = Convert.ToDouble(Console.ReadLine());
            v2 = Convert.ToDouble(Console.ReadLine());
            v3 = Convert.ToDouble(Console.ReadLine());
            QuadraticEquation(v1, v2, v3);*/

            Console.Read();
        }
    }
}
