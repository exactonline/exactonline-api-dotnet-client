namespace ExactOnline.Client.Models.Financial
{
    using System;

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("Year,Period,Journal")]
    public class JournalStatusList
    {
        /// <summary>Reference to Journal</summary>
        public string Journal { get; set; }
        /// <summary>Description of Journal</summary>
        public string JournalDescription { get; set; }
        /// <summary>Type of Journal 10=Cash, 12=Bank, 20=Sales, 21=Return invoice, 22=Purchase, 23=Received return invoice, 90=General journal</summary>
        public Int32 JournalType { get; set; }
        /// <summary>Description of JournalType</summary>
        public string JournalTypeDescription { get; set; }
        /// <summary>Financial period</summary>
        public Int32 Period { get; set; }
        /// <summary>Journal status for this year and period 0=open, 1=closed</summary>
        public Int32 Status { get; set; }
        /// <summary>Description of Status</summary>
        public string StatusDescription { get; set; }
        /// <summary>Financial year</summary>
        public Int32 Year { get; set; }
    }
}