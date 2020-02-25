using System;

class Palindrome
{
  public static void Main()
  {
    Console.WriteLine("Is it a palindrome?");
    Console.Write("Enter text: ");
    string input = Console.ReadLine();
    string[] processed = ProcessString(input);

    Console.WriteLine();
    Console.WriteLine(CheckPalindrome(processed[0], processed[1]));
  }

  public static string[] ProcessString(string input)
  {
    string lowerInput = input.ToLower();
    string noSpaceInput = lowerInput.Replace(" ",String.Empty);
    char[] inputArray = noSpaceInput.ToCharArray();
    Array.Reverse(inputArray);
    string reversedInput = String.Join("",inputArray);
    string[] words = new string[] {noSpaceInput, reversedInput};
    return words;
  }
  public static string CheckPalindrome(string forward, string reversed)
  {
    if (forward == reversed)
    {
      return "That is a palindrome.";
    }
    else
    {
      return "Not a palindrome.";
    }
  }
}