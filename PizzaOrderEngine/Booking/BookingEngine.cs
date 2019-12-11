using PizzaOrderEngine.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOrderEngine.Booking
{
    public class BookingEngine
    {
        BookingItems bookingItem = new BookingItems();
        List<BookedItem> bookedItems = new List<BookedItem>() { };
        int sum = 0;
        public BookingItems getItems(string Id, int totalItem)
        {
            foreach (var item in PizzaItems.pizzaItems)
            {
                if (item.ID == Id && totalItem>0)
                {
                    int price = item.Price * totalItem;
                    bookedItems.Add(new BookedItem()
                    {
                        ID = item.ID,
                        Name = item.Name,
                        Totalitem = totalItem,
                        Category = item.Category,
                        TotalPrice = price.ToString()
                    });
                    sum += price;
                }
            }
            bookingItem.bookingItems = bookedItems;
            bookingItem.TotalPrice = sum.ToString();
            
            return bookingItem;
        }

        public void DisplayItem(BookingItems items)
        {
            int sum = 0,count=0;
            foreach(var item in items.bookingItems)
            {
                Console.WriteLine(item.ID+"|"+item.Name+"|"+item.Totalitem+ "|"+item.TotalPrice+ "|"+item.Category);
                sum += Convert.ToInt32(item.TotalPrice);
                if(item.Totalitem!=0)
                    count += Convert.ToInt32(item.Totalitem);
            }
            Console.WriteLine("************ Total Price :"+sum+" For Total Booked Item : "+count+"*****************");
        }
    }
}
