using System;
using System.Collections.Generic;
using System.Linq;

namespace Book_Library
{
    class Book
    {
        public string title { get; set; }
        public string author { get; set; }
        public string publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public decimal price { get; set; }
    }
}
