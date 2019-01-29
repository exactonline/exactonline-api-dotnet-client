namespace ExactOnline.Client.Models.Accountancy
{
    using System;

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class InvolvedUser
    {
        /// <summary>ID of the account the user is involved with</summary>
        public Guid? Account { get; set; }
        /// <summary>City of the account</summary>
        public string AccountCity { get; set; }
        /// <summary>Code of the account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountCode { get; set; }
        /// <summary>Supplier flag of the account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public bool? AccountIsSupplier { get; set; }
        /// <summary>Logo thumbnail url of the account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountLogoThumbnailUrl { get; set; }
        /// <summary>Name of the account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountName { get; set; }
        /// <summary>Status of the account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountStatus { get; set; }
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
        /// <summary>ID of the user role</summary>
        public Guid? InvolvedUserRole { get; set; }
        /// <summary>Description of the user role</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string InvolvedUserRoleDescription { get; set; }
        /// <summary>Main contact flag of the involved user</summary>
        public bool? IsMainContact { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        /// <summary>Email of a person</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PersonEmail { get; set; }
        /// <summary>Phone of a person</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PersonPhone { get; set; }
        /// <summary>Phone extension of a person</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PersonPhoneExtension { get; set; }
        /// <summary>Picture thumbnail url of a person</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string PersonPictureThumbnailUrl { get; set; }
        /// <summary>ID of the involved user</summary>
        public Guid? User { get; set; }
        /// <summary>User name of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string UserFullName { get; set; }
    }
}