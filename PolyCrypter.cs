using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace security_lab1_csharp
{
    class PolyCrypter
    {
        public static int getKeyLength(string data)
        {
            double treshhold = 0.5;
            List<KeyValuePair<string, double>> theorList = Util.getTheorNGramFrequency(0).ToList();
            List<KeyValuePair<int, double>> xi2List = new List<KeyValuePair<int, double>>();
            for (int i = 1; i < data.Length; i++)
            {
                StringBuilder testData = new StringBuilder();
                for (int j = 0; j < data.Length; j+=i)
                {
                    testData = testData.Append(data[j]);
                }
                List<KeyValuePair<string, double>> list = Util.getSortedRealNGramFrequencyList(testData.ToString(), 0);

                double xi2 = 0;
                for (int j = 0; j < list.Count; j++)
                {
                    if (list[j].Value != 0)
                        xi2 += (theorList[j].Value - list[j].Value) * (theorList[j].Value - list[j].Value) / theorList[j].Value;
                }
                xi2List.Add(new KeyValuePair<int, double>(i, xi2));
            }
            xi2List.Sort(
                delegate (KeyValuePair<int, double> pair1,
                KeyValuePair<int, double> pair2)
                {
                    return pair1.Value.CompareTo(pair2.Value);
                });

            //Kasiski start
            List<KeyValuePair<string, long>> realCountsBiSorted = Util.getSortedRealNGramCountList(data, 1);
            List<KeyValuePair<string, long>> realCountsTriSorted = Util.getSortedRealNGramCountList(data, 2);

            MatchCollection biMatches = Regex.Matches(data, realCountsBiSorted[0].Key);
            MatchCollection triMatches = Regex.Matches(data, realCountsTriSorted[0].Key);
            List<int> biPos = new List<int>();
            List<int> triPos = new List<int>();
            foreach (Match biMatch in biMatches)
            {
                biPos.Add(biMatch.Index);
            }
            foreach (Match triMatch in triMatches)
            {
                triPos.Add(triMatch.Index);
            }
            int[] biDivs = new int[biPos.Count - 1];
            int[] triDivs = new int[triPos.Count - 1];
            int[] matchCounts = new int[data.Length];
            for (int i = 0; i < biPos.Count - 1; i++)
            {
                biDivs[i] = biPos[i + 1] - biPos[i];
            }
            for (int i = 0; i < triPos.Count - 1; i++)
            {
                triDivs[i] = triPos[i + 1] - triPos[i];
            }

            foreach (KeyValuePair<int, double> key in xi2List)
            {
                double perc = 0;
                for (int i = 0; i < biDivs.Length; i++)
                {
                    if (biDivs[i] % key.Key == 0)
                        perc++;
                }
                for (int i = 0; i < triDivs.Length; i++)
                {
                    if (triDivs[i] % key.Key == 0)
                        perc++;
                }
                perc /= (biDivs.Length + triDivs.Length);
                if (perc > treshhold)
                    return key.Key;
            }
            
            return 1;
        }
        public static string findVigenerKey(string data)
        {
            return findVigenerKey(data, getKeyLength(data));
        }
        public static string findVigenerKey(string data, int keyLength)
        {
            string[] subStrings = new string[keyLength];

            for (int i = 0; i < keyLength; i++)
            {
                for (int j = i; j < data.Length; j += keyLength)
                {
                    subStrings[i] += data[j];
                }
            }

            int[] shifts = new int[keyLength];
            for (int i = 0; i < keyLength; i++)
            {
                char topChar = Util.getSortedRealNGramFrequencyList(subStrings[i], 0)[0].Key[0];
                shifts[i] = (topChar - 'E' + 26) % 26;
            }

            string key = "";
            for (int i = 0; i < shifts.Length; i++)
            {
                key += "" + (char)('A' + shifts[i]);
            }

            return key;
        }
        public static string applyVigenerkey(string data, string key)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                char newChar = (char)(((data[i] - 'A') + 26 - (key[i % key.Length] - 'A')) % 26 + 'A');
                result = result.Append(newChar);
            }

            return result.ToString();
        }
        public static List<KeyValuePair<string, double>>[] getDataAnalysis(string data, int keyLength)
        {
            string[] subStrings = new string[keyLength];

            for (int i = 0; i < keyLength; i++)
            {
                for (int j = i; j < data.Length; j += keyLength)
                {
                    subStrings[i] += data[j];
                }
            }

            List<KeyValuePair<string, double>>[] lstArr = new List<KeyValuePair<string, double>>[keyLength];
            for (int i = 0; i < keyLength; i++)
            {
                lstArr[i] = Util.getSortedRealNGramFrequencyList(subStrings[i], 0);
            }

            return lstArr;
        }
        public static string applyPolyKey(string data, string[] key)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sb = sb.Append(key[i % key.Length][data[i] - 'A']);
            }
            return sb.ToString();
        }
        public static string[] findPolyKey(string data)
        {
            int keySize = 5;
            string[] subStrings = new string[keySize];

            for (int i = 0; i < keySize; i++)
            {
                for (int j = i; j < data.Length; j += keySize)
                {
                    subStrings[i] += data[j];
                }
            }
            string[] key = new string[keySize];
            for (int i = 0; i < keySize; i++)
            {
                key[i] = MonoCrypter.findKeyByNgramFrequency(subStrings[i], 0);
            //    key[i] = MonoCrypter.findKeyAStar(subStrings[i], key[i], 0, 100, new bool[26], MonoCrypter.Evristiks.XI2);
            }
            //key = findPolyKeyAStar(data, key, 2, 100, MonoCrypter.Evristiks.XI2);
            //key = findPolyKeyAnnealing(data, key, 2, 10000, MonoCrypter.Evristiks.XI2);
            return key;
        }
        public static List<KeyValuePair<string, double>>[] getPolyMonogramFrequencies(string data, int keySize)
        {
            string[] subStrings = new string[keySize];
            List<KeyValuePair<string, double>>[] listArr = new List<KeyValuePair<string, double>>[keySize];
            for (int i = 0; i < keySize; i++)
            {
                for (int j = i; j < data.Length; j += keySize)
                {
                    subStrings[i] += data[j];
                }
                listArr[i] = Util.getRealNGramFrequency(subStrings[i], 0).ToList();
                listArr[i].Sort(
                delegate (KeyValuePair<string, double> pair1,
                KeyValuePair<string, double> pair2)
                {
                    return pair1.Key.CompareTo(pair2.Key);
                });
            }
            return listArr;
        }
        private static string[][] expandPolyKey(string[] key)
        {
            List<string[]> keys = new List<string[]>();
            for (int row = 0; row < key.Length; row++)
            {
                for (int i = 1; i < key[row].Length; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        string[] newKey = (string[])key.Clone();
                        newKey[row] = key[row].Substring(0, j) + key[row][i] + key[row].Substring(j + 1, i - j - 1) + key[row][j] + key[row].Substring(i + 1);
                        keys.Add(newKey);
                    }
                }
            }
            return keys.ToArray();
        }
        public static string[] findPolyKeyAStar(string data, string[] initialKey, int method, int iterations, Util.Evristiks type)
        {
            Logger.log("Polykey A* search started with " + (method + 1) + "-gram and " + iterations + " iterations.");
            List<string[]> listExpandedKeys = new List<string[]>();
            string[] parts = new string[initialKey.Length];
            for (int i = 0; i < initialKey.Length; i++)
            {
                for (int j = i; j < data.Length; j += initialKey.Length)
                {
                    parts[i] += data[j];
                }
            }
            List<KeyValuePair<string[], double>> keys = new List<KeyValuePair<string[], double>>();
            keys.Add(new KeyValuePair<string[], double>(initialKey, getPolyKeyFitness(initialKey, data, parts, method, type)));

            for (int iter = 0; iter < iterations; iter++)
            {
                int index = 0;

                bool equal = true;
                while (equal)
                {
                    if (listExpandedKeys.Count <= index)
                        break;
                    foreach (string[] key in listExpandedKeys)
                    {
                        if (equal == false)
                            break;
                        equal = true;
                        for (int i = 0; i < key.Length; i++)
                        {
                            if (!keys[index].Key[i].Equals(key[i]))
                            {
                                equal = false;
                                break;
                            }
                        }
                    }
                    index++;
                }
                string[][] newKeys = expandPolyKey(keys[index].Key);
                listExpandedKeys.Add(keys[index].Key);
                foreach (string[] newKey in newKeys)
                {
                    keys.Add(new KeyValuePair<string[], double>(newKey, getPolyKeyFitness(newKey, data, parts, method, type)));
                }
                keys.Sort(
                    delegate (KeyValuePair<string[], double> pair1,
                    KeyValuePair<string[], double> pair2)
                    {
                        return pair2.Value.CompareTo(pair1.Value);
                    });
                Logger.log("Iteration " + iter + " \tBest fitness " + keys[0].Value);
                if (keys.Count > 50000)
                {
                    keys.RemoveRange(50000, keys.Count - 50000);
                }
            }
            return keys[0].Key;
        }
        public static string[] findPolyKeyAnnealing(string data, string[] initialKey, int method, int iterations, Util.Evristiks type)
        {
            Random random = new Random();
            string[] parts = new string[initialKey.Length];
            for (int i = 0; i < initialKey.Length; i++)
            {
                for (int j = i; j < data.Length; j += initialKey.Length)
                {
                    parts[i] += data[j];
                }
            }
            string[] bestKey = initialKey;
            double bestFitness = getPolyKeyFitness(initialKey, data, parts, method, type);
            for (int iter = 0; iter < iterations; iter++)
            {
                string[] newKey = new string[bestKey.Length];
                for (int k = 0; k < newKey.Length; k++)
                {
                    newKey[k] = bestKey[k];
                }
                //Modify new key
                int row = random.Next() % newKey.Length;
                int x = random.Next() % 26;
                int y = random.Next() % 26;
                int i = Math.Max(x, y);
                int j = Math.Min(x, y);
                if (x != y)
                {
                    newKey[row] = newKey[row].Substring(0, j) + newKey[row][i] + newKey[row].Substring(j + 1, i - j - 1) + newKey[row][j] + newKey[row].Substring(i + 1);
                }
                
                double newFitness = getPolyKeyFitness(newKey, data, parts, method, type);
                if (newFitness > bestFitness)
                {
                    bestFitness = newFitness;
                    bestKey = newKey;
                }
                else if (random.NextDouble() < Math.Exp(-(newFitness - bestFitness) / (bestFitness / iter)))
                {
                    bestFitness = newFitness;
                    bestKey = newKey;
                }
            }
            return bestKey;
        }
        public static double getPolyKeyFitness(string[] key, string data, string[] parts, int method, Util.Evristiks type)
        {
            double bigFitness = 0;
            double[] smallFitnesses = new double[key.Length];
            switch (type)
            {
                case Util.Evristiks.COUNT:
                    {
                        bigFitness = getPolyKeyFitnessCount(key, data, method);
                    }
                    break;
                case Util.Evristiks.XI2:
                    {
                        bigFitness = getPolyKeyFitnessXI2(key, data, method);
                    }
                    break;
                case Util.Evristiks.MAGIC:
                    {
                        bigFitness = getPolyKeyFitnessMagic(key, data, method);
                    }
                    break;
            }
            double smallSum = 0;
            for (int i = 0; i < parts.Length; i++)
            {
                smallFitnesses[i] = MonoCrypter.getKeyFitness(key[i], parts[i], method, Util.Evristiks.XI2);
                smallSum += smallFitnesses[i];
            }
            return bigFitness * smallSum;
        }
        public static long getPolyKeyFitnessCount(string[] key, string data, int method)
        {
            long fitness = 0;
            string endata = applyPolyKey(data, key);
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
        public static double getPolyKeyFitnessMagic(string[] key, string data, int method)
        {
            string endata = applyPolyKey(data, key);
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
        public static double getPolyKeyFitnessXI2(string[] key, string data, int method)
        {
            string endata = applyPolyKey(data, key);
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
    }
}
