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

		Poco()
		{
		}
	}
}
