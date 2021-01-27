using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			//var person = new Person();
			var person  = Person.Parse("John");
			//person.Name = "John";
			person.Introduce("Mosh");
		}
	}
}