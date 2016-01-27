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
                //Propt the user for a valid choice
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

        //Print all information contained in the string
        public void PrintAllOutput(String allOutput)
        {
            Console.WriteLine(allOutput);
        }

     }
}
