// 1.4 implement an algorithem that when given a string, it will 
// check whether the string is a permutation of a palindrome

namespace PalindromePermutation {

  class PalindromePermutation {

    private bool CheckIfPalindromePermutation(string givenStr)
    {
      bool retval = false;

      // how to tackle this...

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