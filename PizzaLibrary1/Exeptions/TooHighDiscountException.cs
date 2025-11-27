using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary1.Exeptions
{
    public class TooHighDiscountException: Exception //Denne exception bruge ikke længere, InvalidDiscountException bruges i stedet.
    {
        public TooHighDiscountException(string message) : base (message) 
        {
        }
    }
}
