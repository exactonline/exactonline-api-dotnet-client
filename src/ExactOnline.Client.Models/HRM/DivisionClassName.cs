namespace ExactOnline.Client.Models.HRM
{
    using System;
    using System.Collections.Generic;

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class DivisionClassName
    {
        /// <summary>Creation date</summary>
        public DateTime Created { get; set; }
        /// <summary>User ID of creator</summary>
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        public string CreatorFullName { get; set; }
        /// <summary>ID of customer</summary>
        public Guid Customer { get; set; }
        /// <summary>Description of classification</summary>
        public string Description { get; set; }
        /// <summary>Term ID of the classification</summary>
        public Int32? DescriptionTermID { get; set; }
        /// <summary>Collection of classification properties</summary>
        public IEnumerable<DivisionClass> DivisionClasses { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Last modified date</summary>
        public DateTime Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        public string ModifierFullName { get; set; }
        /// <summary>Sequence number</summary>
        public Int32 SequenceNr { get; set; }
    }
}