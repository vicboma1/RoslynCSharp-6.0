using System;
namespace Poco
{
	public class Poco
	{
		//Initializers for auto-properties
		public String Name { get; set; } = "Victor";
		public String Last { get; set; } = "Bolinches";

		//Expression bodies on method-like members
		public String Alias => "vicboma1";

		//FactoryMethod
		//Extension Add methods in collection initializers
		public static Poco Create() => new Poco();

		//Improved overload resolution
		void Foo(Func<Func<Int64>> func) { }
		void Foo(Func<Func<Int32>> func) { }
		void Foo(Func<Func<Int16>> func) { }

		Poco()
		{
			Foo(() => () => 1234);
		}
	}
}
