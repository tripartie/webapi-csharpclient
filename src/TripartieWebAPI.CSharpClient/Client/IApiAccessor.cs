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
using RestSharp;

namespace TripartieWebAPI.CSharpClient.Client
{
    /// <summary>
    /// Represents configuration aspects required to interact with the API endpoints.
    /// </summary>
    public interface IApiAccessor
    {
        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        Configuration Configuration {get; set;}

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        String GetBasePath();
        
        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        ExceptionFactory ExceptionFactory { get; set; }
    }
}
