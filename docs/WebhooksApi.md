# TripartieWebAPI.CSharpClient.Api.WebhooksApi

All URIs are relative to *https://platform.preprod.tripartie.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Validate**](WebhooksApi.md#validate) | **GET** /api/web/webhooks/ | Validate



## Validate

> Webhook Validate (string uuid = null)

Validate

Check a webhook's authenticity 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TripartieWebAPI.CSharpClient.Api;
using TripartieWebAPI.CSharpClient.Client;
using TripartieWebAPI.CSharpClient.Model;

namespace Example
{
    public class ValidateExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.preprod.tripartie.com";
            // Configure API key authorization: ClientIdAuth
            Configuration.Default.AddApiKey("client-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("client-id", "Bearer");

            var apiInstance = new WebhooksApi(Configuration.Default);
            var uuid = 123e4567-e89b-12d3-a456-426614174000;  // string | The Webhook UUID. (optional) 

            try
            {
                // Validate
                Webhook result = apiInstance.Validate(uuid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling WebhooksApi.Validate: " + e.Message );
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
 **uuid** | **string**| The Webhook UUID. | [optional] 

### Return type

[**Webhook**](Webhook.md)

### Authorization

[ClientIdAuth](../README.md#ClientIdAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Webhook is authentic |  -  |
| **400** | Webhook is not authentic |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

