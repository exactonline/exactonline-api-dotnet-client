namespace ExactOnline.Client.Models.Accountancy
{
    using System;

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class AccountOwner
    {
        /// <summary>ID of the account that is owned</summary>
        public Guid? Account { get; set; }
        /// <summary>Code of the account that is owned</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountCode { get; set; }
        /// <summary>Name of the account that is owned</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountName { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>User ID of the creator</summary>
        public Guid? Creator { get; set; }
        /// <summary>Name of the creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        /// <summary>Division code</summary>
        public Int32? Division { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>User ID of the modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of the modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        /// <summary>ID of the account who owns specified account</summary>
        public Guid? OwnerAccount { get; set; }
        /// <summary>Code of the account who owns specified account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string OwnerAccountCode { get; set; }
        /// <summary>Name of the account who owns specified account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string OwnerAccountName { get; set; }
        /// <summary>Percentage of shares that is owned. 1 is 100%, 0.5 is 50%</summary>
        public double? Shares { get; set; }
    }
}