namespace ExactOnline.Client.Models.Subscription
{
    using System;

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class SubscriptionLineType
    {
        /// <summary>Description</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string Description { get; set; }
        /// <summary>Primary key</summary>
        public Int16 ID { get; set; }
    }
}