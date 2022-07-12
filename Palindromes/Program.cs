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
      Array.Reverse(charArray);
      PrintIndexAndValues(charArray);
      string finalWord = new String(charArray);
      Console.WriteLine("Your reversed word is " + finalWord);
      Palindromes userInput = new Palindromes(userInputWord);
      TrueOrFalse(userInput.CheckPalindromeWord(finalWord));
    }
    public static void TrueOrFalse(bool palindrome)
    {  
      if (palindrome == true)
      {
        Console.WriteLine("Your word is a Palindrome");
      }
      else 
      {
        Console.WriteLine("Your word is not a Palindrome");
      }
    }
    public static void PrintIndexAndValues( Array myArray )  {
      for ( int i = myArray.GetLowerBound(0); i <= myArray.GetUpperBound(0); i++ )
         Console.WriteLine( "\t[{0}]:\t{1}", i, myArray.GetValue( i ) );
   }
  }
}