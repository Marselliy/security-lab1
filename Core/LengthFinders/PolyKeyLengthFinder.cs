using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace security_lab1_csharp.Core.LengthFinders
{
    public class PolyKeyLengthFinder
    {
        public static int getPolyKeyLength(string plainText)
        {
            const double treshhold = 0.5;
            var theorList = Util.getTheorNGramFrequency(1).ToList();
            var xi2List = new List<KeyValuePair<int, double>>();
            for (var i = 1; i < plainText.Length; i++)
            {
                var testData = new StringBuilder();
                for (var j = 0; j < plainText.Length; j += i)
                {
                    testData = testData.Append(plainText[j]);
                }
                var list = Util.getSortedRealNGramFrequencyList(testData.ToString(), 1);

                double xi2 = 0;
                for (var j = 0; j < list.Count; j++)
                {
                    if (list[j].Value != 0)
                        xi2 += (theorList[j].Value - list[j].Value) * (theorList[j].Value - list[j].Value) / theorList[j].Value;
                }
                xi2List.Add(new KeyValuePair<int, double>(i, xi2));
            }
            xi2List.Sort((pair1, pair2) => pair1.Value.CompareTo(pair2.Value));

            //Kasiski start
            var realCountsBiSorted = Util.getSortedRealNGramCountList(plainText, 2);
            var realCountsTriSorted = Util.getSortedRealNGramCountList(plainText, 3);

            var biMatches = Regex.Matches(plainText, realCountsBiSorted[0].Key);
            var triMatches = Regex.Matches(plainText, realCountsTriSorted[0].Key);
            var biPos = (from Match biMatch in biMatches select biMatch.Index).ToList();
            var triPos = (from Match triMatch in triMatches select triMatch.Index).ToList();
            var biDivs = new int[biPos.Count - 1];
            var triDivs = new int[triPos.Count - 1];
            for (var i = 0; i < biPos.Count - 1; i++)
            {
                biDivs[i] = biPos[i + 1] - biPos[i];
            }
            for (var i = 0; i < triPos.Count - 1; i++)
            {
                triDivs[i] = triPos[i + 1] - triPos[i];
            }

            foreach (var key in xi2List)
            {
                double perc = 0;
                foreach (var t in biDivs)
                {
                    if (t % key.Key == 0)
                        perc++;
                }
                foreach (var t in triDivs)
                {
                    if (t % key.Key == 0)
                        perc++;
                }
                perc /= (biDivs.Length + triDivs.Length);
                if (perc > treshhold)
                    return key.Key;
            }

            return 1;
        }
    }
}