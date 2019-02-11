using System;

namespace ExactOnline.Client.Models.Financial
{
    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("AgeGroup")]
    public class AgingOverview
    {
        /// <summary>Primary key</summary>
        public Int32 AgeGroup { get; set; }
        /// <summary>Description of AgeGroup</summary>
        public string AgeGroupDescription { get; set; }
        /// <summary>Amount payable</summary>
        public double AmountPayable { get; set; }
        /// <summary>Amount receivable</summary>
        public double AmountReceivable { get; set; }
        /// <summary>Code of Currency</summary>
        public string CurrencyCode { get; set; }
    }
}
