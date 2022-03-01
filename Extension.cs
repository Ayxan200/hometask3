using System;
using System.Collections.Generic;
using System.Text;

namespace hometask3
{
    static class Extension
    {
        public static string IsCapitalized(this string word)
        {
            string word1 = "";
            word = word.ToLower();
            string[] words = word.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i][0].ToString().ToUpper() + words[i].Substring(1);
            }
            word1 = string.Join(' ', words);
            return word1;
        }
    }
}
