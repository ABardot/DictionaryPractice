using System.Collections.Generic;

namespace DictionaryPractice
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Syntax Dictionary <Key data type, value data type> dictionary
            Dictionary<string, int> studentGrades = new Dictionary<string, int>()
            {
                { "Kerry", 90 },
                { "Barry", 85 },
                { "Michelle", 100 }
            };
        }
    }
}