using System;
using System.Linq;
using System.Text.RegularExpressions;
using security_lab1_csharp.Core.Keys;

namespace security_lab1_csharp.Core.Raters
{
    public class KeyRaterDictionary : KeyRater
    {
        private string[] dictionary;
        public KeyRaterDictionary(string plainText, string[] dictionary) : base(plainText)
        {
            this.dictionary = dictionary;
        }

        public override double getKeyFitness(Key key)
        {
            var endata = key.ApplyKey(plainText);
            double fitness = 0;
            foreach (var word in dictionary)
            {
                for (var i = 0; i < endata.Length - (word.Length - 1); i++)
                {
                    fitness += getSimilarityIndex(word, endata.Substring(i, word.Length));
                }
            }
            return fitness;
            //    return dictionary.Aggregate<string, double>(0, (current, word) => current + Regex.Matches(endata, word).Count);
        }

        private double getSimilarityIndex(string substring1, string substring2)
        {
            if (substring1.Length != substring2.Length)
                throw new Exception("Only strings with equal lengths can be compared");
            int hits = 1;
            double similarity = 0;
            for (var i = 0; i < substring1.Length; i++)
            {
                if (substring1[i] == substring2[i])
                {
                    similarity += hits*hits*hits;
                    hits++;
                }
            }
            return similarity;
        }
    }
}