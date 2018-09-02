using System;

namespace Book_Library_Modified
{
    public class Book
    {
        public string title { get; set; }
        public string author { get; set; }
        public string publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public decimal price { get; set; }
    }
}
