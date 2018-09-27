# RickAndMorty.Net.Api

![alt text](https://travis-ci.org/Carlj28/RickAndMorty.Net.Api.svg?branch=master)

.NET client for Rick And Morty knowledge base api: https://rickandmortyapi.com/

# Get from nuget

https://www.nuget.org/packages/RickAndMorty.Net.Api/

```Bash
Package Manager:
Install-Package RickAndMorty.Net.Api

.NET CLI
dotnet add package RickAndMorty.Net.Api
```

# Usage

Get service from factory class:

```CSharp
var service = RickAndMortyApiFactory.Create();
var result = service.GetCharacter(5);
```

Or register DI module (for now AutoFac only):

```CSharp
builder.RegisterModule(new RickAndMortyModule());
```

To get service interface:

```CSharp
public class A
{
  public A(IRickAndMortyService service)
  { 
  }
}
```

# Methods

Service contains all methods availible from api https://rickandmortyapi.com/documentation

