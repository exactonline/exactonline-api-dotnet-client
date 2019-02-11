namespace ExactOnline.Client.Models.Project
{
    using System;

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("Id")]
    public class RecentCost
    {
        /// <summary>Code of Account</summary>
        public String AccountCode { get; set; }
        /// <summary>Reference to Account</summary>
        public Guid? AccountId { get; set; }
        /// <summary>Name of Account</summary>
        public String AccountName { get; set; }
        /// <summary>Amount approved</summary>
        public Double AmountApproved { get; set; }
        /// <summary>Amount draft</summary>
        public Double AmountDraft { get; set; }
        /// <summary>Amount rejected</summary>
        public Double AmountRejected { get; set; }
        /// <summary>Amount submitted</summary>
        public Double AmountSubmitted { get; set; }
        /// <summary>Code of Currency</summary>
        public String CurrencyCode { get; set; }
        /// <summary>Date</summary>
        public DateTime Date { get; set; }
        /// <summary>Entry ID</summary>
        public Guid? EntryId { get; set; }
        /// <summary>Reference to Expense</summary>
        public Guid? Expense { get; set; }
        /// <summary>Description of Expense</summary>
        public String ExpenseDescription { get; set; }
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
        /// <summary>Quantity approved</summary>
        public Double QuantityApproved { get; set; }
        /// <summary>Quantity draft</summary>
        public Double QuantityDraft { get; set; }
        /// <summary>Quantity rejected</summary>
        public Double QuantityRejected { get; set; }
        /// <summary>Quantity submitted</summary>
        public Double QuantitySubmitted { get; set; }
        /// <summary>Week number</summary>
        public Int32 WeekNumber { get; set; }
    }
}