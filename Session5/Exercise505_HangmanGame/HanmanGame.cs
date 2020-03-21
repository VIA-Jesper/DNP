using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise505_HangmanGame
{
    class HangManGame
    {   
        // checking for word 
        public bool IsWord(string secreword, List<string> letterGuessed)
        {

            bool word = false;
            // loop through secretword
            for (int i = 0; i < secreword.Length; i++)
            {
                // initialize c with the index of secretword[i]
                string c = Convert.ToString(secreword[i]);
                // check if c is in list of letters Guess
                if (letterGuessed.Contains(c))
                {
                    word = true;
                }
                /*if c is not in the letters guessed then we dont have the
                 * we dont have the full word*/
                else
                {
                    // change the value of word to false and return false
                    return word = false;

                }

            }
            return word;
        }

        // check for single letter 
        public string Isletter(string secretword, List<string> letterGuessed)
        {
            // set guessedword as empty string
            string correctletters = "";
            // loop through secret word
            for (int i = 0; i < secretword.Length; i++)
            {
                /* initialize c with the value of index i
                 * mean when i = 0
                 * c = secretword[0] is the first index of secretword
                 * c = secretword[1] is the second index of secretword and so on */
                string c = Convert.ToString(secretword[i]);

                // if c is in list of lettersGuessed 
                if (letterGuessed.Contains(c))
                {
                    // add c to correct letters
                    correctletters += c;
                }
                else
                {
                    // else print (__) to show that the letter is not in the secretword
                    correctletters += "_ ";
                }

            }
            // after looping return all the correct letters found
            return correctletters;

        }


        private List<string> alphabet = null;

        // The alphabet to use
        public void GetAlphabet(string letters)
        {
            if (alphabet == null)
            {
                alphabet = new List<string>();
                for (int i = 1; i <= 26; i++)
                {
                    char alpha = Convert.ToChar(i + 96);
                    alphabet.Add(Convert.ToString(alpha));
                }
            }
            

            // for regulating the number of alphabet left
            int num = 49;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Letters Left are :");

            
            for (int i = 0; i < num; i++)
            {
                if (alphabet.Contains(letters))
                {
                    alphabet.Remove(letters);
                    num -= 1;
                }
               
            }

            foreach (var alpha in alphabet)
            {
                Console.Write("[" + alpha + "] ");
            }

            Console.WriteLine();

        }

    }
}
