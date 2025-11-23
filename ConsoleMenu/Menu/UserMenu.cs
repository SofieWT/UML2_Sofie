using ConsoleMenu.Controllers.Customers;
using ConsoleMenu.Controllers.MenuItems;
using PizzaLibrary1.Models;
using PizzaLibrary1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMenu.Menu
{
    public class UserMenu
    {
        private static string mainMenuChoices = "\t1.Vis Pizzamenu\n\t2.Vis Kunder\n\t3.Add Customer\n\t4.Add MenuItem\n\t5.Add VIPCustomer\n\t6.Add Beverage\n\tQ.Afslut\n\n\tIndtast valg:";

        private CustomerRepository _customerRepository = new CustomerRepository();
        private MenuItemRepository _menuItemRepository = new MenuItemRepository();
        private static string ReadChoice(string choices)
        {
            Console.Clear();
            Console.Write(choices);
            string choice = Console.ReadLine();
            Console.Clear();
            return choice.ToLower();
        }
        public void ShowMenu()
        {
            string theChoice = ReadChoice(mainMenuChoices);
            while (theChoice != "q")
            {
                switch (theChoice)
                {
                    case "1":
                        Console.WriteLine("Valg 1");
                        ShowMenuItemController showMenuItemController = new ShowMenuItemController(_menuItemRepository);
                        showMenuItemController.ShowAllMenuItems();
                        Console.ReadLine();
                        break;
                    case "2":
                        Console.WriteLine("Valg 2");
                        _customerRepository.PrintAllCustomers();
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.WriteLine("Valg 3");
                        Console.WriteLine("Indlæs navn:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Indlæs mobil nr:");
                        string mobile = Console.ReadLine();
                        Console.WriteLine("Indlæs adresse:");
                        string address = Console.ReadLine();
                        Console.WriteLine("Vil du være clubmember y/n");
                        string clubMemberString = Console.ReadLine().ToLower();
                        bool isClubMember = (clubMemberString[0] == 'y') ? true : false;
                        AddCustomerController addCustomerController = new AddCustomerController(name, mobile, address, isClubMember, _customerRepository);
                        addCustomerController.AddCustomer();
                        break;
                    case "4":
                        Console.WriteLine("valg 4");
                        Console.WriteLine("Indlæs navn:");
                        string itemName = Console.ReadLine();
                        Console.WriteLine("Indlæs pris:");
                        string price = Console.ReadLine();
                        double itemPrice = double.Parse(price);
                        Console.WriteLine("Indlæs beskrivelse:");
                        string description = Console.ReadLine();
                        Console.WriteLine("Indlæs menu type:");
                        string menuType = Console.ReadLine();
                        MenuType theMenuType = Enum.Parse<MenuType>(menuType);//Med parse skal det skrives helt korrekt før at der ikke kommer fejlmeddelse. Programmet crasher hvis det er forkert. kan man lave en fejlmeddelse?
                        AddPizzaController addPizzaController = new AddPizzaController(itemName, itemPrice, description, theMenuType, _menuItemRepository);
                        addPizzaController.AddMenuItem();
                        break;
                    case "5":
                        Console.WriteLine("Valg 5");
                        Console.WriteLine("Indlæs navn:");
                        string vipName = Console.ReadLine();
                        Console.WriteLine("Indlæs mobil:");
                        string vipMobile = Console.ReadLine();
                        Console.WriteLine("Indlæs addresse:");
                        string vipAddresse = Console.ReadLine();
                        Console.WriteLine("Indlæs mængde rabat");
                        string discount = Console.ReadLine().ToLower();
                        int theDiscount = int.Parse(discount);
                        AddVIPCustomerController addVIPCustomerController = new AddVIPCustomerController(vipName, vipMobile, vipAddresse, theDiscount, _customerRepository);
                        addVIPCustomerController.AddVIPCustomer();
                        break;
                    case "6":
                        Console.WriteLine("valg 6");
                        Console.WriteLine("Indlæs navn:");
                        string bevName = Console.ReadLine();
                        Console.WriteLine("Indlæs pris:");
                        string bPrice = Console.ReadLine();
                        double bevPrice = double.Parse(bPrice);
                        Console.WriteLine("Indlæs description:");
                        string bevDescription = Console.ReadLine();
                        Console.WriteLine("Indlæs om det indeholder alkohol y/n:");
                        string alkohol = Console.ReadLine().ToLower();
                        bool hasAlkohol = (alkohol[0] == 'y')?true:false; //Denne virker måske...
                        Console.WriteLine("Indlæs menutypen 'BEVERAGE'");
                        string bevMenuType = Console.ReadLine();
                        MenuType theBevMenuType = Enum.Parse<MenuType>(bevMenuType);
                        AddBeverageController addBeverageController = new AddBeverageController(bevName, bevPrice, bevDescription,theBevMenuType, hasAlkohol, _menuItemRepository);
                        addBeverageController.AddBeverage();
                        break;
                    default:
                        Console.WriteLine("Angiv et tal fra 1..6 eller q for afslut");
                        break;
                }
                theChoice = ReadChoice(mainMenuChoices);
            }
        }

    }
}
