using System.Linq;
using security_lab1_csharp.Core.Keys;
using security_lab1_csharp.Core.LengthFinders;

namespace security_lab1_csharp.Core.KeyFinders
{
    public class KeyFinderVigenere : KeyFinder
    {
        public override Key FindKey(string plainText)
        {
            var keyLength = PolyKeyLengthFinder.getPolyKeyLength(plainText);
            var subStrings = new string[keyLength];

            for (var i = 0; i < keyLength; i++)
            {
                for (var j = i; j < plainText.Length; j += keyLength)
                {
                    subStrings[i] += plainText[j];
                }
            }

            var shifts = new int[keyLength];
            for (var i = 0; i < keyLength; i++)
            {
                var topChar = Util.getSortedRealNGramFrequencyList(subStrings[i], 1)[0].Key[0];
                shifts[i] = (topChar - 'E' + 26) % 26;
            }

            var key = shifts.Aggregate("", (current, t) => current + ("" + (char) ('A' + t)));

            return new KeyVigenere(key);
        }
    }
}