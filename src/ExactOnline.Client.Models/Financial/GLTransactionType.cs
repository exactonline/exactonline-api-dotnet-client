namespace ExactOnline.Client.Models.Financial
{
    using System;

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class GLTransactionType
    {
        public string Description { get; set; }
        public string DescriptionSuffix { get; set; }
        public Int32 ID { get; set; }
    }
}