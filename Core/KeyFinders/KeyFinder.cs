using security_lab1_csharp.Core.Keys;

namespace security_lab1_csharp.Core.KeyFinders
{
    public abstract class KeyFinder
    {
        public abstract Key FindKey(string plainText);
    }
}