namespace ExactOnline.Client.Sdk.Helpers
{
    public static class StringExtensions
    {
        public static int? ToNullableInt(this string s)
        {
            int i;
            if (int.TryParse(s, out i))
            {
                return i;
            }

            return null;
        }

        public static long? ToNullableLong(this string s)
        {
            long i;
            if (long.TryParse(s, out i))
            {
                return i;
            }

            return null;
        }
    }
}
