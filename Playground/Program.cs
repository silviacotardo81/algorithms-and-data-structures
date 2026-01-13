using System;
using System.Collections.Generic;
using System.IO.Pipelines;
using Playground.Problems;

class Program
{
    /*static void Main(string[] args)
    {
        var solution = new ContainsDuplicate();

        int[] nums1 = { 1, 2, 3, 1 };
        int[] nums2 = { 1, 2, 3, 4 };

        Console.WriteLine(solution.Solve(nums1)); // True
        Console.WriteLine(solution.Solve(nums2)); // False
    }*/
    /*static void Main(string[] args)
    {
        var anagram = new ValidAnagram();

        Console.WriteLine(anagram.Solve("roma", "amor")); // True
        Console.WriteLine(anagram.Solve("rat", "car"));         // False
    }*/

    /*static void Main(string[] args)
    {
        var firstUnique = new FirstUniqueCharacter();

        Console.WriteLine(firstUnique.Solve("peppetpeppes"));
    }*/

    static void Main(string[] args)
    {
        var result = new List<List<string>>();
        var groupAnagrams = new GroupAnagrams();
        var input = new List<string>
                    {
                        "eat",
                        "tea",
                        "tan",
                        "ate",
                        "nat",
                        "bat"
                    };

        result = groupAnagrams.Solve(input);

        foreach (var group in result)
        {
            Console.WriteLine($"[{string.Join(", ", group)}]");
        }
    }
}

