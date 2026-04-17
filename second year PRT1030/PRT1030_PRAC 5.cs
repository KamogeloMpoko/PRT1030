using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // PART 1: Hashtable 
        Hashtable teams = new Hashtable();

        teams.Add("MUN", "Manchester United");
        teams.Add("TOT", "Tottenham Hotspur");
        teams.Add("LIV", "Liverpool");
        teams.Add("EVE", "Everton");
        teams.Add("MCI", "Manchester City");
        teams.Add("WOL", "Wolverhampton Wanderers");
        teams.Add("CHE", "Chelsea");
        teams.Add("ARS", "Arsenal");

        // Display all teams
        foreach (DictionaryEntry entry in teams)
        {
            Console.WriteLine($"Key: {entry.Key,3}| Value: {entry.Value}");
        }

        Console.WriteLine();

        // Search for a team by key
        Console.Write("Enter a team abbreviation (eg. LIV) you want to search for: ");
        string searchKey = Console.ReadLine().ToUpper();

        if (teams.ContainsKey(searchKey))
        {
            Console.WriteLine("Found it!");
        }
        else
        {
            Console.WriteLine("Team not found.");
        }

        Console.WriteLine();

        // PART 2: LinkedList
        LinkedList<string> teamList = new LinkedList<string>();

        // Take four team full names from the Hashtable
        teamList.AddLast((string)teams["ARS"]);
        teamList.AddLast((string)teams["MUN"]);
        teamList.AddLast((string)teams["LIV"]);
        teamList.AddLast((string)teams["WOL"]);

        // Display the four teams
        foreach (string team in teamList)
        {
            Console.WriteLine(team);
        }

        Console.WriteLine();

        // Remove the 2nd team
        LinkedListNode<string> secondNode = teamList.First.Next;
        teamList.Remove(secondNode);

        Console.WriteLine("2nd team removed.");

        // Display the list again
        foreach (string team in teamList)
        {
            Console.WriteLine(team);
        }
    }
}