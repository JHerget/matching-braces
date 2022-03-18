﻿using System;

namespace JobNimbus
{
    class Braces
    {
        static bool MatchingBraces(string inputString)
        {
            int openBraces = 0;

            foreach (char c in inputString)
            {
                if (c.Equals('{'))
                {
                    openBraces++;
                }

                if (c.Equals('}'))
                {
                    if (openBraces <= 0)
                    {
                        return false;
                    }

                    openBraces--;
                }
            }

            return !(openBraces > 0);
        }

        static void UnitTest(string[] testInputsArray, bool[] testOutputsArray)
        {
            Console.WriteLine("Start testing...");

            for (int i=0; i<testInputsArray.Length; i++)
            {
                string testInput = testInputsArray[i];
                bool outputActual = testOutputsArray[i];
                bool output = MatchingBraces(testInput);

                if (output != outputActual)
                {
                    Console.WriteLine($"For the string '{testInput}' the output '{output}' was given. The expected output was '{outputActual}'.");
                }
            }

            Console.WriteLine("End testing...");
        }

        static void Main(string[] args)
        {
            string[] testInputsArray = new string[] { "{}", "}{", "{{}", "", "{abc...xyz}" };
            bool[] testOutputsArray = new bool[] { true, false, false, true, true };

            UnitTest(testInputsArray, testOutputsArray);
        }
    }
}
