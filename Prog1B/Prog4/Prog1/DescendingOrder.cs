using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryItems
{
    public class DescendingOrder : Comparer<LibraryItem>
    {           
        // Precondition: none 
        // Postcondition: if both are equal after null check a zero is returned, if item one is greater than item two positive number returned, if item two is greater a negative number will be returned 

        public override int Compare(LibraryItem Lib1, LibraryItem Lib2)
        {
            if (Lib1 == null && Lib2 == null)
                return 0;

            if (Lib1 == null)
                return -1;

            if (Lib2 == null)
                return 1;
            return (-1) * (Lib1.CopyrightYear).CompareTo(Lib2.CopyrightYear);
           
        }
    }
}
