namespace ExactOnline.Client.Models.Manufacturing
{
    using System;
    using System.Collections.Generic;

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class ShopOrderRoutingStepPlan
    {
        /// <summary>Reference to Account providing the Outsourced item</summary>
        public Guid? Account { get; set; }
        /// <summary>Account name</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String AccountName { get; set; }
        /// <summary>Account number</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String AccountNumber { get; set; }
        /// <summary>Attended Percentage</summary>
        public Double? AttendedPercentage { get; set; }
        /// <summary>Indicates if this is a backflush step</summary>
        public Byte? Backflush { get; set; }
        /// <summary>Total cost / Shop order planned quantity</summary>
        public Double? CostPerItem { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String CreatorFullName { get; set; }
        /// <summary>Description of the operation</summary>
        public String Description { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>Efficiency Percentage</summary>
        public Double? EfficiencyPercentage { get; set; }
        /// <summary>Conversion factor type between Shop order Item and Subcontract purchase Unit</summary>
        public Int32? FactorType { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Sequential order of the operation</summary>
        public Int32? LineNumber { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ModifierFullName { get; set; }
        /// <summary>Notes</summary>
        public String Notes { get; set; }
        /// <summary>Reference to Operations</summary>
        public Guid? Operation { get; set; }
        /// <summary>Code of the routing step operation</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String OperationCode { get; set; }
        /// <summary>Description of the operation step</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String OperationDescription { get; set; }
        /// <summary>Reference to OperationResources</summary>
        public Guid? OperationResource { get; set; }
        /// <summary>Planned end date</summary>
        public DateTime? PlannedEndDate { get; set; }
        /// <summary>Planned run hours</summary>
        public Double? PlannedRunHours { get; set; }
        /// <summary>Planned setup hours</summary>
        public Double? PlannedSetupHours { get; set; }
        /// <summary>Planned start date</summary>
        public DateTime? PlannedStartDate { get; set; }
        /// <summary>Setup hours + Run hours</summary>
        public Double? PlannedTotalHours { get; set; }
        /// <summary>Reference to Units</summary>
        public String PurchaseUnit { get; set; }
        /// <summary>Purchase Unit Factor</summary>
        public Double? PurchaseUnitFactor { get; set; }
        /// <summary>Purchase Unit Price in the currency of the transaction</summary>
        public Double? PurchaseUnitPriceFC { get; set; }
        /// <summary>Purchase unit quantity of the plan</summary>
        public Double? PurchaseUnitQuantity { get; set; }
        /// <summary>Reference to RoutingStepTypes</summary>
        public Int32? RoutingStepType { get; set; }
        /// <summary>Used in conjunction with RunMethod, and EfficiencyPercentage to determine PlannedRunHours</summary>
        public Double? Run { get; set; }
        /// <summary>Reference to OperationMethod</summary>
        public Int32? RunMethod { get; set; }
        /// <summary>Description of RunMethod</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String RunMethodDescription { get; set; }
        /// <summary>Used in conjunction with SetupCount and Setup Unit to determine PlannedSetupHours</summary>
        public Double? Setup { get; set; }
        /// <summary>Reference to TimeUnits</summary>
        public String SetupUnit { get; set; }
        /// <summary>Reference to Shop orders</summary>
        public Guid? ShopOrder { get; set; }
        /// <summary>Reference to OperationStatus</summary>
        public Int32? Status { get; set; }
        /// <summary>Description of Status</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String StatusDescription { get; set; }
        /// <summary>Subcontracted lead days</summary>
        public Int32? SubcontractedLeadDays { get; set; }
        /// <summary>Collection of TimeTransactions</summary>
        public IEnumerable<ExactOnline.Client.Models.Manufacturing.TimeTransaction> TimeTransactions { get; set; }
        /// <summary>Total cost of the routing line</summary>
        public Double? TotalCostDC { get; set; }
        /// <summary>Reference to Workcenters</summary>
        public Guid? Workcenter { get; set; }
        /// <summary>Workcenter code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String WorkcenterCode { get; set; }
        /// <summary>Workcenter description</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String WorkcenterDescription { get; set; }
    }
}