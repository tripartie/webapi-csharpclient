# TripartieWebAPI.CSharpClient - the C# library for the Tripartie Web API

This document describes all use cases offered by the Tripartie Web API.<br /><br />
The Tripartie Web API allows you to easily create Transaction templates.<br />
A Transaction template allows a User (the Buyer) to safely initiate a Transaction pre-configured by another User (the Seller).<br />
This allows you to add a Secured Payment button on your website pages.<br /><br />


This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 1.0
- SDK version: 1.0.0
- Build package: org.openapitools.codegen.languages.CSharpClientCodegen

## Frameworks supported


- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

## Dependencies


- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

## Installation

To use this package in your project, you must first create a GitHub Personal Access Token with at least the scope *read:packages*: https://docs.github.com/en/github/authenticating-to-github/creating-a-personal-access-token

You can then use this token to authenticate with the NuGet source:

```
NuGet source: https://nuget.pkg.github.com/tripartie/index.json
Username: <YOUR GITHUB USERNAME>
Password: <YOUR PERSONAL ACCESS TOKEN>
```

:point_up: You can test this by navigating to https://nuget.pkg.github.com/tripartie/index.json

You need to add this source in Visual Studio: 

Once this is done, you can add the package to your project: `Tools > NuGet Package Manager > Package Manager Settings`, then go to tab `Package Sources`, and add a new Package Source.

Finally, you can install the NuGet package within the `Package Manager Console` using:

```
Install-Package TripartieWebAPI.CSharpClient
```

If prompted, use your GitHub username and your Personal Access Token.


## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TripartieWebAPI.CSharpClient.Api;
using TripartieWebAPI.CSharpClient.Client;
using TripartieWebAPI.CSharpClient.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration.Default.BasePath = "https://platform.preprod.tripartie.com";
            // Configure API key authorization: ClientIdAuth
            Configuration.Default.ApiKey.Add("client-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("client-id", "Bearer");

            var apiInstance = new TransactionTemplatesApi(Configuration.Default);
            var externalId = template-87;  // string | The Transaction template's External ID. (optional) 

            try
            {
                // Fetch
                ModelTransactionTemplate result = apiInstance.Fetch(externalId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TransactionTemplatesApi.Fetch: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

## Documentation for API Endpoints

All URIs are relative to *https://platform.preprod.tripartie.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*TransactionTemplatesApi* | [**Fetch**](docs/TransactionTemplatesApi.md#fetch) | **GET** /api/web/transaction-templates/ | Fetch
*TransactionTemplatesApi* | [**Create**](docs/TransactionTemplatesApi.md#create) | **POST** /api/web/transaction-templates/ | Create
*UsersApi* | [**Unregister**](docs/UsersApi.md#unregister) | **DELETE** /api/web/users/ | Unregister
*UsersApi* | [**Fetch**](docs/UsersApi.md#fetch) | **GET** /api/web/users/ | Fetch
*UsersApi* | [**Register**](docs/UsersApi.md#register) | **POST** /api/web/users/ | Register
*WebhooksApi* | [**Validate**](docs/WebhooksApi.md#validate) | **GET** /api/web/webhooks/ | Validate


## Documentation for Models

 - [Model.Error](docs/Error.md)
 - [Model.ModelTransactionTemplate](docs/ModelTransactionTemplate.md)
 - [Model.ModelUser](docs/ModelUser.md)
 - [Model.RequestCreateTransactionTemplate](docs/RequestCreateTransactionTemplate.md)
 - [Model.RequestCreateTransactionTemplatePackageFormat](docs/RequestCreateTransactionTemplatePackageFormat.md)
 - [Model.RequestRegisterUser](docs/RequestRegisterUser.md)
 - [Model.Webhook](docs/Webhook.md)


## Documentation for Authorization


### ClientIdAuth

- **Type**: API key

- **API key parameter name**: client-id
- **Location**: URL query string

