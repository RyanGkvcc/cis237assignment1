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
        

        public static Int32 Processor(StreamReader wineList)
        {
            Int32 arrayLength_Int32 = 0;
            

            try
            {
                
                arrayLength_Int32 = CountLinesInFile(wineList); ;
                //ReadFile(arrayLength_Int32, wineList);
                wineList.Close();
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("There was a error while reading the file.");
                MainProgram.Pause();
            }

            return arrayLength_Int32;



        }

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

        //public static void ReadFile(Int32 arrayCount, StreamReader wineList)
        public static void ReadFile(WineItem[] wineItems, StreamReader wineList)
        {
            //WineItem[] wineItems = new WineItem[arrayCount + 5];

            foreach (WineItem wineItem in wineItems)
            {
                Int32 count2 = 0;
                while (!wineList.EndOfStream)
                {
                    String[] Temp = wineList.ReadLine().Split(',');
                    wineItems[count2] = new WineItem(Temp[0], Temp[1], Temp[2]);
                    count2++;
                }
            }
            wineList.Close();
        }
    }
}