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
        public static Int32 Processor()
        {
            Int32 arrayLength_Int32 = 0;
            try
            {
                StreamReader wineList = new StreamReader("../../../datafies/WineList.csv");
                //arrayLength_Int32 = CountLinesInFile("../../../datafies/WineList.csv");
                arrayLength_Int32 = Int32.Parse(wineList.ReadLine());
                //String[] productNumber_String = new String[arrayLength_Int32 + 5];
                //String[] wineNames_String = new String[arrayLength_Int32 + 5];
                //String[] containerSize_String = new String[arrayLength_Int32 + 5];
                //ReadFile(wineList, productNumber_String, wineNames_String, containerSize_String);
                //UserInterface.Menu1(productNumber_String, wineNames_String, containerSize_String);
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

        private static Int32 CountLinesInFile(String csv)
        {
            Int32 count = 0;

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

        // public static void ReadFile(Int32 arrayCount)
        //{
        //    Int32 counter_Int32 = 0;
            

            //while (!winelist.EndOfStream)
            //{
            //    String[] tempArray_String = winelist.ReadLine().Split(',');
            //    id[counter_Int32] = tempArray_String[0];
            //    name[counter_Int32] = tempArray_String[1];
            //    size[counter_Int32] = tempArray_String[2];
            //    counter_Int32++;
            //}
            //record.Close();
        //}
    }
}
