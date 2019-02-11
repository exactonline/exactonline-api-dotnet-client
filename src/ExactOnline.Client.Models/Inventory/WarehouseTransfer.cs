using System;
using System.Collections.Generic;

namespace ExactOnline.Client.Models.Inventory
{
    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("TransferID")]
    public class WarehouseTransfer
    {
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String CreatorFullName { get; set; }
        /// <summary>Description</summary>
        public String Description { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>Entry Date</summary>
        public DateTime? EntryDate { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ModifierFullName { get; set; }
        /// <summary>Planned delivery date / Planned transfer date &lt;br&gt;It shows the date the items will be sent for transfer delivery.</summary>
        public DateTime? PlannedDeliveryDate { get; set; }
        /// <summary>Planned receipt date &lt;br&gt;It shows the date the items will arrive at the warehouse location.</summary>
        public DateTime? PlannedReceiptDate { get; set; }
        /// <summary>Remarks</summary>
        public String Remarks { get; set; }
        /// <summary>Source of warehouse transfer entry: 1-Manual entry, 2-Import, 3-Transfer advice, 4-Web service</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int16? Source { get; set; }
        /// <summary>Warehouse transfer status: 10-Draft, 50-Processed</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int16 Status { get; set; }
        /// <summary>Transfer Date of the processed warehouse transfer</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? TransferDate { get; set; }
        /// <summary>Primary key</summary>
        public Guid TransferID { get; set; }
        /// <summary>Transfer Number</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? TransferNumber { get; set; }
        /// <summary>ID of warehouse to transfer item from</summary>
        public Guid? WarehouseFrom { get; set; }
        /// <summary>Code of warehouse to transfer item from</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String WarehouseFromCode { get; set; }
        /// <summary>Description of warehouse to transfer item from</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String WarehouseFromDescription { get; set; }
        /// <summary>ID of warehouse to transfer item to</summary>
        public Guid? WarehouseTo { get; set; }
        /// <summary>Code of warehouse to transfer item to</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String WarehouseToCode { get; set; }
        /// <summary>Description of warehouse to transfer item to</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String WarehouseToDescription { get; set; }
        /// <summary>Collection of warehouse transfer lines</summary>
        public IEnumerable<WarehouseTransferLine> WarehouseTransferLines { get; set; }
    }
}
