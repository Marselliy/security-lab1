using System;
using System.Collections.Generic;

namespace security_lab1_csharp.Core.Raters
{
    public class KeyRaterCount : KeyRater
    {
        private int n;

        public KeyRaterCount(int n, string plainText) : base(plainText)
        {
            if (n < 1 || n > 5)
                throw new Exception("Illegal n");
            this.n = n;
        }

        public override double getKeyFitness(Keys.Key key)
        {
            double fitness = 0;
            var endata = key.ApplyKey(plainText);
            var realFreq = Util.getTheorNGramCounts(n);
            for (var i = 0; i < endata.Length - n + 1; i += n)
            {
                var part = endata.Substring(i, n);
                if (!realFreq.ContainsKey(part)) continue;
                long count;
                realFreq.TryGetValue(part, out count);
                fitness += count;
            }
            return fitness;
        }
    }
}