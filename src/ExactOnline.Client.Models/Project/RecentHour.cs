namespace ExactOnline.Client.Models.Project
{
    using System;

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("Id")]
    public class RecentHour
    {
        /// <summary>Code of Account</summary>
        public String AccountCode { get; set; }
        /// <summary>Reference to Account</summary>
        public Guid? AccountId { get; set; }
        /// <summary>Name of Account</summary>
        public String AccountName { get; set; }
        /// <summary>Reference to Activity</summary>
        public Guid? Activity { get; set; }
        /// <summary>Description of Activity</summary>
        public String ActivityDescription { get; set; }
        /// <summary>Date</summary>
        public DateTime Date { get; set; }
        /// <summary>Entry ID</summary>
        public Guid? EntryId { get; set; }
        /// <summary>Hours approved</summary>
        public Double HoursApproved { get; set; }
        /// <summary>Billable hours approved</summary>
        public Double HoursApprovedBillable { get; set; }
        /// <summary>Hours draft</summary>
        public Double HoursDraft { get; set; }
        /// <summary>Billable hours draft</summary>
        public Double HoursDraftBillable { get; set; }
        /// <summary>Hours rejected</summary>
        public Double HoursRejected { get; set; }
        /// <summary>Billable hours rejected</summary>
        public Double HoursRejectedBillable { get; set; }
        /// <summary>Hours submitted</summary>
        public Double HoursSubmitted { get; set; }
        /// <summary>Billable hours submitted</summary>
        public Double HoursSubmittedBillable { get; set; }
        /// <summary>Primary key</summary>
        public Int32 Id { get; set; }
        /// <summary>Code of Item</summary>
        public String ItemCode { get; set; }
        /// <summary>Description of Item</summary>
        public String ItemDescription { get; set; }
        /// <summary>Reference to Item</summary>
        public Guid? ItemId { get; set; }
        /// <summary>Remarks</summary>
        public String Notes { get; set; }
        /// <summary>Code of Project</summary>
        public String ProjectCode { get; set; }
        /// <summary>Description of Project</summary>
        public String ProjectDescription { get; set; }
        /// <summary>Reference to Project</summary>
        public Guid? ProjectId { get; set; }
        /// <summary>Week number</summary>
        public Int32 WeekNumber { get; set; }
    }
}