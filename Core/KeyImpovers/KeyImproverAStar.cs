using System.Collections.Generic;
using security_lab1_csharp.Core.Keys;
using security_lab1_csharp.Core.Raters;

namespace security_lab1_csharp.Core.KeyImpovers
{
    public class KeyImproverAStar : KeyImprover
    {
        private KeyRater keyRater;

        public KeyImproverAStar(KeyRater keyRater)
        {
            this.keyRater = keyRater;
        }
        public override Key ImproveKey(Key initialKey, int iterations)
        {
            var listExpandedKeys = new List<Key>();
            var keys = new List<Key> {initialKey};

            for (var iter = 0; iter < iterations; iter++)
            {
                var index = 0;
                while (listExpandedKeys.Contains(keys[index++])) {}

                if (iter == 0)
                    index = 0;
                listExpandedKeys.Add(keys[index]);
                keys.AddRange(keys[index].ExpandKey());
                keys.Sort((key1, key2) => key2.GetFitness(keyRater).CompareTo(key1.GetFitness(keyRater)));
                if (keys.Count > 50000)
                {
                    keys.RemoveRange(50000, keys.Count - 50000);
                }
            }
            return keys[0];
        }
    }
}