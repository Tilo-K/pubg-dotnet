![PUBG Developer API Logo](https://d16ehlcspsm2m.cloudfront.net/0.0.39/assets/pubg/logo_large-a7a4f3e0242846f9d0d722ef21ad7729defdf2bac2d04ce82255a2b7b9ec4741.png)


# Pubg-DotNet [![Build status](https://ci.appveyor.com/api/projects/status/w3vk9q4avelqpgcp?svg=true)](https://ci.appveyor.com/project/GavinPower747/pubg-dotnet)

A sync/async client library for communicating with the Pubg developer api. Supporting .Net Standard 2.0.

Contact GavinPower747 on the Pubg Api Discord for more details

## Installation

### Install via Nuget

From the nuget command line:

	nuget install Pubg-DotNet

From the .Net CLI

	dotnet add package Pubg-DotNet 

From Package Manager:

	PM> Install-Package Pubg-DotNet

From within Visual Studio:

1. Open the Solution Explorer.
2. Right-click on a project within your solution.
3. Click on *Manage NuGet Packages...*
4. Click on the *Browse* tab and search for "Pubg-DotNet".
5. Click on the Pubg-DotNet package, select the appropriate version in the right-tab and click *Install*.

# Contributions
All contributions are welcome, feel free to create an issue to suggest improvements/missing features or just submit a PR to our Development branch with any work you want to contribute yourself.

## Configuring Api Key

There are a number of ways to configure your api key. You can choose any of the below methods based on your circumstances, you only need to follow one of the examples below.

1. Static Configuration Method

In order to configure your Api Key through our config class you just need to add the following code:

**In Your Startup class**
```csharp
    PubgApiConfiguration.Configure(opt => 
    {
        opt.ApiKey = "myApiKey";
    });
```

2. Per Request

When making a request to one of our services, all of our request objects contain an ApiKey field, simply provide your api key here. Below we use the GetPubgPlayersRequest as an example

```csharp
  var playerService = new PubgPlayerService();
  var request = new GetPubgPlayersRequest
  {
    ApiKey = "myApiKey",
    PlayerNames = new string[] { "myplayername" }
  }
  
  playerService.GetPlayers(PubgRegion.PCEurope, request);
```

Or if the method doesn't need a request object the API key can be provided using an optional parameter at the end of each method call

```csharp
  var playerService = new PubgPlayerService();
  
  playerService.GetPlayer(PubgRegion.PCEurope, "myplayerid", apiKey: "MyApiKey");
```

3. Service Instanciation

When instanciating your service you can supply it with your api key

```csharp
    var matchService = new PubgMatchService("myApiKey");
```
