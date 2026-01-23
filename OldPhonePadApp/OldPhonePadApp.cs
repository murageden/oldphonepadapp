

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace OldPhonePadApp;

public class OldPhonePadApp

{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Numbers (0-9) to Simulate Key Press to Old Phone Keypad:");
        string input = Console.ReadLine();

        string result = OldPhonePad(input);

        Console.WriteLine("Old Phone Keypad Result: " + result);
    }

    public static string OldPhonePad(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return string.Empty;
        }

        var phonePad = new Dictionary<char, string> {
            {'1', ",.?!:;@$%&*()"},
            {'2', "ABC2"},
            {'3', "DEF3"},
            {'4', "GHI4"},
            {'5', "JKL5"},
            {'6', "MNO6"},
            {'7', "PQRS7"},
            {'8', "TUV8"},
            {'9', "WXYZ9"},
            {'0', " 0"}
        };

        var result = new StringBuilder();
        int i = 0;
        int n = input.Length;

        while (i < n)
        {
            char currentChar = input[i];

            if (currentChar == '#')
            {
                break;
            }
            else if (currentChar == '*')
            {
                if (result.Length > 0)
                {
                    result.Length--;
                }
                i++;
            }
            else
            {
                char key = currentChar;
                int count = 0;
                while (i < n && input[i] == key)
                {
                    count++;
                    i++;
                }
                if (phonePad.ContainsKey(key))
                {
                    string alphabets = phonePad[key];
                    int index = (count - 1) % alphabets.Length;
                    result.Append(alphabets[index]);
                }
            }
        }

        return result.ToString();
    }
}