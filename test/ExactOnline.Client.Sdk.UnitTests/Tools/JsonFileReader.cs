using System;
using System.IO;
using System.Reflection;

namespace ExactOnline.Client.Sdk.UnitTests.Tools
{
	public class JsonFileReader
	{
		public static string GetJsonFromFile(string filename)
		{
			string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
			string filepath = path + Path.DirectorySeparatorChar  + "Json" + Path.DirectorySeparatorChar + filename;

			string text = "";
			try
			{
				using (StreamReader sr = new StreamReader(filepath))
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
			string text = GetJsonFromFile(filename);
			text = text.Replace(" ", string.Empty);
			text = text.Replace("\n", string.Empty);
			text = text.Replace("\r", string.Empty);
			return text;
		}
	}
}
