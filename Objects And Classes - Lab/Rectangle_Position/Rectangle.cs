using System;

namespace Rectangle_Position
{
    public class Rectangle
    {
        public int left { get; set; }
        public int top { get; set; }
        public int width { get; set; }
        public int height { get; set; }

        public int bottom => top - height;
        public int right => left + width;
    }
}
