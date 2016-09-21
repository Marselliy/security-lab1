using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace security_lab1_csharp
{
    class MonoCrypter
    {
        public static string applyKey(string data, string key)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sb = sb.Append(key[data[i] - 'A']);
            }
            return sb.ToString();
        }
        public static bool isValidKey(string key)
        {
            for (int i = 0; i < Util.alphabet.Length; i++)
            {
                if (!key.Contains(Util.alphabet[i] + ""))
                {
                    return false;
                }
            }
            return true;
        }
        public static double getKeyFitness(string key, string data, int method, Util.Evristiks type)
        {
            switch (type)
            {
                case Util.Evristiks.COUNT:
                    {
                        return getKeyFitnessCount(key, data, method);
                    }
                    break;
                case Util.Evristiks.XI2:
                    {
                        return getKeyFitnessXI2(key, data, method);
                    }
                    break;
                case Util.Evristiks.MAGIC:
                    {
                        return getKeyFitnessMagic(key, data, method);
                    }
                    break;
                case Util.Evristiks.ENTROPY:
                    {
                        return getKeyFitnessEntropy(key, data, method);
                    }
                    break;
            }
            return 0;
        }
        public static long getKeyFitnessCount(string key, string data, int method)
        {
            if (!isValidKey(key))
            {
                return 0;
            }
            long fitness = 0;
            string endata = applyKey(data, key);
            Dictionary<string, long> realFreq = Util.getTheorNGramCounts(method);
            for (int i = 0; i < endata.Length - method; i += (method + 1))
            {
                string part = endata.Substring(i, (method + 1));
                if (realFreq.ContainsKey(part))
                {
                    long count;
                    realFreq.TryGetValue(part, out count);
                    fitness += count;
                }
            }
            return fitness;
        }
        public static double getKeyFitnessMagic(string key, string data, int method)
        {
            string endata = applyKey(data, key);
            Dictionary<string, double> freqDictT = Util.getTheorNGramFrequency(0);
            Dictionary<string, double> freqDictR = Util.getRealNGramFrequency(endata, 0);
            double sum = 0;
            for (int i = 0; i < Util.alphabet.Length; i++)
            {
                double rCharFreq;
                double tCharFreq;
                freqDictR.TryGetValue(Util.alphabet[i] + "", out rCharFreq);
                freqDictT.TryGetValue(Util.alphabet[i] + "", out tCharFreq);
                sum += rCharFreq * tCharFreq;
            }
            return 1 / Math.Abs(sum - 0.0644);
        }
        public static double getKeyFitnessXI2(string key, string data, int method)
        {
            string endata = applyKey(data, key);
            Dictionary<string, double> freqDictT = Util.getTheorNGramFrequency(method);
            Dictionary<string, double> freqDictR = Util.getRealNGramFrequency(endata, method);
            double sum = 0;
            foreach (string curkey in freqDictR.Keys)
            {
                double rCharFreq;
                double tCharFreq;
                freqDictR.TryGetValue(curkey, out rCharFreq);
                if (rCharFreq == 0)
                    continue;
                freqDictT.TryGetValue(curkey, out tCharFreq);
                sum += (rCharFreq - tCharFreq) * (rCharFreq - tCharFreq) / rCharFreq;
            }
            return 1 / (sum);
        }
        public static double getKeyFitnessEntropy(string key, string data, int method)
        {
            string endata = applyKey(data, key);
            Dictionary<string, double> freqDictR = Util.getRealNGramFrequency(endata, 0);
            double sum = 0;
            for (int i = 0; i < Util.alphabet.Length; i++)
            {
                double rCharFreq;
                freqDictR.TryGetValue(Util.alphabet[i] + "", out rCharFreq);
                if (rCharFreq == 0)
                    continue;
                sum -= rCharFreq * Math.Log(rCharFreq, 2);
            }
            return 1 / (Math.Abs(sum - 1.8));
        }
        
        public static string findKeyByNgramFrequency(string data, int method)
        {
            Dictionary<string, double> theorFreqs = Util.getTheorNGramFrequency(method);
            Dictionary<string, double> realFreqs = Util.getRealNGramFrequency(data, method);
            List<KeyValuePair<string, double>> monoFreqList = Util.getTheorNGramFrequency(0).ToList();
            monoFreqList.Sort(
                delegate (KeyValuePair<string, double> pair1,
                KeyValuePair<string, double> pair2)
                {
                    return pair2.Value.CompareTo(pair1.Value);
                });

            List<KeyValuePair<string, double>> theorFreqsList = theorFreqs.ToList();
            List<KeyValuePair<string, double>> realFreqsList = realFreqs.ToList();

            theorFreqsList.Sort(
                delegate (KeyValuePair<string, double> pair1,
                KeyValuePair<string, double> pair2)
                {
                    return pair2.Value.CompareTo(pair1.Value);
                });
            realFreqsList.Sort(
                delegate (KeyValuePair<string, double> pair1,
                KeyValuePair<string, double> pair2)
                {
                    return pair2.Value.CompareTo(pair1.Value);
                });
            StringBuilder key = new StringBuilder(new string(' ', 26));
            
            for (int i = 0; i < realFreqsList.Count; i++)
            {
                string realPart = realFreqsList[i].Key;
                bool done = false;
                for (int j = 0; j < theorFreqsList.Count && !done; j++)
                {
                    string theorPart = theorFreqsList[j].Key;
                    bool suitable = true;

                    string theorMap = theorPart;
                    string realMap = realPart;
                    int count = 0;
                    for (int x = 0; x < theorMap.Length; x++)
                    {
                        if (theorMap[x] >= 'A' && theorMap[x] <= 'Z')
                        {
                            theorMap = theorMap.Replace(theorMap[x], (char)count);
                            count++;
                        }
                    }
                    count = 0;
                    for (int x = 0; x < realMap.Length; x++)
                    {
                        if (realMap[x] >= 'A' && realMap[x] <= 'Z')
                        {
                            realMap = realMap.Replace(realMap[x], (char)count);
                            count++;
                        }
                    }
                    for (int x = 0; x < theorMap.Length; x++)
                    {
                        if (theorMap[x] != realMap[x])
                        {
                            suitable = false;
                        }
                    }

                    for (int pos = 0; pos < method + 1; pos++)
                    {
                        if (Regex.Matches(key.ToString(), theorPart[pos] + "").Count != 0)
                        {
                            suitable = false;
                        }
                    }

                    if (suitable)
                    {
                        for (int pos = 0; pos < method + 1; pos++)
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

            //for (int i = 0; i < realFreqsList.Count; i++)
            //{
            //    bool suitable = true;
            //    for (int pos = 0; pos < method + 1; pos++)
            //    {
            //        if (Regex.Matches(key.ToString(), realFreqsList[i].Key[pos] + "").Count != 0)
            //        {
            //            suitable = false;
            //        }
            //    }
                
            //    if (suitable)
            //    {
            //        for (int pos = 0; pos < method + 1; pos++)
            //        {
            //            char oldchar = realFreqsList[i].Key[pos];
            //            char newchar = theorFreqsList[i].Key[pos];
            //            if (key[oldchar - 'A'] == ' ')
            //            {
            //                key[oldchar - 'A'] = newchar;
            //            }
            //        }
            //    }
            //}
            int counter = 0;
            for (int i = 0; i < key.Length; i++)
            {
                if (key[i] == ' ')
                {
                    while (Regex.Matches(key.ToString(), monoFreqList[counter].Key).Count > 0)
                    {
                        counter ++;
                    }
                    key[i] = monoFreqList[counter].Key[0];
                }
            }
            return key.ToString();
        }
        public static string findKey(string data, int method)
        {
            //return findKeyEvol(data, 1000, 100, 0.2);
            return findKeyByNgramFrequency(data, method);
        }
        public static string getRandomKey()
        {
            List<char> listKey = Util.alphabet.ToCharArray().ToList<char>();
            List<char> newkeylist = listKey.OrderBy(c => Util.random.Next()).ToList();
            
            return new string(newkeylist.ToArray());
        }
        public static string crossbreedKeys(string key1, string key2, string data, int method, double mutRate, Util.Evristiks type)
        {
            double fitness1 = getKeyFitness(key1, data, method, type);
            double fitness2 = getKeyFitness(key2, data, method, type);
            StringBuilder key = new StringBuilder(new string(' ', Util.alphabet.Length));
            for (int i = 0; i < key1.Length; i++)
            {
                if (Util.random.NextDouble() < (fitness1 / (fitness1 + fitness2)) || Regex.Matches(key.ToString(), key2[i] + "").Count > 0)
                {
                    key[i] = key1[i];
                }
                else
                {
                    key[i] = key2[i];
                }
            }
            string strKey = key.ToString();
            if (Util.random.NextDouble() < mutRate)
            {
                int i = Util.random.Next() % Util.alphabet.Length;
                int j = Util.random.Next() % Util.alphabet.Length;
                int mi = Math.Max(i, j);
                int mj = Math.Min(i, j);
                if (mi != mj)
                    strKey = strKey.Substring(0, mj) + strKey[mi] + strKey.Substring(mj + 1, mi - mj - 1) + strKey[mj] + strKey.Substring(mi + 1);
            }
            return strKey;
        }
        public static string findKeyEvol(string data, int method, int iterations, int popSize, double mutationRate, Util.Evristiks type)
        {
            List<KeyValuePair<string, double>> keys = new List<KeyValuePair<string, double>>();
            string monoKey = findKeyByNgramFrequency(data, 0);
            string bikey = findKeyByNgramFrequency(data, 1);
            string monoAStarMonoKey = findKeyAStar(data, monoKey, 0, 200, new bool[26], type);
            string monoAStarBiKey = findKeyAStar(data, monoKey, 1, 200, new bool[26], type);
            string monoAStarTriKey = findKeyAStar(data, monoKey, 2, 200, new bool[26], type);
            string biAStarMonoKey = findKeyAStar(data, bikey, 0, 200, new bool[26], type);
            string biAStarBiKey = findKeyAStar(data, bikey, 1, 200, new bool[26], type);
            string biAStarTriKey = findKeyAStar(data, bikey, 2, 200, new bool[26], type);
            keys.Add(new KeyValuePair<string, double>(monoKey, getKeyFitness(monoKey, data, method, type)));
            keys.Add(new KeyValuePair<string, double>(bikey, getKeyFitness(bikey, data, method, type)));
            keys.Add(new KeyValuePair<string, double>(monoAStarMonoKey, getKeyFitness(monoAStarMonoKey, data, method, type)));
            keys.Add(new KeyValuePair<string, double>(monoAStarBiKey, getKeyFitness(monoAStarBiKey, data, method, type)));
            keys.Add(new KeyValuePair<string, double>(monoAStarTriKey, getKeyFitness(monoAStarTriKey, data, method, type)));
            keys.Add(new KeyValuePair<string, double>(biAStarMonoKey, getKeyFitness(biAStarMonoKey, data, method, type)));
            keys.Add(new KeyValuePair<string, double>(biAStarBiKey, getKeyFitness(biAStarBiKey, data, method, type)));
            keys.Add(new KeyValuePair<string, double>(biAStarTriKey, getKeyFitness(biAStarTriKey, data, method, type)));

            //Initialize
            for (int i = keys.Count; i < popSize; i++)
            {
                string newkey = getRandomKey();
                keys.Add(new KeyValuePair<string, double>(newkey, getKeyFitness(newkey, data, method, type)));
            }

            for (int iter = 0; iter < iterations; iter++)
            {
                //Sort
                keys.Sort(delegate (KeyValuePair<string, double> pair1,
                KeyValuePair<string, double> pair2)
                {
                    return pair2.Value.CompareTo(pair1.Value);
                });

                //Select
                List<KeyValuePair<string, double>> nextkeys = new List<KeyValuePair<string, double>>();
                for (int i = 0; i < popSize; i++)
                {
                    if (Util.random.NextDouble() > (double)i / popSize)
                    {
                        nextkeys.Add(keys[i]);
                    }
                }
                keys = nextkeys;

                //Crossbreed
                while (keys.Count < popSize)
                {
                    string newkey = crossbreedKeys(keys[0].Key, keys[1].Key, data, method, mutationRate, type);
                    keys.Add(new KeyValuePair<string, double>(newkey, getKeyFitness(newkey, data, method, type)));
                }
            }

            return keys[0].Key;
        }
        private static string[] expandKey(string key, bool[] fixFlags)
        {
            List<string> keys = new List<string>();
            for (int i = 1; i < key.Length; i++)
            {
                if (!fixFlags[i])
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (!fixFlags[j])
                        {
                            keys.Add(key.Substring(0, j) + key[i] + key.Substring(j + 1, i - j - 1) + key[j] + key.Substring(i + 1));
                        }
                    }
                }
            }
            return keys.ToArray();
        }
        public static string findKeyAStar(string data, string initialKey, int method, int iterations, bool[] fixFlags, Util.Evristiks type)
        {
            List<KeyValuePair<string, double>> keys = new List<KeyValuePair<string, double>>();
            keys.Add(new KeyValuePair<string, double>(initialKey, getKeyFitness(initialKey, data, method, type)));

            for (int iter = 0; iter < iterations; iter++)
            {
                string[] newKeys = expandKey(keys[0].Key, fixFlags);
                for (int i = 0; i < newKeys.Length; i++)
                {
                    keys.Add(new KeyValuePair<string, double>(newKeys[i], getKeyFitness(newKeys[i], data, method, type)));
                }

                keys.Sort(
                    delegate (KeyValuePair<string, double> pair1,
                    KeyValuePair<string, double> pair2)
                    {
                        return pair2.Value.CompareTo(pair1.Value);
                    });
            }
            return keys[0].Key;
        }
    }
}
