using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryItems
{
    public class Extra : Comparer<LibraryItem>
    {
        string itemType;//string to hold the value of item ones type
        string itemType2;//string to hold the value of item twos type
                         // Precondition: none 
                         // Postcondition: Values are checked for null return value if null, types are then checked if equal then return compared titles, if not equal then return the compared types
        public override int Compare(LibraryItem LibItem1, LibraryItem LibItem2)
        {
            
            if (LibItem1 == null && LibItem2 == null)
                return 0;

            if (LibItem1 == null)
                return -1;

            if (LibItem2 == null)
                return 1;

            itemType = LibItem1.GetType().ToString();

            itemType2 = LibItem2.GetType().ToString();

            if (itemType == itemType2)
                return (LibItem1.Title).CompareTo(LibItem2.Title);


            return itemType.CompareTo(itemType2);
        }
    }
}
