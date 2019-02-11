namespace ExactOnline.Client.Models.Project
{
    using System;

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class TimeAndBillingItemDetail
    {
        /// <summary>Item code</summary>
        public string Code { get; set; }
        /// <summary>Description of the item code</summary>
        public string Description { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Indicates if fractions are allowed for quantities of this item</summary>
        public bool IsFractionAllowedItem { get; set; }
        /// <summary>Indicates if the item can be sold</summary>
        public bool IsSalesItem { get; set; }
        /// <summary>Sales currency code</summary>
        public string SalesCurrency { get; set; }
        /// <summary>Sales price</summary>
        public double SalesPrice { get; set; }
    }
}