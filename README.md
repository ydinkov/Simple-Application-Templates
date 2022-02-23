
![](icon.png)

# Simple Application Templates

This repository contains minimal dotnet commandline templates that combine:
- [System.CommandLine](https://github.com/dotnet/command-line-api)
- [Microsoft.Extensions.DependencyInjection](https://docs.microsoft.com/en-us/dotnet/core/extensions/dependency-injection)


# Usage:

First we install the package from nuget:
```cmd
dotnet new --install Nibblebit.Templates.CommandLine
```

then navigate to your working directory and:
```cmd
dotnet new di-commandline
```