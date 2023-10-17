using System;
using System.Collections.Generic;
using System.Text;

namespace Demo1
{
    class Film : MediaItem
    {
        // public string Title { get; set; }
        public string Director { get; set; }

        public ushort NumberOfMinutes { get; set; }   // max 65,535
        public bool SeenFilm { get; set; }
        // public ushort Rating { get; set; }  // 0-10

        public Film(string title, string director, ushort numberOfMinutes, bool seenFilm, ushort rating)
            : base(title, rating)
        {
            Title = title;
            Director = director;
            NumberOfMinutes = numberOfMinutes;
            SeenFilm = seenFilm;
            Rating = rating;
        }
    }
}
