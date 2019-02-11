namespace ExactOnline.Client.Models.Project
{
    using System;

    [SupportedActionsSDK(true, true, true, true)]
    [DataServiceKey("ID")]
    public class ProjectPlanning
    {
        /// <summary>Account linked to the project planning</summary>
        public Guid? Account { get; set; }
        /// <summary>Code of Account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String AccountCode { get; set; }
        /// <summary>Name of Account</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String AccountName { get; set; }
        /// <summary>Status of the project planning process, 1 = To be processed, 2 = Processed, 3 = Failed</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int16? BGTStatus { get; set; }
        /// <summary>Status of the external calendar, 0 = No error, 1 = Credentials error, 2 = Technical error, 3 = Both credentials &amp; technical errors, 4 = In progress</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int16? CommunicationErrorStatus { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String CreatorFullName { get; set; }
        /// <summary>Description of project planning</summary>
        public String Description { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>Employee linked to the project planning</summary>
        public Guid? Employee { get; set; }
        /// <summary>Code of employee</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String EmployeeCode { get; set; }
        /// <summary>Numeric ID of the employee</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? EmployeeHID { get; set; }
        /// <summary>End date of the project planning</summary>
        public DateTime? EndDate { get; set; }
        /// <summary>Hours of the project planning</summary>
        public Double? Hours { get; set; }
        /// <summary>The type of hour for the project planning, item with &apos;Time&apos; type</summary>
        public Guid? HourType { get; set; }
        /// <summary>Code of the hour type</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String HourTypeCode { get; set; }
        /// <summary>Description of the hour type</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String HourTypeDescription { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Indicates whether the project planning is separated from the recurring planning</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Boolean? IsBrokenRecurrence { get; set; }
        /// <summary>Date modified</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>Modifier user ID</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Modifier { get; set; }
        /// <summary>Modifier name</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ModifierFullName { get; set; }
        /// <summary>For additional information about project planning</summary>
        public String Notes { get; set; }
        /// <summary>Indicates whether the entries can have over allocated planning hours</summary>
        public Boolean? OverAllocate { get; set; }
        /// <summary>Project linked to the planning</summary>
        public Guid? Project { get; set; }
        /// <summary>Code of project</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ProjectCode { get; set; }
        /// <summary>Description of project</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ProjectDescription { get; set; }
        /// <summary>Recurring planning linked to the project planning</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? ProjectPlanningRecurring { get; set; }
        /// <summary>WBS linked to the project planning</summary>
        public Guid? ProjectWBS { get; set; }
        /// <summary>Description of WBS</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ProjectWBSDescription { get; set; }
        /// <summary>Start date of the project planning</summary>
        public DateTime? StartDate { get; set; }
        /// <summary>Status of the project planning, 1 = Reserved, 2 = Planned</summary>
        public Int16? Status { get; set; }
        /// <summary>Type of the project planning, it will always is 4 (employee)</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int16? Type { get; set; }
    }
}