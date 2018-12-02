using System.Collections.Generic;

namespace ExactOnline.Client.Sdk.Models
{
    public class ApiList<T>
    {
        public ApiList( List<T> list, string skipToken )
        {
            this.List = list;
            this.SkipToken = skipToken;
        }

        public List<T> List { get; }
        public string SkipToken { get; }
    }
}
