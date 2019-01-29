namespace ExactOnline.Client.Models.HRM
{
    using System;

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class DivisionClass
    {
        /// <summary>Classification customer ID</summary>
        public Guid ClassNameCustomer { get; set; }
        /// <summary>Related classification description</summary>
        public string ClassNameDescription { get; set; }
        /// <summary>Related classification ID</summary>
        public Guid ClassNameID { get; set; }
        /// <summary>Property code</summary>
        public string Code { get; set; }
        /// <summary>Creation date</summary>
        public DateTime Created { get; set; }
        /// <summary>User ID of creator</summary>
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        public string CreatorFullName { get; set; }
        /// <summary>Property description</summary>
        public string Description { get; set; }
        /// <summary>Property description term ID</summary>
        public Int32? DescriptionTermID { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Last modified date</summary>
        public DateTime Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        public string ModifierFullName { get; set; }
        /// <summary>Related classification sequence number </summary>
        public Int32 SequenceNr { get; set; }
    }
}