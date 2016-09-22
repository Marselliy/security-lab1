using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace security_lab1_csharp.Core.Raters
{
    class KeyRaterXi2 : KeyRater
    {
        private int n;
        public KeyRaterXi2(int n, string plainText) : base(plainText)
        {
            if (n < 1 || n > 5)
                throw new Exception("Illegal n");
            this.n = n;
        }

        public override double getKeyFitness(Keys.Key key)
        {
            var endata = key.ApplyKey(plainText);
            var freqDictT = Util.getTheorNGramFrequency(n);
            var freqDictR = Util.getRealNGramFrequency(endata, n);
            double sum = 0;
            foreach (var curkey in freqDictR.Keys)
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
