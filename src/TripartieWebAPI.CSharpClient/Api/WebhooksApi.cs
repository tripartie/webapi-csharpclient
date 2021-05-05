/* 
 * Tripartie Web API
 *
 * This document describes all use cases offered by the Tripartie Web API.<br /><br /> The Tripartie Web API allows you to easily create Transaction templates.<br /> A Transaction template allows a User (the Buyer) to safely initiate a Transaction pre-configured by another User (the Seller).<br /> This allows you to add a Secured Payment button on your website pages.<br /><br /> To facilitate working with the Web API, we built libraries for common development environment:<br/> <ul class=\"bullet\">   <li><a target=\"_blank\" rel=\"noopener noreferrer\" href=\"https://github.com/tripartie/webapi-jsclient\">Javascript</a></li> </ul> <br/> You're reading the documentation for version 1.0 of the Web API.<br/> Go to version <select id=\"version-switcher\"></select> 
 *
 * The version of the OpenAPI document: 1.0
 * Contact: support@tripartie.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using RestSharp;
using TripartieWebAPI.CSharpClient.Client;
using TripartieWebAPI.CSharpClient.Model;

namespace TripartieWebAPI.CSharpClient.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IWebhooksApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Validate
        /// </summary>
        /// <remarks>
        /// Check a webhook&#39;s authenticity 
        /// </remarks>
        /// <exception cref="TripartieWebAPI.CSharpClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uuid">The Webhook UUID. (optional)</param>
        /// <returns>Webhook</returns>
        Webhook Validate (string uuid = default(string));

        /// <summary>
        /// Validate
        /// </summary>
        /// <remarks>
        /// Check a webhook&#39;s authenticity 
        /// </remarks>
        /// <exception cref="TripartieWebAPI.CSharpClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uuid">The Webhook UUID. (optional)</param>
        /// <returns>ApiResponse of Webhook</returns>
        ApiResponse<Webhook> ValidateWithHttpInfo (string uuid = default(string));
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Validate
        /// </summary>
        /// <remarks>
        /// Check a webhook&#39;s authenticity 
        /// </remarks>
        /// <exception cref="TripartieWebAPI.CSharpClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uuid">The Webhook UUID. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Webhook</returns>
        System.Threading.Tasks.Task<Webhook> ValidateAsync (string uuid = default(string), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Validate
        /// </summary>
        /// <remarks>
        /// Check a webhook&#39;s authenticity 
        /// </remarks>
        /// <exception cref="TripartieWebAPI.CSharpClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uuid">The Webhook UUID. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Webhook)</returns>
        System.Threading.Tasks.Task<ApiResponse<Webhook>> ValidateWithHttpInfoAsync (string uuid = default(string), CancellationToken cancellationToken = default(CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class WebhooksApi : IWebhooksApi
    {
        private TripartieWebAPI.CSharpClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksApi"/> class.
        /// </summary>
        /// <returns></returns>
        public WebhooksApi(String basePath)
        {
            this.Configuration = new TripartieWebAPI.CSharpClient.Client.Configuration { BasePath = basePath };

            ExceptionFactory = TripartieWebAPI.CSharpClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksApi"/> class
        /// </summary>
        /// <returns></returns>
        public WebhooksApi()
        {
            this.Configuration = TripartieWebAPI.CSharpClient.Client.Configuration.Default;

            ExceptionFactory = TripartieWebAPI.CSharpClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public WebhooksApi(TripartieWebAPI.CSharpClient.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = TripartieWebAPI.CSharpClient.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = TripartieWebAPI.CSharpClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public TripartieWebAPI.CSharpClient.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public TripartieWebAPI.CSharpClient.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Validate Check a webhook&#39;s authenticity 
        /// </summary>
        /// <exception cref="TripartieWebAPI.CSharpClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uuid">The Webhook UUID. (optional)</param>
        /// <returns>Webhook</returns>
        public Webhook Validate (string uuid = default(string))
        {
             ApiResponse<Webhook> localVarResponse = ValidateWithHttpInfo(uuid);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Validate Check a webhook&#39;s authenticity 
        /// </summary>
        /// <exception cref="TripartieWebAPI.CSharpClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uuid">The Webhook UUID. (optional)</param>
        /// <returns>ApiResponse of Webhook</returns>
        public ApiResponse<Webhook> ValidateWithHttpInfo (string uuid = default(string))
        {

            var localVarPath = "/api/web/webhooks/";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (uuid != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "uuid", uuid)); // query parameter

            // authentication (ClientIdAuth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("client-id")))
            {
                localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "client-id", this.Configuration.GetApiKeyWithPrefix("client-id")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Validate", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Webhook>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Webhook) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Webhook)));
        }

        /// <summary>
        /// Validate Check a webhook&#39;s authenticity 
        /// </summary>
        /// <exception cref="TripartieWebAPI.CSharpClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uuid">The Webhook UUID. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of Webhook</returns>
        public async System.Threading.Tasks.Task<Webhook> ValidateAsync (string uuid = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<Webhook> localVarResponse = await ValidateWithHttpInfoAsync(uuid, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Validate Check a webhook&#39;s authenticity 
        /// </summary>
        /// <exception cref="TripartieWebAPI.CSharpClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uuid">The Webhook UUID. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (Webhook)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Webhook>> ValidateWithHttpInfoAsync (string uuid = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/api/web/webhooks/";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (uuid != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "uuid", uuid)); // query parameter

            // authentication (ClientIdAuth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("client-id")))
            {
                localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "client-id", this.Configuration.GetApiKeyWithPrefix("client-id")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Validate", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Webhook>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Webhook) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Webhook)));
        }

    }
}
