namespace ExactOnline.Client.Models.SystemBase
{
    using System;

    [SupportedActionsSDK(false, true, false, false)]
    [DataServiceKey("ID")]
    public class AvailableFeature
    {
        /// <summary>The description of the feature.</summary>
        public string Description { get; set; }
        /// <summary>The ID of the feature.</summary>
        public Int32 ID { get; set; }
    }
}