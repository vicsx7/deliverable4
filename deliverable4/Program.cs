/* 
 Author: Victor Minaya
 Date: 2/2/2023
 Comments: This C# Consolole application code demostrates the use 
           of Arrays after getting input from users
*/

using System;

namespace deliverable4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] fibonacci = new int[25];

            // Initialize fibonacci series
            fibonacci[0] = 0;
            fibonacci[1] = 1;

            for (int i = 0; i < fibonacci.Length; i++)
            {
                if (i >= 2)
                {
                    fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
                }

                Console.WriteLine("Fibonacci(" + i + ") = " + fibonacci[i]);
            }        
        }
    }
}