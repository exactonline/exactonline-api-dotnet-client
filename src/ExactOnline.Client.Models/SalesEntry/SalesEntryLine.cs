namespace ExactOnline.Client.Models.SalesEntry
{
    using System;

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class SalesEntryLine
    {
        /// <summary>Amount in the default currency of the company. For almost all lines this can be calculated like: AmountDC = AmountFC * RateFC.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Double AmountDC { get; set; }
        /// <summary>For normal lines it&apos;s the amount excluding VAT</summary>
        public Double AmountFC { get; set; }
        /// <summary>Reference to Asset</summary>
        public Guid? Asset { get; set; }
        /// <summary>Description of Asset</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String AssetDescription { get; set; }
        /// <summary>Reference to Cost center</summary>
        public String CostCenter { get; set; }
        /// <summary>Description of CostCenter</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String CostCenterDescription { get; set; }
        /// <summary>Reference to Cost unit</summary>
        public String CostUnit { get; set; }
        /// <summary>Description of CostUnit</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String CostUnitDescription { get; set; }
        /// <summary>Description. Can be different for header and lines</summary>
        public String Description { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        /// <summary>The unique ID of the entry. Via this ID all transaction lines of a single entry can be retrieved</summary>
        public Guid EntryID { get; set; }
        /// <summary>Extra duty amount in the currency of the transaction. Both extra duty amount and VAT amount need to be specified in order to differ this property from automatically calculated.</summary>
        public Double? ExtraDutyAmountFC { get; set; }
        /// <summary>Extra duty percentage for the item</summary>
        public Double? ExtraDutyPercentage { get; set; }
        /// <summary>From date for deferred revenue</summary>
        public DateTime? From { get; set; }
        /// <summary>The GL Account of the invoice line. This field is generated based on the revenue account of the item (or the related item group). G/L Account is also used to determine whether the costcenter / costunit is mandatory</summary>
        public Guid? GLAccount { get; set; }
        /// <summary>Code of GLAccount</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String GLAccountCode { get; set; }
        /// <summary>Description of GLAccount</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String GLAccountDescription { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>IntraStat area</summary>
        public String IntraStatArea { get; set; }
        /// <summary>IntraStatCountry</summary>
        public String IntraStatCountry { get; set; }
        /// <summary>IntraStat delivery term</summary>
        public String IntraStatDeliveryTerm { get; set; }
        /// <summary>IntraStat transaction a</summary>
        public String IntraStatTransactionA { get; set; }
        /// <summary>IntraStat transport method</summary>
        public String IntraStatTransportMethod { get; set; }
        /// <summary>Indicates the sequence of the lines within one entry</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? LineNumber { get; set; }
        /// <summary>Extra notes</summary>
        public String Notes { get; set; }
        /// <summary>The project to which the sales transaction line is linked. The project can be different per line. Sometimes also the project in the header is filled although this is not really used</summary>
        public Guid? Project { get; set; }
        /// <summary>Description of Project</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ProjectDescription { get; set; }
        /// <summary>The number of items sold in default units. The quantity shown in the entry screen is Quantity * UnitFactor</summary>
        public Double? Quantity { get; set; }
        /// <summary>Serial number</summary>
        public String SerialNumber { get; set; }
        /// <summary>Statistical NetWeight</summary>
        public Double? StatisticalNetWeight { get; set; }
        /// <summary>Statistical Number</summary>
        public String StatisticalNumber { get; set; }
        /// <summary>Statistical Quantity</summary>
        public Double? StatisticalQuantity { get; set; }
        /// <summary>Statistical Value</summary>
        public Double? StatisticalValue { get; set; }
        /// <summary>When generating invoices from subscriptions, this field records the link between invoice lines and subscription lines</summary>
        public Guid? Subscription { get; set; }
        /// <summary>Description of Subscription</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String SubscriptionDescription { get; set; }
        /// <summary>Obsolete</summary>
        public Guid? TaxSchedule { get; set; }
        /// <summary>To date for deferred revenue</summary>
        public DateTime? To { get; set; }
        /// <summary>Reference to TrackingNumber</summary>
        public Guid? TrackingNumber { get; set; }
        /// <summary>Description of TrackingNumber</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String TrackingNumberDescription { get; set; }
        /// <summary>Type: 20 = Sales entry, 21 = Sales credit note</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Type { get; set; }
        /// <summary>VAT amount in the default currency of the company</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Double? VATAmountDC { get; set; }
        /// <summary>VAT amount in the currency of the transaction. Use this property to specify a VAT amount that differs from the VAT amount that is automatically calculated. However if the transaction uses extra duty, extra duty amount also needs to be specified. </summary>
        public Double? VATAmountFC { get; set; }
        /// <summary>The VAT base amount in the default currency of the company. This is calculated based on the VATBaseAmountFC</summary>
        public Double? VATBaseAmountDC { get; set; }
        /// <summary>The VAT base amount in invoice currency. This is calculated with the use of VAT codes. It&apos;s an internal value</summary>
        public Double? VATBaseAmountFC { get; set; }
        /// <summary>The VAT code used when the invoice was registered</summary>
        public String VATCode { get; set; }
        /// <summary>Description of VATCode</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String VATCodeDescription { get; set; }
        /// <summary>The VAT percentage of the VAT code. This is the percentage at the moment the invoice is created. It&apos;s also used by the default calculation of VAT amounts and VAT base amounts</summary>
        public Double? VATPercentage { get; set; }
    }
}