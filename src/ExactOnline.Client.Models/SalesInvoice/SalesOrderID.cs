namespace ExactOnline.Client.Models.SalesInvoice
{
    using System;

    [SupportedActionsSDK(true, false, false, false)]
    [DataServiceKey("ID")]
    public class SalesOrderID
    {
        public Guid ID { get; set; }
    }
}