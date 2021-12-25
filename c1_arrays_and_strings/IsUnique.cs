// 1.1 implement an algorithm to determine if a string has all unique
// characters.
using System;
using System.Linq;
using System.Collections.Generic;

namespace IsUniqueApp {
  class IsUnique {

    private string DetermineIfCharsUnique(string givenString) {
      string retval = "";
      string[] uniqueChars = {};
      
      for (int i = 0; i < givenString.Length; i++) {
        if (Array.IndexOf(uniqueChars, Char.ToString(givenString[i])) == -1) {
          Array.Resize(ref uniqueChars, uniqueChars.Length + 1);
          uniqueChars[uniqueChars.Length - 1] = Char.ToString(givenString[i]);
        }
      }

      if (givenString.Length == uniqueChars.Length) {
        retval = "The string has only unique chars.";
      } else {
        retval = "This string has repeating characters.";
      }

      return retval;

    }

    public static void Main(string[] args) {

      IsUnique isUnique = new IsUnique();

      Console.WriteLine("Give me a string and I will determine if it is unique or not!");

      string givenString = Console.ReadLine();

      string result = isUnique.DetermineIfCharsUnique(givenString);

      Console.WriteLine(result);

    }
  }

}