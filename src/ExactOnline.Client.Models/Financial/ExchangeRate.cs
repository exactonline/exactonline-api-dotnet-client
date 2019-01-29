namespace ExactOnline.Client.Models.Financial
{
    using System;

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class ExchangeRate
    {
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
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
        /// <summary>The exchange rate is stored as 1 TARGET CURRENCY = x SOURCE CURRENCY</summary>
        public double? Rate { get; set; }
        /// <summary>The foreign currency</summary>
        public string SourceCurrency { get; set; }
        /// <summary>Description of SourceCurrency</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string SourceCurrencyDescription { get; set; }
        /// <summary>The date as of which the rate is valid. The rate is valid until a next rate is defined</summary>
        public DateTime? StartDate { get; set; }
        /// <summary>The default currency of the division</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string TargetCurrency { get; set; }
        /// <summary>Description of TargetCurrency</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string TargetCurrencyDescription { get; set; }
    }
}