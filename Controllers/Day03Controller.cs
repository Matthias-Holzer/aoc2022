using Microsoft.AspNetCore.Mvc;

public class Day03Controller : Controller
{
    private List<char> ca = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToList();
    public IActionResult One(){
        List<string> input = System.IO.File.ReadAllLines("Input/day03.txt").ToList();

        List<char> equals = new();
        foreach(string s in input){
            int len = s.Length;
            string s1 = s.Substring(0,len/2);
            string s2 = s.Substring(len/2,len/2);

            foreach(char c in s1){
                if(s2.Contains(c)){
                    equals.Add(c);
                    break;
                }
            }
        }

        int sum = 0;
        foreach(char s in equals){
            sum += ca.IndexOf(s)+1;
        }

        return View(sum);
    }

    public IActionResult Two(){
        List<string> input = System.IO.File.ReadAllLines("Input/day03.txt").ToList();

        List<char> badges = new();
        for(int i = 0; i<=input.Count()-3; i+=3){
            foreach(char c in input[i]){
                if(input[i+1].Contains(c)){
                    if(input[i+2].Contains(c)){
                        badges.Add(c);
                        break;
                    }
                }
            }
        }

        int sum = 0;
        foreach(char s in badges){
            sum += ca.IndexOf(s)+1;
        }
        return View(sum);
    }
}