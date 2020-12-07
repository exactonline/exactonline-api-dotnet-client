namespace ExactOnline.Client.Sdk.Helpers
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class NewtonsoftJsonConverter : JsonConverter
    {
        private readonly IJsonConverter _converter;
        private readonly IJsonSerializer _serializer;

        public NewtonsoftJsonConverter(IJsonSerializer serializer, IJsonConverter converter)
        {
            _serializer = serializer;
            _converter = converter;
        }

        public override bool CanConvert(Type objectType)
        {
            foreach (var type in _converter.SupportedTypes)
            {
                if (type.IsAssignableFrom(objectType))
                {
                    return true;
                }
            }

            return false;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
            JsonSerializer serializer)
        {
            var value = ReadValue(reader);

            if (value == null)
            {
                return value;
            }

            if (!(value is IDictionary<string, object>))
            {
                throw new Exception("Expected dictionary but found a list");
            }

            value = _converter.Deserialize((IDictionary<string, object>)value, objectType, _serializer);

            return value;
        }

        private object ReadValue(JsonReader reader)
        {
            while (reader.TokenType == JsonToken.Comment)
            {
                if (!reader.Read())
                {
                    throw new Exception("Unexpected end.");
                }
            }

            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    return ReadObject(reader);
                case JsonToken.StartArray:
                    return ReadList(reader);
                default:
                    if (IsPrimitiveToken(reader.TokenType))
                    {
                        return reader.Value;
                    }

                    throw new Exception($"Unexpected token when converting to Dictionary: {reader.TokenType}");
            }
        }

        private bool IsPrimitiveToken(JsonToken token)
        {
            switch (token)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                case JsonToken.String:
                case JsonToken.Boolean:
                case JsonToken.Undefined:
                case JsonToken.Null:
                case JsonToken.Date:
                case JsonToken.Bytes:
                    return true;
                default:
                    return false;
            }
        }

        private object ReadList(JsonReader reader)
        {
            IList<object> list = new List<object>();

            while (reader.Read())
            {
                switch (reader.TokenType)
                {
                    case JsonToken.Comment:
                        break;
                    default:
                        var v = ReadValue(reader);

                        list.Add(v);
                        break;
                    case JsonToken.EndArray:
                        return list;
                }
            }

            throw new Exception("Unexpected end.");
        }

        private object ReadObject(JsonReader reader)
        {
            IDictionary<string, object> dictionary = new Dictionary<string, object>();

            while (reader.Read())
            {
                switch (reader.TokenType)
                {
                    case JsonToken.PropertyName:
                        var propertyName = reader.Value.ToString();

                        if (!reader.Read())
                        {
                            throw new Exception("Unexpected end.");
                        }

                        dictionary[propertyName] = ReadValue(reader);
                        break;
                    case JsonToken.Comment:
                        break;
                    case JsonToken.EndObject:
                        return dictionary;
                }
            }

            throw new Exception("Unexpected end.");
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var dictionary = _converter.Serialize(value, _serializer);
            serializer.Serialize(writer, dictionary);
        }
    }
}
