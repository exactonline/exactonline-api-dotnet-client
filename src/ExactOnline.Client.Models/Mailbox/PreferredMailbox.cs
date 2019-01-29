namespace ExactOnline.Client.Models.Mailbox
{
    using System;

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class PreferredMailbox
    {
        /// <summary>Creation date</summary>
        public DateTime Created { get; set; }
        /// <summary>User ID of creator</summary>
        public Guid? Creator { get; set; }
        /// <summary>Extra description of the mailbox</summary>
        public string Description { get; set; }
        /// <summary>Only used when this mailbox is used for one specific administration, for example invoices to this mailbox will only be booked in this administration</summary>
        public Int32? ForDivision { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Indicates whether this service is used for messages returned by the scanning service</summary>
        public bool IsScanServiceMailbox { get; set; }
        /// <summary>E-mail address-like format, for example johndoe@exactonline.nl</summary>
        public string Mailbox { get; set; }
        /// <summary>Last modified date</summary>
        public DateTime Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        public Guid? Modifier { get; set; }
        /// <summary>Date that this mailbox became valid</summary>
        public DateTime? ValidFrom { get; set; }
        /// <summary>Date that this mailbox will not be valid anymore</summary>
        public DateTime? ValidTo { get; set; }
    }
}