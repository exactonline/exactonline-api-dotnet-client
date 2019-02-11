namespace ExactOnline.Client.Models.CRM
{
    using System;

    [SupportedActionsSDK(true, false, false, false)]
    [DataServiceKey("QuotationID")]
    public class AcceptQuotation
    {
        /// <summary>0 = No action (Default), 1 = create sales order, 2 = create sales invoice, 3 = create project.</summary>
		public Int32 Action { get; set; }
        /// <summary>Create a project work breakdown structure. Only needed when ProjectBudgetType = 2.</summary>
        public Boolean? CreateProjectWBS { get; set; }
        /// <summary>Division code</summary>
        public Int32 Division { get; set; }
        /// <summary>Contains the error message if an error occurred during the acception of the quotation.</summary>
        public String ErrorMessage { get; set; }
        /// <summary>The journal in which the sales invoice will be booked. Mandatory for Action = 2.</summary>
        public Int32 InvoiceJournal { get; set; }
        /// <summary>The budget type of the project that will be created. Default = 0.</summary>
        public Int32? ProjectBudgetType { get; set; }
        /// <summary>The code of the project that will be created. Mandatory for Action = 3.</summary>
        public String ProjectCode { get; set; }
        /// <summary>The description of the project that will be created. Mandatory for Action = 3.</summary>
        public String ProjectDescription { get; set; }
        /// <summary>The invoicing date of the project. Mandatory for ProjectInvoicingAction = 2.</summary>
        public DateTime? ProjectInvoiceDate { get; set; }
        /// <summary>The project invoicing action. 0 = None (Default), 1 = Create invoice terms, 2 = As quoted.</summary>
        public Int32? ProjectInvoicingAction { get; set; }
        /// <summary>The prepaid type. Mandatory for ProjectType = 5. 1 = Retainer, 2 = Hour type bundle.</summary>
        public Int32? ProjectPrepaindTypes { get; set; }
        /// <summary>PriceAgreement.</summary>
        public Double? ProjectPriceAgreement { get; set; }
        /// <summary>Contains information if the project was successfully created.</summary>
        public String ProjectSuccess { get; set; }
        /// <summary>The type of the project that will be created. 2 = Fixed price (Default), 3 = Time and Material, 4 = Non billable, 5 = Prepaid.</summary>
        public Int32? ProjectType { get; set; }
        /// <summary>Identifier of the quotation.</summary>
        public Guid QuotationID { get; set; }
        /// <summary>Reason why the quotation was accepted.</summary>
        public Guid? ReasonCode { get; set; }
        /// <summary>Contains information if the sales invoice was successfully created.</summary>
        public String SalesInvoiceSuccess { get; set; }
        /// <summary>Contains information if the sales order was successfully created.</summary>
        public String SalesOrderSuccess { get; set; }
        /// <summary>Contains information if the quotation was successfully accepted.</summary>
        public String SuccessMessage { get; set; }
    }
}