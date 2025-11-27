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
        public int Count 
        {
            get { return _menuItemList.Count; } 
        }

        public MenuItemRepository()
        { 
            _menuItemList = MockData.MenuItemData;
        }

        public void AddMenuItem(MenuItem menuItem) //Man kan også lave en ny metode, som tjekker om Navnet er i listen.
        {
            if (GetMenuItemByNo(menuItem.No) == null)
            {
                _menuItemList.Add(menuItem);               
            }
            throw new MenuItemNumberExist($"Der er allerede et menu item, som har nr.{menuItem.No}, prøv igen med et andet nr.");
        }
        

        public List<MenuItem> GetAll()
        {
            //List<MenuItem> returnMenu = new List<MenuItem>();
            //foreach(MenuItem m in _menuItemList)
            //{
            //    returnMenu.Add(m);
            //}
            //return returnMenu;
            return _menuItemList;     
        }
        
        public MenuItem? GetMenuItemByNo(int no)
        {
            foreach (MenuItem item in _menuItemList)
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
                Console.WriteLine(m);
            }
        }

        public void RemoveMenuItem(int no)
        {
            //for (int i; i<_menuItemList; i++)
            //{ 
            //    if ()
            //}
            if (GetMenuItemByNo(no)!=null)
            {
                _menuItemList.Remove(GetMenuItemByNo(no));                
            }            
            throw new MenuItemNumberExist("Dette menu item nummer er ikke i listen, prøv at slettet et andet nr.");
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
            MenuItem mostExpenciveMenuItem = null;
            foreach(MenuItem m in _menuItemList)
            {
                if(m.TheMenuType == MenuType.PIZZECLASSSICHE || m.TheMenuType == MenuType.PIZZESPECIALI)
                {
                    if (mostExpenciveMenuItem.Price == null || mostExpenciveMenuItem.Price > m.Price)
                    {
                        mostExpenciveMenuItem = m;
                    }
                }                
            }
            return mostExpenciveMenuItem;
        }        


        public MenuItem PrintMenu(List<MenuItem> menuItems)
        {
            MenuItem menuType = null;
            foreach (MenuItem m in _menuItemList)
            {                
                if (menuType == null || m.TheMenuType != menuType.TheMenuType)
                {
                    Console.WriteLine($"---{m.TheMenuType}--");
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
