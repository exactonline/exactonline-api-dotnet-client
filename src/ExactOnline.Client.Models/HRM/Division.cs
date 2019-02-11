namespace ExactOnline.Client.Models.HRM
{
    using System;

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("Code")]
    public class Division
    {
        /// <summary>Values: 0 = Not blocked 1 = Backup 2 = Conversion busy 3 = Conversion shadow 4 = Conversion waiting 5 = Copy data waiting 6 = Copy data buzy 100 = Wait for deletion 101 = Deleted 102 = Deletion failed</summary>
        public Int32? BlockingStatus { get; set; }
        /// <summary>First division classification. User should have access rights to view division classifications.</summary>
        public DivisionClass Class_01 { get; set; }
        /// <summary>Second division classification. User should have access rights to view division classifications.</summary>
        public DivisionClass Class_02 { get; set; }
        /// <summary>Third division classification. User should have access rights to view division classifications.</summary>
        public DivisionClass Class_03 { get; set; }
        /// <summary>Fourth division classification. User should have access rights to view division classifications.</summary>
        public DivisionClass Class_04 { get; set; }
        /// <summary>Fifth division classification. User should have access rights to view division classifications.</summary>
        public DivisionClass Class_05 { get; set; }
        /// <summary>Primary key</summary>
        public Int32 Code { get; set; }
        /// <summary>Country of the division. Is used for determination of legislation</summary>
        public string Country { get; set; }
        /// <summary>Description of Country</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CountryDescription { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of the creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        /// <summary>Default currency of the division</summary>
        public string Currency { get; set; }
        /// <summary>Description of Currency</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CurrencyDescription { get; set; }
        /// <summary>Owner account of the division</summary>
        public Guid? Customer { get; set; }
        /// <summary>Owner account code of the division</summary>
        public string CustomerCode { get; set; }
        /// <summary>Owner account name of the division</summary>
        public string CustomerName { get; set; }
        /// <summary>Description</summary>
        public string Description { get; set; }
        /// <summary>Number that customers give to the division</summary>
        public Int64? HID { get; set; }
        /// <summary>True for the main (hosting) division</summary>
        public bool? Main { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of the last modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        /// <summary>Siret Number of the division (France)</summary>
        public string SiretNumber { get; set; }
        /// <summary>Date on which the division becomes active</summary>
        public DateTime? StartDate { get; set; }
        /// <summary>Regular administrations will have status 0.  Currently, the only other possibility is &apos;archived&apos; (1), which means the administration is not actively used, but still needs to be accessible for the customer/accountant to meet legal obligations</summary>
        public Int16? Status { get; set; }
        /// <summary>Number of your local tax authority (Germany)</summary>
        public string TaxOfficeNumber { get; set; }
        /// <summary>Local tax reference number (Germany)</summary>
        public string TaxReferenceNumber { get; set; }
        /// <summary>VAT number</summary>
        public string VATNumber { get; set; }
        /// <summary>Customer value, hyperlink to external website</summary>
        public string Website { get; set; }
    }
}