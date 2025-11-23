using PizzaLibrary1.Exeptions;
using PizzaLibrary1.Interfaces;
using PizzaLibrary1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary1.Services
{
    public class MenuItemRepository : IMenuItemRepository
    {
        private List<MenuItem> _menuItemList;
        public int Count { get { return _menuItemList.Count; } }

        public MenuItemRepository()
        { 
            _menuItemList = MockData.MenuItemData;
        }

        public void AddMenuItem(MenuItem menuItem) 
        {
            if (GetMenuItemByNo(menuItem.No) != null)
            {
                throw new MenuItemNumberExist($"Der er allerede et menu item, som har nr.{menuItem.No} ");
            }
            _menuItemList.Add(menuItem);
        }


        public List<MenuItem> GetAll()
        {
            List<MenuItem> returnMenu = new List<MenuItem>();
            foreach(MenuItem m in _menuItemList)
            {
                returnMenu.Add(m);
            }
            return returnMenu;
                        
        }
        
        public MenuItem? GetMenuItemByNo(int no)
        {
            foreach(MenuItem item in _menuItemList)
            {
                if (item.No == no)
                {
                    return item;
                }
            }
            return null;
        }

        public void PrintAllMenuItems()
        {
            foreach (MenuItem m in _menuItemList)
            {
                Console.WriteLine(m.ToString());
            }
        }

        public void RemoveMenuItem(int no)
        {
            if (GetMenuItemByNo(no)==null)
            {
                throw new MenuItemNumberExist("Dette menu item nummer er ikke i systemet, prøv et andet");
            }
            _menuItemList.RemoveAt(no);
        }

        public List<MenuItem> GetAllItemsInGivenMenuType(MenuType menuType) 
        {
            List<MenuItem> menuTypeList = new List<MenuItem>();
            //Her går den igennem en liste med alle menuitems og sammenligner menutype, og tilføjer, de samme menutyper til en ny liste.
            foreach (MenuItem menuItem in _menuItemList)
            {
                if(menuItem.TheMenuType==menuType)
                {
                    menuTypeList.Add(menuItem);
                }
            }
            return menuTypeList;
        }

            //foreach (MenuItem menuItem in menuTypeList)
            //{
            //    if (menuItem.TheMenuType == menuType)
            //    {
            //        if (menuItem.Price > MostExpensive)
            //        {
            //            MostExpensive = menuItem.Price;
            //        }

            //    }
            //}


        public MenuItem? MostExpensiveGivenMenuItem(MenuType menuType)
        {
            MenuItem mostExpensive=null;

            foreach(MenuItem menuItem in _menuItemList)
            {
                if (menuItem.TheMenuType == menuType)
                {
                    if (mostExpensive == null || menuItem.Price > mostExpensive.Price)
                    {
                        mostExpensive = menuItem;
                    }                    
                }
            }
            return mostExpensive;
        }

        public MenuItem? MostExpensivePizza()
        {
            MenuItem mostExpensivePizza=null;
            foreach(MenuItem pizza in _menuItemList)
            {
                if (mostExpensivePizza== null||pizza.Price>mostExpensivePizza.Price)
                {
                    mostExpensivePizza = pizza;
                }
            }
            return mostExpensivePizza;
        }


        public MenuItem PrintMenu(List<MenuItem> menuItems)
        {
            MenuItem menuType = null;
            foreach (MenuItem m in _menuItemList)
            {
                
                if (menuType == null || m.TheMenuType != menuType.TheMenuType)
                {
                    Console.WriteLine(m.TheMenuType);
                    menuType = m;
                }
                Console.WriteLine(m.ToString());
            }
            return null;
        }




        public void PrintListe(List<MenuItem> List)
        {
            foreach (MenuItem m in List)
            {
                Console.WriteLine(m);
            }

        }

    }
}
