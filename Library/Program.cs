using Library;

class Program
{
    static void Main(string[] args)
    {
        // Create a new instance (object) of the Book class
        // Note how the object name differs from the class name
        Book book = new Book("C# for beginners", "Bill Gates", "1234567");

        book.DisplayInfo();

        // Create another instance of the Book class
        Book book1 = new Book("Ultimate C", "Microsoft", "988776");

        book1.DisplayInfo();
    }
}
