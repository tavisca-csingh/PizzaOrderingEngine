using PizzaOrderEngine.Booking;
using PizzaOrderEngine.Models;
using System;
using System.Collections.Generic;

namespace PizzaOrderEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome \nselect the pizzas you want\n");
            PizzaItems.getMenu();
            Console.WriteLine("\nenter number of items u want to book");
            int query = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nenter item ID and No Of Items");
            BookingEngine booking = new BookingEngine();
            BookingItems items = new BookingItems();
            for (int item = 0; item < query; item++)
            {
                var input= Console.ReadLine();
                items=booking.getItems(input.Split()[0], Convert.ToInt32(input.Split()[1]));
                
            }
            Console.WriteLine("Items Booked \n");
            booking.DisplayItem(items);
            
            
            Console.WriteLine("***********************Thanks for Booking**********************");
            
            Console.ReadKey();
        }
    }
}
