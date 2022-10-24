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
		public string City(string city) { return city; }
		public string ZipCode(string zipcode) { return zipcode; }
		public string Street(string street) { return street; }

	}

	class Telephone
	{
		public string CountryCode(string country) { return country; }
		public string AreaCode(string areacode) { return areacode; }
		public string Number(string number) { return number; }
		public string Ext(string ext) { return ext; }
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
