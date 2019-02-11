namespace ExactOnline.Client.Models.Logistics
{
    using System;

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class Unit
    {
        /// <summary>Indicates whether a unit is in use</summary>
        public Boolean? Active { get; set; }
        /// <summary>Unique code for the unit</summary>
        public String Code { get; set; }
        /// <summary>Description</summary>
        public String Description { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Indicates the main unit per division. Will be used when creating new item</summary>
        public Byte? Main { get; set; }
        /// <summary>If Type = &apos;T&apos; (time) then this fields indicates the type of time frame. yy = Year, mm = Month, wk = Week, dd = Day, hh = Hour, mi = Minute, ss = Second</summary>
        public String TimeUnit { get; set; }
        /// <summary>Type of unit. Type &apos;Time&apos; is especially important for contracts.</summary>
        public String Type { get; set; }
    }
}