using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace security_lab1_csharp.Core.Keys
{
    public class KeyVigenere : Key
    {
        public string shifts { get; set; }
        public KeyVigenere(string shifts)
        {
            this.shifts = shifts;
        }
        public override string ApplyKey(string plainText)
        {
            return (plainText.Select((t, i) => (char) (((t - 'A') + 26 - (shifts[i % shifts.Length] - 'A'))%26 + 'A')).
                Aggregate(new StringBuilder(), (current, newChar) => current.Append(newChar))).ToString();
        }

        public override Key[] ExpandKey()
        {
            var keys = new List<KeyVigenere>();
            for (var i = 0; i < shifts.Length; i++)
            {
                for (var c = 'A'; c <= 'Z'; c++)
                {
                    if (c != shifts[i])
                    {
                        keys.Add(new KeyVigenere(shifts.Substring(0, i) + c + shifts.Substring(i + 1)));
                    }
                }
            }
            return keys.ToArray();
        }

        public override void SlightlyModifyKey()
        {
            var index = Util.random.Next() % shifts.Length;
            shifts = shifts.Substring(0, index) + shifts[index] + shifts.Substring(index + 1);
        }


        public override bool Equals(object obj)
        {
            var key = obj as KeyVigenere;
            return key != null && shifts.Equals(key.shifts);
        }
        public override object Clone()
        {
            return new KeyVigenere((string)shifts.Clone());
        }

        public override Key Crossbreed(Key secondKey)
        {
            if (!(secondKey is KeyVigenere))
                throw new Exception("Only keys of same type can be crossbreeded");
            var second = (KeyVigenere)secondKey;

            if (GetFitness() == -1 || second.GetFitness() == -1)
                throw new Exception("Keys must be rated");

            var ratio = GetFitness() / (GetFitness() + second.GetFitness());
            return new KeyVigenere(Util.CrossbreedStrings(shifts, second.shifts, ratio));
        }
    }
}