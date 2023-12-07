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
            CountCharacters(input: result);
        }
        else
        {
            throw new InvalidStringException("Были введены не подходящие символы: " + GetInvalidCharacters(input: inputString));
        }
    }

    static void CountCharacters(string input)
    {
        foreach (var baseCharacter in input.Distinct().ToArray())
        {
            var count = input.Count(character => character == baseCharacter);
            Console.WriteLine("Количество символов {0} в обработанной строке = {1}", baseCharacter, count);
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
