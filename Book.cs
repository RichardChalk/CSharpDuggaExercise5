using System;
using System.Collections.Generic;
using System.Text;

namespace Demo1
{
    class Book : MediaItem
    {
        // public string Title { get; set; }
        public string Author { get; set; }

        public ushort NumberOfPages { get; set; }   // max 65,535
        public bool ReadBook { get; set; }
        // public ushort Rating { get; set; }  // 0-10

        public Book(string title, string author, ushort numberOfPages, bool readBook, ushort rating)
            : base(title, rating)
        {
            Title = title;
            Author = author;
            NumberOfPages = numberOfPages;
            ReadBook = readBook;
            Rating = rating;
        }
    }
}
