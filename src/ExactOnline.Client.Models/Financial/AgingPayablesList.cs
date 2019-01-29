namespace ExactOnline.Client.Models.Financial
{
    using System;

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("AccountId")]
    public class AgingPayablesList
    {
        /// <summary>Code of Account</summary>
        public string AccountCode { get; set; }
        /// <summary>Primary key</summary>
        public Guid AccountId { get; set; }
        /// <summary>Name of Account</summary>
        public string AccountName { get; set; }
        /// <summary>Age group 1</summary>
        public Int32 AgeGroup1 { get; set; }
        /// <summary>Amount of age group 1</summary>
        public double AgeGroup1Amount { get; set; }
        /// <summary>Description of AgeGroup1</summary>
        public string AgeGroup1Description { get; set; }
        /// <summary>Age group 2</summary>
        public Int32 AgeGroup2 { get; set; }
        /// <summary>Amount of age group 2</summary>
        public double AgeGroup2Amount { get; set; }
        /// <summary>Description of AgeGroup2</summary>
        public string AgeGroup2Description { get; set; }
        /// <summary>Age group 3</summary>
        public Int32 AgeGroup3 { get; set; }
        /// <summary>Amount of age group 3</summary>
        public double AgeGroup3Amount { get; set; }
        /// <summary>Description of AgeGroup3</summary>
        public string AgeGroup3Description { get; set; }
        /// <summary>Age group 4</summary>
        public Int32 AgeGroup4 { get; set; }
        /// <summary>Amount of age group 4</summary>
        public double AgeGroup4Amount { get; set; }
        /// <summary>Description of AgeGroup4</summary>
        public string AgeGroup4Description { get; set; }
        /// <summary>Code of Currency</summary>
        public string CurrencyCode { get; set; }
        /// <summary>Total amount of all age groups</summary>
        public double TotalAmount { get; set; }
    }
}