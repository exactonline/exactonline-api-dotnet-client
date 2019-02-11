namespace ExactOnline.Client.Models.Inventory
{
    using System;

    [SupportedActionsSDK(true, false, false, false)]
    [DataServiceKey("StockCountID")]
    public class ProcessStockCount
    {
        /// <summary>Division code</summary>
        public Int32? Division { get; set; }
        /// <summary>Contains the error message if an error occurred during the processing of the stock count.</summary>
        public String ErrorMessage { get; set; }
        /// <summary>Primary key</summary>
        public Guid StockCountID { get; set; }
        /// <summary>Contains information if the stock count was successfully processed.</summary>
        public String SuccessMessage { get; set; }
    }
}