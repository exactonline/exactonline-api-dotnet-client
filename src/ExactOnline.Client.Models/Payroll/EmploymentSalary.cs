namespace ExactOnline.Client.Models.Payroll
{
    using System;

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class EmploymentSalary
    {
        /// <summary>The average number of contract days that an employee works per week</summary>
        public Double? AverageDaysPerWeek { get; set; }
        /// <summary>The average number of contract hours that an employee works per week</summary>
        public Double? AverageHoursPerWeek { get; set; }
        /// <summary>Creation date</summary>
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        public String CreatorFullName { get; set; }
        /// <summary>Division code</summary>
        public Int32? Division { get; set; }
        /// <summary>Employee ID</summary>
        public Guid? Employee { get; set; }
        /// <summary>Name of employee</summary>
        public String EmployeeFullName { get; set; }
        /// <summary>Employee number</summary>
        public Int32? EmployeeHID { get; set; }
        /// <summary>Employment</summary>
        public Guid? Employment { get; set; }
        /// <summary>Employment number</summary>
        public Int32? EmploymentHID { get; set; }
        /// <summary>Salary type of employment. 1 - Periodical (fixed), 2 - Per hour (variable)</summary>
        public Int32? EmploymentSalaryType { get; set; }
        /// <summary>Salary type description</summary>
        public String EmploymentSalaryTypeDescription { get; set; }
        /// <summary>Salary record end date</summary>
        public DateTime? EndDate { get; set; }
        /// <summary>Salary when working fulltime</summary>
        public Double? FulltimeAmount { get; set; }
        /// <summary>Hourly wage</summary>
        public Double? HourlyWage { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Internal rate for time &amp; billing or professional service user</summary>
        public Double? InternalRate { get; set; }
        /// <summary>Employee job level in context of a wage scale</summary>
        public Int32? JobLevel { get; set; }
        /// <summary>Last modified date</summary>
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        public String ModifierFullName { get; set; }
        /// <summary>Salary when working parttime</summary>
        public Double? ParttimeAmount { get; set; }
        /// <summary>Contract hours / Fulltime contract hours</summary>
        public Double? ParttimeFactor { get; set; }
        /// <summary>Employee wage scale</summary>
        public String Scale { get; set; }
        /// <summary>Employment schedule</summary>
        public Guid? Schedule { get; set; }
        /// <summary>Employment schedule code</summary>
        public String ScheduleCode { get; set; }
        /// <summary>Description of employment schedule</summary>
        public String ScheduleDescription { get; set; }
        /// <summary>Salary record start date</summary>
        public DateTime? StartDate { get; set; }
    }
}