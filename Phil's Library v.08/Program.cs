namespace Phil_s_Library_v._08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string libraryName = "Phil's Lending Library";
            foreach (char character in libraryName)
            {
                Console.Write(character);
                Thread.Sleep(100); // adjust delay here
            }
            Console.WriteLine();
            Console.WriteLine("Hello, welcome to the Library!");
            Library myLibrary = new Library();
            Backpack backPack = new Backpack();

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Press the corresponding key to continue.");
                Console.WriteLine("Add a Book [1]");
                Console.WriteLine("Borrow a Book [2]");
                Console.WriteLine("Return a Book [3]");
                Console.WriteLine("Search for a book [4]");
                Console.WriteLine("View all Books [5]");
                Console.WriteLine();
                string userInput = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("#####################################");
                if (userInput == "5")
                {
                    myLibrary.ViewAllBooks();
                }
                else if (userInput == "1")
                {
                    Console.WriteLine("Please enter the Title of the book");
                    string bookTitle = Console.ReadLine();
                    Console.WriteLine("Please enter the Author of the book");
                    string bookAuthor = Console.ReadLine();
                    Book newBook = new Book(bookTitle, bookAuthor);
                    myLibrary.Add(bookTitle, bookAuthor);
                }
                else if (userInput == "2")
                {
                    Console.WriteLine("Which book would you like to borrow?");
                    string borrowedBook = Console.ReadLine();
                    Book borrowed = myLibrary.Borrow(borrowedBook);
                    //I'm done :)
                    backPack.Pack(borrowed);
                }
                else if (userInput == "3")
                {
                    backPack.ViewAll();
                    Console.WriteLine("Please select a book you want to return");
                    string userChoice = Console.ReadLine();
                    int index = Convert.ToInt32(userChoice);
                    Book Unpack = backPack.Unpack(index);
                    myLibrary.Add(Unpack.Title, Unpack.Author);
                }
                else if(userInput == "4")
                {
                    Console.WriteLine("Search for a book by title");
                    string userChoice = Console.ReadLine();
                    myLibrary.Search(userChoice);
                }
                Console.WriteLine("#####################################");


            }

        }
    }
}