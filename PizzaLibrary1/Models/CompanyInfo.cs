using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary1.Models
{
	public class CompanyInfo
	{
		private string _cvr;

		public string CVR
		{
			get { return _cvr; }
			set { _cvr = value; }
		}
		private int _vat;

		public int VAT
		{
			get { return _vat; }
			set { _vat = value; }
		}

		private string _name;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		//Ekstra public string Addrese { get; set; }

		public int ClubDiscount { get; set; }

		private CompanyInfo() //Denne er private, da man ikke vil have at der laves flere instanser i denne.
		{
			
		}

		private static CompanyInfo _instans = null;

		public static CompanyInfo Instance
		{
			get 
			{ 
				if (_instans == null)
				{
					_instans = new CompanyInfo();
				}
				
				return _instans; 
			}
		}
			


	}	
}
