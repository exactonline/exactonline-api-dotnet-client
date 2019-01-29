namespace ExactOnline.Client.Models.Payroll
{
    using System;

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class Employee
    {
        /// <summary>Obsolete</summary>
        public Byte? ActiveEmployment { get; set; }
        /// <summary>Second address line</summary>
        public String AddressLine2 { get; set; }
        /// <summary>Third address line</summary>
        public String AddressLine3 { get; set; }
        /// <summary>Street of address</summary>
        public String AddressStreet { get; set; }
        /// <summary>Street number of address</summary>
        public String AddressStreetNumber { get; set; }
        /// <summary>Street number suffix of address</summary>
        public String AddressStreetNumberSuffix { get; set; }
        /// <summary>Birth date</summary>
        public DateTime? BirthDate { get; set; }
        /// <summary>Birth name</summary>
        public String BirthName { get; set; }
        /// <summary>Birth middle name</summary>
        public String BirthNamePrefix { get; set; }
        /// <summary>Birth place</summary>
        public String BirthPlace { get; set; }
        /// <summary>Email of the employee at the office</summary>
        public String BusinessEmail { get; set; }
        /// <summary>Fax number of the employee at the office</summary>
        public String BusinessFax { get; set; }
        /// <summary>Office mobile number of the employee</summary>
        public String BusinessMobile { get; set; }
        /// <summary>Phone number of the employee at the office</summary>
        public String BusinessPhone { get; set; }
        /// <summary>Phone extension of the employee at the office</summary>
        public String BusinessPhoneExtension { get; set; }
        /// <summary>Obsolete</summary>
        public String CASONumber { get; set; }
        /// <summary>City</summary>
        public String City { get; set; }
        /// <summary>Code of the employee</summary>
        public String Code { get; set; }
        /// <summary>Country code</summary>
        public String Country { get; set; }
        /// <summary>Creation date</summary>
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        public String CreatorFullName { get; set; }
        /// <summary>Customer ID</summary>
        public Guid? Customer { get; set; }
        /// <summary>Division code</summary>
        public Int32? Division { get; set; }
        /// <summary>Email address</summary>
        public String Email { get; set; }
        /// <summary>Employee number</summary>
        public Int32? EmployeeHID { get; set; }
        /// <summary>End date of the employee</summary>
        public DateTime? EndDate { get; set; }
        /// <summary>First name of the employee</summary>
        public String FirstName { get; set; }
        /// <summary>Full name of the employee</summary>
        public String FullName { get; set; }
        /// <summary>Gender</summary>
        public String Gender { get; set; }
        /// <summary>Numeric ID of the employee</summary>
        public Int32? HID { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Initials</summary>
        public String Initials { get; set; }
        /// <summary>IsActive</summary>
        public Boolean IsActive { get; set; }
        /// <summary>Indicates whether the employee is anonymised.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Byte IsAnonymised { get; set; }
        /// <summary>Language code</summary>
        public String Language { get; set; }
        /// <summary>Last name</summary>
        public String LastName { get; set; }
        /// <summary>Description of the location of the employee (where am I?)</summary>
        public String LocationDescription { get; set; }
        /// <summary>Direct manager of the employee</summary>
        public Guid? Manager { get; set; }
        /// <summary>Date of marriage</summary>
        public DateTime? MaritalDate { get; set; }
        /// <summary>Marital status</summary>
        public Int16? MaritalStatus { get; set; }
        /// <summary>Middle name</summary>
        public String MiddleName { get; set; }
        /// <summary>Mobile phone</summary>
        public String Mobile { get; set; }
        /// <summary>Last modified date</summary>
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        public String ModifierFullName { get; set; }
        /// <summary>Municipality</summary>
        public String Municipality { get; set; }
        public Int16? NameComposition { get; set; }
        /// <summary>Nationality</summary>
        public String Nationality { get; set; }
        /// <summary>Nick name</summary>
        public String NickName { get; set; }
        /// <summary>Additional notes</summary>
        public String Notes { get; set; }
        /// <summary>Name of partner</summary>
        public String PartnerName { get; set; }
        /// <summary>Middle name of partner</summary>
        public String PartnerNamePrefix { get; set; }
        /// <summary>Reference to the persons table in which the personal data of the employee is stored</summary>
        public Guid? Person { get; set; }
        /// <summary>Phone number</summary>
        public String Phone { get; set; }
        /// <summary>Phone number extension</summary>
        public String PhoneExtension { get; set; }
        /// <summary>Filename of picture</summary>
        public String PictureFileName { get; set; }
        /// <summary>Url of picture</summary>
        public String PictureUrl { get; set; }
        /// <summary>Postcode</summary>
        public String Postcode { get; set; }
        /// <summary>Private email address</summary>
        public String PrivateEmail { get; set; }
        /// <summary>Social security number</summary>
        public String SocialSecurityNumber { get; set; }
        /// <summary>Start date of the employee</summary>
        public DateTime? StartDate { get; set; }
        /// <summary>State</summary>
        public String State { get; set; }
        /// <summary>Title</summary>
        public String Title { get; set; }
        /// <summary>User ID of employee</summary>
        public Guid? User { get; set; }
        /// <summary>Name of user</summary>
        public String UserFullName { get; set; }
    }
}