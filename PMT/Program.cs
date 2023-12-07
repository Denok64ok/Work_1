using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string inputString = Console.ReadLine();

        if (Regex.IsMatch(input: inputString, "^[a-z]*$"))
        {
            string result = ProcessString(input: inputString);

            Console.WriteLine(result);
        }
        else
        {
            throw new InvalidStringException("Были введены не подходящие символы: " + GetInvalidCharacters(input: inputString));
        }
    }

    class InvalidStringException : Exception 
    {
        public InvalidStringException(string characters): base(characters) { }
    }

    static string GetInvalidCharacters(string input)
    {
        return new string(input.Where(c => !Regex.IsMatch(c.ToString(), "^[a-z]*$")).Distinct().ToArray());
    }

    static string ProcessString(string input)
    {
        if (input.Length % 2 == 0)
        {
            int halfLength = input.Length / 2;

            string firstHalf = input[..halfLength];
            string secondHalf = input[halfLength..];

            string reversFirstHalf = ReverseString(firstHalf);
            string reversSecondHalf = ReverseString(secondHalf);

            return reversFirstHalf + reversSecondHalf;
        }
        else
        {
            string reversInput = ReverseString(input);

            return reversInput + input;
        }
    }

    static string ReverseString(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
