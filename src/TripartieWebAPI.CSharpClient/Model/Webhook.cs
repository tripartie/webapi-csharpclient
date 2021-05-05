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
    /// Webhook
    /// </summary>
    [DataContract]
    public partial class Webhook :  IEquatable<Webhook>, IValidatableObject
    {
        /// <summary>
        /// The webhook type.
        /// </summary>
        /// <value>The webhook type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EventTypeEnum
        {
            /// <summary>
            /// Enum Propositionsent for value: proposition_sent
            /// </summary>
            [EnumMember(Value = "proposition_sent")]
            Propositionsent = 1,

            /// <summary>
            /// Enum Propositionaccepted for value: proposition_accepted
            /// </summary>
            [EnumMember(Value = "proposition_accepted")]
            Propositionaccepted = 2,

            /// <summary>
            /// Enum Propositionrejected for value: proposition_rejected
            /// </summary>
            [EnumMember(Value = "proposition_rejected")]
            Propositionrejected = 3,

            /// <summary>
            /// Enum Transactioncompleted for value: transaction_completed
            /// </summary>
            [EnumMember(Value = "transaction_completed")]
            Transactioncompleted = 4,

            /// <summary>
            /// Enum Transactioncanceled for value: transaction_canceled
            /// </summary>
            [EnumMember(Value = "transaction_canceled")]
            Transactioncanceled = 5

        }

        /// <summary>
        /// The webhook type.
        /// </summary>
        /// <value>The webhook type.</value>
        [DataMember(Name="eventType", EmitDefaultValue=false)]
        public EventTypeEnum? EventType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Webhook" /> class.
        /// </summary>
        /// <param name="uuid">The Webhook UUID..</param>
        /// <param name="eventType">The webhook type..</param>
        /// <param name="transactionTemplateExternalId">The Transaction template&#39;s External ID..</param>
        /// <param name="transactionTemplateTripartieId">The Transaction template&#39;s Tripartie ID..</param>
        /// <param name="buyerExternalId">The Buyer&#39;s External ID..</param>
        /// <param name="buyerTripartieId">The Buyer&#39;s Tripartie ID..</param>
        /// <param name="eventTimestamp">The event timestamp..</param>
        public Webhook(string uuid = default(string), EventTypeEnum? eventType = default(EventTypeEnum?), string transactionTemplateExternalId = default(string), int transactionTemplateTripartieId = default(int), string buyerExternalId = default(string), int buyerTripartieId = default(int), int eventTimestamp = default(int))
        {
            this.Uuid = uuid;
            this.EventType = eventType;
            this.TransactionTemplateExternalId = transactionTemplateExternalId;
            this.TransactionTemplateTripartieId = transactionTemplateTripartieId;
            this.BuyerExternalId = buyerExternalId;
            this.BuyerTripartieId = buyerTripartieId;
            this.EventTimestamp = eventTimestamp;
        }
        
        /// <summary>
        /// The Webhook UUID.
        /// </summary>
        /// <value>The Webhook UUID.</value>
        [DataMember(Name="uuid", EmitDefaultValue=false)]
        public string Uuid { get; set; }


        /// <summary>
        /// The Transaction template&#39;s External ID.
        /// </summary>
        /// <value>The Transaction template&#39;s External ID.</value>
        [DataMember(Name="transactionTemplateExternalId", EmitDefaultValue=false)]
        public string TransactionTemplateExternalId { get; set; }

        /// <summary>
        /// The Transaction template&#39;s Tripartie ID.
        /// </summary>
        /// <value>The Transaction template&#39;s Tripartie ID.</value>
        [DataMember(Name="transactionTemplateTripartieId", EmitDefaultValue=false)]
        public int TransactionTemplateTripartieId { get; set; }

        /// <summary>
        /// The Buyer&#39;s External ID.
        /// </summary>
        /// <value>The Buyer&#39;s External ID.</value>
        [DataMember(Name="buyerExternalId", EmitDefaultValue=false)]
        public string BuyerExternalId { get; set; }

        /// <summary>
        /// The Buyer&#39;s Tripartie ID.
        /// </summary>
        /// <value>The Buyer&#39;s Tripartie ID.</value>
        [DataMember(Name="buyerTripartieId", EmitDefaultValue=false)]
        public int BuyerTripartieId { get; set; }

        /// <summary>
        /// The event timestamp.
        /// </summary>
        /// <value>The event timestamp.</value>
        [DataMember(Name="eventTimestamp", EmitDefaultValue=false)]
        public int EventTimestamp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Webhook {\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  TransactionTemplateExternalId: ").Append(TransactionTemplateExternalId).Append("\n");
            sb.Append("  TransactionTemplateTripartieId: ").Append(TransactionTemplateTripartieId).Append("\n");
            sb.Append("  BuyerExternalId: ").Append(BuyerExternalId).Append("\n");
            sb.Append("  BuyerTripartieId: ").Append(BuyerTripartieId).Append("\n");
            sb.Append("  EventTimestamp: ").Append(EventTimestamp).Append("\n");
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
            return this.Equals(input as Webhook);
        }

        /// <summary>
        /// Returns true if Webhook instances are equal
        /// </summary>
        /// <param name="input">Instance of Webhook to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Webhook input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Uuid == input.Uuid ||
                    (this.Uuid != null &&
                    this.Uuid.Equals(input.Uuid))
                ) && 
                (
                    this.EventType == input.EventType ||
                    (this.EventType != null &&
                    this.EventType.Equals(input.EventType))
                ) && 
                (
                    this.TransactionTemplateExternalId == input.TransactionTemplateExternalId ||
                    (this.TransactionTemplateExternalId != null &&
                    this.TransactionTemplateExternalId.Equals(input.TransactionTemplateExternalId))
                ) && 
                (
                    this.TransactionTemplateTripartieId == input.TransactionTemplateTripartieId ||
                    (this.TransactionTemplateTripartieId != null &&
                    this.TransactionTemplateTripartieId.Equals(input.TransactionTemplateTripartieId))
                ) && 
                (
                    this.BuyerExternalId == input.BuyerExternalId ||
                    (this.BuyerExternalId != null &&
                    this.BuyerExternalId.Equals(input.BuyerExternalId))
                ) && 
                (
                    this.BuyerTripartieId == input.BuyerTripartieId ||
                    (this.BuyerTripartieId != null &&
                    this.BuyerTripartieId.Equals(input.BuyerTripartieId))
                ) && 
                (
                    this.EventTimestamp == input.EventTimestamp ||
                    (this.EventTimestamp != null &&
                    this.EventTimestamp.Equals(input.EventTimestamp))
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
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                if (this.EventType != null)
                    hashCode = hashCode * 59 + this.EventType.GetHashCode();
                if (this.TransactionTemplateExternalId != null)
                    hashCode = hashCode * 59 + this.TransactionTemplateExternalId.GetHashCode();
                if (this.TransactionTemplateTripartieId != null)
                    hashCode = hashCode * 59 + this.TransactionTemplateTripartieId.GetHashCode();
                if (this.BuyerExternalId != null)
                    hashCode = hashCode * 59 + this.BuyerExternalId.GetHashCode();
                if (this.BuyerTripartieId != null)
                    hashCode = hashCode * 59 + this.BuyerTripartieId.GetHashCode();
                if (this.EventTimestamp != null)
                    hashCode = hashCode * 59 + this.EventTimestamp.GetHashCode();
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