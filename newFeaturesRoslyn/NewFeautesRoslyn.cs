using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using static System.Console;
using System.Linq;
using System.Text;

namespace newFeaturesRoslyn
{
	public class NewFeautesRoslyn : INewFeautesRoslyn
	{
		private string other = "other";
		private IDictionary<String, String> features;

		//Getter-only auto-properties
		public Double Version { get; }


		// Factory Method
		// Expression bodies on method-like members
		// Index initializers
		public static INewFeautesRoslyn Create(Double version, IDictionary<String, String> features) =>
				new NewFeautesRoslyn(version, features);

		//Constructor
		NewFeautesRoslyn(Double version, IDictionary<String, String> features)
		{
			this.Version = version;
			this.features = features;
		}

		//Null-conditional operator & null coalescing operator 
		public int? Count() => features?.Count ?? 0;

		//String interpolation
		//nameof expressions
		public override string ToString() =>
		$"[{nameof(NewFeautesRoslyn)}: {nameof(Version)}={Version} {nameof(Count)}={this.Count()} \n{nameof(ToString)}={ToListString()}]";

		public async Task PrintLnAsync() =>
			   await Task.Factory.StartNew(() => WriteLine($"Async: {this}"));

		async Task PrintLnConsoleAsync(String str) =>
			  await Task.Factory.StartNew(() => WriteLine($"Console: {str}"));

		void PrintLn() => WriteLine(this.ToString());

		//Exception filters
		//Await in catch and finally blocks
		//String interpolation
		//nameof expressions
		public async Task Exception()
		{
			var exit = "exit";
			try { throw new SystemException($"{exit}!!!"); }
			catch (SystemException e) when (e.Message.Contains(nameof(exit)))
			{
				await PrintLnConsoleAsync($"{nameof(Environment.Exit)}");
			}
			catch (Exception e) when (e.Message.Contains(nameof(other)))
			{
				PrintLn();
			}
			finally
			{
				await PrintLnAsync();
			}
		}

		String ToListString()
		{
			var sb = new StringBuilder();
			this.features.ToList().ForEach(x => sb.AppendLine(x.ToString()));
			return $"\n{sb.ToString()}";
		}
	}
}
