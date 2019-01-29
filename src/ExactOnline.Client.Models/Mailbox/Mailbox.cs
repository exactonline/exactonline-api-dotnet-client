using System;

namespace ExactOnline.Client.Models.Mailbox
{
    using Newtonsoft.Json;

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class Mailbox
    {
        /// <summary>The account this mailbox belongs to. Can be empty if the owner of the mailbox isn&apos;t an Exact Online customer yet</summary>
        public Guid? Account { get; set; }
        /// <summary>Name of Account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string AccountName { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatorFullName { get; set; }
        /// <summary>Extra description of the mailbox</summary>
        public string Description { get; set; }
        /// <summary>Only used when this mailbox is used for one specific administration, for example invoices to this mailbox will only be booked in this administration</summary>
        public Int32? ForDivision { get; set; }
        /// <summary>Description of ForDivision</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ForDivisionDescription { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>E-mail address-like format, for example johndoe@exactonline.nl</summary>
        [JsonProperty(PropertyName = "mailbox")]
        public string MailboxName { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ModifierFullName { get; set; }
        /// <summary>Customers can decide if they want this mailbox to be visible by all. i.e. some other customer can see this in address maintenance for digital postbox of type Exact</summary>
        public byte Publish { get; set; }
        /// <summary>Type of mailbox. Exact / Government / Manual</summary>
        public Int16? Type { get; set; }
        /// <summary>Date that this mailbox became valid</summary>
        public DateTime? ValidFrom { get; set; }
        /// <summary>Date that this mailbox will not be valid anymore</summary>
        public DateTime? ValidTo { get; set; }
    }
}
