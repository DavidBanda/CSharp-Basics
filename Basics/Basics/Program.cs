using System;

namespace Basics
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*Create variables and append them to a string*/
            string characterName = "David";
            int charaterAge = 24;
            charaterAge++;
            char grade = 'a';

            
            Console.WriteLine($"Hol{grade} {characterName}, de {charaterAge} años");
        }
    }
}
