using System;

namespace ExactOnline.Client.Models.Cashflow
{
    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class Bank
    {
        /// <summary>The name of the bank</summary>
        public string BankName { get; set; }
        /// <summary>The bank identification code of the bank</summary>
        public string BICCode { get; set; }
        /// <summary>The country in which the bank is based</summary>
        public string Country { get; set; }
        /// <summary>Creation date</summary>
        public DateTime? Created { get; set; }
        /// <summary>The extended description of the bank</summary>
        public string Description { get; set; }
        /// <summary>The account format used by the bank</summary>
        public string Format { get; set; }
        /// <summary>The website of the bank</summary>
        public string HomePageAddress { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>The status of the bank. A = Active, P = Passive</summary>
        public string Status { get; set; }
    }
}
