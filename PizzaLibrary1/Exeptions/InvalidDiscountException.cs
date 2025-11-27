using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary1.Exeptions
{
    public class InvalidDiscountException: Exception
    {
        public InvalidDiscountException(string message) : base(message)
        {

        }
    } 

        ///Denne virker kun i ConsoleMenu. Jeg er meget i tvivl om hvordan jeg
        ///løser dette, da jeg ikke kan køre koden for program.cs uden at denne exception
        ///er i brug. De to andre exceptions virker 
        ///ellers fint i program.cs inden jeg lavede denne.
    
}
