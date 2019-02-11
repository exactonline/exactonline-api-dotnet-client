using System;

namespace ExactOnline.Client.Models.Budget
{
    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class Budget
    {
        /// <summary>Budget amount (always in the default currency of the company)</summary>
        public double? AmountDC { get; set; }
        /// <summary>Budget scenario</summary>
        public Guid? BudgetScenario { get; set; }
        /// <summary>Code of BudgetScenario</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string BudgetScenarioCode { get; set; }
        /// <summary>Description of BudgetScenario</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string BudgetScenarioDescription { get; set; }
        /// <summary>Used for cost center-specific budgets - NULL otherwise</summary>
        public string Costcenter { get; set; }
        /// <summary>Description of Costcenter</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CostcenterDescription { get; set; }
        /// <summary>Used for cost unit-specific budgets - NULL otherwise</summary>
        public string Costunit { get; set; }
        /// <summary>Description of Costunit</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CostunitDescription { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>G/L account</summary>
        public Guid? GLAccount { get; set; }
        /// <summary>Code of GLAccount</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLAccountCode { get; set; }
        /// <summary>Description of GLAccount</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLAccountDescription { get; set; }
        /// <summary>Numerical ID. Never displayed to the user, but it may have its use for performance reasons</summary>
        public Int64? HID { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Used for item-specific budgets - NULL otherwise</summary>
        public Guid? Item { get; set; }
        /// <summary>Code of Item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemCode { get; set; }
        /// <summary>Description of Item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        /// <summary>Period (combined with financial year)</summary>
        public Int16? ReportingPeriod { get; set; }
        /// <summary>Financial year</summary>
        public Int16? ReportingYear { get; set; }
    }
}
