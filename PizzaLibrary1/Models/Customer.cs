using PizzaLibrary1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary1.Models
{
    public class Customer:ICustomer
    {
        private int _id;
        private static int _counter = 0;

        public string Address { get; set; }
        public bool ClubMember { get; set; }

        public int Id { get { return _id; } }

        public string Mobile { get; set; }
        public string Name { get; set; }

        public Customer(string name, string mobile, string address)
        {
            Name = name;
            Mobile = mobile;
            Address = address;

            _counter++;
            _id = _counter;
        }

        public override string ToString()
        {
            return $"Name:{Name}, Id: {_id} Mobile: {Mobile}, Address: {Address}. Clubmember: {(ClubMember ? "Is member" : "Is NOT member")}";
        }
    }
}
