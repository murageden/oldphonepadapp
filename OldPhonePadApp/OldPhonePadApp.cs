

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace OldPhonePadApp;

public class OldPhonePadApp

{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter numbers (0-9) to simulate key press to old phone keypad:");
        string input = Console.ReadLine();

        string result = OldPhonePad(input);

        Console.WriteLine("Old phone keypad result: " + result);
    }

    public static string OldPhonePad(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return string.Empty;
        }

        var phonePad = new Dictionary<char, string> {
        {'1', ",.?!:;@$%&*()"},
        {'2', "ABC"},
        {'3', "DEF"},
        {'4', "GHI"},
        {'5', "JKL"},
        {'6', "MNO"},
        {'7', "PQRS"},
        {'8', "TUV"},
        {'9', "WXYZ"},
        {'0', " "}
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
            else if (currentChar == ' ')
            {
                i++; // Space to next character
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
                    if (key == '0')
                    {
                        // Special case for '0' which maps to space
                        result.Append(' ');
                    }
                    else
                    {
                        string alphabets = phonePad[key];
                        int index = (count - 1) % alphabets.Length;
                        result.Append(alphabets[index]);
                    }
                }
            }
        }

        return result.ToString();
    }


}  


// The code above defines a program that converts a string to an old phone pad format.
// It uses a dictionary to map characters to their corresponding phone pad numbers. 
// The main method prompts the user for input and displays the converted result.
// The OldPhonePad method handles the conversion logic.