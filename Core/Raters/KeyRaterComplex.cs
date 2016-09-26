using System.Linq;
using security_lab1_csharp.Core.Keys;

namespace security_lab1_csharp.Core.Raters
{
    public class KeyRaterComplex : KeyRater
    {
        private KeyRater[] subRaters;
        public KeyRaterComplex(string plainText, params KeyRater[] subRaters) : base(plainText)
        {
            this.subRaters = subRaters;
        }

        public override double getKeyFitness(Key key)
        {
            return subRaters.Aggregate<KeyRater, double>(1, (current, rater) => current * rater.getKeyFitness(key));
        }
    }
}