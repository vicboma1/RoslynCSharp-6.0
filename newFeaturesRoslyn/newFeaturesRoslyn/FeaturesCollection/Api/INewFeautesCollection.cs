using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using NewFeaturesRoslyn.Api;
using static System.Console;

namespace NewFeaturesCollection.Api
{
	public interface INewFeautesCollection : IEnumerable<INewFeautesRoslyn>
	{
		void Put(INewFeautesRoslyn _value);

	    IEnumerator<INewFeautesRoslyn> GetEnumerator();
	}
}