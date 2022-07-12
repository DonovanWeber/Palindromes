using System;
using System.Collections.Generic;
using PalindromesChecker.Models;

namespace PalindromesChecker
{
  class Program
  {
     public static void Main()
    {
      Console.WriteLine("Test your word, number, or phrase to see if it is a PALINDROME! ");
      Console.WriteLine("Enter a word: ");
      string userInputWord = Console.ReadLine();
      Palindromes userInput = new Palindromes(userInputWord);
      Console.WriteLine(userInput.CheckPalindromeWord());

    }
  }
}