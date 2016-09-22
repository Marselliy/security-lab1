using System;
using security_lab1_csharp.Core.Raters;

namespace security_lab1_csharp.Core.Keys
{
    public abstract class Key : ICloneable
    {
        private double fitness = -1;

        public double GetFitness(KeyRater rater)
        {
            if (fitness == -1)
                fitness = rater.getKeyFitness(this);
            return fitness;
        }

        public double GetFitness()
        {
            if (fitness == -1)
            {
                throw new Exception("Key fitness wasn't calculated");
            }
            else
            {
                return fitness;
            }
        }

        public abstract string ApplyKey(string plainText);
        public abstract Key[] ExpandKey();

        public abstract void SlightlyModifyKey();
        public abstract object Clone();
    }
}