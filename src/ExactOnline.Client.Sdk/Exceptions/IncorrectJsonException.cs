namespace ExactOnline.Client.Sdk.Exceptions
{
    using System;

    [Serializable]
    public class IncorrectJsonException : Exception
    {
        public IncorrectJsonException()
        {
        }

        public IncorrectJsonException(string message)
            : base(message)
        {
        }
    }
}
