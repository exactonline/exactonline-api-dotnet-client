using System.Collections.Generic;
using System;

namespace ExactOnline.Client.Models.VAT
{
    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class VATCode
    {
        /// <summary>Tax account</summary>
        public Guid? Account { get; set; }
        /// <summary>Code of Account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountCode { get; set; }
        /// <summary>Name of Account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountName { get; set; }
        /// <summary>Indicates how to calculate the tax. 0 = based on the gross amount, 1 = based on the gross amount + another tax</summary>
        public byte? CalculationBasis { get; set; }
        /// <summary>Indicates if transactions using the VAT code are transactions of the domestic VAT charging regulation (such as those for subcontractors) or transactions that are registered within the EU. If Charged=1 and linked to a purchase invoice, both a line for the VAT to pay and a line for the VAT to claim are being created</summary>
        public bool? Charged { get; set; }
        /// <summary>VAT code</summary>
        public string Code { get; set; }
        /// <summary>Obsolete</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string Country { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        /// <summary>Description of the VAT code</summary>
        public string Description { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>Used in all legislations except France. Indicates if and how transactions using the VAT code appear on the ICT return (EU sales list). L = Listing goods, N = No listing, S = Listing services, T = Triangulation</summary>
        public string EUSalesListing { get; set; }
        /// <summary>Indicates the purchase discount GL account linked to the VAT codes for German legislation</summary>
        public Guid? GLDiscountPurchase { get; set; }
        /// <summary>Code of GLDiscountPurchase</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLDiscountPurchaseCode { get; set; }
        /// <summary>Description of GLDiscountPurchase</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLDiscountPurchaseDescription { get; set; }
        /// <summary>Indicates the sales discount GL account linked to the VAT codes for German legislation</summary>
        public Guid? GLDiscountSales { get; set; }
        /// <summary>Code of GLDiscountSales</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLDiscountSalesCode { get; set; }
        /// <summary>Description of GLDiscountSales</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLDiscountSalesDescription { get; set; }
        /// <summary>G/L account that is used to book the VAT to claim. If you enter purchases with a VAT code, the VAT amount to be claimed is entered to this VAT account. Must be of type VAT</summary>
        public Guid? GLToClaim { get; set; }
        /// <summary>Code of GLToClaim</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLToClaimCode { get; set; }
        /// <summary>Description of GLToClaim</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLToClaimDescription { get; set; }
        /// <summary>G/L account that is used to book the VAT to pay. If you enter sales with a VAT code, the VAT amount to be paid is entered to this VAT account. Must be of type VAT</summary>
        public Guid? GLToPay { get; set; }
        /// <summary>Code of GLToPay</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLToPayCode { get; set; }
        /// <summary>Description of GLToPay</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLToPayDescription { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Used in all legislations except France. Indicates if intrastat is used</summary>
        public bool? IntraStat { get; set; }
        /// <summary>Used in France legislation only. Indicates if and how transactions using the VAT code appear on the DEB/DES return. L = Goods, N = Empty, S = Services</summary>
        public string IntrastatType { get; set; }
        /// <summary>Indicates if the VAT code may still be used</summary>
        public bool? IsBlocked { get; set; }
        /// <summary>Legal description for VAT code to print in the total block of the invoice</summary>
        public string LegalText { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>User name of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        /// <summary>Percentage of the VAT code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? Percentage { get; set; }
        /// <summary>Indicates what type of Taxcode it is: can be VAT, IncomeTax</summary>
        public Int16? TaxReturnType { get; set; }
        /// <summary>Indicates how the VAT amount should be calculated in relation to the invoice amount. B = VAT 0% (Only base amount), E = Excluding, I = Including, N = No VAT</summary>
        public string Type { get; set; }
        /// <summary>Field in VAT code maintenance to calculate different VATs depending on the selected document type. P = purchase invoice, F = freelance invoice, E = expense voucher. The field is valid for witholding tax type</summary>
        public string VatDocType { get; set; }
        /// <summary>The VAT margin scheme is used for the trade of secondhand goods which are purchased without VAT (for example when a company buys a secondhand good from a private person). In the VAT margin scheme, the VAT is not calculated based on the sales price. Instead of that, the VAT is calculated based on the margin (gross sales price minus the gross purchase price)</summary>
        public byte VatMargin { get; set; }
        /// <summary>Partial ratio explains which part of the VAT the company has to pay. Used in some branches where the sellers have a bad reputation, so the buyers have to take over the VAT-liability</summary>
        public Int16? VATPartialRatio { get; set; }
        /// <summary>VAT percentages. You can have several VAT percentages, with start and end dates</summary>
        public IEnumerable<VAT.VatPercentage> VATPercentages { get; set; }
        /// <summary>Indicates the type of transactions for which the VAT code may be used. B = Both, P = Purchase, S = Sales</summary>
        public string VATTransactionType { get; set; }
    }
}
