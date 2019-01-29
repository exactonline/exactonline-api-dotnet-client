namespace ExactOnline.Client.Models.Manufacturing
{
    using System;

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class TimeTransaction
    {
        /// <summary>Manufacturing time type: Setup = 10, Run = 20</summary>
        public Int32? Activity { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String CreatorFullName { get; set; }
        /// <summary>Date</summary>
        public DateTime? Date { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>Employee linked to the transaction</summary>
        public Guid? Employee { get; set; }
        /// <summary>Machine hours</summary>
        public Double? Hours { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Is the operation finished?</summary>
        public Byte? IsOperationFinished { get; set; }
        /// <summary>Labor Hours on the operation</summary>
        public Double? LaborHours { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ModifierFullName { get; set; }
        /// <summary>Notes linked to the time transaction</summary>
        public String Notes { get; set; }
        /// <summary>Percentage of the operation that is complete</summary>
        public Double? PercentComplete { get; set; }
        /// <summary>Quantity</summary>
        public Double? Quantity { get; set; }
        /// <summary>Routing step linked to the transaction</summary>
        public Guid? RoutingStepPlan { get; set; }
        /// <summary>Shop order linked to the transaction</summary>
        public Guid? ShopOrder { get; set; }
        /// <summary>Status of the transaction: Draft = 1, Rejected = 2, Submitted = 10, Final = 20</summary>
        public Int32? Status { get; set; }
        /// <summary>Timed time transaction linked to the transaction</summary>
        public Guid? TimedTimeTransaction { get; set; }
        /// <summary>Workcenter linked to the transaction</summary>
        public Guid? WorkCenter { get; set; }
    }
}