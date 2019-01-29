using System;

namespace ExactOnline.Client.Models.General
{
    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("Code")]
    public class Currency
    {
        /// <summary>Amount precision</summary>
        public double AmountPrecision { get; set; }
        /// <summary>Primary key</summary>
        public string Code { get; set; }
        /// <summary>Creation date</summary>
        public DateTime? Created { get; set; }
        /// <summary>Description of the currency</summary>
        public string Description { get; set; }
        /// <summary>Last modified date</summary>
        public DateTime? Modified { get; set; }
        /// <summary>Price precision</summary>
        public double PricePrecision { get; set; }
    }
}
