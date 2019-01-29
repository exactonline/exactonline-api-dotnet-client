using System;

namespace ExactOnline.Client.Models.Manufacturing
{
    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class BillOfMaterialMaterial
    {
        /// <summary>Item average cost available when average cost method is used</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Double? AverageCost { get; set; }
        /// <summary>Indicates if this is a backflush item</summary>
        public Byte? Backflush { get; set; }
        /// <summary>Calculator type</summary>
        public Int32? CalculatorType { get; set; }
        /// <summary>Cost batch</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Double? CostBatch { get; set; }
        /// <summary>Cost center</summary>
        public String CostCenter { get; set; }
        /// <summary>Cost center description</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String CostCenterDescription { get; set; }
        /// <summary>Cost unit</summary>
        public String CostUnit { get; set; }
        /// <summary>Cost unit description</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String CostUnitDescription { get; set; }
        /// <summary>Name of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String CreatorFullName { get; set; }
        /// <summary>Description of the material</summary>
        public String Description { get; set; }
        /// <summary>Detail drawing reference</summary>
        public String DetailDrawing { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>Primary key</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid ID { get; set; }
        /// <summary>Key of item version</summary>
        public Guid? ItemVersion { get; set; }
        /// <summary>Line number</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? LineNumber { get; set; }
        /// <summary>Net weight</summary>
        public Double? NetWeight { get; set; }
        /// <summary>Net weight unit of measure</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String NetWeightUnit { get; set; }
        /// <summary>Notes</summary>
        public String Notes { get; set; }
        /// <summary>Key of part item</summary>
        public Guid? PartItem { get; set; }
        /// <summary>Part item code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String PartItemCode { get; set; }
        /// <summary>Item standard cost available when standard cost method is used</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Double? PartItemCostPriceStandard { get; set; }
        /// <summary>Part item description</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String PartItemDescription { get; set; }
        /// <summary>Quantity</summary>
        public Double? Quantity { get; set; }
        /// <summary>Quantity batch</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Double? QuantityBatch { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? syscreated { get; set; }
        /// <summary>User ID of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? syscreator { get; set; }
        /// <summary>Modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? sysmodified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? sysmodifier { get; set; }
        /// <summary>Material type 1 indicates material, 2 indicates byproduct</summary>
        public Int32? Type { get; set; }
    }
}
