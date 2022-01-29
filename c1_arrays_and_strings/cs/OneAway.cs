// 1.5 implement an algorithm that, when given two strings, will determine if one
// is only one edit away from the other 

// an edit is considered one of the three actions: insert a character, remove a character, replace a character

using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace OneAwayApp {
    class OneAway {

        private bool CheckStrings(string first, string second) {

            bool retval = false;
            
            // how to tackle this...
            

            return retval;

        }

        public static void Main(string[] args) {

            OneAway oneAway = new OneAway();

            Console.WriteLine("Give me a string!");

            string first = Console.ReadLine();
            
            Console.WriteLine("Thanks. Give me another string!");

            string second = Console.ReadLine();

            bool result = oneAway.CheckStrings(first, second);

            if (result) Console.WriteLine("String 2 is one character away from string 1.");
            else Console.WriteLine("String 2 is NOT one character away from string 1.");

        }
    }

}