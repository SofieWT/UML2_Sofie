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
		private string _vat;

		public string VAT
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

        public int ClubDiscount { get; set; }

        private CompanyInfo(string cvr, string vat, string name, int clubDiscount)
        {
			CVR = cvr;
			VAT = vat;
			Name = name;
			ClubDiscount = clubDiscount;
        }
		private CompanyInfo instans = null;

		//public static CompanyInfo GetInstans()
		//{
		//	if (instans==null)
		//	{

		//	}
		//}
    }
}
