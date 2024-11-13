namespace Lecture5
{
    class Person
    {
        private string firstName = "";
        private string lastName = "";
        public string GetFirstName()
        {
            return this.firstName;
        }
        public string GetLasttName()
        {
            return this.lastName;
        }
        public void SetFirstName(string firstName)
        {
            this.firstName = firstName;
        }
        public void SetLastName(string lastName)
        {
            this.lastName = lastName;
        }
    }
    internal class Program
    {
        public enum Seasons
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }
        public enum Days
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        public enum ErrorCode
        {
            None = 0,
            NotFound = 404,
            ServerError = 500
        }
        static void MySwap(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        static dynamic Addition<T>(T x, T y)
        {
            return (dynamic)x + (dynamic)y;
        }
        static void Swap(ref int x, ref int y)
        {
            int temp = x; x = y; y = temp;
        }

        static void Swap(ref double x, ref double y)
        {
            double temp = x; x = y; y = temp;
        }

        static void Swap<T>(ref T x, ref T y)
        {
            T temp = x; x = y;  y= temp;
        }

        static void Main1(string[] args)
        {
            Console.WriteLine("-----------Lecture 5-----------");

            /*Seasons currentSeason = Seasons.Summer;
            Console.WriteLine("Current season: {0}", currentSeason);
            Seasons nextSeason = currentSeason + 1;
            Console.WriteLine("Next season: {0}", nextSeason);*/

            /*Days today = (Days)1 + 1;
            Console.WriteLine("{0}", today);*/

            /*ErrorCode code = ErrorCode.NotFound;
            Console.WriteLine(code);
            Console.WriteLine((int) code);*/

            /*int a = 0, b = 1;
            Console.WriteLine("a={0}, b={1}", a, b); // a=0, b=1
            //Swap(ref a, ref b);
            Swap<int>(ref a, ref b);
            Console.WriteLine("a={0}, b={1}", a, b); //a=1, b=0

            double c = 6.5, d = 8.5;
            Console.WriteLine("c={0}, d={1}", a, b); //c=6.5, b=8.5
            //Swap(ref c, ref d);
            Swap<double>(ref c, ref d);
            Console.WriteLine("c={0}, d={1}", a, b); //c=8.5, d=6.5

            string s1 = "FPT", s2 = "FGW";
            Console.WriteLine("s1={0}, s2={1}", s1, s2);
            Swap<string>(ref s1, ref s2);
            Console.WriteLine("s1={0}, s2={1}", s1, s2);*/

            /*int a = 1, b = 2;
            int c = Addition<int>(a, b);
            Console.WriteLine("a+b={0}", c);

            double x = 0.5, y = 1.5;
            double z = Addition<double>(x, y);
            Console.WriteLine("x+y={0}", z);*/

            /*Person[] people = new Person[10];
            for (int i = 0; i < people.Length; i++)
            {
                people[i] = new Person();
            }

            people[0].SetFirstName("An");
            people[1].SetFirstName("Linh");
            people[2].SetFirstName("Thuy");

            foreach (Person p in people)
            {
                Console.WriteLine(p.GetFirstName());
            }*/


            /*List<Person> MyList = new List<Person>();
            Person p1 = new Person();
            p1.SetFirstName("Anh");
            MyList.Add(p1);

            Person p2 = new Person();
            p2.SetFirstName("Hoa");
            MyList.Add(p2);

            Person p3 = new Person();
            p3.SetFirstName("Lan");
            MyList.Add(p3);

            MyList.RemoveAt(1);
            MyList.Insert(1, p2);

            foreach (Person p in MyList)
            {
                Console.WriteLine(p.GetFirstName());
            }*/

            /*DateTime a = new DateTime();
            Console.WriteLine(a.ToLongDateString());

            DateTime b = new DateTime(1945, 9, 2);
            Console.WriteLine(b.ToLongDateString());
            
            DateTime c = new DateTime(1945, 9, 2, 9, 10, 0);
            Console.WriteLine(c.ToLongTimeString());

            DateTime today = DateTime.Today;
            Console.WriteLine(today.ToLongDateString());

            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToLongTimeString());

            DateTime specificDate = new DateTime(2024, 6, 10, 15, 30, 0);

            DateTime futureDate = specificDate.AddYears(1).AddMonths(2).AddDays(3);
            Console.WriteLine("Future Date: " + futureDate);

            DateTime pastDate = specificDate.AddYears(-1).AddMonths(-2).AddDays(-3);
            Console.WriteLine("Past Date: " + pastDate);

            string formattedDate = specificDate.ToString("yyyy-MM-dd HH:mm:ss");
            Console.WriteLine("Formatted Date: " + formattedDate);

            string dateString = "2024-12-25 08:00:00";
            DateTime parsedDate = DateTime.ParseExact(dateString, "yyyy-MM-dd HH:mm:ss", null);
            Console.WriteLine("Parsed Date: " + parsedDate);*/

            /*DateTime now = DateTime.Now;
            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToLongTimeString());

            DateTime yesterday = now.AddDays(-1);
            Console.WriteLine(yesterday.ToLongDateString());

            DateTime tmr = now.AddDays(1);
            Console.WriteLine(tmr.ToLongDateString());

            Console.Read();*/
        }
    }
}
