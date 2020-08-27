using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCodeTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            Console.WriteLine("Morse Code Translator");

            Console.WriteLine("Test 1");
            answer = MorseCodeTranslator(true,  ".... .- .-.. .-.. ---   .... --- .--   .- .-. .   -.-- --- ..-");
            Console.WriteLine(answer);
            Console.WriteLine("Expected: hallo how are you");
            Test.CheckAnswer(answer, "hallo how are you");

            Console.WriteLine("Test 2");
            answer = MorseCodeTranslator(false, "Just wanted to know how was you day");
            Console.WriteLine(answer);
            Console.WriteLine("Expected: .--- ..- ... -   .-- .- -. - . -..   - ---   -.- -. --- .--   .... --- .--   .-- .- ...   -.-- --- ..-   -.. .- -.--");
            Test.CheckAnswer(answer, ".--- ..- ... -   .-- .- -. - . -..   - ---   -.- -. --- .--   .... --- .--   .-- .- ...   -.-- --- ..-   -.. .- -.--");


            Console.ReadKey();

            
        }

        static string MorseCodeTranslator(bool MorseToEnglish, string textToTranslate)
        {

            string translatedText = "";
            if(MorseToEnglish == true)
            {
                translatedText = Translator.MorseToEnglish(textToTranslate);
            }
            else
            {
                translatedText = Translator.EnglishToMorse(textToTranslate);
            }

            return translatedText;
        }
    }
    class Validation
    {
        public static bool MorseCodeValidation(string morseCode)
        {

        }
    }

}


