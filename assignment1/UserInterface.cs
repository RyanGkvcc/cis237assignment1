using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class UserInterface
    {

        public Int32 InputMenu1()
        {
            //Prints the menu first.
            this.printMenu1();

            //Store the users input from the terminal. 
            String input = Console.ReadLine();

            //While the input is NOT valid
            while (input != "1" && input != "2" && input != "3" && input != "4" && input != "5")
            {
                //Propt the user for a valid choice
                Console.WriteLine("That is not a valid entry");
                Console.WriteLine("Please make a valid choice (1-5)");
                Console.WriteLine();
                //Reprint the menu for the user.
                this.printMenu1();
                //Re-fetch the user input from the console
                input = Console.ReadLine();
            }

            //Parse the valid entry, and return to navigate the program
            return Int32.Parse(input);
        }
        
        //The first menu to be displayed
        private void printMenu1()
        {
            Console.WriteLine();
            Console.WriteLine("Select what you wish to do with the file.");
            Console.WriteLine();
            Console.WriteLine("1: Show the entire wine directory as entered in the file.");
            Console.WriteLine("2: Show the entire wine directory sorted ascending/descending by Id.");
            Console.WriteLine("3: Find and Display the details of a wine by Id. (By user input search)");
            Console.WriteLine("4: Add a new wine item to the list.");
            Console.WriteLine();
            Console.WriteLine("5: Exit Program");
            Console.WriteLine();
        }

        public Int32 InputMenu2()
        {
            //Prints the second menu to sort Ascending or Descending.
            this.printMenu2();

            //Store the users input from the terminal. 
            String input2 = Console.ReadLine();

            //While the input is NOT valid
            while (input2 != "1" && input2 != "2")
            {
                //Propt the user for a valid choice.
                Console.WriteLine("That is not a valid entry");
                Console.WriteLine("Please make a valid choice (1-2)");
                Console.WriteLine();
                //Reprint the menu for the user.
                this.printMenu2();
                //Re-fetch the user input from the console
                input2 = Console.ReadLine();
            }

            //Parse the valid entry, and return to navigate the program
            return Int32.Parse(input2);
        }

        //The second menu to be displayed
        private void printMenu2()
        {
            Console.Clear();
            Console.WriteLine("Do you wish to display the list in Ascending or Descending order?");
            Console.WriteLine();
            Console.WriteLine("1: Ascending");
            Console.WriteLine("2: Descending");
            Console.WriteLine();
        }

        public Int32 InputMenu3()
        {
            //Prints the second menu to search Sequential or Binary.
            this.printMenu3();

            //Store the users input from the terminal. 
            String input3 = Console.ReadLine();

            //While the input is NOT valid
            while (input3 != "1" && input3 != "2")
            {
                //Propt the user for a valid choice.
                Console.WriteLine("That is not a valid entry");
                Console.WriteLine("Please make a valid choice (1-2)");
                Console.WriteLine();
                //Reprint the menu for the user.
                this.printMenu3();
                //Re-fetch the user input from the console
                input3 = Console.ReadLine();
            }

            //Parse the valid entry, and return to navigate the program
            return Int32.Parse(input3);
        }

        //The third menu to be displayed
        private void printMenu3()
        {
            Console.Clear();
            Console.WriteLine("Do you wish to Sequential Search or Binary Search?");
            Console.WriteLine();
            Console.WriteLine("1: Sequential");
            Console.WriteLine("2: Binary");
            Console.WriteLine();
        }

        //Displays a message if there is a problem opening the input file.
        public static void FileErrorMessage()
        {
            Console.Clear();
            Console.WriteLine("There was a error while reading the file.");
            MainProgram.Pause();
        }

        //Print all information contained in the string
        public void PrintAllOutput(String allOutput)
        {
            Console.WriteLine(allOutput);
        }

        //Prompts the user to enter an Id that will be searched for.
        public String SearchId()
        {
            Console.Clear();
            Console.WriteLine("Enter the ID you wish to search for: ");
            Console.WriteLine();
            String temp = Console.ReadLine();
            return temp;
        }

        //Displays a message if the item Id was not successfully found. 
        public void NotFound(String temp)
        {
            Console.WriteLine();
            Console.WriteLine("There was no Id found matching {0} in the wine directory.", temp);
            MainProgram.Pause();
        }

        //Displays all matching items with the Id the user input.
        public static void PrintMatchingItem(WineItem[] wineItems, Int32 foundLocation)
        {
            Console.WriteLine();
            Console.WriteLine(" ** Match Found ** ");
            Console.WriteLine();
            Console.WriteLine(wineItems[foundLocation]);
            Console.WriteLine();
        }

        //Prompts the user to enter an ID, Description, and Pack Size for the item being added to the list.
        //Displays a message if the item was successfully added to the list.
        //Displays a message if the item was NOT successfully added to the list.
        public Int32 UserAddWine(WineItem[] wineItems, Int32 location)
        {
            Console.Clear();
            Console.WriteLine("Enter the ID you wish to add to the wine directory: ");
            Console.WriteLine();
            String temp1 = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter the Description you wish to add to the wine directory: ");
            Console.WriteLine();
            String temp2 = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter the Pack Size you wish to add to the wine directory: ");
            Console.WriteLine();
            String temp3 = Console.ReadLine();
            Console.WriteLine();
            if (temp1 != "" && temp2 != "" && temp3 != "")
            {
                String[] Temp = { temp1, temp2, temp3 };
                CSVProcessor.AddToArray(wineItems, location, Temp);
                Console.WriteLine("Your item has been successfully added to the wine directory!");
                Console.WriteLine();
                location++;
                
            }
            else
            {
                Console.WriteLine("There seems to be an issue with adding your item to the wine directory.");
                Console.WriteLine();
            }
            return location;
        }
    }
}
