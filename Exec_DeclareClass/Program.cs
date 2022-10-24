using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Exec_DeclareClass
{
	internal class Program
	{
		static void Main(string[] args)
		{
		}
	}
	class Address
	{
		public string City { get; set; }
		public string ZipCode { get; set; }
		public string Street { get; set; }


	}

	class Telephone
	{
		public string CountryCode { get; set; }
		public string AreaCode { get; set; }
		public string Number { get; set; }
		public string Ext { get; set; }
		
	}
	class Member
	{
		public string Name(string name) { return name; }
		public string Account(string account) { return account; }
		public string Password(string password) { return password; }
		public string Email(string email) { return email; }
		public Address Address(Address address) { return address; }
		public string CeilPhone(string cellphone) { return cellphone; }
		public Telephone telephone(Telephone telephone) { return telephone; }


		public void Register(string Name, string Account, string Password, string ConfirmPassword, string Email)
		{

		}
		public void ForgetPassword(string name, string Email)
		{

		}
		public void Authenticate(string Account, string Password)
		{

		}




	}
}
