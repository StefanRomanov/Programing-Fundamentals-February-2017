using System;

namespace Sales_Report
{
    public class Sales
    {
        public string town { get; set; }
        public string product { get; set; }
        public decimal price { get; set; }
        public decimal quantity { get; set; }

        public decimal total => price * quantity;
    }
}
