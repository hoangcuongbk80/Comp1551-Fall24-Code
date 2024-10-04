static class MathUtilities
{
    // Method to calculate the factorial of a number
    public static long Factorial(int number)
    {
        if (number == 0 || number == 1)
        {
            return 1;
        }
        long result = 1;
        for (int i = 2; i <= number; i++)
        {
            result *= i;
        }
        return result;
    }

    // Method to calculate the greatest common divisor (GCD)
    public static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    // Method to calculate the power of a number
    public static double Power(double baseValue, int exponent)
    {
        double result = 1;
        for (int i = 0; i < exponent; i++)
        {
            result *= baseValue;
        }
        return result;
    }
}

// Main method to demonstrate static class usage
class TestMath
{
    static void Main1(string[] args)
    {
        Console.WriteLine("Factorial of 5: " + MathUtilities.Factorial(5)); // Output: Factorial of 5: 120
        Console.WriteLine("GCD of 48 and 18: " + MathUtilities.GCD(48, 18)); // Output: GCD of 48 and 18: 6
        Console.WriteLine("2 to the power of 3: " + MathUtilities.Power(2, 3)); // Output: 2 to the power of 3: 8
    }
}
