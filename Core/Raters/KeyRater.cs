namespace security_lab1_csharp.Core.Raters
{
    public abstract class KeyRater
    {
        protected string plainText;

        protected KeyRater(string plainText)
        {
            this.plainText = plainText;
        }
        public abstract double getKeyFitness(Keys.Key key);
    }
}