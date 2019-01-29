using System;

namespace ExactOnline.Client.Models.Webhooks
{
    [SupportedActionsSDK(true, true, false, true)]
    [DataServiceKey("ID")]
    public class WebhookSubscription
    {
        public Guid ID { get; set; }
        public string CallbackURL { get; set; }
        public string Topic { get; set; }
    }
}
