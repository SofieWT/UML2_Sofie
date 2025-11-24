using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary1.Exeptions
{
    public class MenuItemNumberExist:Exception
    {
        public MenuItemNumberExist(string message) : base(message) //Denne exception bliver kastet i AddMenuItem og i RemoveMenuItem i MenuItemRepositoryog samles op i program.cs i console
        {
        }
    }
}
