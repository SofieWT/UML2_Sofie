using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary1.Exeptions
{
    public class CustomerMobileNumberExist:Exception
    {
        public CustomerMobileNumberExist(string message) : base(message) 
        {
        }
    }
}