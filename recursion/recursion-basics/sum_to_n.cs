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
    class SumToNRecursion
    {
        static void Main(string[] args){

            int n = 6;
            int result = SumToN(n);
            Console.WriteLine(String.Format("The sum of 1 to {0} is: {1}", n.ToString(), result.ToString()));

        }

        // Returns the sum of all natural numbers from 1 to n inclusive
        public static int SumToN(int n){

            if (n == 1){
                return 1;
            } else {
                return n + SumToN(n-1);
            }

        }
    }
}
