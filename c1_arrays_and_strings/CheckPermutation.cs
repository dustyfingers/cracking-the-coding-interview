// 1.2 implement an algorithm that, when given two strings, will determine if one is a permutation of the other

using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CheckPermutationApp {
  class CheckPermutation {

    private bool CheckStrings(string first, string second) {
      bool retval = false;
    
      // how to tackle this...
      // take first string, split to create list of strings
      // take second string, do the same
      // if the two arrays have the same elements, the second is a permutation of the first 

      List<string> firstList = new List<string>(Regex.Split(first, string.Empty));
      List<string> secondList = new List<string>(Regex.Split(second, string.Empty));

      if (firstList.Count != secondList.Count) return retval;

      retval = firstList.All(secondList.Contains);

      return retval;

    }

    public static void Main(string[] args) {

      CheckPermutation checkPermutation = new CheckPermutation();

      Console.WriteLine("Give me a string!");

      string first = Console.ReadLine();
      
      Console.WriteLine("Thanks. Give me another string!");

      string second = Console.ReadLine();

      bool result = checkPermutation.CheckStrings(first, second);

      if (result) Console.WriteLine("String 2 is a permutation of string 1.");
      else Console.WriteLine("The strings are not permutations of each other.");

    }
  }

}