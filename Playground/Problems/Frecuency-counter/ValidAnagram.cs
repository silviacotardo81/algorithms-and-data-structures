using System.Collections.Generic;

namespace Playground.Problems
{
    public class ValidAnagram
    {
        public bool Solve(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }

            var counts = new Dictionary<char, int>();

            foreach (var c in s)
            {
                if (counts.ContainsKey(c))
                {
                    counts[c]++;
                }
                else
                {
                    counts[c] = 1;
                }
            }

            foreach (var c in t)
            {
                if (!counts.ContainsKey(c))
                {
                    return false;
                }

                counts[c]--;

                if (counts[c] < 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
