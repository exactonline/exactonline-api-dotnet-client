namespace ExactOnline.Client.Models.Manufacturing
{
    using System;

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class Workcenter
    {
        /// <summary>Capacity of the work center</summary>
        public Int32? Capacity { get; set; }
        /// <summary>Code of the work center</summary>
        public String Code { get; set; }
        /// <summary>Reference to CostCenters</summary>
        public String Costcenter { get; set; }
        /// <summary>Description of Costcenter</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String CostcenterDescription { get; set; }
        /// <summary>Reference to CostUnits</summary>
        public String Costunit { get; set; }
        /// <summary>Description of Costunit</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String CostunitDescription { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String CreatorFullName { get; set; }
        /// <summary>Description of the work center</summary>
        public String Description { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>General burden rate</summary>
        public Double? GeneralBurdenRate { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Indicates if labor burden is calculated as a percentage or amount</summary>
        public Byte IsLaborBurdenPercent { get; set; }
        /// <summary>Labor burden rate</summary>
        public Double? LaborBurdenRate { get; set; }
        /// <summary>Machine burden rate</summary>
        public Double? MachineBurdenRate { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ModifierFullName { get; set; }
        /// <summary>Remarks</summary>
        public String Notes { get; set; }
        /// <summary>Area to which the work center belongs.</summary>
        public Guid? ProductionArea { get; set; }
        /// <summary>Run labor rate</summary>
        public Double? RunLaborRate { get; set; }
        /// <summary>Search code of the work center</summary>
        public String SearchCode { get; set; }
        /// <summary>Setup labor rate</summary>
        public Double? SetupLaborRate { get; set; }
        /// <summary>Reference to WorkcenterStatus</summary>
        public Int32? Status { get; set; }
        /// <summary>Reference to WorkcenterTypes</summary>
        public Int32? Type { get; set; }
    }
}