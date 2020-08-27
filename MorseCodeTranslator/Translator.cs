using System;

namespace MorseCodeTranslator
{
    class Translator
    {
        public static string MorseToEnglish(string textToTranslate)
        {
            string translatedText = "";
            
            string[] words = textToTranslate.Split(new string[] {"   "},StringSplitOptions.None);
            foreach (string word in words)
            {
                string[] letters = word.Split(' ');
                foreach (string letter in letters)
                {
                    translatedText += Alphabet.EnglishAlphabet[Array.IndexOf(Alphabet.MorseAlphabet, letter)];
                    
                }
                translatedText += " ";
            }
            translatedText = translatedText.TrimEnd(' ');
            return translatedText;
        }

        public static string EnglishToMorse(string textToTranslate)
        {
            string translatedText = "";
            string[] words = textToTranslate.Split(' ');
            foreach(string word in words)
            {
                char[] letters = word.ToCharArray();
                foreach (char letter in letters)
                {
                    translatedText += Alphabet.MorseAlphabet[Array.IndexOf(Alphabet.EnglishAlphabet, Char.ToLower(letter))];
                    translatedText += " ";
                }
                translatedText += "  ";
            }
            translatedText = translatedText.TrimEnd(' ');
            return translatedText;
        }
    }

}


