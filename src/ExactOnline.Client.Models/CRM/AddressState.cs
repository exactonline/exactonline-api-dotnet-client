namespace ExactOnline.Client.Models.CRM
{
    using System;

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class AddressState
    {
        /// <summary>Country code</summary>
        public String Country { get; set; }
        /// <summary>Description of state prefixed with the code</summary>
        public String DisplayValue { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Latitude</summary>
        public Double? Latitude { get; set; }
        /// <summary>Longitude</summary>
        public Double? Longitude { get; set; }
        /// <summary>State name</summary>
        public String Name { get; set; }
        /// <summary>State code</summary>
        public String State { get; set; }
    }
}