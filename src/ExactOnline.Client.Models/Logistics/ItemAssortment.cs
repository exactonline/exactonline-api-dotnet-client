using System;
using System.Collections.Generic;

namespace ExactOnline.Client.Models.Logistics
{
    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class ItemAssortment
    {
        /// <summary>Code of ItemAssortment</summary>
        public Int32 Code { get; set; }
        /// <summary>Description of ItemAssortment</summary>
        public String Description { get; set; }
        /// <summary>Division</summary>
        public Int32 Division { get; set; }
        /// <summary>ID of ItemAssortment</summary>
        public Guid ID { get; set; }
        /// <summary>Properties of this ItemAssortment</summary>
        public IEnumerable<ItemAssortmentProperty> Properties { get; set; }
    }
}
