namespace ExactOnline.Client.Models.HRM
{
    using System;

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class LeaveBuildUpRegistration
    {
        /// <summary>Creation date</summary>
        public DateTime Created { get; set; }
        /// <summary>User ID of creator</summary>
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        public string CreatorFullName { get; set; }
        /// <summary>Date of leave build up</summary>
        public DateTime Date { get; set; }
        /// <summary>Description of leave build up</summary>
        public string Description { get; set; }
        /// <summary>Division code</summary>
        public Int32? Division { get; set; }
        /// <summary>Employee linked to the leave build up</summary>
        public Guid Employee { get; set; }
        /// <summary>Employee full name</summary>
        public string EmployeeFullName { get; set; }
        /// <summary>Numeric ID of the employee</summary>
        public Int32 EmployeeHID { get; set; }
        /// <summary>Total number of leave build up hours</summary>
        public double Hours { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Type of leave</summary>
        public Guid LeaveType { get; set; }
        /// <summary>Code for type of leave</summary>
        public string LeaveTypeCode { get; set; }
        /// <summary>Description for type of leave</summary>
        public string LeaveTypeDescription { get; set; }
        /// <summary>Last modified date</summary>
        public DateTime Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        public string ModifierFullName { get; set; }
        /// <summary>Extra information for leave build up</summary>
        public string Notes { get; set; }
        /// <summary>Status of leave build up, 1 = Submitted, 2 = Approved, 3 = Rejected</summary>
        public Int16 Status { get; set; }
    }
}