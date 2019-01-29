namespace ExactOnline.Client.Models.Financial
{
    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("CurrencyCode")]
    public class OutstandingInvoicesOverview
    {
        /// <summary>Primary key</summary>
        public string CurrencyCode { get; set; }
        /// <summary>Total invoice amount to be paid</summary>
        public double OutstandingPayableInvoiceAmount { get; set; }
        /// <summary>Number of invoices to be paid</summary>
        public double OutstandingPayableInvoiceCount { get; set; }
        /// <summary>Total invoice amount to be received</summary>
        public double OutstandingReceivableInvoiceAmount { get; set; }
        /// <summary>Number of invoices to be received</summary>
        public double OutstandingReceivableInvoiceCount { get; set; }
        /// <summary>Total payable invoice amount that is overdue</summary>
        public double OverduePayableInvoiceAmount { get; set; }
        /// <summary>Number of payable invoices that are overdue</summary>
        public double OverduePayableInvoiceCount { get; set; }
        /// <summary>Total receivable invoice amount that is overdue</summary>
        public double OverdueReceivableInvoiceAmount { get; set; }
        /// <summary>Number of receivable invoices that are overdue</summary>
        public double OverdueReceivableInvoiceCount { get; set; }
    }
}