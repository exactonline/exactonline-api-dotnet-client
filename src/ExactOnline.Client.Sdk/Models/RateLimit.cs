namespace ExactOnline.Client.Sdk.Models
{
    /// <summary>
    ///     If you exceed the shaping limit, all of your app API calls will be queued,
    ///     which will result in an increased response time for each API call.
    ///     Once you exceed the throttling limit, all of your app API calls will be blocked,
    ///     and you will receive an HTTP 429 (Too many requests) including following HTTP response headers
    ///     more info: https://support.exactonline.com/community/s/knowledge-base#All-All-DNO-Simulation-gen-apilimits
    /// </summary>
    public class RateLimit
    {
        /// <summary>
        ///     The maximum number of API calls you're permitted to make per app, per company, per 24-hour window.
        /// </summary>
        public int? Limit { get; set; }

        /// <summary>
        ///     The number of API calls remaining within the rate limit window of an app and company.
        /// </summary>
        public int? Remaining { get; set; }

        /// <summary>
        ///     The time at which the rate limit window resets in UTC epoch seconds.
        /// </summary>
        public long? Reset { get; set; }
    }
}
