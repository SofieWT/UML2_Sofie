using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary1.Models
{
    public class Beverage : MenuItem
    {
        public bool Alcohol { get; set; }
        public Beverage(string itemName, double price, string description,MenuType menuType, bool alcohol) : base(itemName, price, description, menuType)
        {
            ItemName = itemName;
            Price = price;
            Description = description;
            TheMenuType = menuType;
            Alcohol = alcohol;
        }

        public override string ToString()
        {
            return $"Name: {ItemName}, price: {Price}kr., \n{Description}, Contains alcohol: {(Alcohol? "Yes" : "No")}";
        }
    }
}
