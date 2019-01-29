namespace ExactOnline.Client.Models.SystemBase
{
    using System;

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("Code")]
    public class Division
    {
        /// <summary>Address line 1</summary>
        public string AddressLine1 { get; set; }
        /// <summary>Address line 2</summary>
        public string AddressLine2 { get; set; }
        /// <summary>Address line 3</summary>
        public string AddressLine3 { get; set; }
        /// <summary>Chamber of commerce number</summary>
        public string ChamberOfCommerceNumber { get; set; }
        /// <summary>City</summary>
        public string City { get; set; }
        /// <summary>Primary key</summary>
        public Int32 Code { get; set; }
        /// <summary>Country of the division. Is used for determination of legislation</summary>
        public string Country { get; set; }
        /// <summary>Creation date</summary>
        public DateTime Created { get; set; }
        /// <summary>Default currency</summary>
        public string Currency { get; set; }
        /// <summary>True when this division is most recently used by the API</summary>
        public bool Current { get; set; }
        /// <summary>Owner account of the division</summary>
        public Guid? Customer { get; set; }
        /// <summary>Owner account code of the division</summary>
        public string CustomerCode { get; set; }
        /// <summary>Owner account name of the division</summary>
        public string CustomerName { get; set; }
        /// <summary>Description</summary>
        public string Description { get; set; }
        /// <summary>Email address</summary>
        public string Email { get; set; }
        /// <summary>Company number that is assigned by the customer</summary>
        public Int64 Hid { get; set; }
        /// <summary>True if the division is the main division</summary>
        public bool IsMainDivision { get; set; }
        /// <summary>Last modified date</summary>
        public DateTime Modified { get; set; }
        /// <summary>Phone number</summary>
        public string Phone { get; set; }
        /// <summary>Postcode</summary>
        public string Postcode { get; set; }
        /// <summary>State/Province code</summary>
        public string State { get; set; }
        /// <summary>Follow the Division Status 0 for Inactive, 1 for Active and 2 for Archived Divisions</summary>
        public Int32 Status { get; set; }
        /// <summary>The number under which the account is known at the Value Added Tax collection agency</summary>
        public string VATNumber { get; set; }
    }
}
