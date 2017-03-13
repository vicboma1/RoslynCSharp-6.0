using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NewFeaturesRoslyn.Src;
using NewFeatureCollection.Src;
using static Poco.Poco;

namespace newFeaturesRoslyn
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var poco = Create();

			var newFeaturesCollection = new NewFeaturesCollection {
				NewFeautesRoslyn.Create(6.0,GetFeatures()),
				NewFeautesRoslyn.Create(6.0,GetFeatures1_6()),
				NewFeautesRoslyn.Create(6.0,GetFeatures7_14())
			};

			foreach (var item in newFeaturesCollection)
			{
				item.PrintLnAsync();
			}

			Task.Factory.StartNew(() => { Environment.Exit(-1); });
		}

		//Index initializers
		public static IDictionary<String, String> GetFeatures() => new Dictionary<String, String>
		{
			["0"] = "Initializers for auto-properties"
		};

		//Index initializers
		public static IDictionary<String, String> GetFeatures1_6() => new Dictionary<String, String>
		{
			["1"] = "Getter-only auto-properties",
			["2"] = "Expression-bodied function members",
			["3"] = "Expression bodies on property-lik -  function members",
			["4"] = "Using static",
			["5"] = "Null-conditional operators",
			["6"] = "Null-coalescing operators",
		};

		//Index initializers
		public static IDictionary<String, String> GetFeatures7_14() => new Dictionary<String, String>
		{
			["7"] = "String interpolation",
			["8"] = "nameOf interpolation",
			["9"] = "Index initializers",
			["10"] = "Exception filters",
			["11"] = "Await in catch and finally blocks",
			["12"] = "Extension Add methods in collection initializers",
			["13"] = "Improved overload resolution"
		};

	}
}
	

