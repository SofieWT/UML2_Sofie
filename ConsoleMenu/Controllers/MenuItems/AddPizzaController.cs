using PizzaLibrary1.Interfaces;
using PizzaLibrary1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMenu.Controllers.MenuItems
{
    public class AddPizzaController
    {
        public MenuItem MenuItem { get; set; }
        private IMenuItemRepository _menuItemRepository;

        public AddPizzaController(string itemName, double price, string description, MenuType menuType, IMenuItemRepository menuItemRepository)
        {
            MenuItem = new MenuItem(itemName, price, description, menuType);
            _menuItemRepository = menuItemRepository;
        }
        public void AddMenuItem()
        {
            _menuItemRepository.AddMenuItem(MenuItem);
        }
    }
}
