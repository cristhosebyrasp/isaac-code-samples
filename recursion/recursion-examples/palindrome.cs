/*
Note: This file is designed to be copied out and compiled on your machine. 
In order for it to compile properly you need to ensure that the project name is the same as the "namespace" in this file. 

To run this file you need to:
1. Copy the contents
2. Paste them into the C# IDE of your choice (Visual Studio, for example)
3. Compile the program
4. Run the program
*/

using System;

namespace isaac_code_samples
{
    class PalindromeRecursive
    {
        static void Main(string[] args){
            string test_word = "kayak";
            bool is_palindrome = Palindrome(test_word);
            Console.WriteLine(String.Format("{0}: {1}", test_word, is_palindrome.ToString()));
        }

        // Returns True if string is a palindrome
        public static bool Palindrome(string word){

            int length = word.Length;
            if (length == 0 || length == 1){
                return true;
            } else if (word[0] == word[length - 1]){
                string new_word = word.Substring(1, length - 2);
                return Palindrome(new_word);
            } else {
                return false;
            }
        }
    }
}