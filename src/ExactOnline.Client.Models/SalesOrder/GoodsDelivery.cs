namespace ExactOnline.Client.Models.SalesOrder
{
    using System;
    using System.Collections.Generic;

    [SupportedActionsSDK(true, true, true, false)]
    [DataServiceKey("EntryID")]
    public class GoodsDelivery
    {
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>User ID of the creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of the creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        /// <summary>Reference to account for delivery</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? DeliveryAccount { get; set; }
        /// <summary>Delivery account code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DeliveryAccountCode { get; set; }
        /// <summary>Account name</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DeliveryAccountName { get; set; }
        /// <summary>Reference to shipping address</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? DeliveryAddress { get; set; }
        /// <summary>Reference to contact for delivery</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? DeliveryContact { get; set; }
        /// <summary>Name of the contact person of the customer who will receive delivered goods</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DeliveryContactPersonFullName { get; set; }
        /// <summary>Date of goods delivery</summary>
        public DateTime? DeliveryDate { get; set; }
        /// <summary>Delivery number</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? DeliveryNumber { get; set; }
        /// <summary>Header description</summary>
        public string Description { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>Document that is manually linked to the sales order delivery</summary>
        public Guid? Document { get; set; }
        /// <summary>Document Subject</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string DocumentSubject { get; set; }
        /// <summary>Primary key</summary>
        public Guid EntryID { get; set; }
        /// <summary>Entry number</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? EntryNumber { get; set; }
        /// <summary>Collection of lines</summary>
        public IEnumerable<GoodsDeliveryLine> GoodsDeliveryLines { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        /// <summary>Remarks</summary>
        public string Remarks { get; set; }
        /// <summary>Reference to shipping method</summary>
        public Guid? ShippingMethod { get; set; }
        /// <summary>Code of shipping method</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ShippingMethodCode { get; set; }
        /// <summary>Description of shipping method</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ShippingMethodDescription { get; set; }
        /// <summary>Reference to header tracking number</summary>
        public string TrackingNumber { get; set; }
        /// <summary>Warehouse</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Warehouse { get; set; }
        /// <summary>Code of Warehouse</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string WarehouseCode { get; set; }
        /// <summary>Description of Warehouse</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string WarehouseDescription { get; set; }
    }
}