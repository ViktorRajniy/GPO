using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
	public class Organization
	{
		private string _OrganizationName;
		private int _OrganizationYear;
		private Person _Director;

		public Organization()
		{
			OrganizationName = " - ";
			OrganizationYear = 2000;
			Director = new Person();
		}

        public Organization(string name, int year, Person person)
        {
            OrganizationName = name;
            OrganizationYear = year;
            Director = person;
        }

        public string OrganizationName
		{
			get 
			{
				return _OrganizationName; 
			}
			set 
			{
				if(VariableVerification.IsStringCorrect(value))
				{
                    _OrganizationName = value;
                }
				
			}	
		}

		public int OrganizationYear
		{
			get 
			{
				return _OrganizationYear; 
			}
			set 
			{
				if(VariableVerification.IsYearCorrect(value))
				{
                    _OrganizationYear = value;
                }
				else
				{
					Console.WriteLine("Не верно введённый год");
				}
			}
		}

		public Person Director
		{
			get 
			{
				return _Director; 
			}
            set
            {
                _Director = value;
            }
		}

		public void Print()
		{
			Console.WriteLine("Информация об организации:");
			Console.WriteLine("Название организации: " + OrganizationName);
			Console.WriteLine("Год основания: " + OrganizationYear);
            Console.WriteLine("Директор: " + Director.FCs);
        }
	}
}
