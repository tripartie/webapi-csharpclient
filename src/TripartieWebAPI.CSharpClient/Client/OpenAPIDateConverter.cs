/* 
 * Tripartie Web API
 *
 * This document describes all use cases offered by the Tripartie Web API.<br /><br /> The Tripartie Web API allows you to easily create Transaction templates.<br /> A Transaction template allows a User (the Buyer) to safely initiate a Transaction pre-configured by another User (the Seller).<br /> This allows you to add a Secured Payment button on your website pages.<br /><br /> To facilitate working with the Web API, we built libraries for common development environment:<br/> <ul class=\"bullet\">   <li><a target=\"_blank\" rel=\"noopener noreferrer\" href=\"https://github.com/tripartie/webapi-jsclient\">Javascript</a></li> </ul> <br/> You're reading the documentation for version 1.0 of the Web API.<br/> Go to version <select id=\"version-switcher\"></select> 
 *
 * The version of the OpenAPI document: 1.0
 * Contact: support@tripartie.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using Newtonsoft.Json.Converters;

namespace TripartieWebAPI.CSharpClient.Client
{
    /// <summary>
    /// Formatter for 'date' openapi formats ss defined by full-date - RFC3339
    /// see https://github.com/OAI/OpenAPI-Specification/blob/master/versions/3.0.0.md#data-types
    /// </summary>
    public class OpenAPIDateConverter : IsoDateTimeConverter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAPIDateConverter" /> class.
        /// </summary>
        public OpenAPIDateConverter()
        {
            // full-date   = date-fullyear "-" date-month "-" date-mday
            DateTimeFormat = "yyyy-MM-dd";
        }
    }
}
