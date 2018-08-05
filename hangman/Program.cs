using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            var newGame = new Hangman();
            newGame.Game();
        }

    }

    internal class Hangman
    {
        private string hello;
        private string input;

        private List<string> words = new List<string>();
        private int index;
        private string word;

        internal List<string> guesses = new List<string>();

        internal Hangman()
        {
            words.Add("c#");
            words.Add("java");
            words.Add("css");
            words.Add("javascript");
            words.Add("html");
            words.Add("typescript");
            words.Add("php");
            words.Add("ruby");
            words.Add("sql");
            words.Add("c");
            words.Add("c++");
            words.Add("go");
            words.Add("python");
        }

        internal void addToList(string userInput)
        {
            guesses.Add(userInput);
        }

        internal void Game()
        {
            if (guesses.Count == 0)
            {
                hello = "Today I will let you guess programming languages. Ready to go? Then pelease guess your first letter and press enter.";
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(hello);
            }

            Random r = new Random();
            index = r.Next(words.Count);
            word = words[index];

            Console.WriteLine(word);

            Console.ForegroundColor = ConsoleColor.Cyan;
            input = Console.ReadLine().ToLower();

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Player wrote: " + input);
            addToList(input);
            Console.WriteLine(guesses.Count);

        }
    }
}
