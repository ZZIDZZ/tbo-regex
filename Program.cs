using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "lorem ipsum dolor sit amet consectetur lorem elit sed do eiusmod tempor incididunt ut labore et dolore magna aliqua Ut enim ad lorem veniam quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu lorem nulla pariatur Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia lorem mollit anim id est laborum";
        string pattern = "lorem";

        MatchCollection matches = Regex.Matches(text, pattern);

        if (matches.Count > 0)
        {
            Console.WriteLine("Kata kunci ditemukan pada posisi berikut:");
            foreach (Match match in matches)
            {
                Console.WriteLine("Posisi: " + match.Index);
            }
        }
        else
        {
            Console.WriteLine("Kata kunci tidak ditemukan dalam teks.");
        }

        System.Console.WriteLine();

        string email = "zidan@gmail.com";
        pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
        System.Console.WriteLine("Email: " + email);
        System.Console.WriteLine("Pattern: " + pattern);

        if (Regex.IsMatch(email, pattern))
        {
            Console.WriteLine("Email valid.");
        }
        else
        {
            Console.WriteLine("Email tidak valid.");
        }

        System.Console.WriteLine();


        text = "lorem ipsum dolor sit amet consectetur lorem elit sed do eiusmod tempor incididunt ut labore et dolore magna aliqua Ut enim ad lorem veniam quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu lorem nulla pariatur Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia lorem mollit anim id est laborum";
        pattern = "lorem";
        System.Console.WriteLine("Teks sebelum penggantian: \n" + text);
        System.Console.WriteLine("Pattern: " + pattern);

        string replacedText = Regex.Replace(text, pattern, "!");
        Console.WriteLine("Teks setelah penggantian: \n" + replacedText);
    }
}
