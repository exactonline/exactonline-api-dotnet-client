using System.Collections.Generic;
using System;

namespace ExactOnline.Client.Models.GeneralJournalEntry
{
    [SupportedActionsSDK(true, true, false, false)]
    [DataServiceKey("EntryID")]
    public class GeneralJournalEntry
    {
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Created { get; set; }
        /// <summary>Currency code</summary>
        public string Currency { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Division { get; set; }
        /// <summary>Primary key</summary>
        public Guid EntryID { get; set; }
        /// <summary>Entry number</summary>
        public Int32? EntryNumber { get; set; }
        /// <summary>Exchange rate</summary>
        public double? ExchangeRate { get; set; }
        /// <summary>Financial period</summary>
        public Int16? FinancialPeriod { get; set; }
        /// <summary>Financial year</summary>
        public Int16? FinancialYear { get; set; }
        /// <summary>Collection of lines</summary>
        public IEnumerable<GeneralJournalEntryLine> GeneralJournalEntryLines { get; set; }
        /// <summary>Code of Journal</summary>
        public string JournalCode { get; set; }
        /// <summary>Description of Journal</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string JournalDescription { get; set; }
        /// <summary>Last modified date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? Modified { get; set; }
        /// <summary>Indicates that amounts are reversed</summary>
        public bool? Reversal { get; set; }
        /// <summary>Status: 5 = Rejected, 20 = Open, 50 = Processed</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int16? Status { get; set; }
        /// <summary>Description of Status</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string StatusDescription { get; set; }
        /// <summary>Type: 10 = Opening balance, 90 = Other</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32? Type { get; set; }
        /// <summary>Description of Type</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string TypeDescription { get; set; }
    }
}
