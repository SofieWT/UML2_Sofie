using PizzaLibrary1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary1.Models
{
    public class MenuItem : IMenuItem
    {
        private int _no;
        private static int _counter = 0;

        public string Description { get; set; }
        public string ItemName { get; set; }

        public int No { get { return _no; } }

        public double Price { get; set; }
        public MenuType TheMenuType { get; set; }

        public MenuItem(string itemName, double price, string description, MenuType menuType)
        {
            ItemName = itemName;
            Price = price;
            Description = description;            
            TheMenuType = menuType;
                       
            _no = _counter++;
        }

        public override string ToString()
        {
            return $"{No} Name: {ItemName}, price: {Price} kr., Menutype: {TheMenuType} \nDescription: {Description}";
        }
    }
}
