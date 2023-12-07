using System;

class Program
{
    static void Main()
    {
        string inputString = Console.ReadLine();

        string result = ProcessString(input: inputString);

        Console.WriteLine(result);
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
