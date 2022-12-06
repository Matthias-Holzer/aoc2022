using Microsoft.AspNetCore.Mvc;

namespace AdventOfCode.Controllers;

public class Day02Controller : Controller
{
    // GET
    public IActionResult One()
    {
        string[] input = System.IO.File.ReadAllLines("Input/day02.txt");        
        List<string> list = input.ToList();
        
        Dictionary<string, int> dic = new();

        dic["pointsForRock"] = list.Count(s => s.Contains('X')) * 1;
        dic["pointsForPaper"] = list.Count(s => s.Contains('Y')) * 2;
        dic["pointsForScissors"] = list.Count(s => s.Contains('Z')) * 3;

        dic["pointsForDraw"] = list.Count(s => s.Contains("A X") || s.Contains("B Y") || s == ("C Z")) * 3;
        dic["pointsForWin"] = list.Count(s => s is "A Y" or "B Z" or "C X") * 6;
        
        return View(dic);
    }

    public IActionResult Two()
    {
        List<string> input = System.IO.File.ReadAllLines("Input/day02.txt").ToList();

        Dictionary<string, int> dic = new();
        
        // rock i have to play,
        // when its rock(A) and i want a draw(Y),
        // when its paper(B) and i want to lose(X),
        // when its scissors(C) and i want to win(Z),
        dic["pointsForRock"] = 1 * input.Count(s => s is "A Y" or "B X" or "C Z");
        dic["pointsForPaper"] = 2 * input.Count(s => s is "A Z" or "B Y" or "C X");
        dic["pointsForScissors"] = 3 * input.Count(s => s is "A X" or "B Z" or "C Y");

        dic["pointsForDraw"] = 3 * input.Count(s => s.Contains("Y"));
        dic["pointsForWin"] = 6 * input.Count(s => s.Contains("Z"));

        return View(dic);
    }
}