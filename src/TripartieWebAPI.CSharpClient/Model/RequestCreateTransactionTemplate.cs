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
    /// RequestCreateTransactionTemplate
    /// </summary>
    [DataContract]
    public partial class RequestCreateTransactionTemplate :  IEquatable<RequestCreateTransactionTemplate>, IValidatableObject
    {
        /// <summary>
        /// Defines ShippingProviders
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ShippingProvidersEnum
        {
            /// <summary>
            /// Enum Colissimo for value: colissimo
            /// </summary>
            [EnumMember(Value = "colissimo")]
            Colissimo = 1,

            /// <summary>
            /// Enum Tnt for value: tnt
            /// </summary>
            [EnumMember(Value = "tnt")]
            Tnt = 2,

            /// <summary>
            /// Enum Chronopost for value: chronopost
            /// </summary>
            [EnumMember(Value = "chronopost")]
            Chronopost = 3,

            /// <summary>
            /// Enum Dpd for value: dpd
            /// </summary>
            [EnumMember(Value = "dpd")]
            Dpd = 4,

            /// <summary>
            /// Enum Ups for value: ups
            /// </summary>
            [EnumMember(Value = "ups")]
            Ups = 5,

            /// <summary>
            /// Enum Dhl for value: dhl
            /// </summary>
            [EnumMember(Value = "dhl")]
            Dhl = 6,

            /// <summary>
            /// Enum Fedex for value: fedex
            /// </summary>
            [EnumMember(Value = "fedex")]
            Fedex = 7,

            /// <summary>
            /// Enum SwissPost for value: swiss-post
            /// </summary>
            [EnumMember(Value = "swiss-post")]
            SwissPost = 8

        }


        /// <summary>
        /// Allowed shipping providers.&lt;br /&gt;&lt;strong&gt;Required for automatic shipping costs and shipping label generation.&lt;/strong&gt;
        /// </summary>
        /// <value>Allowed shipping providers.&lt;br /&gt;&lt;strong&gt;Required for automatic shipping costs and shipping label generation.&lt;/strong&gt;</value>
        [DataMember(Name="shippingProviders", EmitDefaultValue=false)]
        public List<ShippingProvidersEnum> ShippingProviders { get; set; }
        /// <summary>
        /// The product category (required for improved anti-fraud protection).
        /// </summary>
        /// <value>The product category (required for improved anti-fraud protection).</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ProductCategoryEnum
        {
            /// <summary>
            /// Enum Automoto for value: auto_moto
            /// </summary>
            [EnumMember(Value = "auto_moto")]
            Automoto = 1,

            /// <summary>
            /// Enum Fashion for value: fashion
            /// </summary>
            [EnumMember(Value = "fashion")]
            Fashion = 2,

            /// <summary>
            /// Enum Housegarden for value: house_garden
            /// </summary>
            [EnumMember(Value = "house_garden")]
            Housegarden = 3,

            /// <summary>
            /// Enum Service for value: service
            /// </summary>
            [EnumMember(Value = "service")]
            Service = 4,

            /// <summary>
            /// Enum Sport for value: sport
            /// </summary>
            [EnumMember(Value = "sport")]
            Sport = 5,

            /// <summary>
            /// Enum Telecom for value: telecom
            /// </summary>
            [EnumMember(Value = "telecom")]
            Telecom = 6,

            /// <summary>
            /// Enum Other for value: other
            /// </summary>
            [EnumMember(Value = "other")]
            Other = 7

        }

        /// <summary>
        /// The product category (required for improved anti-fraud protection).
        /// </summary>
        /// <value>The product category (required for improved anti-fraud protection).</value>
        [DataMember(Name="productCategory", EmitDefaultValue=false)]
        public ProductCategoryEnum? ProductCategory { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestCreateTransactionTemplate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RequestCreateTransactionTemplate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestCreateTransactionTemplate" /> class.
        /// </summary>
        /// <param name="title">The title. (required).</param>
        /// <param name="description">The description..</param>
        /// <param name="externalId">The Transaction template&#39;s External ID..</param>
        /// <param name="sellerExternalId">The Seller&#39;s External ID..</param>
        /// <param name="sellerTripartieId">The Seller&#39;s Tripartie ID..</param>
        /// <param name="subTotal">The price, in cents. (required).</param>
        /// <param name="shippingCosts">The shipping costs, in cents.&lt;br /&gt;If provided, the Seller will have to handle shipping by himself. &lt;code&gt;packageFormat&lt;/code&gt; and &lt;code&gt;shippingProviders&lt;/code&gt; will be ignored, and automatic shipping costs calculation and shipping label generation will be disabled. .</param>
        /// <param name="packageFormat">packageFormat.</param>
        /// <param name="shippingProviders">Allowed shipping providers.&lt;br /&gt;&lt;strong&gt;Required for automatic shipping costs and shipping label generation.&lt;/strong&gt;.</param>
        /// <param name="currency">The currency code (ISO 4217). (required).</param>
        /// <param name="flow">The desired flow (see &lt;a href&#x3D;\&quot;#tag/Flows\&quot;&gt;Flows&lt;/a&gt;). (required).</param>
        /// <param name="productCategory">The product category (required for improved anti-fraud protection). (default to ProductCategoryEnum.Other).</param>
        /// <param name="adUrl">The original Ad&#39;s URL..</param>
        /// <param name="allowPriceChange">Allow price negociation? (default to true).</param>
        /// <param name="allowInPerson">Allow hand-over? (default to true).</param>
        /// <param name="allowDelivery">Allow delivery? (default to true).</param>
        /// <param name="picture">Ad picture, in &lt;strong&gt;base64 format&lt;/strong&gt;.&lt;br /&gt; Max initial file size: 2Mo.&lt;br /&gt; &lt;strong&gt;You MUST send only the binary code.&lt;/strong&gt; Do not send the first part that some converters add into the binary code which is &lt;code&gt;data:image/png;base64,&lt;/code&gt;. .</param>
        public RequestCreateTransactionTemplate(string title = default(string), string description = default(string), string externalId = default(string), string sellerExternalId = default(string), string sellerTripartieId = default(string), int subTotal = default(int), int shippingCosts = default(int), RequestCreateTransactionTemplatePackageFormat packageFormat = default(RequestCreateTransactionTemplatePackageFormat), List<ShippingProvidersEnum> shippingProviders = default(List<ShippingProvidersEnum>), string currency = default(string), string flow = default(string), ProductCategoryEnum? productCategory = ProductCategoryEnum.Other, string adUrl = default(string), bool allowPriceChange = true, bool allowInPerson = true, bool allowDelivery = true, string picture = default(string))
        {
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new InvalidDataException("title is a required property for RequestCreateTransactionTemplate and cannot be null");
            }
            else
            {
                this.Title = title;
            }
            
            // to ensure "subTotal" is required (not null)
            if (subTotal == null)
            {
                throw new InvalidDataException("subTotal is a required property for RequestCreateTransactionTemplate and cannot be null");
            }
            else
            {
                this.SubTotal = subTotal;
            }
            
            // to ensure "currency" is required (not null)
            if (currency == null)
            {
                throw new InvalidDataException("currency is a required property for RequestCreateTransactionTemplate and cannot be null");
            }
            else
            {
                this.Currency = currency;
            }
            
            // to ensure "flow" is required (not null)
            if (flow == null)
            {
                throw new InvalidDataException("flow is a required property for RequestCreateTransactionTemplate and cannot be null");
            }
            else
            {
                this.Flow = flow;
            }
            
            this.Description = description;
            this.ExternalId = externalId;
            this.SellerExternalId = sellerExternalId;
            this.SellerTripartieId = sellerTripartieId;
            this.ShippingCosts = shippingCosts;
            this.PackageFormat = packageFormat;
            this.ShippingProviders = shippingProviders;
            // use default value if no "productCategory" provided
            if (productCategory == null)
            {
                this.ProductCategory = ProductCategoryEnum.Other;
            }
            else
            {
                this.ProductCategory = productCategory;
            }
            this.AdUrl = adUrl;
            // use default value if no "allowPriceChange" provided
            if (allowPriceChange == null)
            {
                this.AllowPriceChange = true;
            }
            else
            {
                this.AllowPriceChange = allowPriceChange;
            }
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
            this.Picture = picture;
        }
        
        /// <summary>
        /// The title.
        /// </summary>
        /// <value>The title.</value>
        [DataMember(Name="title", EmitDefaultValue=true)]
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
        [DataMember(Name="externalId", EmitDefaultValue=false)]
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
        [DataMember(Name="subTotal", EmitDefaultValue=true)]
        public int SubTotal { get; set; }

        /// <summary>
        /// The shipping costs, in cents.&lt;br /&gt;If provided, the Seller will have to handle shipping by himself. &lt;code&gt;packageFormat&lt;/code&gt; and &lt;code&gt;shippingProviders&lt;/code&gt; will be ignored, and automatic shipping costs calculation and shipping label generation will be disabled. 
        /// </summary>
        /// <value>The shipping costs, in cents.&lt;br /&gt;If provided, the Seller will have to handle shipping by himself. &lt;code&gt;packageFormat&lt;/code&gt; and &lt;code&gt;shippingProviders&lt;/code&gt; will be ignored, and automatic shipping costs calculation and shipping label generation will be disabled. </value>
        [DataMember(Name="shippingCosts", EmitDefaultValue=false)]
        public int ShippingCosts { get; set; }

        /// <summary>
        /// Gets or Sets PackageFormat
        /// </summary>
        [DataMember(Name="packageFormat", EmitDefaultValue=false)]
        public RequestCreateTransactionTemplatePackageFormat PackageFormat { get; set; }


        /// <summary>
        /// The currency code (ISO 4217).
        /// </summary>
        /// <value>The currency code (ISO 4217).</value>
        [DataMember(Name="currency", EmitDefaultValue=true)]
        public string Currency { get; set; }

        /// <summary>
        /// The desired flow (see &lt;a href&#x3D;\&quot;#tag/Flows\&quot;&gt;Flows&lt;/a&gt;).
        /// </summary>
        /// <value>The desired flow (see &lt;a href&#x3D;\&quot;#tag/Flows\&quot;&gt;Flows&lt;/a&gt;).</value>
        [DataMember(Name="flow", EmitDefaultValue=true)]
        public string Flow { get; set; }


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
        /// Ad picture, in &lt;strong&gt;base64 format&lt;/strong&gt;.&lt;br /&gt; Max initial file size: 2Mo.&lt;br /&gt; &lt;strong&gt;You MUST send only the binary code.&lt;/strong&gt; Do not send the first part that some converters add into the binary code which is &lt;code&gt;data:image/png;base64,&lt;/code&gt;. 
        /// </summary>
        /// <value>Ad picture, in &lt;strong&gt;base64 format&lt;/strong&gt;.&lt;br /&gt; Max initial file size: 2Mo.&lt;br /&gt; &lt;strong&gt;You MUST send only the binary code.&lt;/strong&gt; Do not send the first part that some converters add into the binary code which is &lt;code&gt;data:image/png;base64,&lt;/code&gt;. </value>
        [DataMember(Name="picture", EmitDefaultValue=false)]
        public string Picture { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RequestCreateTransactionTemplate {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  SellerExternalId: ").Append(SellerExternalId).Append("\n");
            sb.Append("  SellerTripartieId: ").Append(SellerTripartieId).Append("\n");
            sb.Append("  SubTotal: ").Append(SubTotal).Append("\n");
            sb.Append("  ShippingCosts: ").Append(ShippingCosts).Append("\n");
            sb.Append("  PackageFormat: ").Append(PackageFormat).Append("\n");
            sb.Append("  ShippingProviders: ").Append(ShippingProviders).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Flow: ").Append(Flow).Append("\n");
            sb.Append("  ProductCategory: ").Append(ProductCategory).Append("\n");
            sb.Append("  AdUrl: ").Append(AdUrl).Append("\n");
            sb.Append("  AllowPriceChange: ").Append(AllowPriceChange).Append("\n");
            sb.Append("  AllowInPerson: ").Append(AllowInPerson).Append("\n");
            sb.Append("  AllowDelivery: ").Append(AllowDelivery).Append("\n");
            sb.Append("  Picture: ").Append(Picture).Append("\n");
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
            return this.Equals(input as RequestCreateTransactionTemplate);
        }

        /// <summary>
        /// Returns true if RequestCreateTransactionTemplate instances are equal
        /// </summary>
        /// <param name="input">Instance of RequestCreateTransactionTemplate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RequestCreateTransactionTemplate input)
        {
            if (input == null)
                return false;

            return 
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
                    this.ShippingCosts == input.ShippingCosts ||
                    (this.ShippingCosts != null &&
                    this.ShippingCosts.Equals(input.ShippingCosts))
                ) && 
                (
                    this.PackageFormat == input.PackageFormat ||
                    (this.PackageFormat != null &&
                    this.PackageFormat.Equals(input.PackageFormat))
                ) && 
                (
                    this.ShippingProviders == input.ShippingProviders ||
                    this.ShippingProviders != null &&
                    input.ShippingProviders != null &&
                    this.ShippingProviders.SequenceEqual(input.ShippingProviders)
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
                    this.ProductCategory == input.ProductCategory ||
                    (this.ProductCategory != null &&
                    this.ProductCategory.Equals(input.ProductCategory))
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
                    this.Picture == input.Picture ||
                    (this.Picture != null &&
                    this.Picture.Equals(input.Picture))
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
                if (this.ShippingCosts != null)
                    hashCode = hashCode * 59 + this.ShippingCosts.GetHashCode();
                if (this.PackageFormat != null)
                    hashCode = hashCode * 59 + this.PackageFormat.GetHashCode();
                if (this.ShippingProviders != null)
                    hashCode = hashCode * 59 + this.ShippingProviders.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.Flow != null)
                    hashCode = hashCode * 59 + this.Flow.GetHashCode();
                if (this.ProductCategory != null)
                    hashCode = hashCode * 59 + this.ProductCategory.GetHashCode();
                if (this.AdUrl != null)
                    hashCode = hashCode * 59 + this.AdUrl.GetHashCode();
                if (this.AllowPriceChange != null)
                    hashCode = hashCode * 59 + this.AllowPriceChange.GetHashCode();
                if (this.AllowInPerson != null)
                    hashCode = hashCode * 59 + this.AllowInPerson.GetHashCode();
                if (this.AllowDelivery != null)
                    hashCode = hashCode * 59 + this.AllowDelivery.GetHashCode();
                if (this.Picture != null)
                    hashCode = hashCode * 59 + this.Picture.GetHashCode();
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
