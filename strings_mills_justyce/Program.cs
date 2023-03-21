using System;

namespace strings_mills_justyce
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please input a character");
            char myChar = Console.ReadKey().KeyChar;
            bool isLetter = char.IsLetter(myChar);
            Console.WriteLine($"\n{myChar} is a letter: {isLetter}.");
            Console.WriteLine("input a sentnce");
            string sentence = Console.ReadLine();
            Console.WriteLine("input a word");
            string word = Console.ReadLine();
            bool isIn = sentence.Contains(word);
            Console.WriteLine($"{word} exists in {sentence}, {isIn}");
        }
    }
}
