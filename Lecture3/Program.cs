namespace Lecture3
{
    public class MyBook
    {
        public string title;
        public string author;
        public int year;

        public MyBook(string title, string author, int year)
        {
            this.title = title;
            this.author = author;
            this.year = year;
        }
        public MyBook(string author, int year)
        {
            this.title = title;
            this.author = author;
            this.year = year;
        }
    }
    internal class Program
    {
       static void Main(string[] args)
        {
            MyBook CShape = new MyBook("C#", "Cuong", 1999);
            MyBook Java = new MyBook("Cuong", 1999);
        }
    }
}