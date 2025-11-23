using PizzaLibrary1.Interfaces;
using PizzaLibrary1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMenu.Controllers.Customers
{
    public class AddVIPCustomerController
    {

        ICustomerRepository _customerRepository;
        public VIPCustomer VIPCustomer { get; set; }

        public AddVIPCustomerController(string vipName, string vipMobile, string vipAddress, int theDiscount, ICustomerRepository customerRepository)
        {
            VIPCustomer = new VIPCustomer(vipName, vipMobile, vipAddress, theDiscount);            
            _customerRepository = customerRepository;
        }

        public void AddVIPCustomer()
        {
            _customerRepository.AddCustomer(VIPCustomer);
        }
    }
}
