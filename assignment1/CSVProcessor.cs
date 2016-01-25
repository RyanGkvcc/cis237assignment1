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
        public static void Processor()
        {
            Int32 arrayLength_Int32;

            try
            {
                StreamReader wineList = new StreamReader("WineList.csv");
                arrayLength_Int32 = CountLinesInFile("WineList.csv");
                String[] productNumber_String = new String[arrayLength_Int32 + 5];
                String[] wineNames_String = new String[arrayLength_Int32 + 5];
                String[] containerSize_String = new String[arrayLength_Int32 + 5];
                ReadFile(wineList, productNumber_String, wineNames_String, containerSize_String);
                UserInterface.Menu1(productNumber_String, wineNames_String, containerSize_String);
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("There was a error while reading the file.");
                MainProgram.Pause();
            }
            
        }

        private static int CountLinesInFile(String csv)
        {
            int count = 0;

            using (StreamReader wineList = new StreamReader(csv))
            {
                String line;
                while ((line = wineList.ReadLine()) != null)
                {
                    count++;
                }
            }
            return count;
        }

        private static void ReadFile(StreamReader record, String[] id, String[] name, String[] size)
        {
            Int32 counter_Int32 = 0;

            while (!record.EndOfStream)
            {
                String[] tempArray_String = record.ReadLine().Split(',');
                id[counter_Int32] = tempArray_String[0];
                name[counter_Int32] = tempArray_String[1];
                size[counter_Int32] = tempArray_String[2];
                counter_Int32++;
            }
            record.Close();
        }
    }
}
