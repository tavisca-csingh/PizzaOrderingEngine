using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOrderEngine.Models
{
    public static class PizzaItems
    {
        public static List<PizzaItem> pizzaItems = new List<PizzaItem>() {
                new PizzaItem() { ID = "112", Name = "The Big Margherita", Category = "veg" ,Price=120},
                new PizzaItem() { ID = "113", Name = "The Big Chese", Category = "veg",Price=130 },
                new PizzaItem() { ID = "114", Name = "The Big Pepperoni", Category = "veg",Price=140 },
                new PizzaItem() { ID = "115", Name = "The Big Three meats", Category = "Non veg",Price=150},
                new PizzaItem() { ID = "116", Name = "The Big Mushroom & Chese", Category = "veg",Price=189 },
                new PizzaItem() { ID = "117", Name = "The Garlic Prawn", Category = "veg",Price=190 },
                new PizzaItem() { ID = "118", Name = "The vegoroma", Category = "veg",Price=230 },
                new PizzaItem() { ID = "119", Name = "Chessy garlic pizza", Category = "veg",Price=190 },
                new PizzaItem() { ID = "120", Name = "Hawaiian", Category = "veg",Price=160 },
                new PizzaItem() { ID = "121", Name = "Pepperoni", Category = "veg",Price=110 },
                new PizzaItem() { ID = "122", Name = "Veg Trio", Category = "veg",Price=170 },
                new PizzaItem() { ID = "123", Name = "Loaded Veg", Category = "veg",Price=180 },
                new PizzaItem() { ID = "124", Name = "Mega Pepperoni", Category = "veg",Price=190 },
                new PizzaItem() { ID = "125", Name = "Cheese paneer", Category = "veg",Price=110 },
                new PizzaItem() { ID = "126", Name = "Onion", Category = "veg",Price=130 },
                new PizzaItem() { ID = "127", Name = "Tomato", Category = "veg",Price=120 },
                new PizzaItem() { ID = "128", Name = "Butter chichen", Category = "Non veg",Price=230 },
                new PizzaItem() { ID = "129", Name = "Garlic Chicken & bacon Ranch", Category = "Non veg",Price=220 },
                new PizzaItem() { ID = "130", Name = "Chicken Bacon & AIOLI", Category = "Non veg",Price=250 },
                new PizzaItem() { ID = "131", Name = "Chicken& Camembert", Category = "Non veg",Price=380 },
                new PizzaItem() { ID = "132", Name = "Chicken & cranbery", Category = "Non veg",Price=200 },
                new PizzaItem() { ID = "133", Name = "BBQ Chicken", Category = "Non veg",Price=260 }
                };
        public static void getMenu()
        {
            foreach (var item in pizzaItems)
            {
                Console.WriteLine(item.ID+"|"+item.Name + "|" + item.Category + "|" + item.Price);
            }
        }
    }
}
