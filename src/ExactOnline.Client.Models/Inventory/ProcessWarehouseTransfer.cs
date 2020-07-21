namespace ExactOnline.Client.Models.Inventory
{
    using System;

    [SupportedActionsSDK(true, false, false, false)]
    [DataServiceKey("TransferID")]
    public class ProcessWarehouseTransfer
    {
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }

        /// <summary>Transfer Date</summary>
        public DateTime? TransferDate { get; set; }

        /// <summary>Primary key</summary>
        public Guid TransferID { get; set; }
    }
}
