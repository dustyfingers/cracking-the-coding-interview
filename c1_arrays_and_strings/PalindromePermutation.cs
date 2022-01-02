// 1.4 implement an algorithm that when given a string, will 
// check whether the string is a permutation of a palindrome

// ex: 'rrcacae' --> returns { result: true,  permutations: ['racecar', 'arcacre', ...]}
// ex: 'Tact Coa' --> returns { result: true, permutations: ['taco cat', 'atco cta', ...] }

using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace PalindromePermutation {

  class PalindromePermutation {

    private bool CheckIfPalindromePermutation(string givenStr)
    {
      bool retval = false;
      int numOfEvenLetters = 0;
      int numOfOddLetters = 0;
      int numOfLettersTotal = 0;

      // how to tackle this...
      // find if the string can be rearranged to be a palindrome
      // what does this mean?
      // a palindrome has an even number of EVERY letter - except one. 
      // it must have one letter that appear an uneven number of times

      // ...right?

      List<string> letterList = new List<string>(Regex.Split(givenStr, "").Where(s => (s != " " && s != "")));
      Dictionary<string, int> letterHash = new Dictionary<string, int>();
      
      for (int i = 0; i < letterList.Count; i++)
      {

        if (letterHash.ContainsKey(letterList[i]))
        {

          letterHash[letterList[i]]++;

        } 
        else 
        {

          letterHash.Add(letterList[i], 1);

        }

      }

      foreach (KeyValuePair<string, int> kvp in letterHash)
      {

        if (kvp.Value % 2 == 0) numOfEvenLetters++;
        else numOfOddLetters++;

        numOfLettersTotal++;

      }

      if (numOfOddLetters != 1) return retval;

      if (numOfLettersTotal - 1 == numOfEvenLetters) retval = true;

      return retval;

    }

    public static void Main(string[] args)
    {

      PalindromePermutation palindromePermutation = new PalindromePermutation();

      Console.WriteLine("Give me a string!");

      string givenStr = Console.ReadLine();

      bool result = palindromePermutation.CheckIfPalindromePermutation(givenStr);

      if (result) Console.WriteLine("The given string is a permutation of a palindrome.");
      else Console.WriteLine("The given string is NOT a permutation of a palindrome.");

    }

  }

}