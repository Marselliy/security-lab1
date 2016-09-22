using System;
using System.Collections.Generic;
using security_lab1_csharp.Core.Keys;

namespace security_lab1_csharp.Core.Raters
{
    public class KeyRaterEntropy : KeyRater
    {
        public KeyRaterEntropy(string plainText) : base(plainText)
        {
        }

        public override double getKeyFitness(Key key)
        {
            string endata = key.ApplyKey(plainText);
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
    }
}