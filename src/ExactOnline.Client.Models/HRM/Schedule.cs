namespace ExactOnline.Client.Models.HRM
{
    using System;

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class Schedule
    {
        /// <summary>Obsolete</summary>
        public byte? Active { get; set; }
        /// <summary>Average hours per week in a schedule</summary>
        public double? AverageHours { get; set; }
        /// <summary>Schedule code</summary>
        public string Code { get; set; }
        /// <summary>Creation date</summary>
        public DateTime? Created { get; set; }
        /// <summary>ID of creator</summary>
        public Guid? Creator { get; set; }
        /// <summary>Name of the creator</summary>
        public string CreatorFullName { get; set; }
        /// <summary>Average days per week in the schedule</summary>
        public double? Days { get; set; }
        /// <summary>Description of the schedule</summary>
        public string Description { get; set; }
        /// <summary>Division code</summary>
        public Int32? Division { get; set; }
        /// <summary>Employment ID for schedule</summary>
        public Guid? Employment { get; set; }
        /// <summary>Employment number</summary>
        public Int32? EmploymentHID { get; set; }
        /// <summary>End date of the schedule</summary>
        public DateTime? EndDate { get; set; }
        /// <summary>Number of hours per week in a CLA for which the schedule is built</summary>
        public double? Hours { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Number of hours which are built up each week for later leave</summary>
        public double? LeaveHoursCompensation { get; set; }
        /// <summary>Indication if the schedule is a main schedule for a CLA. 1 = Yes, 0 = No</summary>
        public byte? Main { get; set; }
        /// <summary>Last modified date</summary>
        public DateTime? Modified { get; set; }
        /// <summary>ID of modifier</summary>
        public Guid? Modifier { get; set; }
        /// <summary>Name of the modifier</summary>
        public string ModifierFullName { get; set; }
        /// <summary>Part-time factor for payroll calculation. Value between 0 and 1</summary>
        public double? PaymentParttimeFactor { get; set; }
        /// <summary>Type of schedule. 1 = Hours and average days, 2 = Hours and specific days, 3 = Hours per day, 4 = Time frames per day</summary>
        public Int32? ScheduleType { get; set; }
        /// <summary>Description of the schedule type</summary>
        public string ScheduleTypeDescription { get; set; }
        /// <summary>Week in the schedule which is used to start with. By default the number will be 1.</summary>
        public DateTime? StartDate { get; set; }
        /// <summary>Week to start the schedule from for an employee</summary>
        public Int32? StartWeek { get; set; }
    }
}