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
    /// ModelTransactionTemplate
    /// </summary>
    [DataContract]
    public partial class ModelTransactionTemplate :  IEquatable<ModelTransactionTemplate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelTransactionTemplate" /> class.
        /// </summary>
        /// <param name="id">The Transaction template&#39;s Tripartie ID..</param>
        /// <param name="permalink">The template permalink. &lt;strong&gt;This is what you need for the Secured Payment button.&lt;/strong&gt;.</param>
        /// <param name="title">The title..</param>
        /// <param name="description">The description..</param>
        /// <param name="externalId">The Transaction template&#39;s External ID..</param>
        /// <param name="sellerExternalId">The Seller&#39;s External ID..</param>
        /// <param name="sellerTripartieId">The Seller&#39;s Tripartie ID..</param>
        /// <param name="subTotal">The price, in cents..</param>
        /// <param name="currency">The currency code (ISO 4217)..</param>
        /// <param name="flow">The flow..</param>
        /// <param name="buyerFees">The buyer&#39;s fees, in cents..</param>
        /// <param name="shippingCosts">The shipping costs, in cents..</param>
        /// <param name="buyerTotal">The buyer&#39;s total, in cents..</param>
        /// <param name="sellerFees">The seller&#39;s fees, in cents..</param>
        /// <param name="sellerTotal">The seller&#39;s total, in cents..</param>
        /// <param name="adUrl">The original Ad&#39;s URL..</param>
        /// <param name="allowPriceChange">Allow price negociation?.</param>
        /// <param name="allowInPerson">Allow hand-over? (default to true).</param>
        /// <param name="allowDelivery">Allow delivery? (default to true).</param>
        /// <param name="hasPicture">Has a picture?.</param>
        public ModelTransactionTemplate(int id = default(int), string permalink = default(string), string title = default(string), string description = default(string), string externalId = default(string), string sellerExternalId = default(string), string sellerTripartieId = default(string), int subTotal = default(int), string currency = default(string), string flow = default(string), int buyerFees = default(int), int shippingCosts = default(int), int buyerTotal = default(int), int sellerFees = default(int), int sellerTotal = default(int), string adUrl = default(string), bool allowPriceChange = default(bool), bool allowInPerson = true, bool allowDelivery = true, bool hasPicture = default(bool))
        {
            this.ExternalId = externalId;
            this.Id = id;
            this.Permalink = permalink;
            this.Title = title;
            this.Description = description;
            this.ExternalId = externalId;
            this.SellerExternalId = sellerExternalId;
            this.SellerTripartieId = sellerTripartieId;
            this.SubTotal = subTotal;
            this.Currency = currency;
            this.Flow = flow;
            this.BuyerFees = buyerFees;
            this.ShippingCosts = shippingCosts;
            this.BuyerTotal = buyerTotal;
            this.SellerFees = sellerFees;
            this.SellerTotal = sellerTotal;
            this.AdUrl = adUrl;
            this.AllowPriceChange = allowPriceChange;
            // use default value if no "allowInPerson" provided
            if (allowInPerson == null)
            {
                this.AllowInPerson = true;
            }
            else
            {
                this.AllowInPerson = allowInPerson;
            }
            // use default value if no "allowDelivery" provided
            if (allowDelivery == null)
            {
                this.AllowDelivery = true;
            }
            else
            {
                this.AllowDelivery = allowDelivery;
            }
            this.HasPicture = hasPicture;
        }
        
        /// <summary>
        /// The Transaction template&#39;s Tripartie ID.
        /// </summary>
        /// <value>The Transaction template&#39;s Tripartie ID.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int Id { get; set; }

        /// <summary>
        /// The template permalink. &lt;strong&gt;This is what you need for the Secured Payment button.&lt;/strong&gt;
        /// </summary>
        /// <value>The template permalink. &lt;strong&gt;This is what you need for the Secured Payment button.&lt;/strong&gt;</value>
        [DataMember(Name="permalink", EmitDefaultValue=false)]
        public string Permalink { get; set; }

        /// <summary>
        /// The title.
        /// </summary>
        /// <value>The title.</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// The description.
        /// </summary>
        /// <value>The description.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// The Transaction template&#39;s External ID.
        /// </summary>
        /// <value>The Transaction template&#39;s External ID.</value>
        [DataMember(Name="externalId", EmitDefaultValue=true)]
        public string ExternalId { get; set; }

        /// <summary>
        /// The Seller&#39;s External ID.
        /// </summary>
        /// <value>The Seller&#39;s External ID.</value>
        [DataMember(Name="sellerExternalId", EmitDefaultValue=false)]
        public string SellerExternalId { get; set; }

        /// <summary>
        /// The Seller&#39;s Tripartie ID.
        /// </summary>
        /// <value>The Seller&#39;s Tripartie ID.</value>
        [DataMember(Name="sellerTripartieId", EmitDefaultValue=false)]
        public string SellerTripartieId { get; set; }

        /// <summary>
        /// The price, in cents.
        /// </summary>
        /// <value>The price, in cents.</value>
        [DataMember(Name="subTotal", EmitDefaultValue=false)]
        public int SubTotal { get; set; }

        /// <summary>
        /// The currency code (ISO 4217).
        /// </summary>
        /// <value>The currency code (ISO 4217).</value>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }

        /// <summary>
        /// The flow.
        /// </summary>
        /// <value>The flow.</value>
        [DataMember(Name="flow", EmitDefaultValue=false)]
        public string Flow { get; set; }

        /// <summary>
        /// The buyer&#39;s fees, in cents.
        /// </summary>
        /// <value>The buyer&#39;s fees, in cents.</value>
        [DataMember(Name="buyerFees", EmitDefaultValue=false)]
        public int BuyerFees { get; set; }

        /// <summary>
        /// The shipping costs, in cents.
        /// </summary>
        /// <value>The shipping costs, in cents.</value>
        [DataMember(Name="shippingCosts", EmitDefaultValue=false)]
        public int ShippingCosts { get; set; }

        /// <summary>
        /// The buyer&#39;s total, in cents.
        /// </summary>
        /// <value>The buyer&#39;s total, in cents.</value>
        [DataMember(Name="buyerTotal", EmitDefaultValue=false)]
        public int BuyerTotal { get; set; }

        /// <summary>
        /// The seller&#39;s fees, in cents.
        /// </summary>
        /// <value>The seller&#39;s fees, in cents.</value>
        [DataMember(Name="sellerFees", EmitDefaultValue=false)]
        public int SellerFees { get; set; }

        /// <summary>
        /// The seller&#39;s total, in cents.
        /// </summary>
        /// <value>The seller&#39;s total, in cents.</value>
        [DataMember(Name="sellerTotal", EmitDefaultValue=false)]
        public int SellerTotal { get; set; }

        /// <summary>
        /// The original Ad&#39;s URL.
        /// </summary>
        /// <value>The original Ad&#39;s URL.</value>
        [DataMember(Name="adUrl", EmitDefaultValue=false)]
        public string AdUrl { get; set; }

        /// <summary>
        /// Allow price negociation?
        /// </summary>
        /// <value>Allow price negociation?</value>
        [DataMember(Name="allowPriceChange", EmitDefaultValue=false)]
        public bool AllowPriceChange { get; set; }

        /// <summary>
        /// Allow hand-over?
        /// </summary>
        /// <value>Allow hand-over?</value>
        [DataMember(Name="allowInPerson", EmitDefaultValue=false)]
        public bool AllowInPerson { get; set; }

        /// <summary>
        /// Allow delivery?
        /// </summary>
        /// <value>Allow delivery?</value>
        [DataMember(Name="allowDelivery", EmitDefaultValue=false)]
        public bool AllowDelivery { get; set; }

        /// <summary>
        /// Has a picture?
        /// </summary>
        /// <value>Has a picture?</value>
        [DataMember(Name="hasPicture", EmitDefaultValue=false)]
        public bool HasPicture { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModelTransactionTemplate {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Permalink: ").Append(Permalink).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  SellerExternalId: ").Append(SellerExternalId).Append("\n");
            sb.Append("  SellerTripartieId: ").Append(SellerTripartieId).Append("\n");
            sb.Append("  SubTotal: ").Append(SubTotal).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Flow: ").Append(Flow).Append("\n");
            sb.Append("  BuyerFees: ").Append(BuyerFees).Append("\n");
            sb.Append("  ShippingCosts: ").Append(ShippingCosts).Append("\n");
            sb.Append("  BuyerTotal: ").Append(BuyerTotal).Append("\n");
            sb.Append("  SellerFees: ").Append(SellerFees).Append("\n");
            sb.Append("  SellerTotal: ").Append(SellerTotal).Append("\n");
            sb.Append("  AdUrl: ").Append(AdUrl).Append("\n");
            sb.Append("  AllowPriceChange: ").Append(AllowPriceChange).Append("\n");
            sb.Append("  AllowInPerson: ").Append(AllowInPerson).Append("\n");
            sb.Append("  AllowDelivery: ").Append(AllowDelivery).Append("\n");
            sb.Append("  HasPicture: ").Append(HasPicture).Append("\n");
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
            return this.Equals(input as ModelTransactionTemplate);
        }

        /// <summary>
        /// Returns true if ModelTransactionTemplate instances are equal
        /// </summary>
        /// <param name="input">Instance of ModelTransactionTemplate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModelTransactionTemplate input)
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
                    this.Permalink == input.Permalink ||
                    (this.Permalink != null &&
                    this.Permalink.Equals(input.Permalink))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && 
                (
                    this.SellerExternalId == input.SellerExternalId ||
                    (this.SellerExternalId != null &&
                    this.SellerExternalId.Equals(input.SellerExternalId))
                ) && 
                (
                    this.SellerTripartieId == input.SellerTripartieId ||
                    (this.SellerTripartieId != null &&
                    this.SellerTripartieId.Equals(input.SellerTripartieId))
                ) && 
                (
                    this.SubTotal == input.SubTotal ||
                    (this.SubTotal != null &&
                    this.SubTotal.Equals(input.SubTotal))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.Flow == input.Flow ||
                    (this.Flow != null &&
                    this.Flow.Equals(input.Flow))
                ) && 
                (
                    this.BuyerFees == input.BuyerFees ||
                    (this.BuyerFees != null &&
                    this.BuyerFees.Equals(input.BuyerFees))
                ) && 
                (
                    this.ShippingCosts == input.ShippingCosts ||
                    (this.ShippingCosts != null &&
                    this.ShippingCosts.Equals(input.ShippingCosts))
                ) && 
                (
                    this.BuyerTotal == input.BuyerTotal ||
                    (this.BuyerTotal != null &&
                    this.BuyerTotal.Equals(input.BuyerTotal))
                ) && 
                (
                    this.SellerFees == input.SellerFees ||
                    (this.SellerFees != null &&
                    this.SellerFees.Equals(input.SellerFees))
                ) && 
                (
                    this.SellerTotal == input.SellerTotal ||
                    (this.SellerTotal != null &&
                    this.SellerTotal.Equals(input.SellerTotal))
                ) && 
                (
                    this.AdUrl == input.AdUrl ||
                    (this.AdUrl != null &&
                    this.AdUrl.Equals(input.AdUrl))
                ) && 
                (
                    this.AllowPriceChange == input.AllowPriceChange ||
                    (this.AllowPriceChange != null &&
                    this.AllowPriceChange.Equals(input.AllowPriceChange))
                ) && 
                (
                    this.AllowInPerson == input.AllowInPerson ||
                    (this.AllowInPerson != null &&
                    this.AllowInPerson.Equals(input.AllowInPerson))
                ) && 
                (
                    this.AllowDelivery == input.AllowDelivery ||
                    (this.AllowDelivery != null &&
                    this.AllowDelivery.Equals(input.AllowDelivery))
                ) && 
                (
                    this.HasPicture == input.HasPicture ||
                    (this.HasPicture != null &&
                    this.HasPicture.Equals(input.HasPicture))
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
                if (this.Permalink != null)
                    hashCode = hashCode * 59 + this.Permalink.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ExternalId != null)
                    hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.SellerExternalId != null)
                    hashCode = hashCode * 59 + this.SellerExternalId.GetHashCode();
                if (this.SellerTripartieId != null)
                    hashCode = hashCode * 59 + this.SellerTripartieId.GetHashCode();
                if (this.SubTotal != null)
                    hashCode = hashCode * 59 + this.SubTotal.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.Flow != null)
                    hashCode = hashCode * 59 + this.Flow.GetHashCode();
                if (this.BuyerFees != null)
                    hashCode = hashCode * 59 + this.BuyerFees.GetHashCode();
                if (this.ShippingCosts != null)
                    hashCode = hashCode * 59 + this.ShippingCosts.GetHashCode();
                if (this.BuyerTotal != null)
                    hashCode = hashCode * 59 + this.BuyerTotal.GetHashCode();
                if (this.SellerFees != null)
                    hashCode = hashCode * 59 + this.SellerFees.GetHashCode();
                if (this.SellerTotal != null)
                    hashCode = hashCode * 59 + this.SellerTotal.GetHashCode();
                if (this.AdUrl != null)
                    hashCode = hashCode * 59 + this.AdUrl.GetHashCode();
                if (this.AllowPriceChange != null)
                    hashCode = hashCode * 59 + this.AllowPriceChange.GetHashCode();
                if (this.AllowInPerson != null)
                    hashCode = hashCode * 59 + this.AllowInPerson.GetHashCode();
                if (this.AllowDelivery != null)
                    hashCode = hashCode * 59 + this.AllowDelivery.GetHashCode();
                if (this.HasPicture != null)
                    hashCode = hashCode * 59 + this.HasPicture.GetHashCode();
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
