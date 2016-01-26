using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace assignment1
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            Int32 arrayCount = CSVProcessor.Processor();
            WineItem[] wineItems = new WineItem[arrayCount + 5];
            
            
            
            
            
            //CSVProcessor.ReadFile(arrayCount);
            WineItemCollection.PopulateCollection();

            UserInterface ui1 = new UserInterface();

            Int32 selection1_Int32 = ui1.InputMenu1();
            WineItemCollection.ProcessMenu1(selection1_Int32);
            

        }

        public static void Pause()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
    }
}
