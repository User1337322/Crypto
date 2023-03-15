using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypto
{
    public class CalculateSymbols
    {
        /// <summary>
        /// Gets the count of symbol repeats
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static Dictionary<char, int> GetSymbolCount(string text)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            foreach (char c in text)
            {
                if (charCount.ContainsKey(c))
                    charCount[c]++;
                else
                    charCount.Add(c, 1);
            }
            return charCount;
        }
        /// <summary>
        /// If step = 0 => bigrams without p
        /// If step = 1 => bigrams with step 2 
        /// </summary>
        /// <param name="text"></param>
        /// <param name="step"></param>
        /// <returns></returns>
        public static Dictionary<string, int> GetBigramsCount(string text)
        {
            Dictionary<string, int> bigramCount = new Dictionary<string, int>();

            for (int i = 0; i < text.Length - 1; i++)
            {
                string bigram = text.Substring(i++, 2);

                if (bigramCount.ContainsKey(bigram))
                    bigramCount[bigram]++;
                else
                    bigramCount.Add(bigram, 1);
            }
            return bigramCount;
        }
    }
}
