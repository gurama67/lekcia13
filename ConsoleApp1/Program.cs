namespace ConsoleApp1
{
    class Person
    {
        private string firstName;
        private string lastName;
        private int age;

        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"firstName: {firstName}");
            Console.WriteLine($"lastName: {lastName}");
            Console.WriteLine($"age: {age}");
        }
    }
    //დავალება 2
    class Book
    {
        private string title;
        private string author;
        private double price;
        private int publicationYear;

        public Book()
        {
            title = "Unknown";
            author = "Unknown";
            price = 0;
            publicationYear = 0;
        }

        public Book(string title, string author, double price, int publicationYear)
        {
            this.title = title;
            this.author = author;
            this.price = price;
            this.publicationYear = publicationYear;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"title: {title}");
            Console.WriteLine($"author: {author}");
            Console.WriteLine($"price: {price}");
            Console.WriteLine($"publicationYear: {publicationYear}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Gurami", "Example", 15);

            person.PrintDetails();

            Console.WriteLine();

            Book book1 = new Book();
            book1.PrintDetails();

            Console.WriteLine();

            Book book2 = new Book("The Hobbit", "J.R.R. Tolkien", 25.50, 1937);
            book2.PrintDetails();
        }
    }
}