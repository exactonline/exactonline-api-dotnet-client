namespace ExactOnline.Client.Models.Cashflow
{
    using System;

    [SupportedActionsSDK(true, true, false, false)]
    [DataServiceKey("ID")]
    public class PaymentCondition
    {
        /// <summary>Code of the payment condition</summary>
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
        /// <summary>Default credit management scenario to be used for new payment terms</summary>
        public Guid? CreditManagementScenario { get; set; }
        /// <summary>Code of CreditManagementScenario</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreditManagementScenarioCode { get; set; }
        /// <summary>Description of CreditManagementScenario</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreditManagementScenarioDescription { get; set; }
        /// <summary>Description of the payment condition</summary>
        public string Description { get; set; }
        /// <summary>Indicates how the discount amount is calculated. Values: E = Excluding VAT, I = Including VAT</summary>
        public string DiscountCalculation { get; set; }
        /// <summary>Number of days to pay within, to have the right to take the discount</summary>
        public Int32? DiscountPaymentDays { get; set; }
        /// <summary>Discount percentage</summary>
        public double? DiscountPercentage { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>Primary key</summary>
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
        /// <summary>Number of days to be included in the due date calculation. Example: invoice date = 17/01 PaymentEndOfMonths = 2 =&gt; 31/03 PaymentDays = 15 =&gt; 15/04</summary>
        public Int32? PaymentDays { get; set; }
        /// <summary>Type of payment discount. Values: B = Settlement discount, K = Credit surcharge</summary>
        public string PaymentDiscountType { get; set; }
        /// <summary>Number of month endings to be included in the due date calculation</summary>
        public Int32? PaymentEndOfMonths { get; set; }
        /// <summary>Method of payment. Values: B = On credit, I = Collection, K = Cash</summary>
        public string PaymentMethod { get; set; }
        /// <summary>Percentage (stored as fraction) of total invoice amount</summary>
        public double? Percentage { get; set; }
        /// <summary>Indicates how the VAT amount is calculated Values: E = Excluding discount, I = Including discount</summary>
        public string VATCalculation { get; set; }
    }
}