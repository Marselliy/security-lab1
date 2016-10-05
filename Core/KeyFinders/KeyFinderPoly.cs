using security_lab1_csharp.Core.KeyImpovers;
using security_lab1_csharp.Core.Keys;
using security_lab1_csharp.Core.LengthFinders;
using security_lab1_csharp.Core.Raters;

namespace security_lab1_csharp.Core.KeyFinders
{
    public class KeyFinderPoly : KeyFinder
    {
        private KeyImprover mainImprover;
        private int mainIters;

        public KeyFinderPoly(KeyImprover mainImprover, int mainIters)
        {
            this.mainImprover = mainImprover;
            this.mainIters = mainIters;
        }
        public override Key FindKey(string plainText)
        {
            var keySize = PolyKeyLengthFinder.getPolyKeyLength(plainText);
            var subStrings = new string[keySize];

            for (var i = 0; i < keySize; i++)
            {
                for (var j = i; j < plainText.Length; j += keySize)
                {
                    subStrings[i] += plainText[j];
                }
            }
            var keys = new KeyMono[keySize];
            var keyFinderMono = new KeyFinderMono(1);
            for (var i = 0; i < keySize; i++)
            {
                keys[i] = (KeyMono)keyFinderMono.FindKey(subStrings[i]);
            }
            var keyPoly = new KeyPoly(keys);
            if (mainImprover != null)
                keyPoly = (KeyPoly) mainImprover.ImproveKey(keyPoly, mainIters);
            return keyPoly;
        }
    }
}