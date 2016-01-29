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

        public static String CreateString(WineItem[] wineItems, Int32 selection2_Int32)
        {
            if (selection2_Int32 == 1)
            {
                //Sort Ascending (by id)
                BubbleSort(wineItems);
            }
            if (selection2_Int32 == 2)
            {
                //Sort Ascending (by id) and then reverse sort
                BubbleSort(wineItems);
                Array.Reverse(wineItems);
            }
            String allOutput = " ";
            foreach (WineItem wineItem in wineItems)
            {
                if (wineItem != null)
                {
                    allOutput += wineItem.ToString() + Environment.NewLine;
                }
            }

            return allOutput;

            //UserInterface.PrintAllOutput(allOutput);
         }

        // Sorts the the file by id and swaps the id, name and size if needed.
        public static void BubbleSort(WineItem[] wineItems)
        {
            for (Int32 anotherCounter_Int32 = 1; anotherCounter_Int32 < wineItems.Length; anotherCounter_Int32++)
            {
                for (Int32 yetAnotherCounter_Int32 = 0; yetAnotherCounter_Int32 < wineItems.Length - anotherCounter_Int32; yetAnotherCounter_Int32++)
                {
                    if (wineItems[yetAnotherCounter_Int32 + 1] != null)
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

        public static Int32 SequentialSearch(WineItem[] wineItems, String temp)
        {
            //Boolean match_Boolean = false;
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






        // Displays multiple results on the Console in Ascending or Descending order
        // depending on the user's selection.


        //public static void ListArray( String[] id, String[] name, String[] size, Int32 orderSelection)
        //{
        //    Console.Clear();
        //    Console.WriteLine(" Wine Directory ");
        //    Console.WriteLine();
        //    Console.WriteLine("{0,-8} {1,4} {2,12}", "Id", "Name", "Size");
        //    Console.WriteLine();
        //    switch (orderSelection)
        //    {
        //        case 1:
        //            {
        //                for (Int32 localCounter_Int32 = 0; localCounter_Int32 < id.Length; localCounter_Int32++)
        //                {
        //                    Console.WriteLine("{0,-8} {1,4} {2,12}", id[localCounter_Int32], name[localCounter_Int32], size[localCounter_Int32]);   // Output in Ascending order.
        //                }
        //                break;
        //            }
        //        case 2:
        //            {
        //                Array.Reverse(id);
        //                Array.Reverse(name);
        //                Array.Reverse(size);
        //                for (Int32 localCounter_Int32 = 0; localCounter_Int32 < id.Length; localCounter_Int32++)
        //                {
        //                    Console.WriteLine("{0,-8} {1,4} {2,12}", id[localCounter_Int32], name[localCounter_Int32], size[localCounter_Int32]);   // Output in Descending order.
        //                }
        //                break;
        //            }
        //    }

        //}
    }
}
