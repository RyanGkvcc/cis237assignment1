using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace assignment1
{



    class CSVProcessor
    {
        //Counts the items in the csv file.
        //Directs the program to display a message if there is a problem opening the input file.
        //Returns a value to set the array length.
        public static Int32 Processor(StreamReader wineList)
        {
            Int32 arrayLength_Int32 = 0;

            try
            {
                arrayLength_Int32 = CountLinesInFile(wineList); ;
            }

            catch
            {
                UserInterface.FileErrorMessage();
            }

            return arrayLength_Int32;
        }

        //Reads the input file and counts the lines.
        private static Int32 CountLinesInFile(StreamReader csv)
        {
            Int32 count = 0;
            String line;

            while ((line = csv.ReadLine()) != null)
            {
                count++;
            }

            csv.BaseStream.Position = 0;
            return count;
        }

        //Reads each line of the input file and passes the information to populate an array.
        public static void ReadFile(WineItem[] wineItems, StreamReader wineList)
        {
            foreach (WineItem wineItem in wineItems)
            {
                Int32 count2 = 0;
                while (!wineList.EndOfStream)
                {
                    String[] Temp = wineList.ReadLine().Split(',');
                    AddToArray(wineItems, count2, Temp);
                    count2++;
                }
            }
            wineList.Close();
        }

        //Populates an array with the information being passed.
        public static void AddToArray(WineItem[] wineItems, Int32 location, String[] Temp)
        {
            wineItems[location] = new WineItem(Temp[0], Temp[1], Temp[2]);
        }
    }
}