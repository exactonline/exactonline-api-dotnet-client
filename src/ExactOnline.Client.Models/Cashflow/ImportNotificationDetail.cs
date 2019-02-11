using System;

namespace ExactOnline.Client.Models.Cashflow
{
    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class ImportNotificationDetail
    {
        /// <summary>ID of the notification these details belong to.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid CashflowImportNotification { get; set; }
        /// <summary>ID of the cashflow transaction feed related to this notification.</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? CashflowTransactionFeed { get; set; }
        /// <summary>Creation date</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime Created { get; set; }
        /// <summary>Division code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }
        /// <summary>Primary key</summary>
        public Guid ID { get; set; }
        /// <summary>Termed message</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String Message { get; set; }
        /// <summary>Response code</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Int16 ResponseCode { get; set; }
        /// <summary>Additional information about the response</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public String ResponseCodeArguments { get; set; }
    }
}
