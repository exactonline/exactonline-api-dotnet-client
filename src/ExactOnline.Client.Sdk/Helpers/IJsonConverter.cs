namespace ExactOnline.Client.Sdk.Helpers
{
    using System;
    using System.Collections.Generic;

    public interface IJsonConverter
    {
        IEnumerable<Type> SupportedTypes { get; }
        object Deserialize(IDictionary<string, object> dictionary, Type type, IJsonSerializer serializer);
        IDictionary<string, object> Serialize(object obj, IJsonSerializer serializer);
    }
}
