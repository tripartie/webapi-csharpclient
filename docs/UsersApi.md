# TripartieWebAPI.CSharpClient.Api.UsersApi

All URIs are relative to *https://platform.preprod.tripartie.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Unregister**](UsersApi.md#unregister) | **DELETE** /api/web/users/ | Unregister
[**Fetch**](UsersApi.md#fetch) | **GET** /api/web/users/ | Fetch
[**Register**](UsersApi.md#register) | **POST** /api/web/users/ | Register



## Unregister

> void Unregister (string externalId = null, int? tripartieId = null)

Unregister

Unregister a User using its External ID or Tripartie ID.<br /> You MUST provide either <code>external-id</code> or <code>tripartie-id</code>, but not both.<br /> This wont delete the User's Tripartie account. 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TripartieWebAPI.CSharpClient.Api;
using TripartieWebAPI.CSharpClient.Client;
using TripartieWebAPI.CSharpClient.Model;

namespace Example
{
    public class UnregisterExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.preprod.tripartie.com";
            // Configure API key authorization: ClientIdAuth
            Configuration.Default.AddApiKey("client-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("client-id", "Bearer");

            var apiInstance = new UsersApi(Configuration.Default);
            var externalId = user-96;  // string | The User's External ID. (optional) 

            try
            {
                // Unregister
                apiInstance.Unregister(externalId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UsersApi.Unregister: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **externalId** | **string**| The User&#39;s External ID. | [optional] 
 **tripartieId** | **int?**| The User&#39;s Tripartie ID. | [optional] 

### Return type

void (empty response body)

### Authorization

[ClientIdAuth](../README.md#ClientIdAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Success |  -  |
| **400** | Bad request |  -  |
| **404** | Not found |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Fetch

> ModelUser Fetch (string externalId = null, int? tripartieId = null)

Fetch

Fetch a User by its External ID or Tripartie ID.<br /> You MUST provide either <code>external-id</code> or <code>tripartie-id</code>, but not both. 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TripartieWebAPI.CSharpClient.Api;
using TripartieWebAPI.CSharpClient.Client;
using TripartieWebAPI.CSharpClient.Model;

namespace Example
{
    public class FetchExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.preprod.tripartie.com";
            // Configure API key authorization: ClientIdAuth
            Configuration.Default.AddApiKey("client-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("client-id", "Bearer");

            var apiInstance = new UsersApi(Configuration.Default);
            var externalId = user-96;  // string | The User's External ID. (optional) 

            try
            {
                // Fetch
                ModelUser result = apiInstance.Fetch(externalId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UsersApi.Fetch: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **externalId** | **string**| The User&#39;s External ID. | [optional] 
 **tripartieId** | **int?**| The User&#39;s Tripartie ID. | [optional] 

### Return type

[**ModelUser**](ModelUser.md)

### Authorization

[ClientIdAuth](../README.md#ClientIdAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad request |  -  |
| **404** | Not found |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Register

> ModelUser Register (RequestRegisterUser requestRegisterUser)

Register

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TripartieWebAPI.CSharpClient.Api;
using TripartieWebAPI.CSharpClient.Client;
using TripartieWebAPI.CSharpClient.Model;

namespace Example
{
    public class RegisterExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.preprod.tripartie.com";
            // Configure API key authorization: ClientIdAuth
            Configuration.Default.AddApiKey("client-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("client-id", "Bearer");

            var apiInstance = new UsersApi(Configuration.Default);
            var requestRegisterUser = new RequestRegisterUser(); // RequestRegisterUser | 

            try
            {
                // Register
                ModelUser result = apiInstance.Register(requestRegisterUser);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UsersApi.Register: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **requestRegisterUser** | [**RequestRegisterUser**](RequestRegisterUser.md)|  | 

### Return type

[**ModelUser**](ModelUser.md)

### Authorization

[ClientIdAuth](../README.md#ClientIdAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Success |  -  |
| **400** | Bad request |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

