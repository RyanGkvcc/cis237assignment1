using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class WineItemCollection
    {

        //public static void PopulateCollection()
        //{
        //    Int32 counter = 0;
        //    StreamReader csv = new StreamReader("../../../datafiles/WineList.csv");
        //    while (!csv.EndOfStream)
        //    {
        //        String[] Temp = csv.ReadLine().Split(',');
        //        //WineItem[] wineItem[counter] = new WineItem(Temp[0], Temp[1], Temp[2]);
        //        counter++;
        //    }
        //    csv.Close();
        //}

        
        // Sorts the the file by id and swaps the id, name and size if needed.
        public static void BubbleSort(String[] wineItems)
        {
            for (Int32 anotherCounter_Int32 = 1; anotherCounter_Int32 < wineItems.Length; anotherCounter_Int32++)
            {
                for (Int32 yetAnotherCounter_Int32 = 0; yetAnotherCounter_Int32 < wineItems.Length - anotherCounter_Int32; yetAnotherCounter_Int32++)
                {
                    if (wineItems[yetAnotherCounter_Int32].CompareTo(wineItems[yetAnotherCounter_Int32 + 1]) > 0)
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

        // The process used to swap two arrays.
        private static void Swap(ref String greater, ref String less)
        {
            String temp_String = greater;
            greater = less;
            less = temp_String;
        }

       
    }
}
