namespace ExactOnline.Client.Sdk.Helpers
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class NewtonsoftJsonSerializer : IJsonSerializer
    {
        private readonly JsonSerializerSettings _settings = new JsonSerializerSettings();

        public void RegisterConverters(IEnumerable<IJsonConverter> converters)
        {
            foreach (var converter in converters)
            {
                _settings.Converters.Add(new NewtonsoftJsonConverter(this, converter));
            }
        }

        public T ConvertToType<T>(IDictionary<string, object> dictionary)
        {
            var intermediate = JsonConvert.SerializeObject(dictionary);
            return JsonConvert.DeserializeObject<T>(intermediate);
        }

        public T Deserialize<T>(string input)
        {
            return JsonConvert.DeserializeObject<T>(input, _settings);
        }

        public string Serialize(object obj)
        {
            return JsonConvert.SerializeObject(obj, Formatting.None, _settings);
        }

        public string DefaultSerialize(object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
    }
}
