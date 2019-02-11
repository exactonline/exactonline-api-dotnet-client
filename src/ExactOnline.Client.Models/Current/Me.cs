using System;

namespace ExactOnline.Client.Models.Current
{
    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("UserID")]
    public class Me
    {
        /// <summary>Division number that is currently used in the API. You should use a division number in the url</summary>
        public Int32 CurrentDivision { get; set; }
        /// <summary>Owner account of the division</summary>
        public Guid? DivisionCustomer { get; set; }
        /// <summary>Owner account code of the division</summary>
        public string DivisionCustomerCode { get; set; }
        /// <summary>Owner account name of the division</summary>
        public string DivisionCustomerName { get; set; }
        /// <summary>Email address of the user</summary>
        public string Email { get; set; }
        /// <summary>Employee ID</summary>
        public Guid EmployeeID { get; set; }
        /// <summary>First name</summary>
        public string FirstName { get; set; }
        /// <summary>Full name of the user</summary>
        public string FullName { get; set; }
        /// <summary>Gender: M=Male, V=Female, O=Unknown</summary>
        public string Gender { get; set; }
        /// <summary>Initials</summary>
        public string Initials { get; set; }
        /// <summary>Language spoken by this user</summary>
        public string Language { get; set; }
        /// <summary>Language (culture) that is used in Exact Online</summary>
        public string LanguageCode { get; set; }
        /// <summary>Last name</summary>
        public string LastName { get; set; }
        /// <summary>Legislation</summary>
        public Int64 Legislation { get; set; }
        /// <summary>Middle name</summary>
        public string MiddleName { get; set; }
        /// <summary>Mobile phone</summary>
        public string Mobile { get; set; }
        /// <summary>Nationality</summary>
        public string Nationality { get; set; }
        /// <summary>Phone number</summary>
        public string Phone { get; set; }
        /// <summary>Phone number extension</summary>
        public string PhoneExtension { get; set; }
        /// <summary>Url that can be used to retrieve the picture of the user</summary>
        public string PictureUrl { get; set; }
        /// <summary>The current date and time in Exact Online</summary>
        public string ServerTime { get; set; }
        /// <summary>The time difference with UTC in seconds</summary>
        public double ServerUtcOffset { get; set; }
        /// <summary>Binary thumbnail picture of this user</summary>
        public byte[] ThumbnailPicture { get; set; }
        /// <summary>File type of the picture</summary>
        public string ThumbnailPictureFormat { get; set; }
        /// <summary>Title</summary>
        public string Title { get; set; }
        /// <summary>Primary key</summary>
        public Guid UserID { get; set; }
        /// <summary>Login name of the user</summary>
        public string UserName { get; set; }
    }
}
