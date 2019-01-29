namespace ExactOnline.Client.Models.HRM
{
    using System;

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class DivisionClassValue
    {
        /// <summary>First classification</summary>
        public DivisionClass Class_01 { get; set; }
        /// <summary>First classification ID</summary>
        public Guid? Class_01_ID { get; set; }
        /// <summary>Second classification</summary>
        public DivisionClass Class_02 { get; set; }
        /// <summary>Second classification ID</summary>
        public Guid? Class_02_ID { get; set; }
        /// <summary>Third classification</summary>
        public DivisionClass Class_03 { get; set; }
        /// <summary>Third classification ID</summary>
        public Guid? Class_03_ID { get; set; }
        /// <summary>Fourth classification</summary>
        public DivisionClass Class_04 { get; set; }
        /// <summary>Fourth classification ID</summary>
        public Guid? Class_04_ID { get; set; }
        /// <summary>Fifth classification</summary>
        public DivisionClass Class_05 { get; set; }
        /// <summary>Fifth classification ID</summary>
        public Guid? Class_05_ID { get; set; }
        /// <summary>Creation date</summary>
        public DateTime Created { get; set; }
        /// <summary>User ID of creator</summary>
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        public string CreatorFullName { get; set; }
        /// <summary>ID of customer</summary>
        public Guid Customer { get; set; }
        /// <summary>Division code</summary>
        public Int32 Division { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Last modified date</summary>
        public DateTime Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        public string ModifierFullName { get; set; }
    }
}