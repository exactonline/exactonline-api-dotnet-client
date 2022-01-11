using System;

namespace ExactOnline.Client.Models.Logistics
{
    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ItemID")]
    public class ItemExtraField
    {
        /// <summary>Description of the free field</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String Description { get; set; }
        /// <summary>Item Identidy</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid ItemID { get; set; }
        /// <summary>Item last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>Used to determine the unique free field name as FreeField{Number}, first of all this is used for the external communication</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Number { get; set; }
        /// <summary>The value store in free field</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String Value { get; set; }
    }
}
