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
        internal void Game()
        {
            var newWord = new RandomWord();
            Console.WriteLine(newWord.word);
            
            var greeting = new Greeting();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(greeting.hello);
            
            Console.ForegroundColor = ConsoleColor.Cyan;
            var playerInput1 = new Guess();
            
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Player wrote: " + playerInput1.input);
            playerInput1.addToList(playerInput1.input);
            Console.WriteLine(playerInput1.guesses.Count);

        }
    }

    internal class Greeting
    {
        internal string hello = "Today I will let you guess programming languages. Ready to go? Then pelease guess your first letter and press enter.";
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

    internal class RandomWord
    {
        internal List<string> words = new List<string>();
        internal int index;
        internal string word;

        internal RandomWord()
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

            Random r = new Random();
            index = r.Next(words.Count);
            word = words[index];
        }
    }
}
