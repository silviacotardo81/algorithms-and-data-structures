using System.Collections.Generic;

namespace Playground.Problems
{
    public class GroupAnagrams
    {
        public List<List<string>> Solve(List<string> a)
        {
            var map = new Dictionary<string, List<string>>();

            foreach (var item in a)
            {
                char[] chars = item.ToCharArray();
                Array.Sort(chars);
                string key = new string(chars);
                //var key = new string(word.ToCharArray().OrderBy(c => c).ToArray());

                if (!map.ContainsKey(key))
                    map[key] = new List<string>();
                
                map[key].Add(item);
            }

            return map.Values.ToList();

        }
    }
}