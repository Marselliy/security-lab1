using System;
using System.Collections.Generic;
using security_lab1_csharp.Core.Raters;

namespace security_lab1_csharp.Core.Keys
{
    public abstract class Key : ICloneable
    {
        private Dictionary<KeyRater, double> fitnesses = new Dictionary<KeyRater, double>();
        private double lastFitness;

        public double GetFitness(KeyRater rater)
        {
            if (!fitnesses.ContainsKey(rater))
                fitnesses.Add(rater, rater.getKeyFitness(this));
            lastFitness = fitnesses[rater];
            return lastFitness;
        }

        public double GetFitness()
        {
            return lastFitness;
        }
        public abstract string ApplyKey(string plainText);
        public abstract Key[] ExpandKey();
        public abstract void SlightlyModifyKey();
        public abstract object Clone();
        public abstract Key Crossbreed(Key secondKey);
    }
}