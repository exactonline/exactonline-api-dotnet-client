namespace ExactOnline.Client.Models.Financial
{
    using System;

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class Journal
    {
        /// <summary>Indicates if the journal allows variable currency</summary>
        public bool? AllowVariableCurrency { get; set; }
        /// <summary>Indicates if the journal allows the exchange rate of the currency of the amounts in the journal entry to be changed</summary>
        public bool? AllowVariableExchangeRate { get; set; }
        /// <summary>Indicates if the journal allows the use of VAT in the financial entry. Especially true for general journals</summary>
        public bool? AllowVAT { get; set; }
        /// <summary>Indicates if the journal automatically saves the entries when the amount is in balance with the entry lines</summary>
        public bool? AutoSave { get; set; }
        /// <summary>Reference to bank account</summary>
        public Guid? Bank { get; set; }
        /// <summary>BIC code of the bank where the bank account is held</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string BankAccountBICCode { get; set; }
        /// <summary>Country of bank account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string BankAccountCountry { get; set; }
        /// <summary>Description of BankAccount</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string BankAccountDescription { get; set; }
        /// <summary>IBAN of the bank account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string BankAccountIBAN { get; set; }
        /// <summary>Reference to the Bank Account linked to the Journal</summary>
        public Guid? BankAccountID { get; set; }
        /// <summary>Bank account number. Is mandatory for Journals that have Type = Bank</summary>
        public string BankAccountIncludingMask { get; set; }
        /// <summary>Obsolete. Whether or not use SEPA for the bank account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public bool? BankAccountUseSEPA { get; set; }
        /// <summary>Obsolete. Whether or not use SEPA direct debit for the bank account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public bool? BankAccountUseSepaDirectDebit { get; set; }
        /// <summary>Name of bank account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string BankName { get; set; }
        /// <summary>Primary key</summary>
        public string Code { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        /// <summary>Default Currency of the Journal. If AllowVariableCurrency is false this is the only currency that can be used</summary>
        public string Currency { get; set; }
        /// <summary>Description of Currency</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CurrencyDescription { get; set; }
        /// <summary>Name of the Journal</summary>
        public string Description { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>Suspense general ledger account</summary>
        public Guid? GLAccount { get; set; }
        /// <summary>Code of GLAccount</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLAccountCode { get; set; }
        /// <summary>Description of GLAccount</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string GLAccountDescription { get; set; }
        /// <summary>Type of GLAccount</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? GLAccountType { get; set; }
        /// <summary>Primary Key</summary>
        public Guid ID { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        /// <summary>General ledger account for payment in transit</summary>
        public Guid? PaymentInTransitAccount { get; set; }
        /// <summary>Identifier detail of the Payment service account. Ex. EmailID for Paypal type of Payment service account</summary>
        public string PaymentServiceAccountIdentifier { get; set; }
        /// <summary>Type of Payment service provider. The following values are supported: 1 (Adyen), 2 (Paypal), 3 (Stripe). Is mandatory for Journals of Type 16 (Payment service)</summary>
        public Int32? PaymentServiceProvider { get; set; }
        /// <summary>Name of the Payment service provider</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PaymentServiceProviderName { get; set; }
        /// <summary>Type of Journal. The following values are supported: 10 (Cash) 12 (Bank) 16 (Payment service) 20 (Sales) 21 (Return invoice) 22 (Purchase) 23 (Received return invoice) 90 (General journal)</summary>
        public Int32? Type { get; set; }
    }
}