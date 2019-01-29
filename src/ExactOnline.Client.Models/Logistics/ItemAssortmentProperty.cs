using System;

namespace ExactOnline.Client.Models.Logistics
{
    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class ItemAssortmentProperty
    {
        /// <summary>Code of Property</summary>
        public String Code { get; set; }
        /// <summary>Description of Property</summary>
        public String Description { get; set; }
        /// <summary>Division</summary>
        public Int32 Division { get; set; }
        /// <summary>ID of Property</summary>
        public Guid ID { get; set; }
        /// <summary>Code of ItemAssortment</summary>
        public Int32 ItemAssortmentCode { get; set; }
    }
}
