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
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = TripartieWebAPI.CSharpClient.Client.OpenAPIDateConverter;

namespace TripartieWebAPI.CSharpClient.Model
{
    /// <summary>
    /// ModelUser
    /// </summary>
    [DataContract]
    public partial class ModelUser :  IEquatable<ModelUser>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelUser" /> class.
        /// </summary>
        /// <param name="id">The User&#39;s Tripartie ID..</param>
        /// <param name="externalId">The User&#39;s External ID..</param>
        public ModelUser(int id = default(int), string externalId = default(string))
        {
            this.ExternalId = externalId;
            this.Id = id;
            this.ExternalId = externalId;
        }
        
        /// <summary>
        /// The User&#39;s Tripartie ID.
        /// </summary>
        /// <value>The User&#39;s Tripartie ID.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int Id { get; set; }

        /// <summary>
        /// The User&#39;s External ID.
        /// </summary>
        /// <value>The User&#39;s External ID.</value>
        [DataMember(Name="externalId", EmitDefaultValue=true)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModelUser {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModelUser);
        }

        /// <summary>
        /// Returns true if ModelUser instances are equal
        /// </summary>
        /// <param name="input">Instance of ModelUser to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModelUser input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ExternalId != null)
                    hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
