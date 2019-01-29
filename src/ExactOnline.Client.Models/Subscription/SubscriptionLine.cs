namespace ExactOnline.Client.Models.Subscription
{
    using System;

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class SubscriptionLine
    {
        /// <summary>Amount in the default currency of the company</summary>
        public double AmountDC { get; set; }
        /// <summary>Amount in the currency of the transaction</summary>
        public double AmountFC { get; set; }
        /// <summary>Cost center</summary>
        public string Costcenter { get; set; }
        /// <summary>Cost unit</summary>
        public string Costunit { get; set; }
        /// <summary>Description</summary>
        public string Description { get; set; }
        /// <summary>Discount percentage</summary>
        public double? Discount { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        /// <summary>Entry ID</summary>
        public Guid EntryID { get; set; }
        /// <summary>From date</summary>
        public DateTime FromDate { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Reference to Item</summary>
        public Guid Item { get; set; }
        /// <summary>Description of Item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }
        /// <summary>Line number</summary>
        public Int32 LineNumber { get; set; }
        /// <summary>Reference to LineType</summary>
        public Int16? LineType { get; set; }
        /// <summary>Description of LineType</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string LineTypeDescription { get; set; }
        /// <summary>Net price in the currency of the transaction</summary>
        public double NetPrice { get; set; }
        /// <summary>Remarks</summary>
        public string Notes { get; set; }
        /// <summary>Quantity</summary>
        public double Quantity { get; set; }
        /// <summary>To date</summary>
        public DateTime? ToDate { get; set; }
        /// <summary>Unit code</summary>
        public string UnitCode { get; set; }
        /// <summary>Description of Unit</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string UnitDescription { get; set; }
        /// <summary>Unit price in the currency of the transaction (price * unit factor)</summary>
        public double UnitPrice { get; set; }
        /// <summary>Vat Amount in the currency of the transaction</summary>
        public double? VATAmountFC { get; set; }
        /// <summary>VATCode</summary>
        public string VATCode { get; set; }
        /// <summary>Description of VATCode</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string VATCodeDescription { get; set; }
    }
}