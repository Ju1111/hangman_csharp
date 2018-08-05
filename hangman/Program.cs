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

        private char inputChar;

        private List<string> words = new List<string>();
        private int index;
        private string word;

        internal List<char> guesses = new List<char>();

        internal Hangman()
        {
            words.Add("leiden");
            words.Add("delft");
            words.Add("amsterdam");
            words.Add("haarlem");
            words.Add("utrecht");
            words.Add("groningen");
            words.Add("rotterdam");
            words.Add("arnhem");
            words.Add("dokkum");
            words.Add("leeuwarden");
            words.Add("appeldoorn");
            words.Add("nijmegen");
            words.Add("maastricht");
            words.Add("venlo");
            words.Add("eindhoven");
            words.Add("breda");
            words.Add("oss");
            words.Add("tilburg");
            words.Add("enschede");
            words.Add("zwolle");
            words.Add("gouda");
            words.Add("amersfoort");
        }

        internal void addToList(char userInput)
        {
            guesses.Add(userInput);
        }

        internal void Game()
        {
            if (guesses.Count == 0)
            {
                hello = "Today I will let you gess Dutch cities. Ready to go? Then pelease guess your first letter and press enter.";
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(hello);
            }

            Random r = new Random();
            index = r.Next(words.Count);
            word = words[index];

            Console.WriteLine(word);

            Console.ForegroundColor = ConsoleColor.Cyan;
            input = Console.ReadLine().ToLower();
            inputChar = char.Parse(input);

            if (inputChar >= 'a' && inputChar <= 'z')
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Player wrote: " + input);
                addToList(inputChar);
                Console.WriteLine(guesses.Count);
            }
            else
            {
                Console.WriteLine("Please choose a letter bewteen a and z!");
            }
        }
    }
}
