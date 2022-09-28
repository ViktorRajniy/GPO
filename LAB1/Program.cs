// See https://aka.ms/new-console-template for more information
using LAB1;

namespace LAB1
{
	class Program
	{
		static void Main()
		{
			Person person = new Person("Оксингерт Виктор Константинович", false, 19);
			person.Print();
			Console.WriteLine();

			Person director = new Person("Михаил Андреевич Иванов", false, 40);
			Organization organization = new Organization("1C", 1991, director);
			Console.WriteLine();

			organization.Print();
			Console.WriteLine();

			Worker worker = new Worker("Иван Васильевич Петров", 30, false);
			HR.Employ(worker, organization);
			Console.WriteLine();
			worker.Print();
			HR.Dismiss(worker);
			Console.WriteLine();
			Console.WriteLine("Информация после увольнения: ");
			worker.Print();

		}
	}
}