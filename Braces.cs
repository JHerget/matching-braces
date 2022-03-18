using System;

namespace JobNimbus
{
    class Braces
    {
        static bool MatchingBraces(string inputString)
        {
            int openBraces = 0; //keep track of how many open braces we've encountered

            foreach (char c in inputString) //loop through each character of the given string
            {
                if (c.Equals('{'))
                {
                    openBraces++; //increment the number of open braces that need closing braces
                }

                if (c.Equals('}'))
                {
                    if (openBraces <= 0) //if we haven't encountered any open braces then we already know we have mismatched braces
                    {
                        return false;
                    }

                    openBraces--; //decrement the number of open braces that don't have a closing brace
                }
            }

            return !(openBraces > 0); //if the number of open braces is 0 return true, otherwise false
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
