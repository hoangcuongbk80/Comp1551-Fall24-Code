namespace Lecture2
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            /*Console.WriteLine("-----Lecture 2-------");
            int myVariable;
            int myNewVariable = 5;
            myVariable = 1;
            myNewVariable = 2;
            Console.WriteLine("{0}, {1}", myVariable, myNewVariable);
            Console.WriteLine(myVariable.GetType());*/

            /*double grade = 6.2;
            Console.WriteLine("grade: {0}", grade);
            Console.WriteLine("Grade data type: {0}", grade.GetType());*/

            /*const double my_pi = 3.14;
            Console.WriteLine("PI={0}", my_pi);*/

            /*var full_name = "Hoang Cuong";
            var age = 20;
            var gpa = 8.8;
            var grade_in_letter = 'D';*/

            /*decimal a = 3.0M;
            decimal b = 0.0000000000000000000001M;
            var c = a + b;
            Console.WriteLine(c);*/

            /*int UserInput;
            bool Flag;
            Console.WriteLine("Enter a value:");
            UserInput = Convert.ToInt32(Console.ReadLine());
            Flag = (UserInput > 0);
            Console.WriteLine("The value is positive, {0}", Flag);*/

            /*Console.Write("Demo True of False: ");          

            bool demo = false;
            demo = bool.Parse(Console.ReadLine());

            int score;
            Console.Write("Enter a value:");
            score = Convert.ToInt32(Console.ReadLine());

            if(score < 40 || !demo) { 
                Console.WriteLine("Refer");
            }
            else if(score >= 40 && score < 50)
            {
                Console.WriteLine("Pass");
            }
            else if (score >= 50 && score < 60)
            {
                Console.WriteLine("Good");
            }
            else if (score > 60 && score < 80)
            {
                Console.WriteLine("Merit");
            }
            else
            {
                Console.WriteLine("Distinction");
            }*/

            /*int i;
            for(i = 0; i<=10; i++)
            {
                if(i % 2 == 1)
                    Console.WriteLine(i);
            }*/

            /*int i = 0;
            while (i <= 10)
            {
                Console.WriteLine(i); 
                i++;
            }*/

            /*int  i = 11;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i <= 10);*/

            char[] grades = { 'R', 'P', 'M', 'D' };
            string[] names = { "Nam", "Anh", "Hoang" };
            int[] scores = { 60, 80, 70 };

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            foreach (string c in names)
            {
                Console.WriteLine(c);
            }
        }
    }
}
