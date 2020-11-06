/*CIS 200-01
Program 1
File: Program.cs
This file creates a simple test class to test inheritance of other files and produce output to the console. 
2/12/20
Grading ID T9749*/
using LibraryItems;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program1
{
    class TestProgram
    {
        // Precondition:  None
        // Postcondition: The LibraryBook class has been tested
        public const int late1 = 14;//value to hold 14 day late variable
        public const int late2 = 7;//value to hold 7 day late variable
        public static void Main()
        {
            List<LibraryPatron> patrons = new List<LibraryPatron>();//List to hold the patrons

            patrons.Add(new LibraryPatron("    Ian G", "    8855"));
            patrons.Add(new LibraryPatron("    Jane P", "    7788"));
            patrons.Add(new LibraryPatron("    Stan P", "    5555"));
            patrons.Add(new LibraryPatron("    Liam J", "    8995"));
            patrons.Add(new LibraryPatron("    Jason J", "    7775"));

            List<LibraryItem> theBooks = new List<LibraryItem>();//List to hold the library book items.

            theBooks.Add(new LibraryJournal("The Shining", "John P", 2020, 7,
                "2512339696", 15, 10, "Fiction", "Jim Book"));
            theBooks.Add(new LibraryJournal("The Tempature", "Smith F", 2040, 9,
    "2512332356", 25, 41, "Fiction", "Tom Wall"));
            theBooks.Add(new LibraryMagazine("Welcome Home", "The Times", 2020, 26, "2534562847", 5, 2));
            theBooks.Add(new LibraryMagazine("Welcome Home", "NYC", 2020, 26, "2534562847", 7, 3));
            theBooks.Add(new LibraryBook("Home", "The Times", 2120, 15, "12546382546", "Tom riddle"));
            theBooks.Add(new LibraryBook("Welcome Back", "The Page", 2030, 16, "12548657958", "Steven Snake"));
            theBooks.Add(new LibraryMovie("Tommorrow", "Printers Pub", 2020, 10, "15245298564", 2.50, "Tom Clancy", LibraryMediaItem.MediaType.BLURAY, LibraryMovie.MPAARatings.PG));
            theBooks.Add(new LibraryMovie("Simon Says", "Loins Gate", 2010, 8, "5625478524", 1.30, "Fiddle Riddle", LibraryMediaItem.MediaType.DVD, LibraryMovie.MPAARatings.PG13));
            theBooks.Add(new LibraryMusic("Say same", "Greens", 2011, 7, "46434543155", .20, "Sam Unt", LibraryMediaItem.MediaType.CD, 12));
            theBooks.Add(new LibraryMusic("Ting tock", "Blend", 2012, 7, "13543531318", .50, "Arial Two", LibraryMediaItem.MediaType.VINYL, 5));

        Console.WriteLine("Original list of books");
            Console.WriteLine("----------------------");
            foreach (var i in theBooks)//Print books to console
                Console.WriteLine($"{i}\n");
            Console.WriteLine("-------------------");
            Pause();

            theBooks[0].CheckOut(patrons[0]);
            theBooks[1].CheckOut(patrons[1]);
            theBooks[2].CheckOut(patrons[2]);
            theBooks[3].CheckOut(patrons[3]);
            theBooks[4].CheckOut(patrons[4]);
            theBooks[5].CheckOut(patrons[0]);
            theBooks[6].CheckOut(patrons[1]);



            Console.WriteLine("After changes");
            Console.WriteLine("----------------------");
            foreach (var i in theBooks)//Print books to console
                Console.WriteLine($"{i}\n");
            Console.WriteLine("----------A--------------");
            Pause();

            var isCheckedOut =                //variable to hold checked out books
                            from i in theBooks
                            where i.IsCheckedOut() != false
                            select i;
            Console.WriteLine("Is checked out");
            Console.WriteLine("----------------------");
            foreach (var i in isCheckedOut)//Print books to console
                Console.WriteLine($"{i}\n");
            Console.WriteLine("-------------B-----------------");

            int count = isCheckedOut.Count();
            Console.WriteLine($"The number of books checked out is: {count}");
            Pause();

            var isMedia = //variable to hold the media items in book list 
            from item in isCheckedOut
            where item is LibraryMediaItem
            select item;

            Console.WriteLine("Is checked out MediaItem");
            Console.WriteLine("----------------------");
            foreach (var i in isMedia)//Print books to console
                Console.WriteLine($"{i}\n");
            Console.WriteLine();
            Pause();

            var isMag =//variable to identify the magazines in the book list
                   from item in theBooks
                   where item is LibraryMagazine
                   select item.Title;

            Console.WriteLine("Is checked out Magazine Title");
            Console.WriteLine("----------------------");
            foreach (var i in isMag)//Print books to console
                Console.WriteLine($"{i}\n");
            Console.WriteLine();
            Pause();


            Console.WriteLine("Is checked out Display title, call number, late fee");
            Console.WriteLine("----------------------");
            //Need to work on 
            foreach (var i in theBooks)//Print books to console
                Console.WriteLine($"Title {i.Title}\n Call Number {i.CallNumber}\nLate Fee ${i.CalcLateFee(late1)}\n");
            Console.WriteLine();
            Pause();

            theBooks[0].ReturnToShelf();//return books to shelf by book ID
            theBooks[1].ReturnToShelf();
            theBooks[2].ReturnToShelf();
            theBooks[3].ReturnToShelf();
            theBooks[4].ReturnToShelf();
            theBooks[5].ReturnToShelf();
            theBooks[6].ReturnToShelf();

            Console.WriteLine("After returning the books");
            Console.WriteLine("----------------------");
            foreach (var i in theBooks)//Print books to console
                Console.WriteLine($"{i}\n");
            Console.WriteLine();
            count = isCheckedOut.Count();
            Console.WriteLine($"The number of books checked out is: {count}");
            Pause();

            Console.WriteLine("Loan period +7 days");
            Console.WriteLine("----------------------");
            foreach (var i in theBooks)//Print books to console
                if (i.LoanPeriod > -1)
                {
                    i.LoanPeriod = i.LoanPeriod + late2;
                    Console.WriteLine($"Title {i.Title}\n Loan Period {i.LoanPeriod}\n");
                }                    
             Console.WriteLine();
             Pause();

            Console.WriteLine("Final Print");
            Console.WriteLine("----------------------");
            foreach (var i in theBooks)//Print books to console

                Console.WriteLine($"{i}\n");
                Console.WriteLine();
            Pause();

        }
        public static void Pause()//precondition none, post condition the user must hit enter to proceed
        {
            Console.WriteLine("Press Enter to Continue...");
            Console.ReadLine();

            Console.Clear(); // Clear screen
        }
    }
}
