using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using NewFeaturesRoslyn.Api;

namespace NewFeatureCollection.Api
{
	public interface INewFeaturesCollection<T> : IEnumerable<T>
	{
		void Put(T _value);
		IEnumerator<T> GetEnumerator();
	}
}

