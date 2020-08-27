using System;

namespace MorseCodeTranslator
{
    class Test
    {
        public static void CheckAnswer(string answer, string expected)
        {
            if(answer == expected)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Test Passed");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Test Failed");
                Console.ResetColor();
            }
        }
    }

}


