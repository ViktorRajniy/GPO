using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
	public class Worker: Person
	{
		public int _Salary;
		public string _Post;
		public Organization _WorcIn;

		public Organization WorcIn
		{
			get 
			{
				return _WorcIn; 
			}

			set 
			{
				_WorcIn = value; 
			}
		}

		public int Salary
		{
			get 
			{
				return _Salary; 
			}

			set 
			{
				_Salary = value; 
			}
		}

		public string Post
		{
			get
			{
				return _Post;
			}

			set 
			{
				if(VariableVerification.IsStringCorrect(value))
				{
					_Post = value;
				}
				else
				{
					Console.WriteLine("Неверный ввод должности");
				}
			}
		}

		public Worker(string fcs, int age, bool gender ): base( fcs, gender, age)
		{
			HR.Dismiss(this);
		}

		public Worker() : base()
		{
			HR.Dismiss(this);
		}

		public void Input()
		{
			base.Input();
			HR.Dismiss(this);
		}

		public override void Print() 
		{
			Console.WriteLine("Информация о сотруднике:");
			Console.WriteLine("ФИО: " + FCs);
			if (Gender)
			{
				Console.WriteLine("Пол: Женский");
			}
			else
			{
				Console.WriteLine("Пол: Мужской");
			}
			if(this.WorcIn == null)
			{
				Console.WriteLine("Безработный");
			}
			else
			{
				Console.WriteLine("Возраст: " + Age);
				Console.WriteLine("Должность: " + Post);
				Console.WriteLine("Зарплата: " + Salary);
				Console.WriteLine("Место работы: " + WorcIn.OrganizationName);
			}
		}
	}
}
