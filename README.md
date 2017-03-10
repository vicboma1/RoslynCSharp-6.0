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




###Indexes for new features for Roslyn compiler
* [Initializers for auto-properties]()
* [Getter-only auto-properties]()
* [Expression-bodied function members](https://github.com/vicboma1/RoslynCSharp-6.0/blob/master/README.md#expression-bodied-function-members)
* [Expression bodies on property-like function members]()
* [Using static]()
* [Null-conditional operators]()
* [String interpolation]()
* [nameof expressions]()
* [Index initializers]()
* [Exception filters]()
* [Await in catch and finally blocks]()
* [Extension Add methods in collection initializers]()
* [Improved overload resolution]()


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
  public static NewFeautesRoslyn Create() {
    return new NewFeautesRoslyn();
  }
```

Now
```c#
  public static NewFeautesRoslyn Create() => new NewFeautesRoslyn();
```



## Expression bodies on property-like function members
Before 
```c#

```

Now
```c#
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


## Null-conditional operators
Before 
```c#

```

Now
```c#
```


## String interpolation
Before 
```c#

```

Now
```c#
```


## nameof expressions
Before 
```c#

```

Now
```c#
```


## Index initializers
Before 
```c#

```

Now
```c#
```

## Exception filters
Before 
```c#

```

Now
```c#
```

## Await in catch and finally blocks
Before 
```c#

```

Now
```c#
```

## Extension Add methods in collection initializers
Before 
```c#

```

Now
```c#
```

## Improved overload resolution
Before 
```c#

```

Now
```c#
```

