// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Console.WriteLine(132 % 10);
//Console.WriteLine(13 % 10);
//Console.WriteLine(1 % 10);
Solution solution = new Solution();
Console.WriteLine("Ответ: " + solution.IsPalindrome(-13333331)); 

public class Solution
{
    public bool IsPalindrome(int x)
    {
        if (x < 0) return false;

        List<int> number = new List<int>();

        while (x > 0)
        {
            int y = x % 10;
            x = x / 10;
            number.Add(y);
        }

        List<int> revrseNumbers = new List<int>();

        for (int i = number.Count - 1; i >= 0; i--)
        {
            revrseNumbers.Add(number[i]);
        }

        if (number.SequenceEqual(revrseNumbers)) return true;
        return false;
    }
}