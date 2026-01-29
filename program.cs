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

    // menu
    static void DisplayMenu()
    {
        Console.WriteLine("\n=== Character Manager ===");
        Console.WriteLine("1. Display Characters");
        Console.WriteLine("2. Add Character");
        Console.WriteLine("3. Level Up Character");
        Console.WriteLine("0. Exit");
        Console.Write("Choose an option:");
    }

    // task 2
    static void DisplayAllCharacters()
    {
        if (!File.Exists(filePath))
        {
            Console.WriteLine("No character file found.");
            return;
        }

        string[] lines = File.RealAllLines(filePath);

        Console.WriteLine("\n--- Characters ---");
        foreach (string line in lines)
        {
            string[] parts = line.Split(',');

            Console.WriteLine(
                $"Name: {parts[0]}, Class: {parts[1]}, Level: {parts[2]},"
            );
        }
    }

//task 3
    static void AddCharacter()
    {
        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Class: ");
        string characterClass = Console.ReadLine();

        Console.Write("Enter Level: ");
        string level = Console.ReadLine();

        Console.Write("Enter HP: ");
        string hp = Console.ReadLine();

        string newLine = $"{name},{characterClass}, {level}, {hp}";
        File.AppendAllText(filePath, newLine + Environment.NewLine);
       
       Console.WriteLine("Character added!");
    }
}
