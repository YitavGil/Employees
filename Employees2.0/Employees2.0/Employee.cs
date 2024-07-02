using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Employees2._0
{
	public class Employee
	{
		public Employee(string id, int code, string firstdName, string lastName, DateTime birthday, bool isMale, string status, string cellPhoneNumber, string city, string street, string streetNumber, string email)
		{
			Id = id; FirstName = firstdName; LastName = lastName; Birthday = birthday; IsMale = isMale; Status = status; Cellphone = cellPhoneNumber; City = city; Street = street; StreetNumber = streetNumber; Email = email; Code = code;
		}

		public string Id { get; set; }
		public int Code {  get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string FullName { get { return FirstName + " " + LastName; } }
		public DateTime Birthday { get; set; }
		public int Age { get { return DateTime.Now.Year - Birthday.Year; } }
		public bool IsMale { get; set; }
		public string Status { get; set; }
		public string Cellphone { get; set; } = string.Empty;
		public string City { get; set; }
		public string Street { get; set; }
		public string StreetNumber { get; set; }
		public string Address { get { return Street + " " + StreetNumber + " " + City; } }
		public string Email { get; set; }	


	}
}
