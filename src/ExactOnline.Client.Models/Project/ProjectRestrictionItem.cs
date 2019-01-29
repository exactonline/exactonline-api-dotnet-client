namespace ExactOnline.Client.Models.Project
{
    using System;

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class ProjectRestrictionItem
    {
        /// <summary>Date created</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>Creator user ID</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Creator name</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String CreatorFullName { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Item linked to the restriction</summary>
        public Guid? Item { get; set; }
        /// <summary>Item code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ItemCode { get; set; }
        /// <summary>Description of the item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ItemDescription { get; set; }
        /// <summary>Indicates if the item is a time unit item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Byte? ItemIsTime { get; set; }
        /// <summary>Date modified</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>Modifier user ID</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Modifier name</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ModifierFullName { get; set; }
        /// <summary>Project linked to the restriction</summary>
        public Guid? Project { get; set; }
        /// <summary>Project code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ProjectCode { get; set; }
        /// <summary>Project description</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ProjectDescription { get; set; }
    }
}