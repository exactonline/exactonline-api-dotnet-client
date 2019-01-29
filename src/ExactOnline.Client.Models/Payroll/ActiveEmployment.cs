using System;

namespace ExactOnline.Client.Models.Payroll
{
    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class ActiveEmployment
    {
        /// <summary>The average number of contract days that an employee works per week</summary>
        public Double? AverageDaysPerWeek { get; set; }
        /// <summary>The average number of contract hours that an employee works per week</summary>
        public Double? AverageHoursPerWeek { get; set; }
        /// <summary>Employment contract ID</summary>
        public Guid? Contract { get; set; }
        /// <summary>Document ID of the employment contract</summary>
        public Guid? ContractDocument { get; set; }
        /// <summary>End date of employment contract</summary>
        public DateTime? ContractEndDate { get; set; }
        /// <summary>Employment probation end date</summary>
        public DateTime? ContractProbationEndDate { get; set; }
        /// <summary>Employment probation period</summary>
        public Int32? ContractProbationPeriod { get; set; }
        /// <summary>Start date of employment contract</summary>
        public DateTime? ContractStartDate { get; set; }
        /// <summary>Type of employment contract. 1 - Definite, 2 - Indefinite, 3 - External</summary>
        public Int32? ContractType { get; set; }
        /// <summary>Description of employment contract type</summary>
        public String ContractTypeDescription { get; set; }
        /// <summary>Creation date</summary>
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        public String CreatorFullName { get; set; }
        /// <summary>Department of employee</summary>
        public Guid? Department { get; set; }
        /// <summary>Department code of employee</summary>
        public String DepartmentCode { get; set; }
        /// <summary>Description of department</summary>
        public String DepartmentDescription { get; set; }
        /// <summary>Division code</summary>
        public Int32? Division { get; set; }
        /// <summary>Employee ID</summary>
        public Guid? Employee { get; set; }
        /// <summary>Name of employee</summary>
        public String EmployeeFullName { get; set; }
        /// <summary>Numeric number of Employee</summary>
        public Int32? EmployeeHID { get; set; }
        /// <summary>Organization of employment</summary>
        public Guid? EmploymentOrganization { get; set; }
        /// <summary>End date of employment</summary>
        public DateTime? EndDate { get; set; }
        /// <summary>Numeric ID of the employment</summary>
        public Int32? HID { get; set; }
        /// <summary>Hourly wage</summary>
        public Double? HourlyWage { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Internal rate for time &amp; billing or professional service user</summary>
        public Double? InternalRate { get; set; }
        /// <summary>Job title of employee</summary>
        public Guid? Jobtitle { get; set; }
        /// <summary>Description of job title</summary>
        public String JobtitleDescription { get; set; }
        /// <summary>Last modified date</summary>
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        public String ModifierFullName { get; set; }
        /// <summary>ID of employment ended</summary>
        public Int32? ReasonEnd { get; set; }
        /// <summary>Reason of end of employment</summary>
        public String ReasonEndDescription { get; set; }
        /// <summary>Reason of ended flexible employment</summary>
        public Int32? ReasonEndFlex { get; set; }
        /// <summary>Other reason for end of employment</summary>
        public String ReasonEndFlexDescription { get; set; }
        /// <summary>Employment salary</summary>
        public Guid? Salary { get; set; }
        /// <summary>Work schedule</summary>
        public Guid? Schedule { get; set; }
        /// <summary>Average hours per week in a schedule.</summary>
        public Double? ScheduleAverageHours { get; set; }
        /// <summary>Work schedule code</summary>
        public String ScheduleCode { get; set; }
        /// <summary>Number of days of work per week</summary>
        public Double? ScheduleDays { get; set; }
        /// <summary>Description of work schedule</summary>
        public String ScheduleDescription { get; set; }
        /// <summary>Number of work hours per week.</summary>
        public Double? ScheduleHours { get; set; }
        /// <summary>Start date of employment</summary>
        public DateTime? StartDate { get; set; }
        /// <summary>Start date of the employee in the organization. This field is used to count the years in service.</summary>
        public DateTime? StartDateOrganization { get; set; }
    }
}
