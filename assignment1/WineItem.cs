using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class WineItem
    {
        private String id;
        private String description;
        private String pack;

        public String Id
        {
            get { return id; }
            set { id = value; }
        }

        public String Description
        {
            get { return description; }
            set { description = value; }
        }

        public String Pack
        {
            get { return pack; }
            set { pack = value; }
        }

        public String FullDetails()
        {
            return this.id + " " + this.description + " " + this.pack;
        }

        //3 Parameter constructor
        public WineItem (String id, String description, String pack)
        {
            this.id = id;
            this.description = description;
            this.pack = pack;
        }

        //Default constructor
        public WineItem()
        {
            //Lets just leave this blank
        }


        //Override method that will print all of the fields
        //It overrides the the default ToString method.
        public override String ToString()
        {
            return this.id + " " + this.description + " " + this.pack;
        }

        //Creates a string with each item in the directory on a new line
        public static String CreateString(WineItem[] wineItems)
        {
            String allOutput = "";
            foreach (WineItem wineItem in wineItems)
            {
                if (wineItem != null)
               {
                    allOutput += wineItem.ToString() + Environment.NewLine;
               }
            }
            
            return allOutput;
        }

        //Sorts the array in ascending or descending order depending on user input.
        //Creates a string with each item and the location on a new line.
        //Ex: Item + Location
        //    Item + Location
        //    ..etc.
        public static String CreateLongString(WineItem[] wineItems, WineItemCollection[] collections, Int32 selection2_Int32)
        {
            Boolean backwardsArray = false;
            if (selection2_Int32 == 1)
            {
                //Sort Ascending (by id).
                BubbleSort(wineItems);
            }
            if (selection2_Int32 == 2)
            {
                //Sort Ascending (by id) and then reverse sort (for descending result).
                BubbleSort(wineItems);
                Array.Reverse(wineItems);
                backwardsArray = true;
            }
            
            String allOutput = "";
            Int32 stringCounter = 0;

            foreach (WineItem wineItem in wineItems)
            {
                if (wineItem != null)
                {
                    //I am not sure if this is the correct way to increment the counter for the collection, but it works.
                    //My method of thinking is that if there is an item, it must be stored in a location.
                    allOutput += wineItem.ToString() + " Storage Location: " + collections[stringCounter].ToString() + Environment.NewLine;
                    stringCounter++;
                }
            }
            if (backwardsArray)
            {
                Array.Reverse(wineItems); // had issues with seaching an array with the first few items = null.
            }

            return allOutput;
        }

        // Sorts the the file by id and swaps the id, name and size if needed.
        public static void BubbleSort(WineItem[] wineItems)
        {
            for (Int32 anotherCounter_Int32 = 1; anotherCounter_Int32 < wineItems.Length; anotherCounter_Int32++)
            {
                for (Int32 yetAnotherCounter_Int32 = 0; yetAnotherCounter_Int32 < wineItems.Length - anotherCounter_Int32; yetAnotherCounter_Int32++)
                {
                    if (wineItems[yetAnotherCounter_Int32 + 1] != null && wineItems[yetAnotherCounter_Int32] != null)
                    {
                        if (wineItems[yetAnotherCounter_Int32].Id.CompareTo(wineItems[yetAnotherCounter_Int32 + 1].Id) > 0)
                        {
                            Swap(ref wineItems[yetAnotherCounter_Int32], ref wineItems[yetAnotherCounter_Int32 + 1]);
                        }
                        else
                        {
                            //Leave good enough alone
                        }
                    }
                    
                }
            }
        }

        // The process used to swap two arrays.
        private static void Swap(ref WineItem greater, ref WineItem less)
        {
            WineItem temp_String = greater;
            greater = less;
            less = temp_String;
        }


        //Directs the program to run the selected search type
        public static Int32 SearchType(WineItem[] wineItems, String temp, Int32 selection3_Int32, Int32 arrayCount)
        {
            Int32 foundLocation = -1;
            switch (selection3_Int32)
            {
                case 1:
                    {
                        foundLocation = SequentialSearch(wineItems, temp);
                        break;
                    }

                case 2:
                    {
                        WineItem.BubbleSort(wineItems);
                        foundLocation = BinarySearch(wineItems, temp, arrayCount);
                        break;
                    }

            }
                
            return foundLocation;
        }

        //Compares the user input to every item one after another, and only prints the matching items to the terminal.
        //Allows for more than one matching item to be printed to the terminal.
        public static Int32 SequentialSearch(WineItem[] wineItems, String temp)
        {
            Int32 whyNotAnotherCounter_Int32 = 0;
            Int32 location_Int32 = -1;

            while (whyNotAnotherCounter_Int32 < wineItems.Length && wineItems[whyNotAnotherCounter_Int32] != null)
            {
                if (wineItems[whyNotAnotherCounter_Int32] != null)
                {
                    if (wineItems[whyNotAnotherCounter_Int32].Id.Equals(temp))
                    {
                        UserInterface.PrintMatchingItem(wineItems, whyNotAnotherCounter_Int32);
                        location_Int32 = whyNotAnotherCounter_Int32;
                    }
                    
                }
                whyNotAnotherCounter_Int32++;
                
            }
            return location_Int32;
        }

        //Sorts the array and then compares the user input to the sorted list.
        //This method does not compare every item in the array. It keeps dividing the
        //array in half until a match is found or it cannot be divided in half again.
        //This method does not allow for multiple matches to be displayed in the terminal.
        public static Int32 BinarySearch(WineItem[] wineItems, String temp, Int32 arrayCount)
        {
            Int32 beginSearch_Int32 = 0;
            Int32 endSearch_Int32 = wineItems.Length - 1;
            Boolean match_Boolean = false;
            Int32 foundLocation_Int32 = -1;
            while (beginSearch_Int32 <= endSearch_Int32 && !match_Boolean)
            {
                Int32 middle = (beginSearch_Int32 + endSearch_Int32) / 2;
                if (String.Compare(wineItems[middle].Id, temp, true) == 0)
                {
                    match_Boolean = true;
                    foundLocation_Int32 = middle;
                    UserInterface.PrintMatchingItem(wineItems, foundLocation_Int32);
                }
                else if (String.Compare(wineItems[middle].Id, temp, true) > 0)
                {
                    endSearch_Int32 = middle - 1;
                }
                else
                {
                    beginSearch_Int32 = middle + 1;
                }
            }
            return foundLocation_Int32;
        }
    }
}
