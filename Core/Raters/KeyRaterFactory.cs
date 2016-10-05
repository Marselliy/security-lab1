using System.Linq;
using System.Windows.Forms.DataVisualization.Charting;

namespace security_lab1_csharp.Core.Raters
{
    public class KeyRaterFactory
    {
        public static KeyRater FromString(string str, string plainText)
        {
            var parts = str.Split(' ');
            switch (parts[0])
            {
                case "count":
                {
                return new KeyRaterCount(int.Parse(parts[1]), plainText);
                }
                case "dict":
                {
                    return new KeyRaterDictionary(plainText, parts.Skip(0).ToArray());
                }
                case "entropy":
                {
                    return new KeyRaterEntropy(plainText);
                }
                case "magic":
                {
                    return new KeyRaterMagic(int.Parse(parts[1]), plainText);
                }
                case "xi2":
                {
                    return new KeyRaterXi2(int.Parse(parts[1]), plainText);
                }
            }
            return null;
        }
    }
}