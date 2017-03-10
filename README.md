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

###Indexes for new features for Roslyn compiler
* [Initializers for auto-properties]()
* [Getter-only auto-properties]()
* [Getter-only auto-properties]()
* [Expression-bodied function members]()
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
