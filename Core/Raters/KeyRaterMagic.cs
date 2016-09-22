using System;
using System.Collections.Generic;

namespace security_lab1_csharp.Core.Raters
{
    public class KeyRaterMagic : KeyRater
    {
        private int n;
        public KeyRaterMagic(int n, string plainText) : base(plainText)
        {
            if (n < 1 || n > 5)
                throw new Exception("Illegal n");
            this.n = n;
        }

        public override double getKeyFitness(Keys.Key key)
        {
            string endata = key.ApplyKey(plainText);
            var freqDictT = Util.getTheorNGramFrequency(0);
            var freqDictR = Util.getRealNGramFrequency(endata, 0);
            double sum = 0;
            foreach (var t in Util.alphabet)
            {
                double rCharFreq;
                double tCharFreq;
                freqDictR.TryGetValue(t + "", out rCharFreq);
                freqDictT.TryGetValue(t + "", out tCharFreq);
                sum += rCharFreq * tCharFreq;
            }
            return 1 / Math.Abs(sum - 0.0644);
        }
    }
}