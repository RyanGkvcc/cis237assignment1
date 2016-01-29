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
            Random randomNumber = new Random();
            Int32 arrayCount = CSVProcessor.Processor(wineList);
            Int32 addToArrayCount = arrayCount;
            WineItem[] wineItems = new WineItem[arrayCount + 5];
            WineItemCollection[] collections = new WineItemCollection[arrayCount + 5];
            CSVProcessor.ReadFile(wineItems, wineList);
            UserInterface ui = new UserInterface();
            Int32 selection1_Int32 = 0;
            Int32 selection2_Int32 = 0;

            while (selection1_Int32 != 5)
            {
                selection1_Int32 = ui.InputMenu1();
                String output;
                String location;

                switch (selection1_Int32)
                {

                    case 1:
                        {
                            output = WineItem.CreateString(wineItems, selection2_Int32);
                            WineItemCollection.SetLocation(wineItems, collections, randomNumber);
                            location = WineItemCollection.CreateAnotherString(collections);
                            ui.PrintAllOutput(output, location);
                            break;
                        }
                    case 2:
                        {
                            //Int32 selection1_Int32 = UserInterface.InputMenu2();
                            //Int32 orderSelection = AscendingDescending();
                            //WineItem.BubbleSort(wineItems);
                            //WineItem.ListArray(id, name, size, orderSelection);
                            selection2_Int32 = ui.InputMenu2();
                            output = WineItem.CreateString(wineItems, selection2_Int32);
                            location = WineItemCollection.CreateAnotherString(collections);
                            ui.PrintAllOutput(output, location);
                            break;
                        }
                    case 3:
                        {
                            String temp = ui.SearchId();
                            Int32 foundLocation = WineItem.SequentialSearch(wineItems, temp);
                            if (foundLocation == -1)
                            {
                                ui.NotFound(temp);
                            }
                            break;
                        }
                    case 4:
                        {
                            ui.UserAddWine(wineItems, addToArrayCount);
                            addToArrayCount++;
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
