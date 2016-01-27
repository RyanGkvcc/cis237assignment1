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
            StreamReader wineList = new StreamReader("../../../datafiles/WineList.csv");
            Int32 arrayCount = CSVProcessor.Processor(wineList);
            WineItem[] wineItems = new WineItem[arrayCount + 5];
            WineItemCollection[] collection = new WineItemCollection[arrayCount + 5];
            CSVProcessor.ReadFile(wineItems, wineList);
            UserInterface ui = new UserInterface();
            Int32 selection1_Int32 = 0;
            Int32 selection2_Int32 = 0;

            while (selection1_Int32 != 5)
            {
                selection1_Int32 = ui.InputMenu1();
                String output;

                switch (selection1_Int32)
                {

                    case 1:
                        {
                            output = WineItem.CreateString(wineItems, selection2_Int32);
                            ui.PrintAllOutput(output);
                            break;
                        }
                    case 2:
                        {
                            //Int32 selection1_Int32 = UserInterface.InputMenu2();
                            //Int32 orderSelection = AscendingDescending();
                            //BubbleSort();
                            //WineItem.ListArray(id, name, size, orderSelection);
                            selection2_Int32 = ui.InputMenu2();
                            WineItem.CreateString(wineItems, selection2_Int32);
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
            
            
        }

        public static void Pause()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
    }
}
