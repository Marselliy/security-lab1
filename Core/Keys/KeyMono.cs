using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;

namespace security_lab1_csharp.Core.Keys
{
    public class KeyMono : Key
    {
        public string map { get; set; }
        public KeyMono(string map)
        {
            this.map = map;
        }
        public override string ApplyKey(string plainText)
        {
            return plainText.Aggregate(new StringBuilder(), (current, t) => current.Append(map[t - 'A'])).ToString();
        }

        public override Key[] ExpandKey()
        {
            var keys = new List<Key>();
            for (var i = 1; i < map.Length; i++)
            {
                for (var j = 0; j < i; j++)
                {    
                    keys.Add(new KeyMono(map.Substring(0, j) + map[i] + map.Substring(j + 1, i - j - 1) + map[j] + map.Substring(i + 1)));   
                }
            }
            return keys.ToArray();
        }

        public override void SlightlyModifyKey()
        {
            var x = Util.random.Next() % 26;
            var y = Util.random.Next() % 26;
            var i = Math.Max(x, y);
            var j = Math.Min(x, y);
            if (x != y)
            {
                map = map.Substring(0, j) + map[i] + map.Substring(j + 1, i - j - 1) + map[j] + map.Substring(i + 1);
            }
        }

        public override object Clone()
        {
            return new KeyMono((string)map.Clone());
        }

        public override bool Equals(object obj)
        {
            var key = obj as KeyMono;
            return key != null && map.Equals(key.map);
        }
        
    }
}