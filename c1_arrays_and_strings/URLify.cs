// 1.2 implement an algorithm that when given string will replace
// space characters with '%20'

// test cases
// 'bad things will happen'             ==> 'bad%20things%20will%20happen'
// 'bad things will happen        '     ==> 'bad%20things%20will%20happen'

using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace URLifyApp {
  class URLify {

    private string URLifyString(string givenStr)
    {

      // how to tackle this...
      // split the string into a list on the spaces
      // join the string back together with %20 in between the 'words'

      List<string> wordList = new List<string>(Regex.Split(givenStr, " ").Where(s => s != ""));

      string result = String.Join("%20", wordList.ToArray());

      return result;

    }

    public static void Main(string[] args)
    {

      URLify urlify = new URLify();

      Console.WriteLine("Give me a string!");

      string givenStr = Console.ReadLine();

      string result = urlify.URLifyString(givenStr);

      
      Console.WriteLine("Here is your urlified string:");

      Console.WriteLine(result);

    }

  }
}