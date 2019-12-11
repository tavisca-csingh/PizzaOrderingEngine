using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOrderEngine.Models
{
   public class PizzaItem
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }
    }
}
