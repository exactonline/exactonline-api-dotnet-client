namespace ExactOnline.Client.Models.Accountancy
{
    using System;

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class SolutionLink
    {
        /// <summary>ID of account to which solution is linked</summary>
        public Guid Account { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        /// <summary>User ID of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Accountant main division</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        /// <summary>If type is external predefined, represents ID of PracticeManagementExternalSolutions (mandatory for External solution)</summary>
        public Int32? ExternalSolutionCode { get; set; }
        /// <summary>Name of the external solution</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ExternalSolutionName { get; set; }
        /// <summary>Customer URl in external solution, like solution.com/id123 (mandatory for External and ExternalOther solution)</summary>
        public string ExternalSolutionUrl { get; set; }
        /// <summary>Primary key</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid ID { get; set; }
        /// <summary>Division code of linked internal solution (mandatory for Internal solution)</summary>
        public Int32? InternalSolutionDivision { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Name of the solution link</summary>
        public string Name { get; set; }
        /// <summary>Name of the custom external solution (mandatory for ExternalOther solution)</summary>
        public string OtherExternalSolutionName { get; set; }
        /// <summary>Type of solution: 0 - Internal(EOL), 1 - External(Wellknown solution), 2 - ExternalOther</summary>
        public Int32 SolutionType { get; set; }
        /// <summary>Link status: 0 - Active, 1 - Inactive, 2 -Archived</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Status { get; set; }
    }
}