namespace ExactOnline.Client.Models.Manufacturing
{
    using System;

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class BillOfMaterialVersion
    {
        /// <summary>Batch Quantity of Item Version</summary>
        public Double? BatchQuantity { get; set; }
        /// <summary>Cad drawing URL</summary>
        public String CadDrawingUrl { get; set; }
        /// <summary>Calculated Cost Price of Item Version</summary>
        public Double? CalculatedCostPrice { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String CreatorFullName { get; set; }
        /// <summary>Description of the item version</summary>
        public String Description { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Indicates if this is the default item version that will be assigned when a item is selected</summary>
        public Byte IsDefault { get; set; }
        /// <summary>Reference to Items table</summary>
        public Guid Item { get; set; }
        /// <summary>Description of Item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ItemDescription { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ModifierFullName { get; set; }
        /// <summary>Line notes</summary>
        public String Notes { get; set; }
        /// <summary>Order lead days for item</summary>
        public Int32? OrderLeadDays { get; set; }
        /// <summary>Production lead time in days of Item version</summary>
        public Int32? ProductionLeadDays { get; set; }
        /// <summary>Statuses of Item version: 10-Engineering change pending, 20-Engineering change approved, 30-Active &amp; 40-Historic</summary>
        public Int16? Status { get; set; }
        /// <summary>Description of Status</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String StatusDescription { get; set; }
        /// <summary>Type of Item version: 10-Sales bill of material, 20-Manufacturing recipe</summary>
        public Int16? Type { get; set; }
        /// <summary>Description of Type</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String TypeDescription { get; set; }
        /// <summary>Version date</summary>
        public DateTime? VersionDate { get; set; }
        /// <summary>Version Number</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? VersionNumber { get; set; }
    }
}