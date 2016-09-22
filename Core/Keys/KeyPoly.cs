using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace security_lab1_csharp.Core.Keys
{
    public class KeyPoly : Key
    {
        public string[] maps { get; set; }
        public KeyPoly(string[] maps)
        {
            this.maps = maps;
        }
        public KeyPoly(KeyMono[] monos)
        {
            maps = new string[monos.Length];
            for (var i = 0; i < monos.Length; i++)
            {
                maps[i] = monos[i].map;
            }
        }
        public override string ApplyKey(string plainText)
        {
            var sb = new StringBuilder();
            for (var i = 0; i < plainText.Length; i++)
            {
                sb = sb.Append(maps[i % maps.Length][plainText[i] - 'A']);
            }
            return sb.ToString();
        }

        public override Key[] ExpandKey()
        {
            var keys = new List<KeyPoly>();
            for (var row = 0; row < maps.Length; row++)
            {
                for (var i = 1; i < maps[row].Length; i++)
                {
                    for (var j = 0; j < i; j++)
                    {
                        var newKey = (string[])maps.Clone();
                        newKey[row] = maps[row].Substring(0, j) + maps[row][i] + maps[row].Substring(j + 1, i - j - 1) + maps[row][j] + maps[row].Substring(i + 1);
                        keys.Add(new KeyPoly(newKey));
                    }
                }
            }
            return keys.ToArray();
        }

        public override void SlightlyModifyKey()
        {
            var row = Util.random.Next() % maps.Length;
            var x = Util.random.Next() % 26;
            var y = Util.random.Next() % 26;
            var i = Math.Max(x, y);
            var j = Math.Min(x, y);
            if (x != y)
            {
                maps[row] = maps[row].Substring(0, j) + maps[row][i] + maps[row].Substring(j + 1, i - j - 1) + maps[row][j] + maps[row].Substring(i + 1);
            }
        }

        public override bool Equals(object obj)
        {
            var key = obj as KeyPoly;
            return !maps.Where((t, i) => !t.Equals(key.maps[i])).Any();
        }

        public override object Clone()
        {
            return new KeyPoly((string[])maps.Clone());
        }

        public static explicit operator KeyPoly(KeyMono v)
        {
            throw new NotImplementedException();
        }
    }
}