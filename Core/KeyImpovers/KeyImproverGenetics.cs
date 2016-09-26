using System.Collections.Generic;
using System.Linq;
using security_lab1_csharp.Core.Keys;
using security_lab1_csharp.Core.Raters;

namespace security_lab1_csharp.Core.KeyImpovers
{
    public class KeyImproverGenetics : KeyImprover
    {
        private int populationSize;
        private double mutationRate;
        private KeyRater[] keyRatersInitial;
        private KeyRater mainKeyRater;

        public KeyImproverGenetics(int populationSize, double mutationRate, KeyRater mainKeyRater, params KeyRater[] keyRatersInitial)
        {
            this.populationSize = populationSize;
            this.mutationRate = mutationRate;
            this.mainKeyRater = mainKeyRater;
            this.keyRatersInitial = keyRatersInitial;
        }
        public override Key ImproveKey(Key initialKey, int iterations)
        {
            var keys = new List<Key> {initialKey};
            keys.AddRange(keyRatersInitial.Select(rater => (new KeyImproverAStar(rater)).ImproveKey(initialKey, 100)));
            keys.Sort((key1, key2) => key2.GetFitness(mainKeyRater).CompareTo(key1.GetFitness(mainKeyRater)));

            for (var iter = 0; iter < iterations; iter++)
            {
                while (keys.Count < populationSize)
                {
                    var newKey = keys[0].Crossbreed(keys[1]);
                    if (Util.random.NextDouble() < mutationRate)
                        newKey.SlightlyModifyKey();
                    keys.Add(newKey);
                }
                keys.Sort((key1, key2) => key2.GetFitness(mainKeyRater).CompareTo(key1.GetFitness(mainKeyRater)));
                var newKeys = new List<Key>();
                for (var i = 0; i < keys.Count; i++)
                {
                    if (Util.random.NextDouble() > ((double) i)/keys.Count)
                    {
                        newKeys.Add(keys[i]);
                    }
                }
                keys = newKeys;
            }

            return keys[0];
        }
    }
}