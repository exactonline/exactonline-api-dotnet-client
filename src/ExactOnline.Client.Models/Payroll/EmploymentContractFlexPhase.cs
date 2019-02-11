namespace ExactOnline.Client.Models.Payroll
{
    using System;

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class EmploymentContractFlexPhase
    {
        /// <summary>Flexible employment contract phase description</summary>
        public string Description { get; set; }
        /// <summary>Primary key</summary>
        public Int32 ID { get; set; }
    }
}