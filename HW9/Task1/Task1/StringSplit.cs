using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task1
{
    class StringSplit
    {
        private string _splittingString;
        public string[] Words { get; set; }

        public StringSplit(string splittingString)
        {
            _splittingString = splittingString;
        }

        public string[] GetWords()
        {
            Words = new[] { String.Join("\n", _splittingString.ToLower().Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).Distinct()) };
            return Words;
        }

        public string GetWordsWithCount()
        {
            Words = _splittingString.ToLower().Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            string result = "";

            for (int i = 0; i < Words.Length; i++)
            {
                Regex Regex = new Regex(Words[i], RegexOptions.IgnoreCase);
                MatchCollection matches = Regex.Matches(_splittingString);

                if (matches.Count > 0)
                {
                    result += Words[i] + ": " + matches.Count + "\n";
                }
            }

            return result;
        }

        public void PrintWords(string[] str)
        {
            foreach (var s in str)
            {
                Console.WriteLine(s);
            }
        }

        public void PrintWordsWithCount(string str)
        {
            foreach (var s in str.ToLower().Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries).Distinct())
            {
                Console.WriteLine(s);
            }
        }
    }
}
