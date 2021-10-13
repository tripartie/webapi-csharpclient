# TripartieWebAPI.CSharpClient.Api.TransactionTemplatesApi

All URIs are relative to *https://platform.preprod.tripartie.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Fetch**](TransactionTemplatesApi.md#fetch) | **GET** /api/web/transaction-templates/ | Fetch
[**Create**](TransactionTemplatesApi.md#create) | **POST** /api/web/transaction-templates/ | Create



## Fetch

> ModelTransactionTemplate Fetch (string externalId = null, int? tripartieId = null)

Fetch

Fetch a Transaction template by its External ID or Tripartie ID.<br /> You MUST provide either <code>external-id</code> or <code>tripartie-id</code>, but not both. 

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

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **externalId** | **string**| The Transaction template&#39;s External ID. | [optional] 
 **tripartieId** | **int?**| The Transaction template&#39;s Tripartie ID. | [optional] 

### Return type

[**ModelTransactionTemplate**](ModelTransactionTemplate.md)

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


## Create

> ModelTransactionTemplate Create (RequestCreateTransactionTemplate requestCreateTransactionTemplate)

Create

Create a Transaction template.<br /> You MUST provide either sellerExternalId or sellerTripartieId but not both 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TripartieWebAPI.CSharpClient.Api;
using TripartieWebAPI.CSharpClient.Client;
using TripartieWebAPI.CSharpClient.Model;

namespace Example
{
    public class CreateExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.preprod.tripartie.com";
            // Configure API key authorization: ClientIdAuth
            Configuration.Default.AddApiKey("client-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("client-id", "Bearer");

            var apiInstance = new TransactionTemplatesApi(Configuration.Default);
            var requestCreateTransactionTemplate = new RequestCreateTransactionTemplate(); // RequestCreateTransactionTemplate | 

            try
            {
                // Create
                ModelTransactionTemplate result = apiInstance.Create(requestCreateTransactionTemplate);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TransactionTemplatesApi.Create: " + e.Message );
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
 **requestCreateTransactionTemplate** | [**RequestCreateTransactionTemplate**](RequestCreateTransactionTemplate.md)|  | 
 **dryRun** | **bool** | Do a dry-run? | [optional] |

### Return type

[**ModelTransactionTemplate**](ModelTransactionTemplate.md)

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

