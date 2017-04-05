# Roslyn C# - 6.0

### Instalation guide for Mac OSx
1 - Download Visual Studio for Mac 2017
 ``` 
 https://www.visualstudio.com/vs/visual-studio-mac/
 ```
2 - Install Hombrew
  ```
  Open terminal and copy :
  /usr/bin/ruby -e "$(curl -fsSL https://raw.githubusercontent.com/Homebrew/install/master/install)"
  ```
3 - Install Pre-requisits
  ```
  Open terminal and copy :
  
  brew update
  brew install openssl
  mkdir -p /usr/local/lib
  ln -s /usr/local/opt/openssl/lib/libcrypto.1.0.0.dylib /usr/local/lib/
  ln -s /usr/local/opt/openssl/lib/libssl.1.0.0.dylib /usr/local/lib/
  ```
  
4 - Install .NET Core SDK
```
https://go.microsoft.com/fwlink/?linkid=843444
```

5 - Open Visual Studio 2017 for Mac 

![](https://github.com/vicboma1/RoslynCSharp-6.0/blob/master/newFeaturesRoslyn/newFeaturesRoslyn/Resources/visualStudio2017Mac.gif)



### Indexes for new features for Roslyn compiler
* [Initializers for auto-properties](https://github.com/vicboma1/RoslynCSharp-6.0/blob/master/README.md#initializers-for-auto-properties)
* [Getter-only auto-properties](https://github.com/vicboma1/RoslynCSharp-6.0/blob/master/README.md#getter-only-auto-properties-setter-inline-inside-the-class)
* [Expression-bodied function members](https://github.com/vicboma1/RoslynCSharp-6.0/blob/master/README.md#expression-bodied-function-members)
* [Expression bodies on property-like function members](https://github.com/vicboma1/RoslynCSharp-6.0/blob/master/README.md#expression-bodies-on-property-like-function-members)
* [Using static](https://github.com/vicboma1/RoslynCSharp-6.0/blob/master/README.md#using-static)
* [Null-conditional operators](https://github.com/vicboma1/RoslynCSharp-6.0/blob/master/README.md#null-conditional-operators)
* [Null-coalescing operators](https://github.com/vicboma1/RoslynCSharp-6.0/blob/master/README.md#null-coalescing-operators)
* [String interpolation](https://github.com/vicboma1/RoslynCSharp-6.0/blob/master/README.md#string-interpolation)
* [nameof expressions](https://github.com/vicboma1/RoslynCSharp-6.0/blob/master/README.md#nameof-expressions)
* [Index initializers](https://github.com/vicboma1/RoslynCSharp-6.0/blob/master/README.md#index-initializers)
* [Exception filters](https://github.com/vicboma1/RoslynCSharp-6.0/blob/master/README.md#exception-filters)
* [Await in catch and finally blocks](https://github.com/vicboma1/RoslynCSharp-6.0/blob/master/README.md#await-in-catch-and-finally-blocks)
* [Extension Add methods in collection initializers](https://github.com/vicboma1/RoslynCSharp-6.0/blob/master/README.md#extension-add-methods-in-collection-initializers)
* [Improved overload resolution](https://github.com/vicboma1/RoslynCSharp-6.0/blob/master/README.md#improved-overload-resolution)


## Initializers for auto-properties
Before 
```c#
  public String Name { get; set; }
  public String Last { get; set; }
  
  public Constructor() {
    this.Name = "Victor";
    this.Last = "Bolinches";
  }
  
```

Now
```c#
  public String Name { get; set; } = "Victor";
  public String Last { get; set; } = "Bolinches";
```


## Getter-only auto-properties (setter inline inside the class)
Before 
```c#
  public Double Version { get; private set; } 
  
  public Constructor() {
     this.Version = 6.0;
  }
```

Now
```c#
  public Double Version { get; } 
  
  public Constructor() {
    this.Version = 6.0;
  }

```


## Expression-bodied function members
Before 
```c#
  public static INewFeautesRoslyn Create() {
    return new NewFeautesRoslyn();
  }
```

Now
```c#
  public static INewFeautesRoslyn Create() => new NewFeautesRoslyn();
```



## Expression bodies on property-like function members
Before 
```c#
  public String Alias() { return "vicboma1"; }
```

Now
```c#
  public String Alias => "vicboma1";
```


## Using static
Before 
```c#
  public void PrintLnAsync(String str) {
    Task.Factory.StartNew( ()=> Console.WriteLine(str));
  }

```

Now
```c#
  using static System.Console;
  ...
  public void PrintLnAsync(String str) => Task.Factory.StartNew( ()=> WriteLine(str));
```

## Extension methods
Before 
```c#
  public static class NewFeautesRoslynExtension {
    public static void PrintLnAsync(this NewFeautesRoslyn newFeautesRoslyn) {
      return Task.Factory.StartNew(() => Console.WriteLine(newFeautesRoslyn));
  }
  
  ...
  
  INewFeautesRoslyn newFeautesRoslyn = NewFeautesRoslyn.Create(5.0);
  PrintLnAsync(newFeautesRoslyn);
```

Now
```c#
  public static class NewFeautesRoslynExtension {
    public static void PrintLnAsync(this NewFeautesRoslyn newFeautesRoslyn) => Task.Factory.StartNew(() => WriteLine(newFeautesRoslyn));
  }
  
  ...
  
  NewFeautesRoslyn newFeautesRoslyn = NewFeautesRoslyn.Create(6.0);
  newFeautesRoslyn.PrintLnAsync();
```

## Null-conditional operators
Before 
```c#
  public int CountFriends() {
    if(friends.Count == null) throw new ArgumentNullException(nameof(x));
    return friends.Count;
  }
```

Now
```c#
  public int? CountFriends() => friends?.Count;
```

## Null-coalescing operators
Before 
```c#
  public int CountFriends() {
    if(friends.Count == null) 
      return 0;
    return friends.Count;
  }
```

Now
```c#
  public int? CountFriends() => friends?.Count ?? 0;
```

## String interpolation
Before 
```c#
  public override string ToString() {
    return string.Format("[NewFeautesRoslyn: Name={0}, Last={1}, Alias={2}, Version={3}]", Name, Last, Alias, Version);
  }
```

Now
```c#
  public override string ToString() => $"[NewFeautesRoslyn: Name={Name}, Last={Last}, Alias={Alias}, Version={Version}]";
```


## nameof expressions
Before with hard-coded
```c#
public override string ToString() {
    return string.Format("[NewFeautesRoslyn: Name={0}, Last={1}, Alias={2}, Version={3}]", Name, Last, Alias, Version);
  }
```

Now
```c#
  public override string ToString() => $"[{nameof(NewFeautesRoslyn)}: {nameof(Name)}={Name}, {nameof(Last)}={Last}, {nameof(Alias)}={Alias}, {nameof(Version)}={Version}]";

```


## Index initializers
Before 
```c#
public static IDictionary<String, String> GetFeatures() {
  return new Dictionary<String,String> {
    { "0", "Initializers for auto-properties"},
    { "1", "Getter-only auto-properties"},
    { "2", "Expression-bodied function members"},
    { "3", "Expression bodies on property-lik -  function members"},
    { "4", "Using static"}
   };
  }
```

Now
```c#
  public static IDictionary<String, String> GetFeatures() => new Dictionary<String,String> {
    ["0"] = "Initializers for auto-properties",
    ["1"] = "Getter-only auto-properties",
    ["2"] = "Expression-bodied function members",
    ["3"] = "Expression bodies on property-lik -  function members",
    ["4"] = "Using static"
  };
```

## Exception filters
Before 
```c#
  public void Exception() {
    var other = "other";
    var exit = "exit";
    try { throw new SystemException($"{exit}!!!"); }
    catch (SystemException e){
      if(e.Message.Contains(exit)
        WriteLine(nameof(Environment.Exit));
    }
   finally
   {
     Environment.Exit(-1);
   }
 }
```

Now
```c#
  public void Exception() {
    var exit = "exit";
    try { throw new SystemException($"{exit}!!!"); }
    catch (SystemException e) when (e.Message.Contains(nameof(exit))) {
      WriteLine(nameof(Environment.Exit));
    }
    finally
    {
      Environment.Exit(-1);
    }
  }
```

## Await in catch and finally blocks
New
```c#
  public async Task Exception() {
    var exit = "exit";
    try { throw new SystemException($"{exit}!!!"); }
    catch (SystemException e) when (e.Message.Contains(nameof(exit))) {
      await PrintLnConsoleAsync($"{nameof(Environment.Exit)}");
    }
    finally {
      await ExitAsync();
    }
  }
  
  public async Task PrintLnConsoleAsync(String str) => await Task.Factory.StartNew(() => WriteLine($"Console: {str}"));
  public async Task ExitAsync() => await Task.Factory.StartNew(() => { Environment.Exit(-1); });
```

## Extension Add methods in collection initializers
New
```c#
namespace newFeaturesRoslyn
{

	public class NewFeaturesCollection : IEnumerable<INewFeautesRoslyn>
	{
		//Initializers for auto-properties
		private IList<INewFeautesRoslyn> features { get; } = new List<INewFeautesRoslyn>();

		public NewFeaturesCollection()
		{
		}

		//Extension Add methods in collection initializers
		public void Put(NewFeautesRoslyn _value) => this.features.Add(_value);

		public IEnumerator<INewFeautesRoslyn> GetEnumerator() => this.features.GetEnumerator();

		IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
	}

	static class NewFeaturesCollectionExtension
	{
		public static void Add(this NewFeaturesCollection newFeaturesCollection, NewFeautesRoslyn newFeautesRoslyn) =>
			newFeaturesCollection.Put(newFeautesRoslyn);
	}
}

...

public static void Main(string[] args)
		{
			var newFeaturesCollection = new NewFeaturesCollection {
				NewFeautesRoslyn.Create(6.0,GetFeatures()),
				NewFeautesRoslyn.Create(6.0,GetFeatures1_6()),
				NewFeautesRoslyn.Create(6.0,GetFeatures7_14())
			};
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
```

## Improved overload resolution
New 
```c#
using System;

class Test
{
    static void Foo(Func<Func<long>> func) {}
    static void Foo(Func<Func<int>> func) {}

    static void Main()
    {
        Foo(() => () => 7);
    }
}
```

@Autor: Victor Bolinches

@Alias: vicboma1
