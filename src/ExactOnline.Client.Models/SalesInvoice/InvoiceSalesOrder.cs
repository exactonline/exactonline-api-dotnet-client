namespace ExactOnline.Client.Models.SalesInvoice
{
    using System;
    using System.Collections.Generic;

    [SupportedActionsSDK(true, false, false, false)]
    [DataServiceKey("ID")]
    public class InvoiceSalesOrder
    {
        /// <summary>Invoice creation mode- 0: Per customer 1: Per sales order</summary>
        public Int32? CreateMode { get; set; }
        /// <summary>Stock entries entry number.</summary>
        public Int32? DeliveryNumber { get; set; }
        /// <summary>Stock entries entry end date.</summary>
        public DateTime? EndDate { get; set; }
        /// <summary>Errors in the process.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String Errors { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Invoice quantity processing mode- 0:By quantity delivered 1:By quantity ordered.</summary>
        public Int32? InvoiceMode { get; set; }
        /// <summary>Code of Journal</summary>
        public String JournalCode { get; set; }
        /// <summary>Number of invoices successfully created.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? NumberOfCreatedInvoices { get; set; }
        /// <summary>Number of invoices failed to create.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? NumberOfFailedInvoices { get; set; }
        /// <summary>Collection of Sales order IDs.</summary>
        public IEnumerable<ExactOnline.Client.Models.SalesInvoice.SalesOrderID> SalesOrderIDs { get; set; }
        /// <summary>Stock entries entry start date.</summary>
        public DateTime? StartDate { get; set; }
        /// <summary>Possibility to override the InvoiceDate during creation of sales invoice from sales orders. Works only for integration with Intuit QuickBooks.</summary>
        public DateTime? UserInvoiceDate { get; set; }
    }
}