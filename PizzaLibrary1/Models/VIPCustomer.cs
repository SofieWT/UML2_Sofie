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
            get { return _discount; }//"The Discount is too high  or too low. It has to be between 1 and 25- VIPCustomer er ikke tilføjet..."
            set
            {
                if (value > 25 || value < 1)
                {
                    throw new InvalidDiscountException("The Discount is too high  or too low. It has to be between 1 and 25 - VIPCustomer er ikke tilføjet...");
                }
                else
                {
                    _discount = value;
                }
            }
        }

        public VIPCustomer(string name, string mobile, string address, int discount) : base(name, mobile, address)
        {
            //if (discount > 25 || discount < 1)
            //{
            //    throw new InvalidDiscountException("The Discount is too high  or too low. It has to be between 1 and 25- VIPCustomer er ikke tilføjet...");
            //}
            Discount = discount;
        }

        public override string ToString() //Overvej ID
        {
            //return $"Name:{Name}, this is a VIPCustomer!, Mobile: {Mobile}, Address: {Address}. " +
            //$"\nDiscount: {Discount} %";

            return base.ToString() + $" Kundetype: VIP-kunde! Discount: {Discount} %";
        }
        //Skal Customer klassen være abstract?
        //Den er lidt svær, da customerklassens metoder ville blive "tomme" og skal overrides af subklasserne
        //Det vil sige at f.eks. toString metoden for en alm. kunne vil ikke være der.
    }
}
