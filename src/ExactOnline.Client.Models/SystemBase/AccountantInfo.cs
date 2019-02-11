namespace ExactOnline.Client.Models.SystemBase
{
    using System;

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class AccountantInfo
    {
        /// <summary>First address line.</summary>
        public string AddressLine1 { get; set; }
        /// <summary>Second address line.</summary>
        public string AddressLine2 { get; set; }
        /// <summary>Third address line.</summary>
        public string AddressLine3 { get; set; }
        /// <summary>City.</summary>
        public string City { get; set; }
        /// <summary>Email.</summary>
        public string Email { get; set; }
        /// <summary>The account ID of the accountant.</summary>
        public Guid ID { get; set; }
        /// <summary>Indicates if the customer is an accountant himself.</summary>
        public bool IsAccountant { get; set; }
        /// <summary>Logo.</summary>
        public byte[] Logo { get; set; }
        /// <summary>Url to retrieve the logo of the accountant.</summary>
        public string MenuLogoUrl { get; set; }
        /// <summary>The name of the accountant.</summary>
        public string Name { get; set; }
        /// <summary>Phone.</summary>
        public string Phone { get; set; }
        /// <summary>Postcode.</summary>
        public string Postcode { get; set; }
        /// <summary>Website.</summary>
        public string Website { get; set; }
    }
}