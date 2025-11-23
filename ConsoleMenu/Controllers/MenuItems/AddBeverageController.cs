using PizzaLibrary1.Interfaces;
using PizzaLibrary1.Models;
using PizzaLibrary1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMenu.Controllers.MenuItems
{
    internal class AddBeverageController : AddPizzaController
    {
        public Beverage Beverage { get; set; }
        private IMenuItemRepository _menuItemRepository;

        public AddBeverageController(string itemName, double price, string description, MenuType menuType, bool alcohol, IMenuItemRepository menuItemRepository) : base(itemName, price, description, menuType, menuItemRepository)
        {
            Beverage = new Beverage(itemName, price, description, menuType, alcohol);
            _menuItemRepository = menuItemRepository;
        }
        public void AddBeverage()
        {
            _menuItemRepository.AddMenuItem(Beverage);
        }
    }
}
