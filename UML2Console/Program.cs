// See https://aka.ms/new-console-template for more information
using PizzaLibrary1.Exeptions;
using PizzaLibrary1.Interfaces;
using PizzaLibrary1.Models;
using PizzaLibrary1.Services;
using System.ComponentModel;
using System.Runtime.ConstrainedExecution;

Console.WriteLine("Hello, World!");

Console.WriteLine("Testing customer:");
CustomerRepository cRepo = new CustomerRepository();


//Console.WriteLine("Test af AddCustomer:");

//cRepo.AddCustomer(c1);
//Console.WriteLine("Antal kunder i kartotektet " + cRepo.Count);
//Console.WriteLine("Antal kunder i kartotektet efter tilføjelse " + cRepo.Count);
//Console.WriteLine("Test af RemoveCustomer:");
//cRepo.RemoveCustomer("56565656");

//Console.WriteLine("Antal kunder i kartotektet efter fjernelse " + cRepo.Count);

//Console.WriteLine("Test af PrintAllCustomers:");
//cRepo.PrintAllCustomers();



//Console.WriteLine("Test af GetAll metode:");
//List<Customer> allCustomers =cRepo.GetAll();
//foreach(Customer c in allCustomers)
//{
//    Console.WriteLine(c.ToString());
//}

//Console.WriteLine("Test af GetCustomerByMobile:");
//cRepo.GetCustomerByMobile("12121212");
//Console.WriteLine(cRepo.GetCustomerByMobile("12121212"));

//Console.WriteLine("Testing GetAllClubMembers:");

//cRepo.GetAllClubMembers();
//cRepo.PrintListe(cRepo.GetAllClubMembers());

//Console.WriteLine("Testing af GetAllCustomersFromRoskilde");
//cRepo.AddCustomer(new Customer("Marie", "56565656", "Allé 5, Roskilde"));
//cRepo.AddCustomer(new Customer("Sofus", "23423423", "Bakkesvinget 89, Roskilde"));
//cRepo.PrintListe(cRepo.GetAllCustomersFromRoskilde());

//Console.WriteLine("Testing VIPCustomer:");
//VIPCustomer vip1 = new VIPCustomer("Oliver", "10101010", "Ringstedvej 42,Roskilde",6);
//Console.WriteLine(vip1.ToString());
//Console.WriteLine();

Console.WriteLine("testing exception af CustomerMobileNumberExist:");
Customer c1 = new Customer("Marie", "56565656", "Allé 5");
cRepo.AddCustomer(c1);
Customer c2 = new Customer("Sofus", "56565656", "Vej 51");
try
{
    cRepo.AddCustomer(c2);
}
catch (CustomerMobileNumberExist cex)
{
    Console.WriteLine($"Fejlbesked: {cex.Message}");
}
try
{
    cRepo.RemoveCustomer("90909090");
}
catch (CustomerMobileNumberExist cex)
{
    Console.WriteLine($"Fejlbesked: {cex.Message}");
}
Console.WriteLine();
Console.WriteLine("Ny test");
Customer c3 = new Customer("Mikkel", "12121212", "Street 123");
try
{
    cRepo.AddCustomer(c3);
}
catch (CustomerMobileNumberExist cex)
{
    Console.WriteLine($"Fejlbesked: {cex.Message}");
}
try
{
    cRepo.RemoveCustomer("90909090");
}
catch (CustomerMobileNumberExist cex)
{
    Console.WriteLine($"Fejlbesked: {cex.Message}");
}

Console.WriteLine();
Console.WriteLine("Testing af TOOHighDiscountException:");

try
{
    VIPCustomer vip1 = new VIPCustomer("Poul", "42424242", "Gaden 21", 50);
}
catch (TooHighDiscountException tex)
{
    Console.WriteLine($"Fejlbesked: {tex.Message}");
}



Console.WriteLine("Testing MenuItems:");

MenuItemRepository mRepo = new MenuItemRepository();

//Console.WriteLine("Antal Menu items i kartotektet " + mRepo.Count);
//Console.WriteLine();
//Console.WriteLine("Test af AddMenuItem:");
mRepo.AddMenuItem(new MenuItem("Gorgonzola", 85, "Tomat, gorgonzola, løg & Svampe", MenuType.PIZZECLASSSICHE));
//Console.WriteLine("Antal Menu items i kartotektet efter AddMenuItem" + mRepo.Count);
//Console.WriteLine();
//Console.WriteLine("Testing RemoveMenuItem:");
//mRepo.RemoveMenuItem(8);
//Console.WriteLine("Antal Menu items i kartotektet efter RemoveMenuItem" + mRepo.Count);

//Console.WriteLine("Testing PrintAll:");
//mRepo.PrintAllMenuItems();

//Console.WriteLine("Testing GetMenuItemByNo:");
//Console.WriteLine(mRepo.GetMenuItemByNo(1));

//Console.WriteLine("Testing GetAll:");

//List<MenuItem> allMenuItems = mRepo.GetAll();
//foreach(MenuItem m in allMenuItems)
//{
//    Console.WriteLine(m.ToString());
//}
mRepo.AddMenuItem(new("Pollo", 40, "Pesto, tomat, rucola salat, løg, Kylling", MenuType.SANDWICHES));

//Console.WriteLine("Testing af GetAllGivenMenuItem:");

//mRepo.PrintListe(mRepo.GetAllItemsInGivenMenuType(MenuType.PIZZECLASSSICHE));

//Console.WriteLine("\nTesting af MostExpensiveGivenMenuType");

//mRepo.MostExpensiveGivenMenuItem(MenuType.PIZZECLASSSICHE);

//Console.WriteLine("Testing PrintMenu:");

//mRepo.MostExpensiveGivenMenuItem(MenuType.PIZZECLASSSICHE);

//Console.WriteLine(mRepo.MostExpensiveGivenMenuItem(MenuType.PIZZECLASSSICHE));
//Console.WriteLine("Testing MostExpensivePizza");
//mRepo.MostExpensivePizza();
//Console.WriteLine(mRepo.MostExpensivePizza());

//Console.WriteLine("Testing PrintMenu");
//mRepo.PrintMenu(mRepo.GetAll());

//Console.WriteLine("Testing Beverage:");

//Beverage b1 = new Beverage("Bottle of Red Wine", 85, "This id red wine", MenuType.BEVERAGE, true);
//Console.WriteLine(b1.ToString());

Console.WriteLine("Testing af MenuItemNumberExist:");
MenuItem m1 = new MenuItem("Romana", 78, "tomat, ost, skinke, bacon, løg", MenuType.PIZZECLASSSICHE);
try
{
    mRepo.AddMenuItem(m1);
}
catch(MenuItemNumberExist mex)
{
    Console.WriteLine($"Fejlbesked: {mex.Message}");
}

CompanyInfo com1 = CompanyInfo.Instance;

CompanyInfo com2 = CompanyInfo.Instance;
Console.WriteLine(com2.Name);







