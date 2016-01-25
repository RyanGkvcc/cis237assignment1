using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class UserInterface
    {

        public static void Menu1(String[] id, String[] name, String[] size)
        {
            Boolean exitMenu1_Boolean = false;

            while (!exitMenu1_Boolean)
            {
                Console.Clear();
                Console.WriteLine("Select what you wish to do with the file.");
                Console.WriteLine();
                Console.WriteLine("1: Show the entire wine directory as entered in the file.");
                Console.WriteLine("2: Show the entire wine directory sorted ascending/descending by id.");
                Console.WriteLine("3: Find and Display the details of a wine by id. (By user input)");
                Console.WriteLine("4: Add a new wine item to the list.");
                Console.WriteLine();
                Console.WriteLine("5: Exit Program");
                Console.WriteLine();
            }
            try
            {
                Int32 selection1_Int32 = Int32.Parse(Console.ReadLine());
                Int32 menuValidation1_Int32 = 1;
                RangeValidation(selection1_Int32, menuValidation1_Int32);
                switch (selection1_Int32)
                {
                    case 1:
                        {
                            break;
                        }
                    case 2:
                        {
                            Int32 orderSelection = AscendingDescending();
                            WineItemCollection.BubbleSort(id, name, size);
                            WineItem.ListArray(id, name, size, orderSelection);
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
                            exitMenu1_Boolean = true;
                            break;
                        }
                }
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("You must enter a numeric selection between 1 and 5.");  // Message for non-numeric entry
                MainProgram.Pause();
            }
            
        }
        
        private static void RangeValidation(Int32 selection, Int32 menu)
        {
            switch (menu)
            {
                case 1:
                    {
                        if (selection >= 1 && selection <= 5)
                        {
                            // Do nothing - Continue
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine(selection + " is not within the specified range of numbers (1-5).");  //Message for outside range
                            MainProgram.Pause();
                        }
                        break;
                        
                    }
                case 2:
                    {
                        if (selection >= 1 && selection <= 2)
                        {
                            // Do nothing - Continue
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine(selection + " is not within the specified range of numbers (1-2).");  //Message for outside range
                            MainProgram.Pause();
                        }
                        break;
                    }
            }
        }
        
        private static Int32 AscendingDescending()
        {
            Boolean exitMenu2_Boolean = false;
            Int32 selection2_Int32 = 0;

            while (!exitMenu2_Boolean)
            {
                Console.Clear();
                Console.WriteLine("Do you wish to display the list in Ascending or Descending order?");
                Console.WriteLine();
                Console.WriteLine("1: Ascending");
                Console.WriteLine("2: Descending");
                Console.WriteLine();
                try
                {
                    selection2_Int32 = Int32.Parse(Console.ReadLine());
                    Int32 menuValidation3_Int32 = 3;                            // Used within RangeValidation for range selector.
                    RangeValidation(selection2_Int32, menuValidation3_Int32);
                    if (selection2_Int32 >= 1 && selection2_Int32 <= 2)
                    {
                        exitMenu2_Boolean = true;
                    }
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("You must enter a numeric selection of either 1 or 2.");  // Message for non-numeric entry
                    MainProgram.Pause();
                }
            }
            return selection2_Int32;
        }

    }
}
