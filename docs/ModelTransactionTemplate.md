
# TripartieWebAPI.CSharpClient.Model.ModelTransactionTemplate

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | The Transaction template&#39;s Tripartie ID. | [optional] 
**Permalink** | **string** | The template permalink. &lt;strong&gt;This is what you need for the Secured Payment button.&lt;/strong&gt; | [optional] 
**Title** | **string** | The title. | [optional] 
**Description** | **string** | The description. | [optional] 
**ExternalId** | **string** | The Transaction template&#39;s External ID. | [optional] 
**SellerExternalId** | **string** | The Seller&#39;s External ID. | [optional] 
**SellerTripartieId** | **string** | The Seller&#39;s Tripartie ID. | [optional] 
**SubTotal** | **int** | The price, in cents. | [optional] 
**Currency** | **string** | The currency code (ISO 4217). | [optional] 
**Flow** | **string** | The flow. | [optional] 
**BuyerFees** | **int** | The buyer&#39;s fees, in cents. | [optional] 
**ShippingCosts** | **int** | The shipping costs, in cents. | [optional] 
**BuyerTotal** | **int** | The buyer&#39;s total, in cents. | [optional] 
**SellerFees** | **int** | The seller&#39;s fees, in cents. | [optional] 
**SellerTotal** | **int** | The seller&#39;s total, in cents. | [optional] 
**AdUrl** | **string** | The original Ad&#39;s URL. | [optional] 
**AllowPriceChange** | **bool** | Allow price negociation? | [optional] 
**AllowInPerson** | **bool** | Allow hand-over? | [optional] [default to true]
**AllowDelivery** | **bool** | Allow delivery? | [optional] [default to true]
**HasPicture** | **bool** | Has a picture? | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

