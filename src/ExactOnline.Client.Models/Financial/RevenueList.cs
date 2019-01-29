namespace ExactOnline.Client.Models.Financial
{
    using System;

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("Year,Period")]
    public class RevenueList
    {
        /// <summary>Total amount in the default currency of the company</summary>
        public double Amount { get; set; }
        /// <summary>Reporting period</summary>
        public Int32 Period { get; set; }
        /// <summary>Current Reporting year</summary>
        public Int32 Year { get; set; }
    }
}