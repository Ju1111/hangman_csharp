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

        private string hello = "Today I will let you guess programming languages. Ready to go? Then pelease guess your first letter and press enter.";

        private string input = Console.ReadLine();

        private List<string> words = new List<string>();
        private int index;
        private string word;

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

        internal void Game()
        {
            Random r = new Random();
            index = r.Next(words.Count);
            word = words[index];

            Console.WriteLine(word);

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(hello);
            
            Console.ForegroundColor = ConsoleColor.Cyan;
            var playerInput1 = new Guess();

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Player wrote: " + playerInput1.input);
            playerInput1.addToList(playerInput1.input);
            Console.WriteLine(playerInput1.guesses.Count);

        }
    }

    internal class Guess
    {
        internal string input = Console.ReadLine();

        internal List<string> guesses = new List<string>();

        internal void addToList(string input)
        {
            guesses.Add(input);
        }
    }
}
