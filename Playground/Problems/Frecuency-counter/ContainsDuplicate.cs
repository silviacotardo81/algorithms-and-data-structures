using System.Collections.Generic;


namespace Playground.Problems
{
    public class ContainsDuplicate
    {

        public bool Solve(int[] nums)
        {
            var seen = new HashSet<int>();

            foreach (var n in nums)
            {
                if (seen.Contains(n))
                {
                    return true;
                }

                seen.Add(n);
            }

            return false;
        }
    }
}
