using PizzaLibrary1.Exeptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary1.Models
{
    public class VIPCustomer : Customer
    {
        private int _discount;
        public int Discount 
        {
            get { return _discount; }
            set
            {
                if (value>25)
                {
                    throw new TooHighDiscountException("The Discount is too high - VIPCustomer er ikke tilføjet...");
                }
                _discount = Discount;
            }
        }

        public VIPCustomer(string name, string mobile, string address, int discount) : base(name, mobile, address)
        {
            Name = name;
            Mobile = mobile;
            Address = address;
            Discount = discount;
        }

        public override string ToString() //Overvej ID
        {
            return $"Name:{Name}, this is a VIPCustomer!, Mobile: {Mobile}, Address: {Address}. " +
                $"\nDiscount: {Discount} %";
        }

        //Skal Customer klassen være abstract?
        //Den er lidt svær, da customerklassens metoder ville blive "tomme" og skal overrides af subklasserne
        //Det vil sige at f.eks. toString metoden for en alm. kunne vil ikke være der.
    }
}
