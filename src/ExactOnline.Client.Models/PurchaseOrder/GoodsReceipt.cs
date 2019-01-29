namespace ExactOnline.Client.Models.PurchaseOrder
{
    using System;
    using System.Collections.Generic;

    [SupportedActionsSDK(true, true, false, false)]
    [DataServiceKey("ID")]
    public class GoodsReceipt
    {
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        /// <summary>User ID of the creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of the creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        /// <summary>Description of the goods receipt</summary>
        public string Description { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        /// <summary>Document that is linked to the goods receipt</summary>
        public Guid? Document { get; set; }
        /// <summary>Document subject</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DocumentSubject { get; set; }
        /// <summary>Entry number of the resulting stock entry</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? EntryNumber { get; set; }
        /// <summary>Collection of receipt lines</summary>
        public IEnumerable<GoodsReceiptLine> GoodsReceiptLines { get; set; }
        /// <summary>Primary key</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid ID { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        /// <summary>User ID of the last modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of the last modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        /// <summary>Date of the goods receipt</summary>
        public DateTime? ReceiptDate { get; set; }
        /// <summary>Receipt number</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? ReceiptNumber { get; set; }
        /// <summary>Receipt note</summary>
        public string Remarks { get; set; }
        /// <summary>Account ID of the supplier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Supplier { get; set; }
        /// <summary>Supplier code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SupplierCode { get; set; }
        /// <summary>ID of the contact person at the supplier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? SupplierContact { get; set; }
        /// <summary>Name of the contact person at the supplier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SupplierContactFullName { get; set; }
        /// <summary>Supplier name</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SupplierName { get; set; }
        /// <summary>Warehouse ID</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Warehouse { get; set; }
        /// <summary>Warehouse code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string WarehouseCode { get; set; }
        /// <summary>Description of the warehouse</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string WarehouseDescription { get; set; }
        /// <summary>The purchase invoice number provided by the supplier</summary>
        public string YourRef { get; set; }
    }
}