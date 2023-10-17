using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates a list for our media library
            List<MediaItem> myMediaLibrary = new List<MediaItem>();

            while (true)
            {
                Console.Clear();
                // Create a menu
                Console.WriteLine("1: Add a book");
                Console.WriteLine("2: Add a film");
                Console.WriteLine("3: Sort Library");
                Console.WriteLine("4: View Library");
                Console.WriteLine("5: Exit");
                int userChoice = Convert.ToInt32(Console.ReadLine());

                if (userChoice == 1)
                {
                    // Let's add a book!
                    myMediaLibrary.Add(BookInput());
                }
                else if (userChoice == 2)
                {
                    // Let's add a film
                    myMediaLibrary.Add(FilmInput());
                }

                else if (userChoice == 3)
                {
                    // Let's sort out library according to rating
                    SortLibrary(ref myMediaLibrary);
                }
                else if (userChoice == 4)
                {
                    // Looking at our library
                    ShowLibrary(myMediaLibrary);
                }
                else if (userChoice == 5)
                {
                    break;
                }
            }
        }

        private static MediaItem FilmInput()
        {
            Console.WriteLine("Please enter the title of the film: ");
            string filmTitle = Console.ReadLine();

            Console.WriteLine("Please enter the director of the film: ");
            string filmDirector = Console.ReadLine();

            Console.WriteLine("Please enter the number of minutes in the film: ");
            ushort filmNumberOfMinutes = Convert.ToUInt16(Console.ReadLine());

            Console.WriteLine("Have you finished watching the film: (y/n) ");
            char filmSeenChar = Convert.ToChar(Console.ReadLine());
            bool filmSeen = false;
            ushort filmRating = 0;
            if (filmSeenChar == 'y')
            {
                filmSeen = true;
                Console.WriteLine("Please enter your rating for the film (1-10): ");
                filmRating = Convert.ToUInt16(Console.ReadLine());
            }
            else
            {
                filmSeen = false;
            }

            Console.WriteLine("Film successfully added to library!");
            Console.ReadLine();

            Film myFilm = new Film(filmTitle, filmDirector, filmNumberOfMinutes, filmSeen, filmRating);
            return myFilm;
        }

        private static Book BookInput()
        {
            Console.WriteLine("Please enter the title of the book: ");
            string bookTitle = Console.ReadLine();

            Console.WriteLine("Please enter the author of the book: ");
            string bookAuthor = Console.ReadLine();

            Console.WriteLine("Please enter the number of pages in the book: ");
            ushort bookNumberOfPages = Convert.ToUInt16(Console.ReadLine());

            Console.WriteLine("Have you finished reading the book: (y/n) ");
            char bookReadChar = Convert.ToChar(Console.ReadLine());
            bool bookRead = false;
            ushort bookRating = 0;
            if (bookReadChar == 'y')
            {
                bookRead = true;
                Console.WriteLine("Please enter your rating for the book (1-10): ");
                bookRating = Convert.ToUInt16(Console.ReadLine());
            }
            else
            {
                bookRead = false;
            }

            Console.WriteLine("Book successfully added to library!");
            Console.ReadLine();

            Book myBook = new Book(bookTitle, bookAuthor, bookNumberOfPages, bookRead, bookRating);
            return myBook;
        }

        private static void SortLibrary(ref List<MediaItem> myMediaLibrary)
        {
            Console.Clear();
            Console.WriteLine("What do you want to sort the library by?");
            Console.WriteLine("1: Title (alphabetical-ascending)");
            Console.WriteLine("2: Rating (numerical-descending)");
            int sortBy = int.Parse(Console.ReadLine());

            if (sortBy == 1)
            {
                myMediaLibrary = myMediaLibrary.OrderBy(Book => Book.Title).ToList();
            }
            else if (sortBy == 2)
            {
                myMediaLibrary = myMediaLibrary.OrderByDescending(Book => Book.Rating).ToList();
            }
        }

        private static void ShowLibrary(List<MediaItem> myMediaLibrary)
        {
            Console.Clear();
            foreach (var mediaItem in myMediaLibrary)
            {
                if (mediaItem is Book)
                {
                    Book bookInLoop = (Book)mediaItem;
                    Console.WriteLine("\nBook");
                    Console.WriteLine("****");
                    Console.WriteLine(bookInLoop.Title);
                    Console.WriteLine(bookInLoop.Author);
                    Console.WriteLine(bookInLoop.NumberOfPages);
                    Console.WriteLine(bookInLoop.ReadBook);
                    Console.WriteLine(bookInLoop.Rating);
                }
                if (mediaItem is Film)
                {
                    Film filmInLoop = (Film)mediaItem;
                    Console.WriteLine("\nFilm");
                    Console.WriteLine("****");
                    Console.WriteLine(filmInLoop.Title);
                    Console.WriteLine(filmInLoop.Director);
                    Console.WriteLine(filmInLoop.NumberOfMinutes);
                    Console.WriteLine(filmInLoop.SeenFilm);
                    Console.WriteLine(filmInLoop.Rating);
                }
            }
            Console.WriteLine("\nPress any key to return to main menu.");
            Console.ReadLine();
        }

    }
}

