namespace ExactOnline.Client.Sdk.Exceptions
{
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public class BadRequestException : Exception // HTTP: 400
    {
        public BadRequestException() { }
        public BadRequestException(string message) : base(message) { }
        public BadRequestException(string message, Exception inner) : base(message, inner) { }

        protected BadRequestException(
            SerializationInfo info,
            StreamingContext context)
            : base(info, context)
        {
        }
    }
}
