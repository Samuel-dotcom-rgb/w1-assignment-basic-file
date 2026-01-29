using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;

class Program
{
    static string filePath = "input.csv";
    
    static void Main()
    {
        bool running = true;

        while (running)
        {
            DisplayMenu();
            string choice = Console.ReadLine();

            switch (choice)
            {
            case "1":
                 DisplayAllCharacters();
                 break;
            case "2":
                AddCharacter();
                 break;
            case "3":
                 LevelUpCharacter();
                 break;
            case "0":
                 running = false;
                 break;
            default:
             Console.WriteLine("Invaild option.");
             break;
            }
        }
    }
}