using System.Collections.Generic;
using System;

namespace ExactOnline.Client.Models.HRM
{
    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class AbsenceRegistration
    {
        /// <summary>Collection of absence registration transactions</summary>
        public IEnumerable<AbsenceRegistrationTransaction> AbsenceRegistrationTransactions { get; set; }
        /// <summary>Absence cause, only supported for the Netherland legislation</summary>
        public Int16? Cause { get; set; }
        /// <summary>Code for the absence cause, only supported for the Netherland legislation</summary>
        public string CauseCode { get; set; }
        /// <summary>Description for the absence cause, only supported for the Netherland legislation</summary>
        public string CauseDescription { get; set; }
        /// <summary>Creation date</summary>
        public DateTime Created { get; set; }
        /// <summary>User ID of creator</summary>
        public Guid? Creator { get; set; }
        /// <summary>Name of creator</summary>
        public string CreatorFullName { get; set; }
        /// <summary>Division code</summary>
        public Int32 Division { get; set; }
        /// <summary>Employee linked to the absence</summary>
        public Guid Employee { get; set; }
        /// <summary>Employee full name</summary>
        public string EmployeeFullName { get; set; }
        /// <summary>Numeric ID of the employee</summary>
        public Int32 EmployeeHID { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Absence kind, only supported for the Netherland legislation</summary>
        public Int16? Kind { get; set; }
        /// <summary>Code for the absence kind, only supported for the Netherland legislation</summary>
        public string KindCode { get; set; }
        /// <summary>Description for the absence kind, only supported for the Netherland legislation</summary>
        public string KindDescription { get; set; }
        /// <summary>Last modified date</summary>
        public DateTime Modified { get; set; }
        /// <summary>User ID of modifier</summary>
        public Guid? Modifier { get; set; }
        /// <summary>Name of modifier</summary>
        public string ModifierFullName { get; set; }
        /// <summary>Extra information for absence</summary>
        public string Notes { get; set; }
    }
}
