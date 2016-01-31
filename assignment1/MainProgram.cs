///Programmer:  Ryan Gowan
///Date:        1/29/2016
///POV:         What are you suppossed to learn from this project.
///                 Console app, switch/case, try, catch, parse,
///                 if/else statements, loops, File Handling, and Modules,
///                 Arrays, sort, search.
///             Read a file, analize user input, and display the results.
///             Store strings in the correct Class, array, and location.
/// 
///             *Extra* I made second menu that allows the user to choose if they would
///             like to see the sorted arrays in ascending or descending order. *Extra*
///             
///             *Extra* I made a third menu that allows the user to choose if they would
///             like to use a sequential search or binary search. *Extra*
///                           
///BOV:         Purpose of this project, if any.
///                 The ability to read an external file, store them in seperate Classes/arrays,
///                 retreive the data from the arrays sort them and return
///                 the requested data within the console window.
///                 Menu selection and proper program navigation.
///                 Ability to create seperate Classes and array types.

//  This project shows Documentation comments, above.
/*  Notes:
 *  ???/100
 */



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
        //Establishes a StreamReader, Random Number, UserInterface.
        //Establishes the WineItem & WineItemCollection class arrays bases on the size of the input file.
        //Reads the input file into the WineItem array.
        //Directs the program based on user input.
        static void Main(string[] args)
        {
            StreamReader wineList = new StreamReader("../../../datafiles/WineList.csv");
            Random randomNumber = new Random();
            UserInterface ui = new UserInterface();

            Int32 arrayCount = CSVProcessor.Processor(wineList);
            Int32 addToArrayCount = arrayCount;
            WineItem[] wineItems = new WineItem[arrayCount + 5];
            WineItemCollection[] collections = new WineItemCollection[arrayCount + 5];
            CSVProcessor.ReadFile(wineItems, wineList);

            Int32 selection1_Int32 = 0;
            
            //While the user has not chosen to exit the program.
            while (selection1_Int32 != 5)
            {
                selection1_Int32 = ui.InputMenu1();
                String output;
                
                switch (selection1_Int32)
                {
                    //Displays the output as found in the input file.
                    //This will display the array in a sorted order if it has already been sorted (if choice 2 or 3 has already been selected).
                    case 1:
                        {
                            output = WineItem.CreateString(wineItems);
                            ui.PrintAllOutput(output);
                            break;
                        }
                    //Displays the output in ascending or descending order with item location.
                    case 2:
                        {
                            Int32 selection2_Int32 = 0;
                            selection2_Int32 = ui.InputMenu2();
                            WineItemCollection.SetLocation(wineItems, collections, randomNumber);
                            output = WineItem.CreateLongString(wineItems, collections, selection2_Int32);
                            ui.PrintAllOutput(output);
                            selection2_Int32 = 0;
                            break;
                        }
                    //Prompts the user for input and searches the file for matching items.
                    //Prompts the user for a search method as well.
                    //Dispays a message for successful and unsuccessful searches.
                    case 3:
                        {
                            Int32 foundLocation = -1;
                            String temp = ui.SearchId();
                            Int32 selection3_Int32 = ui.InputMenu3();
                            foundLocation = WineItem.SearchType(wineItems, temp, selection3_Int32, arrayCount);
                            if (foundLocation == -1)
                            {
                                ui.NotFound(temp);
                            }
                            break;
                        }
                    //Allows the user to add items to the wine directory (up to 5 items).
                    case 4:
                        {
                            addToArrayCount = ui.UserAddWine(wineItems, addToArrayCount);
                            //addToArrayCount++;
                            break;
                        }
                    //Exit loop selection
                    case 5:
                        {
                            //Do Nothing - proceed to close the program.
                            break;
                        }
                }

            }
        }

        //Creates a pause in the program.
        public static void Pause()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
    }
}
