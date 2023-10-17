using System;
using System.Collections.Generic;
using System.Text;

namespace Demo1
{
    class MediaItem
    {
        public string Title { get; set; }
        public ushort Rating { get; set; }

        public MediaItem(string title, ushort rating)
        {
            Title = title;
            Rating = rating;
        }
    }
}
