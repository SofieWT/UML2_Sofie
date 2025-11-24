using PizzaLibrary1.Exeptions;
using PizzaLibrary1.Interfaces;
using PizzaLibrary1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary1.Services
{
    public class CustomerRepository : ICustomerRepository
    {
        private Dictionary<string, Customer> _customers;
        public int Count { get { return _customers.Count; } }

        public CustomerRepository()
        {
            //_customers = new Dictionary<string, Customer>();
            _customers = MockData.CustomerData;
        }
            

        public void AddCustomer(Customer customer)
        {
            if (_customers.ContainsKey(customer.Mobile))
            {
                throw new CustomerMobileNumberExist("Mobil nummeret er allerede i systemet... Tilføj kunden igen med et andet mobilnr."); //Denne massage kommer, hvis nummeret allerede er i listen.
            }
            _customers.Add(customer.Mobile, customer);
        }

        public List<Customer> GetAll()
        {
            List<Customer> returnList = new List<Customer>();
            foreach (Customer c in _customers.Values)
            {
                returnList.Add(c);
            }
            return returnList;

            //Man kan også bruge følgende kode:
            //return _customers.Values.ToList();
        }

        public Customer? GetCustomerByMobile(string mobile)
        { 
            if (_customers.ContainsKey(mobile))
            {
                return _customers[mobile];
            }
            return null;
        }

        public void PrintAllCustomers()
        {
            foreach(Customer c in _customers.Values)
            {
                Console.WriteLine(c.ToString());
            }
            
        }

        public void RemoveCustomer(string mobile)
        {
            if (!_customers.ContainsKey(mobile))
            {
                throw new CustomerMobileNumberExist($"Kunden med mobilnr {mobile} er ikke i listen... Prøv igen,");
            }
            _customers.Remove(mobile);
        }
        
        public List<Customer> GetAllClubMembers() 
        {
            List<Customer> allClubMembers = new List<Customer>();
            foreach(Customer c in _customers.Values)
            {
                if (c.ClubMember==true)
                {
                    allClubMembers.Add(c);
                }                
            }
            return allClubMembers;
        }

        public List<Customer> GetAllCustomersFromRoskilde()
        {
            List<Customer> allFromRoskilde = new List<Customer>();
            foreach (Customer c in _customers.Values)
            {
                if (c.Address.Contains("Roskilde".ToLower())) //Dette vil finde en addresse i Roskilde, hvis Roskilde er inkluderet i addressen??
                {
                    allFromRoskilde.Add(c);
                }
            }
            return allFromRoskilde;
        }


        //Hjælpe metode, som kan printe lister. Kan måske ende i "purefabrication klasse.

        public void PrintListe(List<Customer>List)
        {
            foreach(Customer c in List)
            {
                Console.WriteLine(c);
            }
            
        }
    }
}
