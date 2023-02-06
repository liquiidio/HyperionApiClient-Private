<div align="center">
 <img src="https://avatars.githubusercontent.com/u/82725791?s=200&v=4" align="center"
     alt="Liquiid logo" width="280" height="300">
</div>

# HyperionApiClient 

<div align="center">

[![builds](https://github.com/liquiidio/AtomicAssetsApiClient-Private/actions/workflows/dotnet-build.yml/badge.svg)](https://github.com/liquiidio/AtomicAssetsApiClient-Private/actions/workflows/dotnet-build.yml)
[![tests](https://github.com/liquiidio/AtomicAssetsApiClient-Private/actions/workflows/dotnet-test.yml/badge.svg)](https://github.com/liquiidio/AtomicAssetsApiClient-Private/actions/workflows/dotnet-test.yml)
 
</div>
*.NET and Unity3D-compatible (Desktop, Mobile, WebGL) Client-Library for Hyperion History APIs*

*See [Hyperion History by EosRio](https://eosrio.io/hyperion/)*

# Installation

**_Requires Unity 2019.1+ with .NET 4.x+ Runtime_**

This package can be included into your project by either:

 1. Installing the package via Unity's Package Manager (UPM) in the editor (recommended).
 2. Importing the .unitypackage which you can download here.
 3. Manually add the files in this repo.
 4. Installing it via NuGet.
---

### 1. Installing via Unity Package Manager (UPM).
In your Unity project:
 1. Open the Package Manager Window/Tab

    ![image](https://user-images.githubusercontent.com/74650011/208429048-37e2277c-3e10-4794-97e7-3ec87f55f8c9.png)

 2. Click on + icon and then click on "Add Package From Git URL"

    ![image](https://user-images.githubusercontent.com/74650011/208429298-76fe1101-95f3-4ab0-bbd5-f0a32a1cc652.png)

 3. Enter URL:  `https://github.com/liquiidio/HyperionApiClient-Private.git#upm`
   
---
### 2. Importing the Unity Package.
Download the UnityPackage here <<-- (Hyper link this). Then in your Unity project:

 1. Open up the import a custom package window
    
    ![image](https://user-images.githubusercontent.com/74650011/208430044-caf91dd9-111e-4224-8441-95d116dbec3b.png)

 3. Navigate to where you downloaded the file and open it.
    
    ![image](https://user-images.githubusercontent.com/74650011/208430782-871b64c5-fa00-44bf-96c3-685743b77a63.png)

 4. Check all the relevant files needed (if this is a first time import, just select ALL) and click on import.
   (!TODO!)
   // ADD THE CORRECT SCREENSHOT FOR IMPORT WINDOW
   
   ![image](https://user-images.githubusercontent.com/74650011/208431004-953e07d1-325d-4e9a-a4e1-fc845de06fdd.png)

---
### 3. Install manually. (!TODO!)
Download this project there here <<-- (Hyper link this to the zip download). Then in your Unity project:

 1. Copy the sources from `NativeWebSocket/Assets/WebSocket` into your `Assets` directory.

---
### 4. Install via NuGet (for Standard .NET users only - No Unity3D)

#### .NET CLI

`> dotnet add package Liquiid.io.Hyperion --version 1.0.3`

#### Package Manager

`PM> Install-Package Liquiid.io.Hyperion -Version 1.0.3`

---
# Usage 
.NET and Unity3D-compatible (Desktop, Mobile, WebGL) ApiClient for the different  APIs. 
Endpoints have its own set of parameters that you may build up and pass in to the relevant function.

---
### Examples

#### Accounts
Query various details about a specific account on the blockchain.
```csharp
       var accountsClient = new AccountsClient(new HttpClient());
       var account = await accountsClient.GetAccountAsync("eosio");
```

#### Chain
Get the ABI for a contract based on its account name
```csharp
       var chainClient = new ChainClient(new HttpClient());
       var abi = await chainClient.GetAbiAsync("eosio");
```

#### History
Get actions for a specific Account
```csharp
       var historyClient = new HistoryClient(new HttpClient());
       var actions = await historyClient.GetActionsAsync(null, null, "kingcoolcorv");
```

#### Stats
Get action and transaction stats for a given period
```csharp
       var statsClient = new StatsClient(new HttpClient());
       var actionUsage = await statsClient.GetActionUsageAsync("1h");
```

#### Status
Get Information about the health of the API
```csharp
       var statusClient = new StatusClient(new HttpClient());
       var health = await statusClient.HealthAsync();
```

#### System
Get Information about Accounts voting for Block Producers
```csharp
       var systemClient = new SystemClient(new HttpClient());
       var voters = await systemClient.GetVotersAsync();
```
