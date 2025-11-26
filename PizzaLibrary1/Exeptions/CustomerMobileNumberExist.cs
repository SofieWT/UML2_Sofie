using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary1.Exeptions
{
    public class CustomerMobileNumberExist:Exception
    {
        public CustomerMobileNumberExist(string message) : base(message) //Denne exception bliver kastet i metoden AddCustomer og RemoveCustomer i CustomerRepository og samles op i program.cs i console
        {
        }
    }
}
