# InternalReservedAttributeGenerator

A C# Source Generator for generating C# reserved attributes with internal accessibility.

see also: https://github.com/ufcpp/InternalReservedAttributeContent

Some C# features depend on attributes and modifiers but these can be internal. For instance, you may get [CS0518](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0518?f1url=%3FappId%3Droslyn%26k%3Dk(CS0518)) "Predefined type 'System.Runtime.CompilerServices.IsExternalInit' is not defined or imported" errors when using records (C# 9.0 feature) and you can avoid this error by adding the `IsExternalInit` class internally in your project.

```cs
namespace System.Runtime.CompilerServices
{
    internal sealed class IsExternalInit { }
}
```

The InternalReservedAttributeGenerator automatically generates these attributes and modifiers:

- IsExternalInit for [init-only properties](https://github.com/dotnet/csharplang/blob/main/proposals/csharp-9.0/init.md) / [records](https://github.com/dotnet/csharplang/blob/main/proposals/csharp-9.0/records.md)
- ModuleInitializerAttribute for [module initializers](https://github.com/dotnet/csharplang/blob/main/proposals/csharp-9.0/module-initializers.md)
- SkipLocalsInitAttribute for [localsinit flag](https://github.com/dotnet/csharplang/blob/main/proposals/csharp-9.0/skip-localsinit.md)
- Attributes for [null-state static analysis](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/attributes/nullable-analysis)

## NuGet

[![NuGet](https://img.shields.io/nuget/v/InternalReservedAttributeGenerator?style=flat-square)](https://www.nuget.org/packages/InternalReservedAttributeGenerator)
