using System.Collections.Generic;

namespace Playground.Problems
{
    public class FirstUniqueCharacter
    {
        public int Solve(string s)
        {
            if (s.Length == 0)
                return -1;

            var counts = new Dictionary<char, int>();

            foreach (var a in s)
            {
                if (counts.ContainsKey(a))
                {
                    counts[a]++;
                }
                else
                {
                    counts[a] = 1;
                }
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (counts[s[i]] == 1)
                    return i;
            }

            return -1;
        }
        
    }

}