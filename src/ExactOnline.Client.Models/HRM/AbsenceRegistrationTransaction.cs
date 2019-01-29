namespace ExactOnline.Client.Models.HRM
{
    using System;

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class AbsenceRegistrationTransaction
    {
        /// <summary>Reference key to Absence Registration</summary>
        public Guid AbsenceRegistration { get; set; }
        /// <summary>Creation date</summary>
        public DateTime Created { get; set; }
        /// <summary>User ID of creator</summary>
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        public string CreatorFullName { get; set; }
        /// <summary>Division code</summary>
        public Int32 Division { get; set; }
        /// <summary>End time on the last day of absence stored as DateTime, and the date should be ignored</summary>
        public DateTime? EndTime { get; set; }
        /// <summary>Expected end date of absence</summary>
        public DateTime? ExpectedEndDate { get; set; }
        /// <summary>Total number of absence hours</summary>
        public double Hours { get; set; }
        /// <summary>Hours of absence on the first day</summary>
        public double? HoursFirstDay { get; set; }
        /// <summary>Hours of absence on the last day</summary>
        public double? HoursLastDay { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Last modified date</summary>
        public DateTime Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        public string ModifierFullName { get; set; }
        /// <summary>Extra information for absence</summary>
        public string Notes { get; set; }
        /// <summary>Notification moment of absence</summary>
        public DateTime NotificationMoment { get; set; }
        /// <summary>Percentage disablement</summary>
        public double PercentageDisablement { get; set; }
        /// <summary>Start date of absence</summary>
        public DateTime StartDate { get; set; }
        /// <summary>Start time on the first day of absence stored as DateTime, and the date should be ignored</summary>
        public DateTime? StartTime { get; set; }
        /// <summary>Status of absence, 0 = Open, 1 = Recovered</summary>
        public Int16 Status { get; set; }
    }
}