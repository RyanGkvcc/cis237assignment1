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

            UserInterface ui = new UserInterface();
            Int32 selection1_Int32 = 0;
            Int32 selection2_Int32 = 0;

            while (selection1_Int32 != 5)
            {
                selection1_Int32 = ui.InputMenu1();

                switch (selection1_Int32)
                {

                    case 1:
                        {
                            WineItem.CreateString(selection2_Int32);
                            break;
                        }
                    case 2:
                        {
                            //Int32 selection1_Int32 = UserInterface.InputMenu2();
                            //Int32 orderSelection = AscendingDescending();
                            //BubbleSort();
                            //WineItem.ListArray(id, name, size, orderSelection);
                            selection2_Int32 = ui.InputMenu2();
                            WineItem.CreateString(selection2_Int32);
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
