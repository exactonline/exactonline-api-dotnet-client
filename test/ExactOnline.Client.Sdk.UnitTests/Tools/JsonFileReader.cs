namespace ExactOnline.Client.Sdk.UnitTests.Tools
{
    using System;
    using System.IO;
    using System.Reflection;

    public class JsonFileReader
    {
        public static string GetJsonFromFile(string filename)
        {
            var path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            var filepath = path + Path.DirectorySeparatorChar + "Json" + Path.DirectorySeparatorChar + filename;

            var text = "";
            try
            {
                using (var sr = new StreamReader(filepath))
                {
                    text = sr.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            return text;
        }

        public static string GetJsonFromFileWithoutWhiteSpace(string filename)
        {
            var text = GetJsonFromFile(filename);
            text = text.Replace(" ", string.Empty);
            text = text.Replace("\n", string.Empty);
            text = text.Replace("\r", string.Empty);
            return text;
        }
    }
}
