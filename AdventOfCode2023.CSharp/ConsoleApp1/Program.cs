﻿using Aoc2023.ActiveDay;
using Aoc2023.ActiveDay.CompletedDays;
using System.Diagnostics;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = File.ReadAllText("input.txt");

            //new RunCompletedDays().RunDay03();

            var sln = new Solution();
            int res1 = sln.Solve1(input);
            Trace.Assert(res1 == 514969);
            int res2 = sln.Solve2(input);
            Trace.Assert(res2 == 78915902);
        }
    }
}
