using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task_3
{
    class WordsCounter
    {
        Dictionary<string, int> WordsDictionary = new Dictionary<string, int>();

        public WordsCounter(string text)
        {

            string[] words = GetWordsFromText(text);
            for (int i = 0; i < words.Length; i++)
            {
                if (WordsDictionary.ContainsKey(words[i]))
                {
                    WordsDictionary[words[i]]++;
                }
                else
                {
                    WordsDictionary.Add(words[i], 1);
                }
            }
        }

        public string GetKeyWords()
        {
            return stringMaker(WordsDictionary);
        }

        private string[] GetWordsFromText(string allText)
        {
            allText = allText.ToLower();
            string pattern = @"[\p{P}||\r+||\n||\p{Pd}]";
            string replacement = " ";
            string result = Regex.Replace(allText, pattern, replacement);
            string[] words = result.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return words;
        }
        private string stringMaker(Dictionary<string, int> wordsDictionary)
        {
            string result = "";
            foreach (var x in wordsDictionary.OrderBy(x => x.Key))
            {
                result+= x.Key + " - " + x.Value + "\n";
            }
            return result;
        }
}
}
