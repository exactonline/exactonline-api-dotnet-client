namespace ExactOnline.Client.Sdk.Helpers
{
    using System.Collections.Generic;

    public interface IJsonSerializer
    {
        void RegisterConverters(IEnumerable<IJsonConverter> converters);
        T ConvertToType<T>(IDictionary<string, object> dictionary);
        T Deserialize<T>(string input);
        string Serialize(object obj);
        string DefaultSerialize(object obj);
    }
}
