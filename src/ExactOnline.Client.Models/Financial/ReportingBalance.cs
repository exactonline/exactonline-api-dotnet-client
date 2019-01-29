namespace ExactOnline.Client.Models.Financial
{
    using System;

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class ReportingBalance
    {
        /// <summary>The sum of the amounts of all transactions in the grouping.</summary>
        public double? Amount { get; set; }
        /// <summary>The sum of the amounts of all credit transactions in the grouping.</summary>
        public double? AmountCredit { get; set; }
        /// <summary>The sum of the amounts of all debit transactions in the grouping.</summary>
        public double? AmountDebit { get; set; }
        /// <summary>Balance type of the G/L account: B = Balance Sheet, W = Profit &amp; Loss.</summary>
        public string BalanceType { get; set; }
        /// <summary>The code of the cost center.</summary>
        public string CostCenterCode { get; set; }
        /// <summary>The description of the cost center.</summary>
        public string CostCenterDescription { get; set; }
        /// <summary>The code of the cost unit.</summary>
        public string CostUnitCode { get; set; }
        /// <summary>The description of the cost unit.</summary>
        public string CostUnitDescription { get; set; }
        /// <summary>The number of transactions in the grouping.</summary>
        public Int32? Count { get; set; }
        /// <summary>Division code</summary>
        public Int32? Division { get; set; }
        /// <summary>G/L account</summary>
        public Guid? GLAccount { get; set; }
        /// <summary>The code of the G/L account.</summary>
        public string GLAccountCode { get; set; }
        /// <summary>The description of the G/L account.</summary>
        public string GLAccountDescription { get; set; }
        /// <summary>Record ID</summary>
        public Int64 ID { get; set; }
        /// <summary>The reporting period of the transactions in the grouping.</summary>
        public Int32? ReportingPeriod { get; set; }
        /// <summary>The reporting year of the transactions in the grouping.</summary>
        public Int32? ReportingYear { get; set; }
        /// <summary>Status: 20 = Open, 50 = Processed. To get &apos;after entry&apos; results, both Open and Processed amounts have to be included. This is by default, so it requires no extra filtering.</summary>
        public Int32? Status { get; set; }
        /// <summary>The type of the transactions in the grouping.</summary>
        public Int32? Type { get; set; }
    }
}