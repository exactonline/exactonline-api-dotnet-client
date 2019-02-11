namespace ExactOnline.Client.Models.Payroll
{
    using System;

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class EmploymentEndReason
    {
        /// <summary>Employment end reason description</summary>
        public string Description { get; set; }
        /// <summary>Primary key</summary>
        public Int32 ID { get; set; }
    }
}