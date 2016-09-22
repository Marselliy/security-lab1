using security_lab1_csharp.Core.Keys;

namespace security_lab1_csharp.Core.KeyImpovers
{
    public abstract class KeyImprover
    {
        public abstract Key ImproveKey(Key initialKey, int iterations);
    }
}