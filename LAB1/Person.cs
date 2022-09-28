using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
	public class Person
	{
		private string _FCs;
		private bool _Gender;
		private int _Age;

		public string FCs
		{
			get 
			{ 
				return _FCs; 
			}
			set 
			{
				if(VariableVerification.IsStringCorrect(value))
				{
                    _FCs = value;
                }
				else
				{
					Console.WriteLine("Не верно введённое имя");
				}
            }
		}

		public bool Gender
		{
			get 
			{
				return _Gender; 
			}
			set 
			{
				_Gender = value; 
			}
		}

		public int Age
		{
			get 
			{
				return _Age; 
			}	
			set
			{
				if(VariableVerification.IsAgeCorrect(value))
				{
                    _Age = value;
                }
				else
				{
                    Console.WriteLine("Не верно введённый возраст");
                }
            }
		}

		public Person(string fCs, bool gender, int age)
		{
			FCs = fCs;
			Gender = gender;
			Age = age;
		}

		public Person()
		{
			FCs = "Виктор";
            Gender = false;
            Age = 0;
		}

		~Person()
		{
		}

		public virtual void Print()
		{
			Console.WriteLine("Информация о сотруднике:");
			Console.WriteLine("ФИО: " + FCs);
			if(Gender)
			{
                Console.WriteLine("Пол: Женский");
            }
			else
			{
                Console.WriteLine("Пол: Мужской");
            }
			
			Console.WriteLine("Возраст: " + Age);
		}

		public void Input()
		{
			Console.WriteLine("Введите ФИО сотрудника:");
			string fCs = Console.ReadLine();
			FCs = fCs;

			Console.WriteLine("Введите пол сотрудника:");
			string gender =Console.ReadLine();
			VariableVerification.CorrectGender(ref gender);
			Gender = Convert.ToBoolean(gender);

			Console.WriteLine("Введите возраст сотрудника:");
			string age = Console.ReadLine();
			if(VariableVerification.IsNumberCorrect(age))
			{
				Age = Convert.ToInt32(age);
			}
			else
			{
				Console.WriteLine("Неверный ввод возраста");
			}
		}
	}
}
