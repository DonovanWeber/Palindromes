using System;

namespace PalindromesChecker.Models
{
  public class Palindromes
  {
    public string Word { get; set; }
    // public int Number { get; set; }
    // public string Phrase { get; set; }

    public Palindromes(string word)
    {
      Word = word;
     
    }
    public bool CheckPalindromeWord()
    {
      return true;
    }
  }
}