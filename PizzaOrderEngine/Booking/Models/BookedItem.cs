using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOrderEngine.Booking
{
    public class BookedItem
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Totalitem { get; set; }
        public string TotalPrice { get; set; }
    }
}
