// Program 1A
// CIS 200-01
// Due: 2/13/2020
// By: Andrew L. Wright (Students use Grading ID)

// File: Program.cs
// This file creates a small application that tests the LibraryItem hierarchy

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibraryItems;
using static System.Console;


public class Program
{
    // Precondition:  None
    // Postcondition: The LibraryItem hierarchy has been tested demonstrating polymorphism
    //                in CalcLateFee()
    public static void Main(string[] args)
    {
        const int DAYSLATE = 5; // Number of days late to test each object's CalcLateFee method

        List<LibraryItem> items = new List<LibraryItem>();       // List of library items
        List<LibraryPatron> patrons = new List<LibraryPatron>(); // List of patrons

        // Test data - Magic numbers allowed here
        items.Add(new LibraryBook("The Wright Guide to C#", "UofL Press", 2010, 14,
            "ZZ25 3G", "Andrew Wright"));
        items.Add(new LibraryMovie("   Andrew's Super-Duper Movie   ", "   UofL Movies   ", 2019, 7,
            "MM33 2D", 92.5, "   Andrew L. Wright   ", LibraryMediaItem.MediaType.BLURAY,
            LibraryMovie.MPAARatings.PG)); // Trims?
        items.Add(new LibraryMusic("C# - The Album", "UofL Music", 2020, 14,
            "CD44 4Z", 84.3, "Dr. A", LibraryMediaItem.MediaType.CD, 10));
        items.Add(new LibraryJournal("Journal of C# Goodness", "UofL Journals", 2018, 14,
            "JJ12 7M", 1, 2, "Information Systems", "Andrew Wright"));
        items.Add(new LibraryMagazine("C# Monthly", "UofL Mags", 2017, 14,
            "MA53 9A", 16, 7));

        // Add patrons
        patrons.Add(new LibraryPatron("Ima Reader", "12345"));
        patrons.Add(new LibraryPatron("Jane Doe", "11223"));
        patrons.Add(new LibraryPatron("   John Smith   ", "   654321   ")); // Trims?

        Console.WriteLine("List of items at start:\n");
        foreach (LibraryItem item in items)
            WriteLine($"{item}\n");
        Pause();

        // Check out some items
        items[0].CheckOut(patrons[0]);
        items[2].CheckOut(patrons[2]);
        items[4].CheckOut(patrons[1]);

        WriteLine("List of items after checking some out:\n");
        foreach (LibraryItem item in items)
            WriteLine($"{item}\n");
        Pause();

        WriteLine($"Calculated late fees after {DAYSLATE} days late:\n");
        WriteLine($"{"Title",30} {"Call Number",11} {"Late Fee",8}");
        WriteLine("------------------------------ ----------- --------");

        // Caluclate and display late fees for each item
        foreach (LibraryItem item in items)
            WriteLine($"{item.Title,30} {item.CallNumber,11} {item.CalcLateFee(DAYSLATE),8:C}");
        Pause();
    }

    // Precondition:  None
    // Postcondition: Pauses program execution until user presses Enter and
    //                then clears the screen
    public static void Pause()
    {
        WriteLine("Press Enter to Continue...");
        ReadLine();

        Clear(); // Clear screen
    }
}