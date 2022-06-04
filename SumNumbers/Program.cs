using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] nums = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            Console.WriteLine(nums.Count());
            Console.WriteLine(nums.Sum());
        }

    }
}

