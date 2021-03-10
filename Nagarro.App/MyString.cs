using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagarro.App
{
    public class MyString 
    {

        public string CalculateString(string sentence)
        {           
           
            char[] delimeters = GetStringDelimeters(sentence).ToArray();

            string[] words = sentence.Split(delimeters);

            var ConvertedWords = ConvertStringWords(words);

            var FinalString = ReplaceString(ConvertedWords, delimeters);

            return FinalString;
        }

        public List<char> GetStringDelimeters(string sentence)
        {
            List<char> Sdelimeters = new List<char>();
            
            foreach (char _char in sentence)
            {
                if (!char.IsLetterOrDigit(_char))
                    Sdelimeters.Add(_char);
            }            

            return Sdelimeters;

        }

        public string[] ConvertStringWords(string[] words)
        {
            // no time to implement autofac 
           
            string[] convertedWords = new string[words.Length];
            int index = 0;

            foreach (string word in words)
            {
                //in case you want to convert a word like "we" to "w0e" just change the if validation 
                //from "> 2" to "> 1"
                if (word.Length > 2)
                {
                    int SNumber = GetDistinctStringCharactersCount(word);

                    convertedWords.SetValue(string.Concat(word[0], SNumber, word[word.Length - 1]), index);
                }
                else
                {
                    convertedWords.SetValue(word, index);
                }
                index++;
            }

            return convertedWords;

        }

        public int GetDistinctStringCharactersCount(string word)
        {
            word = word.Remove(word.Length - 1, 1).Remove(0, 1);

            var number = word.Select(x => x).Distinct().Count();

            return number;
        }

        public string ReplaceString(string[] words, char[] delimeters)
        {
            string result = string.Empty;

            for (int i = 0; i < words.Length; i++)
            {
                if (i + 1 <= delimeters.Length)
                    result += string.Concat(words[i], delimeters[i]);
                else
                    result += words[i];
            }

            return result;

        }

    }
}
