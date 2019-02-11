using System;

namespace ExactOnline.Client.Models.CRM
{
    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class ReasonCode
    {
        /// <summary>Indicates if the reason code is active.</summary>
        public Byte? Active { get; set; }
        /// <summary>Code of the reason.</summary>
        public String Code { get; set; }
        /// <summary>Creation date.</summary>
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of creator.</summary>
        public String CreatorFullName { get; set; }
        /// <summary>Description of the reason code.</summary>
        public String Description { get; set; }
        /// <summary>Division code.</summary>
        public Int32? Division { get; set; }
        /// <summary>Primary key.</summary>
        public Guid ID { get; set; }
        /// <summary>Last modified date.</summary>
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier.</summary>
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier.</summary>
        public String ModifierFullName { get; set; }
        /// <summary>Extra notes.</summary>
        public String Notes { get; set; }
        /// <summary>Type of the reason code.</summary>
        public Int16? Type { get; set; }
        /// <summary>Description of the type of the reason code.</summary>
        public String TypeDescription { get; set; }
    }
}