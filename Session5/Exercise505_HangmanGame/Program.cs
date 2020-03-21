using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Exercise505_HangmanGame
{
    class Program
    {
        static void Main(string[] args)
        {
            ProvidedCode pc = new ProvidedCode();
            HangManGame hg = new HangManGame();
            Console.Title = ("HangMan");
            while (true)
            {


                Console.WriteLine("Downloading word....");
                // secretWord
                string secretword = pc.GetWord().Result;
                List<string> correctLettersGuessed = new List<string>();


                int live = secretword.Length;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Welcome to Hangman Game");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Guess for a {0} letter Word ", secretword.Length);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("You have {0} lives", live);
                hg.Isletter(secretword, correctLettersGuessed);
                // while live is greater than 0
                while (live > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    string input = Console.ReadLine();

                    // if letterGuessed contains input
                    if (correctLettersGuessed.Contains(input))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You Entered letter [{0}] already", input);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Try a different word");
                        hg.GetAlphabet(input);
                        continue;
                    }


                    // if word found
                    correctLettersGuessed.Add(input);
                    if (hg.IsWord(secretword, correctLettersGuessed))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(secretword);
                        Console.WriteLine("Congratulations");
                        break;
                    }
                    // if a letter in word found
                    else if (secretword.Contains(input))
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("wow nice entry");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        string letters = hg.Isletter(secretword, correctLettersGuessed);
                        Console.Write(letters);

                    }
                    // when a wrong code is entered
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Oops, letter not in my word");
                        live -= 1;
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("You have {0} live", live);
                        hg.GetAlphabet(input);
                    }

                    Console.WriteLine();
                    // print secret word 
                    if (live == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Game over \nMy secret Word is [ {0} ]", secretword);
                        break;
                    }

                }

                Console.WriteLine("press any key to retry");
                Console.ReadKey();










            }
        }


    }




}
