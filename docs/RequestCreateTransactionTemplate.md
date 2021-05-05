
# TripartieWebAPI.CSharpClient.Model.RequestCreateTransactionTemplate

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Title** | **string** | The title. | 
**Description** | **string** | The description. | [optional] 
**ExternalId** | **string** | The Transaction template&#39;s External ID. | [optional] 
**SellerExternalId** | **string** | The Seller&#39;s External ID. | [optional] 
**SellerTripartieId** | **string** | The Seller&#39;s Tripartie ID. | [optional] 
**SubTotal** | **int** | The price, in cents. | 
**ShippingCosts** | **int** | The shipping costs, in cents.&lt;br /&gt;If provided, the Seller will have to handle shipping by himself. &lt;code&gt;packageFormat&lt;/code&gt; and &lt;code&gt;shippingProviders&lt;/code&gt; will be ignored, and automatic shipping costs calculation and shipping label generation will be disabled.  | [optional] 
**PackageFormat** | [**RequestCreateTransactionTemplatePackageFormat**](RequestCreateTransactionTemplatePackageFormat.md) |  | [optional] 
**ShippingProviders** | **List&lt;string&gt;** | Allowed shipping providers.&lt;br /&gt;&lt;strong&gt;Required for automatic shipping costs and shipping label generation.&lt;/strong&gt; | [optional] 
**Currency** | **string** | The currency code (ISO 4217). | 
**Flow** | **string** | The desired flow (see &lt;a href&#x3D;\&quot;#tag/Flows\&quot;&gt;Flows&lt;/a&gt;). | 
**ProductCategory** | **string** | The product category (required for improved anti-fraud protection). | [optional] [default to ProductCategoryEnum.Other]
**AdUrl** | **string** | The original Ad&#39;s URL. | [optional] 
**AllowPriceChange** | **bool** | Allow price negociation? | [optional] [default to true]
**AllowInPerson** | **bool** | Allow hand-over? | [optional] [default to true]
**AllowDelivery** | **bool** | Allow delivery? | [optional] [default to true]
**Picture** | **string** | Ad picture, in &lt;strong&gt;base64 format&lt;/strong&gt;.&lt;br /&gt; Max initial file size: 2Mo.&lt;br /&gt; &lt;strong&gt;You MUST send only the binary code.&lt;/strong&gt; Do not send the first part that some converters add into the binary code which is &lt;code&gt;data:image/png;base64,&lt;/code&gt;.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

