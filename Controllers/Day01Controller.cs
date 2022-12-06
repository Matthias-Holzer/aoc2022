using System;
using System.IO;
using Microsoft.AspNetCore.Mvc;

namespace AdventOfCode.Controllers
{
    public class Day01Controller : Controller
    {
        public IActionResult One()
        {
            string[] input = System.IO.File.ReadAllLines("Input/day01.txt");
            int sum = 0;
            List<int> sums = new();
            foreach (string s in input)
            {
                if (s == "")
                {
                    sums.Add(sum);
                    sum = 0;
                }
                else
                    sum += Int32.Parse(s);
            }
            return View(sums);
        }

        public IActionResult Two()
        {
            string[] input = System.IO.File.ReadAllLines("Input/day01.txt");
            int sum = 0;
            List<int> sums = new();
            foreach (string s in input)
            {
                if (s == "")
                {
                    sums.Add(sum);
                    sum = 0;
                }
                else
                    sum += Int32.Parse(s);
            }
            sums.Sort();
            sums.Reverse();
            return View(sums);
        }
    }
}