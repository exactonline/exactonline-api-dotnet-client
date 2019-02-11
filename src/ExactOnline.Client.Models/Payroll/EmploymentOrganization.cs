namespace ExactOnline.Client.Models.Payroll
{
    using System;

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class EmploymentOrganization
    {
        /// <summary>Cost center code</summary>
        public String CostCenter { get; set; }
        /// <summary>Description of cost center</summary>
        public String CostCenterDescription { get; set; }
        /// <summary>Cost unit code</summary>
        public String CostUnit { get; set; }
        /// <summary>Description of cost unit</summary>
        public String CostUnitDescription { get; set; }
        /// <summary>Creation date</summary>
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        public String CreatorFullName { get; set; }
        /// <summary>ID of department</summary>
        public Guid? Department { get; set; }
        /// <summary>Department code</summary>
        public String DepartmentCode { get; set; }
        /// <summary>Department description for organization</summary>
        public String DepartmentDescription { get; set; }
        /// <summary>Division code</summary>
        public Int32? Division { get; set; }
        /// <summary>ID of employee</summary>
        public Guid? Employee { get; set; }
        /// <summary>Name of employee</summary>
        public String EmployeeFullName { get; set; }
        /// <summary>Numeric ID of the employee</summary>
        public Int32? EmployeeHID { get; set; }
        /// <summary>Employement ID</summary>
        public Guid? Employment { get; set; }
        /// <summary>Numeric ID of the employment</summary>
        public Int32? EmploymentHID { get; set; }
        /// <summary>Organization end date</summary>
        public DateTime? EndDate { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>ID of job title</summary>
        public Guid? JobTitle { get; set; }
        /// <summary>Job title code</summary>
        public String JobTitleCode { get; set; }
        /// <summary>Job title description</summary>
        public String JobTitleDescription { get; set; }
        /// <summary>Last modified date</summary>
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        public String ModifierFullName { get; set; }
        /// <summary>Explanation or extra information can be stored in the notes</summary>
        public String Notes { get; set; }
        /// <summary>Organization start date</summary>
        public DateTime? StartDate { get; set; }
    }
}