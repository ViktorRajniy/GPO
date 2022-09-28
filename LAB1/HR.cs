using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
	internal static class HR
	{
		public static void Employ(Worker worker, Organization org)
		{
			worker.WorcIn = org;
			Console.WriteLine("Введите должность сотрудника:");
			string post = Console.ReadLine();
			worker.Post = post;
			Console.WriteLine("Введите зарплату сотрудника:");
			string salary = Console.ReadLine();
			if (VariableVerification.IsNumberCorrect(salary))
			{
				worker.Salary = Convert.ToInt32(salary);
			}
			else
			{
				Console.WriteLine("Неверный ввод зарплаты");
			}
		}

		public static void Dismiss(Worker worker)
		{
			worker.WorcIn = null;
			worker.Post = "Без работы";
			worker.Salary = 0;
		}
	}
}
