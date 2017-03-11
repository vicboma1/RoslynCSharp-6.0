using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using NewFeaturesCollection.Api;
using NewFeaturesRoslyn.Api;

namespace NewFeaturesCollection.Src
{

	public class NewFeaturesCollection : INewFeautesCollection
	{
		//Initializers for auto-properties
		private IList<INewFeautesRoslyn> features { get; } = new List<INewFeautesRoslyn>();

		public static INewFeautesCollection Create() => new NewFeaturesCollection();

		NewFeaturesCollection()
		{
		}

		//Extension Add methods in collection initializers
		public void Put(INewFeautesRoslyn _value) => this.features.Add(_value);

		public IEnumerator<INewFeautesRoslyn> GetEnumerator() => this.features.GetEnumerator();

		IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
	}

	//Extension methods
	//Expression bodies on method-like members
	static class NewFeaturesCollectionExtension
	{
		public static void Add(this NewFeaturesCollection newFeaturesCollection, INewFeautesRoslyn newFeautesRoslyn) =>
			newFeaturesCollection.Put(newFeautesRoslyn);
	}
}