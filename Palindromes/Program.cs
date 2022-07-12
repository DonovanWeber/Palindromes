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
      char [] charArray = userInputWord.ToCharArray();
      PrintIndexAndValues(charArray);

      Palindromes userInput = new Palindromes(userInputWord);
      Console.WriteLine(userInput.CheckPalindromeWord());

    }
    public static void PrintIndexAndValues( Array myArray )  {
      for ( int i = myArray.GetLowerBound(0); i <= myArray.GetUpperBound(0); i++ )
         Console.WriteLine( "\t[{0}]:\t{1}", i, myArray.GetValue( i ) );
   }
  }
}