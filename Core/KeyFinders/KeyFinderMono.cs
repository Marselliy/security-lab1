using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using security_lab1_csharp.Core.Keys;

namespace security_lab1_csharp.Core.KeyFinders
{
    public class KeyFinderMono : KeyFinder
    {
        private int n;
        public KeyFinderMono(int n)
        {
            this.n = n;
        }
        public override Key FindKey(string plainText)
        {
            var theorFreqs = Util.getTheorNGramFrequency(n);
            var realFreqs = Util.getRealNGramFrequency(plainText, n);
            var monoFreqList = Util.getTheorNGramFrequency(1).ToList();
            monoFreqList.Sort((pair1, pair2) => pair2.Value.CompareTo(pair1.Value));

            var theorFreqsList = theorFreqs.ToList();
            var realFreqsList = realFreqs.ToList();

            theorFreqsList.Sort((pair1, pair2) => pair2.Value.CompareTo(pair1.Value));
            realFreqsList.Sort((pair1, pair2) => pair2.Value.CompareTo(pair1.Value));

            var key = new StringBuilder(new string(' ', 26));

            foreach (KeyValuePair<string, double> pair in realFreqsList)
            {
                var realPart = pair.Key;
                var done = false;
                for (var j = 0; j < theorFreqsList.Count && !done; j++)
                {
                    var theorPart = theorFreqsList[j].Key;
                    var suitable = true;

                    var theorMap = theorPart;
                    var realMap = realPart;
                    var count = 0;
                    for (int x = 0; x < theorMap.Length; x++)
                    {
                        if (theorMap[x] < 'A' || theorMap[x] > 'Z') continue;
                        theorMap = theorMap.Replace(theorMap[x], (char)count);
                        count++;
                    }
                    count = 0;
                    for (int x = 0; x < realMap.Length; x++)
                    {
                        if (realMap[x] < 'A' || realMap[x] > 'Z') continue;
                        realMap = realMap.Replace(realMap[x], (char)count);
                        count++;
                    }
                    for (var x = 0; x < theorMap.Length; x++)
                    {
                        if (theorMap[x] != realMap[x])
                        {
                            suitable = false;
                        }
                    }

                    for (int pos = 0; pos < n; pos++)
                    {
                        if (Regex.Matches(key.ToString(), theorPart[pos] + "").Count != 0)
                        {
                            suitable = false;
                        }
                    }

                    if (suitable)
                    {
                        for (int pos = 0; pos < n; pos++)
                        {
                            char oldchar = realPart[pos];
                            char newchar = theorPart[pos];
                            if (key[oldchar - 'A'] == ' ')
                            {
                                key[oldchar - 'A'] = newchar;
                            }
                        }
                        done = true;
                        theorFreqsList.RemoveAt(j);
                    }
                }
            }
            var counter = 0;
            for (var i = 0; i < key.Length; i++)
            {
                if (key[i] != ' ') continue;
                while (Regex.Matches(key.ToString(), monoFreqList[counter].Key).Count > 0)
                {
                    counter++;
                }
                key[i] = monoFreqList[counter].Key[0];
            }
            return new KeyMono(key.ToString());
        }
    }
}