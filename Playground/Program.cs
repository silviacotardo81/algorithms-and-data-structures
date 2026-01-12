using System;
using System.Collections.Generic;
using Playground.Problems;

class Program
{
    static void Main(string[] args)
    {
        var solution = new ContainsDuplicate();

        int[] nums1 = { 1, 2, 3, 1 };
        int[] nums2 = { 1, 2, 3, 4 };

        Console.WriteLine(solution.Solve(nums1)); // True
        Console.WriteLine(solution.Solve(nums2)); // False
    }
}

