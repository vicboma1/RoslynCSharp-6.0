﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using static System.Console;

namespace NewFeaturesRoslyn.Api
{
	public interface INewFeautesRoslyn
	{
		Double Version { get; }
		int? Count();
		Task Exception();
		Task PrintLnAsync();
		string ToString();
	}
}