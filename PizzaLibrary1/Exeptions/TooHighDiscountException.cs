using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary1.Exeptions
{
    public class TooHighDiscountException: Exception
    {
        public TooHighDiscountException(string message) : base (message)
        {
        }
    }
}
