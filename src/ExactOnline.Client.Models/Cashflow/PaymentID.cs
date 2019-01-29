namespace ExactOnline.Client.Models.Cashflow
{
    using System;

    [SupportedActionsSDK(true, false, false, false)]
    [DataServiceKey("ID")]
    public class PaymentID
    {
        /// <summary>ID of the payment to be processed.</summary>
        public Guid ID { get; set; }
    }
}