[![NuGet release](https://img.shields.io/nuget/v/LitmosApi.svg)](https://www.nuget.org/packages/LitmosApi/)
[![Build status](https://ci.appveyor.com/api/projects/status/t4q2m091mwf0uotn/branch/master?svg=true)](https://ci.appveyor.com/project/dampee/litmos-net/branch/master)

# Litmos.net

A csharp implementation for Litmos e-learning

## breaking change from earlier versions
Renamed LitmosApiClient to LitmosClient

## Implemented

* users / all users
* user / specific user with loginKey (for Single Sign On)

## Example

```csharp
var litmosClient = new LitmosClient("apiKey");
var users = litmosClient.GetUsers();
```

or use the Litmos configuration if you need to inject the configuration

```csharp
LitmosApi.LitmosConfiguration litmosConfig = new LitmosConfiguration();
litmosConfig.ApiKey = ConfigurationManager.AppSettings["litmos:ApiKey"];

var litmosClient = new LitmosClient(litmosConfig);
```

