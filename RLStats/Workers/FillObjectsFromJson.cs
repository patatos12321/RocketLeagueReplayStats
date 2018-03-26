using QuickType;
using System.IO;


namespace RLStats.Workers
{
    public class FillObjectsFromJson
    {
        public static Welcome Work(string filename)
        {
            string jsonText = File.ReadAllText(filename);
            var welcome = Welcome.FromJson(jsonText);
            return welcome;
        }
    }
}
