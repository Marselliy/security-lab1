using System;
using security_lab1_csharp.Core.Keys;
using security_lab1_csharp.Core.Raters;

namespace security_lab1_csharp.Core.KeyImpovers
{

    public class KeyImproverAnnealing : KeyImprover
    {
        private KeyRater keyRater;

        public void SetKeyRater(KeyRater rater)
        {
            keyRater = rater;
        }

        public KeyImproverAnnealing()
        {
        }

        public KeyImproverAnnealing(KeyRater keyRater)
        {
            this.keyRater = keyRater;
        }
        public override Key ImproveKey(Key initialKey, int iterations)
        {
            var bestKey = initialKey;
            var bestFitness = bestKey.GetFitness(keyRater);
            for (var iter = 0; iter < iterations; iter++)
            {
                var newKey = (Key) bestKey.Clone();
                newKey.SlightlyModifyKey();

                var newFitness = newKey.GetFitness(keyRater);
                if (newFitness > bestFitness)
                {
                    bestFitness = newFitness;
                    bestKey = newKey;
                }
                else if (Util.random.NextDouble() < Math.Exp(-(newFitness - bestFitness) / (bestFitness / iter)))
                {
                    bestFitness = newFitness;
                    bestKey = newKey;
                }
            }
            return bestKey;
        }
    }
}