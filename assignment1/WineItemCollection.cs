using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class WineItemCollection
    {

        Random randomNumber = new Random();

        private String aisle;
        private String row;
        private String shelf;

        public String Id
        {
            get { return aisle; }
            set { aisle = value; }
        }

        public String Description
        {
            get { return row; }
            set { row = value; }
        }

        public String Pack
        {
            get { return shelf; }
            set { shelf = value; }
        }

        public String FullLocation()
        {
            return this.aisle + "-" + this.row + "-" + this.shelf;
        }

        //3 Parameter constructor
        public WineItemCollection(String aisle, String row, String shelf)
        {
            this.aisle = aisle;
            this.row = row;
            this.shelf = shelf;
        }

        //Default constructor
        public WineItemCollection()
        {
            //Lets just leave this blank
        }


        //Override method that will print all of the fields
        //It overrides the the default ToString method.
        public override String ToString()
        {
            return this.aisle + "-" + this.row + "-" + this.shelf;
        }

        //public static String GetLocation()
        //{

        //}




        //private static Int32 RandomGenerator(low, high)
        //{
        //    Int32 number;
        //    number = randomNumber.Next(low, high);
        //    return number;
        //}



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
        public static void BubbleSort(WineItem[] wineItems)
        {
            for (Int32 anotherCounter_Int32 = 1; anotherCounter_Int32 < wineItems.Length; anotherCounter_Int32++)
            {
                for (Int32 yetAnotherCounter_Int32 = 0; yetAnotherCounter_Int32 < wineItems.Length - anotherCounter_Int32; yetAnotherCounter_Int32++)
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

        // The process used to swap two arrays.
        private static void Swap(ref WineItem greater, ref WineItem less)
        {
            //String temp_String = greater;
            //greater = less;
            //less = temp_String;
        }

       
    }
}
