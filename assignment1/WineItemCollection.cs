using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace assignment1
{
    class WineItemCollection
    {

        public static void PopulateCollection()
        {
            Int32 counter = 0;
            StreamReader csv = new StreamReader("../../../datafies/WineList.csv");
            while (!csv.EndOfStream)
            {
                String[] Temp = csv.ReadLine().Split(',');
                //WineItem[] wineItem[counter] = new WineItem(Temp[0], Temp[1], Temp[2]);
                counter++;
            }
            csv.Close();
        }

        public static void ProcessMenu1(Int32 selection1_Int32)
        {
            switch (selection1_Int32)
            {
                case 1:
                    {
                        //foreach (WineItem wineItem in wineItems)
                        //{
                        //    //Check to make sure that the current object is not null.
                        //    if (wineItem != null)
                        //    {
                        //        //output the information of the employee
                        //        Console.WriteLine(wineItem.ToString());
                        //    }

                        //}
                        break;
                    }
                case 2:
                    {
                        //Int32 selection1_Int32 = UserInterface.InputMenu2();
                        //Int32 orderSelection = AscendingDescending();
                        //BubbleSort();
                        //WineItem.ListArray(id, name, size, orderSelection);
                        break;
                    }
                case 3:
                    {
                        break;
                    }
                case 4:
                    {
                        break;
                    }
                case 5:
                    {
                        //Do Nothing - proceed to close the program
                        break;
                    }
            }
        }
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
