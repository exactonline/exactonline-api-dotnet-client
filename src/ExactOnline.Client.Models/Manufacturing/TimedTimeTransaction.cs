using System;

namespace ExactOnline.Client.Models.Manufacturing
{
    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class TimedTimeTransaction
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
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>ID of employee</summary>
        public Guid? Employee { get; set; }
        /// <summary>Name of employee</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String EmployeeFullName { get; set; }
        /// <summary>Time that operation was stopped</summary>
        public DateTime? EndTime { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Is the operation finished?</summary>
        public Byte? IsOperationFinished { get; set; }
        /// <summary>Adjustable labor hours</summary>
        public Double? LaborHours { get; set; }
        /// <summary>Adjustable machine hours</summary>
        public Double? MachineHours { get; set; }
        /// <summary>Modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ModifierFullName { get; set; }
        /// <summary>Notes - viewable in data collection</summary>
        public String Notes { get; set; }
        /// <summary>ID of operation</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Operation { get; set; }
        /// <summary>Code of operation</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String OperationCode { get; set; }
        /// <summary>Description of operation</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String OperationDescription { get; set; }
        /// <summary>Percentage of operation completed within time period</summary>
        public Double? PercentComplete { get; set; }
        /// <summary>Quantity of make item produced within time period</summary>
        public Double? ProducedQuantity { get; set; }
        /// <summary>Production area of the work center</summary>
        public Guid? ProductionArea { get; set; }
        /// <summary>Code of production area of the work center</summary>
        public String ProductionAreaCode { get; set; }
        /// <summary>Description of production area of the work center</summary>
        public String ProductionAreaDescription { get; set; }
        /// <summary>ID of shop order</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? ShopOrder { get; set; }
        /// <summary>Description of shop order</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ShopOrderDescription { get; set; }
        /// <summary>Number of shop order</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? ShopOrderNumber { get; set; }
        /// <summary>Shop order routing step where work occurred</summary>
        public Guid? ShopOrderRoutingStepPlan { get; set; }
        /// <summary>Description of the routing step plan</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ShopOrderRoutingStepPlanDescription { get; set; }
        /// <summary>Remaining planned run hours of the routing step plan</summary>
        public Double ShopOrderRoutingStepPlanRemainingRunHours { get; set; }
        /// <summary>Remaining planned setup hours of the routing step plan</summary>
        public Double ShopOrderRoutingStepPlanRemainingSetupHours { get; set; }
        /// <summary>Source of the timed time transaction</summary>
        public Int32? Source { get; set; }
        /// <summary>Time that operation was started</summary>
        public DateTime? StartTime { get; set; }
        /// <summary>Status of the timed time transaction</summary>
        public Int32? Status { get; set; }
        /// <summary>Type of the timed time transaction: Setup = 10, Run = 20</summary>
        public Int32? Type { get; set; }
        /// <summary>Work center where work occurred</summary>
        public Guid? Workcenter { get; set; }
        /// <summary>Code of the work center</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String WorkcenterCode { get; set; }
        /// <summary>Description of the work center</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String WorkcenterDescription { get; set; }
    }
}
