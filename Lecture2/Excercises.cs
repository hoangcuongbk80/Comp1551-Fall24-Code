using System;

//------------------Exercise 1: Leap Year Checker--------------------

// Problem:
// Write a program that checks if a given year is a leap year.
// A year is a leap year if:
// - It is divisible by 4,
// - It is not divisible by 100, unless it is also divisible by 400.

// Sample Input/Output:
// Enter a year: 2024
// 2024 is a leap year.
// Enter a year: 1900
// 1900 is not a leap year.

class Program1
{
    static void Main1()
    {
        Console.WriteLine("Enter a year:");
        int year = Convert.ToInt32(Console.ReadLine());

        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            Console.WriteLine($"{year} is a leap year.");
        }
        else
        {
            Console.WriteLine($"{year} is not a leap year.");
        }
    }
}

//--------------------------------- Eligibility for Voting------------------------------------
// Problem:
// Write a program that asks the user for their age and
// citizenship status (Yes or No).
// The program should check if the user is eligible to vote based on the following conditions:
// - The user must be 18 or older.
// - The user must be a citizen.

// Sample Input/Output:
// Enter your age: 19
// Are you a citizen? (Yes/No): Yes
// You are eligible to vote.

// Enter your age: 16
// Are you a citizen? (Yes/No): Yes
// You are not eligible to vote.

class Program2
{
    static void Main2()
    {
        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Are you a citizen? (Yes/No): ");
        string isCitizen = Console.ReadLine();

        if (age >= 18 && isCitizen.ToLower() == "yes")
        {
            Console.WriteLine("You are eligible to vote.");
        }
        else
        {
            Console.WriteLine("You are not eligible to vote.");
        }
    }
}


//-------------------------------Exercise 3: Password Strength Checker--------------------------------------
// Problem:
// Write a program that asks the user to input a password and
// checks if it meets the following criteria:
// - The password must be at least 8 characters long.
// - The password must contain at least one digit, one uppercase letter,
// and one lowercase letter.

// Sample Input/Output:
// Enter a password: MyPass123
// Password is strong.

// Enter a password: weakpass
// Password is weak.

class Program3
{
    static void Main3()
    {
        Console.Write("Enter a password: ");
        string password = Console.ReadLine();

        if (password.Length >= 8 &&
            password.Any(char.IsDigit) &&
            password.Any(char.IsUpper) &&
            password.Any(char.IsLower))
        {
            Console.WriteLine("Password is strong.");
        }
        else
        {
            Console.WriteLine("Password is weak.");
        }
    }
}


//--------------------------------Exercise 4: Grade Classification-------------------------------------
// Problem:
// Write a program that asks the user to input a grade (between 0 and 100)
// and then classifies the grade
// based on the following ranges:
// - 90-100: A
// - 80-89: B
// - 70-79: C
// - 60-69: D
// - Below 60: F

// Sample Input/Output:
// Enter your grade: 85
// Your grade is B.
class Program4
{
    static void Main4()
    {
        Console.Write("Enter your grade: ");
        int grade = Convert.ToInt32(Console.ReadLine());

        if (grade >= 90)
        {
            Console.WriteLine("Your grade is A.");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("Your grade is B.");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("Your grade is C.");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("Your grade is D.");
        }
        else
        {
            Console.WriteLine("Your grade is F.");
        }
    }
}

//----------------------------------Exercise 5: Prime Number Checker-----------------------------------
// Problem:
// Write a program that checks if a given number is a prime number.
// A prime number is a number that is greater than 1 and is only divisible
// by 1 and itself.

// Sample Input/Output:
// Enter a number: 29
// 29 is a prime number.

// Enter a number: 12
// 12 is not a prime number.

class Program5
{
    static void Main5()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        bool isPrime = true;

        if (number <= 1)
        {
            isPrime = false;
        }
        else
        {
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }

        if (isPrime)
        {
            Console.WriteLine($"{number} is a prime number.");
        }
        else
        {
            Console.WriteLine($"{number} is not a prime number.");
        }
    }
}


//-------------------------------Exercise 6: Find Maximum and Minimum in an Array--------------------------------------
// Problem:
// Write a program that takes an array of integers and finds
// the maximum and minimum values in the array.

// Sample Input/Output:
// Array: [12, 45, 7, 34, 99, 5, 27]
// Maximum: 99
// Minimum: 5
class Program6
{
    static void Main6()
    {
        int[] numbers = { 12, 45, 7, 34, 99, 5, 27 };
        int max = numbers[0];
        int min = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }

        Console.WriteLine($"Maximum: {max}");
        Console.WriteLine($"Minimum: {min}");
    }
}


//------------------Exercise 7: Remove Duplicates from an Array---------------------------------------------------
// Problem:
// Write a program that removes duplicate values from an array of integers and prints the array with
// unique elements only.

// Sample Input/Output:
// Array: [2, 4, 2, 5, 6, 4, 7, 8]
// Array without duplicates: [2, 4, 5, 6, 7, 8]

class Program
{
    static void Main7()
    {
        int[] numbers = { 2, 4, 2, 5, 6, 4, 7, 8 };
        List<int> uniqueNumbers = new List<int>();

        for (int i = 0; i < numbers.Length; i++)
        {
            if (!uniqueNumbers.Contains(numbers[i]))
            {
                uniqueNumbers.Add(numbers[i]);
            }
        }

        Console.WriteLine("Array without duplicates: " + string.Join(", ", uniqueNumbers));
    }
}


//----------------Exercise 8: Matrix Multiplication (2D Arrays)-----------------------------------------------------
// Problem:
// Write a program that multiplies two 2D arrays (matrices).

// Sample Input/Output:
// Matrix A (2x2):
// 1 2
// 3 4

// Matrix B (2x2):
// 5 6
// 7 8

// Product Matrix:
// 19 22
// 43 50

class Program8
{
    static void Main8()
    {
        int[,] matrixA = { { 1, 2 }, { 3, 4 } };
        int[,] matrixB = { { 5, 6 }, { 7, 8 } };
        int[,] productMatrix = new int[2, 2];

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                productMatrix[i, j] = 0;
                for (int k = 0; k < 2; k++)
                {
                    productMatrix[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }

        Console.WriteLine("Product Matrix:");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write(productMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
