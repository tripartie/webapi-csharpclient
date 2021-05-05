# TripartieWebAPI.CSharpClient.Api.WebhooksApi

All URIs are relative to *https://platform.preprod.tripartie.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiWebWebhooksGet**](WebhooksApi.md#apiwebwebhooksget) | **GET** /api/web/webhooks/ | Validate
[**YourEndpointPost**](WebhooksApi.md#yourendpointpost) | **POST** /your-endpoint/ | Webhook



## ApiWebWebhooksGet

> Webhook ApiWebWebhooksGet (string uuid = null)

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
    public class ApiWebWebhooksGetExample
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
                Webhook result = apiInstance.ApiWebWebhooksGet(uuid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling WebhooksApi.ApiWebWebhooksGet: " + e.Message );
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


## YourEndpointPost

> void YourEndpointPost (Webhook webhook)

Webhook

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TripartieWebAPI.CSharpClient.Api;
using TripartieWebAPI.CSharpClient.Client;
using TripartieWebAPI.CSharpClient.Model;

namespace Example
{
    public class YourEndpointPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.preprod.tripartie.com";
            // Configure API key authorization: ClientIdAuth
            Configuration.Default.AddApiKey("client-id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("client-id", "Bearer");

            var apiInstance = new WebhooksApi(Configuration.Default);
            var webhook = new Webhook(); // Webhook | 

            try
            {
                // Webhook
                apiInstance.YourEndpointPost(webhook);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling WebhooksApi.YourEndpointPost: " + e.Message );
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
 **webhook** | [**Webhook**](Webhook.md)|  | 

### Return type

void (empty response body)

### Authorization

[ClientIdAuth](../README.md#ClientIdAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Acknowledged |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

