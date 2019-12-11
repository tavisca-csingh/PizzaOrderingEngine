using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOrderEngine.Booking
{
    public class BookingItems
    {
        public List<BookedItem> bookingItems = new List<BookedItem>();
        public string TotalPrice { get; set; }
    }
}
