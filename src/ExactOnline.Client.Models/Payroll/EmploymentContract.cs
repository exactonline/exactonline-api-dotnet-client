namespace ExactOnline.Client.Models.Payroll
{
    using System;

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class EmploymentContract
    {
        /// <summary>Flexible employment contract phase</summary>
        public Int32? ContractFlexPhase { get; set; }
        /// <summary>Flexible employment contract phase description.</summary>
        public String ContractFlexPhaseDescription { get; set; }
        /// <summary>Creation date</summary>
        public DateTime? Created { get; set; }
        /// <summary>User ID of creator</summary>
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        public String CreatorFullName { get; set; }
        /// <summary>Division code</summary>
        public Int32? Division { get; set; }
        /// <summary>Document ID of the employment contract</summary>
        public Guid? Document { get; set; }
        /// <summary>ID of employee</summary>
        public Guid? Employee { get; set; }
        /// <summary>Name of employee</summary>
        public String EmployeeFullName { get; set; }
        /// <summary>Numeric ID of the employee</summary>
        public Int32? EmployeeHID { get; set; }
        /// <summary>Type of employee. 1 - Employee, 2 - Contractor, 3 - Temporary, 4 - Student, 5 - Flexworker</summary>
        public Int32? EmployeeType { get; set; }
        /// <summary>Employee type description</summary>
        public String EmployeeTypeDescription { get; set; }
        /// <summary>Employment ID</summary>
        public Guid? Employment { get; set; }
        /// <summary>Numeric ID of the employment</summary>
        public Int32? EmploymentHID { get; set; }
        /// <summary>End date of employment contract</summary>
        public DateTime? EndDate { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Last modified date</summary>
        public DateTime? Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        public String ModifierFullName { get; set; }
        /// <summary>Notes of employment contract</summary>
        public String Notes { get; set; }
        /// <summary>Employment probation end date</summary>
        public DateTime? ProbationEndDate { get; set; }
        /// <summary>Employment probation period</summary>
        public Int32? ProbationPeriod { get; set; }
        /// <summary>Employment contract reason code. 1 - New employment, 2 - Employment change, 3 - New legal employer, 4 - Acquisition 5 - Previous contract expired, 6 - Other</summary>
        public Int32? ReasonContract { get; set; }
        /// <summary>Employment contract reason description</summary>
        public String ReasonContractDescription { get; set; }
        /// <summary>Sequence number</summary>
        public Int32? Sequence { get; set; }
        /// <summary>Start date of employment contract</summary>
        public DateTime? StartDate { get; set; }
        /// <summary>Type of employment contract. 1 - Definite, 2 - Indefinite, 3 - External</summary>
        public Int32? Type { get; set; }
        /// <summary>Description of employment contract type</summary>
        public String TypeDescription { get; set; }
    }
}