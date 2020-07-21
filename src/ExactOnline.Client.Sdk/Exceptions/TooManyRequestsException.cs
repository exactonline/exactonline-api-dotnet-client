namespace ExactOnline.Client.Sdk.Exceptions
{
    using System;

    public class TooManyRequestsException : Exception
    {
        public TooManyRequestsException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
