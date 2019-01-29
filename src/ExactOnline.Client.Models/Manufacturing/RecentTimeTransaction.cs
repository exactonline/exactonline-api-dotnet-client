using System;

namespace ExactOnline.Client.Models.Manufacturing
{
    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("RecentTimeTransaction")]
    public class RecentTimeTransaction
    {
        /// <summary>Customer code</summary>
        public String CustomerCode { get; set; }
        /// <summary>Count of customers</summary>
        public Int32? CustomerCount { get; set; }
        /// <summary>Customer name</summary>
        public String CustomerName { get; set; }
        /// <summary>Type of data returned by query - for internal use</summary>
        public Int16? DataType { get; set; }
        /// <summary>Date of time entry</summary>
        public DateTime? Date { get; set; }
        /// <summary>ID of employee</summary>
        public Guid? Employee { get; set; }
        /// <summary>Time that operation was stopped</summary>
        public DateTime? EndTime { get; set; }
        /// <summary>Hour Status of the time transaction: Rejected = 2, Submitted = 10, Approved = 20</summary>
        public Int16? HourStatus { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Is fraction allowed item</summary>
        public Byte? IsFractionAllowedItem { get; set; }
        /// <summary>Is the operation finished?</summary>
        public Byte? IsOperationFinished { get; set; }
        /// <summary>Shop order make item</summary>
        public Guid? Item { get; set; }
        /// <summary>Make item code</summary>
        public String ItemCode { get; set; }
        /// <summary>Url to retrieve the item</summary>
        public String ItemPictureUrl { get; set; }
        /// <summary>Make item unit</summary>
        public String ItemUnit { get; set; }
        /// <summary>Adjustable labor hours</summary>
        public Double? LaborHours { get; set; }
        /// <summary>Adjustable machine hours</summary>
        public Double? MachineHours { get; set; }
        /// <summary>Modified date</summary>
        public DateTime? Modified { get; set; }
        /// <summary>Notes - viewable in data collection</summary>
        public String Notes { get; set; }
        /// <summary>Routing step operation</summary>
        public Guid? Operation { get; set; }
        /// <summary>Routing step operation code</summary>
        public String OperationCode { get; set; }
        /// <summary>Percentage of operation completed within time period</summary>
        public Double? PercentComplete { get; set; }
        /// <summary>Quantity of make item produced within time period</summary>
        public Double? ProducedQuantity { get; set; }
        /// <summary>Project ID of the shop order</summary>
        public Guid? Project { get; set; }
        /// <summary>Project code of the shop order</summary>
        public String ProjectCode { get; set; }
        /// <summary>Project description of the shop order</summary>
        public String ProjectDescription { get; set; }
        /// <summary>Count of Sales order</summary>
        public Int32? SalesOrderCount { get; set; }
        /// <summary>Sales order line number</summary>
        public Int32? SalesOrderLineNumber { get; set; }
        /// <summary>Sales order number</summary>
        public Int32? SalesOrderNumber { get; set; }
        /// <summary>Shop order</summary>
        public Guid? ShopOrder { get; set; }
        /// <summary>Shop order description</summary>
        public String ShopOrderDescription { get; set; }
        /// <summary>Shop order number</summary>
        public Int32? ShopOrderNumber { get; set; }
        /// <summary>Shop order planned quantity</summary>
        public Double? ShopOrderPlannedQuantity { get; set; }
        /// <summary>Shop order routing step where work occurred</summary>
        public Guid? ShopOrderRoutingStepPlan { get; set; }
        /// <summary>Percentage of time attended on the routing step plan</summary>
        public Double? ShopOrderRoutingStepPlanAttendedPercentage { get; set; }
        /// <summary>Description of the shop order routing step where work occurred</summary>
        public String ShopOrderRoutingStepPlanDescription { get; set; }
        /// <summary>Time that operation was started</summary>
        public DateTime? StartTime { get; set; }
        /// <summary>Status of the time transaction</summary>
        public Int16? Status { get; set; }
        /// <summary>Type of the time transaction: Setup = 10, Run = 20</summary>
        public Int16? Type { get; set; }
        /// <summary>ID of warehouse where shop order is finished</summary>
        public Guid? Warehouse { get; set; }
        /// <summary>Work center where work occurred</summary>
        public Guid? Workcenter { get; set; }
        /// <summary>Work center code</summary>
        public String WorkcenterCode { get; set; }
    }
}
