namespace ExactOnline.Client.Sdk.Models
{
    using System.Collections.Generic;

    public class ApiList<T>
    {
        public ApiList(List<T> list, string skipToken)
        {
            List = list;
            SkipToken = skipToken;
        }

        public List<T> List { get; }
        public string SkipToken { get; }
    }
}
