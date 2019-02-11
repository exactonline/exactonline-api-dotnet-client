using System;

namespace ExactOnline.Client.Models.CRM
{
    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class OpportunityContact
    {
        /// <summary>The account to which the contact belongs</summary>
        public Guid? Account { get; set; }
        /// <summary>Indicates if account is a customer</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Boolean AccountIsCustomer { get; set; }
        /// <summary>Indicates if account is a supplier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Boolean? AccountIsSupplier { get; set; }
        /// <summary>Reference to the main contact of the account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? AccountMainContact { get; set; }
        /// <summary>Name of the account</summary>
        public String AccountName { get; set; }
        /// <summary>Second address line</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String AddressLine2 { get; set; }
        /// <summary>Street name of the address</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String AddressStreet { get; set; }
        /// <summary>Street number of the address</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String AddressStreetNumber { get; set; }
        /// <summary>Street number suffix of the address</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String AddressStreetNumberSuffix { get; set; }
        /// <summary>Obsolete</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? AllowMailing { get; set; }
        /// <summary>Birth date</summary>
        public DateTime? BirthDate { get; set; }
        /// <summary>Obsolete. Please don&apos;t use this field anymore as it may overwrite LastName.</summary>
        public String BirthName { get; set; }
        /// <summary>Obsolete. Please don&apos;t use this field anymore as it may overwrite MiddleName.</summary>
        public String BirthNamePrefix { get; set; }
        /// <summary>Birth place</summary>
        public String BirthPlace { get; set; }
        /// <summary>Email address of the contact</summary>
        public String BusinessEmail { get; set; }
        /// <summary>Fax of the contact</summary>
        public String BusinessFax { get; set; }
        /// <summary>Mobile of the contact</summary>
        public String BusinessMobile { get; set; }
        /// <summary>Phone of the contact</summary>
        public String BusinessPhone { get; set; }
        /// <summary>Phone extension of the contact</summary>
        public String BusinessPhoneExtension { get; set; }
        /// <summary>City</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String City { get; set; }
        /// <summary>Code of the account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String Code { get; set; }
        /// <summary>Contact person that is linked to the opportunity</summary>
        public Guid? Contact { get; set; }
        /// <summary>Country code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String Country { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>User ID of the creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of the creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String CreatorFullName { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>Email address of the contact</summary>
        public String Email { get; set; }
        /// <summary>End date</summary>
        public DateTime? EndDate { get; set; }
        /// <summary>First name. Provide at least first name or last name to create a new contact</summary>
        public String FirstName { get; set; }
        /// <summary>Full name (First name Middle name Last name)</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String FullName { get; set; }
        /// <summary>Gender</summary>
        public String Gender { get; set; }
        /// <summary>Contact ID</summary>
        public Int32? HID { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Identification date</summary>
        public DateTime? IdentificationDate { get; set; }
        /// <summary>Reference to the identification document of the contact</summary>
        public Guid? IdentificationDocument { get; set; }
        /// <summary>Reference to the user responsible for identification</summary>
        public Guid? IdentificationUser { get; set; }
        /// <summary>Initials</summary>
        public String Initials { get; set; }
        /// <summary>Indicates whether the contact is anonymised.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Byte IsAnonymised { get; set; }
        /// <summary>Indicates whether contacts are excluded from the marketing list</summary>
        public Boolean? IsMailingExcluded { get; set; }
        /// <summary>Indicates if this is the main contact of the linked account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Boolean? IsMainContact { get; set; }
        /// <summary>Jobtitle of the contact</summary>
        public String JobTitleDescription { get; set; }
        /// <summary>Language code</summary>
        public String Language { get; set; }
        /// <summary>Last name. Provide at least first name or last name to create a new contact</summary>
        public String LastName { get; set; }
        /// <summary>The user should be able to do a full text search on these notes to gather contacts for a marketing campaign</summary>
        public String MarketingNotes { get; set; }
        /// <summary>Middle name</summary>
        public String MiddleName { get; set; }
        /// <summary>Business phone of the contact</summary>
        public String Mobile { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of the last modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ModifierFullName { get; set; }
        /// <summary>Nationality</summary>
        public String Nationality { get; set; }
        /// <summary>Extra remarks</summary>
        public String Notes { get; set; }
        /// <summary>Opportunity that is linked to the contact person</summary>
        public Guid? Opportunity { get; set; }
        /// <summary>Last name of partner</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String PartnerName { get; set; }
        /// <summary>Middlename of partner</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String PartnerNamePrefix { get; set; }
        /// <summary>Reference to the personal information of this contact such as name, gender, address etc.</summary>
        public Guid? Person { get; set; }
        /// <summary>Phone of the contact</summary>
        public String Phone { get; set; }
        /// <summary>Phone extension of the contact</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String PhoneExtension { get; set; }
        /// <summary>This field is write-only. The picture can be downloaded through PictureUrl and PictureThumbnailUrl.</summary>
        public Byte[] Picture { get; set; }
        /// <summary>Filename of the picture</summary>
        public String PictureName { get; set; }
        /// <summary>Url to retrieve the picture thumbnail</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String PictureThumbnailUrl { get; set; }
        /// <summary>Url to retrieve the picture</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String PictureUrl { get; set; }
        /// <summary>Postcode</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String Postcode { get; set; }
        /// <summary>Social security number</summary>
        public String SocialSecurityNumber { get; set; }
        /// <summary>Start date</summary>
        public DateTime? StartDate { get; set; }
        /// <summary>State</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String State { get; set; }
        /// <summary>Title</summary>
        public String Title { get; set; }
    }
}