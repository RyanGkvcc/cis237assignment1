using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class WineItemCollection
    {

        

        private String aisle;
        private String row;
        private String shelf;

        public String Id
        {
            get { return aisle; }
            set { aisle = value; }
        }

        public String Description
        {
            get { return row; }
            set { row = value; }
        }

        public String Pack
        {
            get { return shelf; }
            set { shelf = value; }
        }

        public String FullLocation()
        {
            return this.aisle + "-" + this.row + "-" + this.shelf;
        }

        //3 Parameter constructor
        public WineItemCollection(String aisle, String row, String shelf)
        {
            this.aisle = aisle;
            this.row = row;
            this.shelf = shelf;
        }

        //Default constructor
        public WineItemCollection()
        {
            //Lets just leave this blank
        }


        //Override method that will print all of the fields
        //It overrides the the default ToString method.
        public override String ToString()
        {
            return this.aisle + "-" + this.row + "-" + this.shelf;
        }

        public static void SetLocation(WineItem[] wineItems, WineItemCollection[] collection, Random randomNumber)
        {
            Int32 anothercounter = 0;
            foreach (WineItem wineItem in wineItems)
            {
                String aisle1 = " ";
                String row1 = " ";
                String shelf1 = " ";
                if (wineItem != null)
                {
                    Int32 locationCounter;
                    for(locationCounter = 0; locationCounter < 5; locationCounter++)
                    {
                        Int32 low = 0;
                        Int32 high = 10;
                        Int32 temp = RandomGenerator(low, high, randomNumber);
                        String temp2 = temp.ToString();
                        aisle1 += temp2;
                    }
                    for (locationCounter = 0; locationCounter < 3; locationCounter++)
                    {
                        Int32 low = 65;
                        Int32 high = 91;
                        Int32 temp1 = RandomGenerator(low, high, randomNumber);
                        String temp2 = ConvertToAscii(temp1);
                        aisle1 += temp2;
                    }
                    for (locationCounter = 0; locationCounter < 4; locationCounter++)
                    {
                        Int32 low = 0;
                        Int32 high = 10;
                        Int32 temp = RandomGenerator(low, high, randomNumber);
                        String temp2 = temp.ToString();
                        shelf1 += temp2;
                    }
                    collection[anothercounter] = new WineItemCollection(aisle1, row1, shelf1);
                }
            }
        }

        private static Int32 RandomGenerator(Int32 low, Int32 high, Random randomNumber)
        {
            Int32 number;
            number = randomNumber.Next(low, high);
            return number;
        }




        private static String ConvertToAscii(Int32 number)
        {
            String ascii = " ";
            try
            {
                //Int32.TryParse(number, out value);
                char a = (char)number;
                ascii = a.ToString();
                
            }
            catch
            {
                Console.WriteLine("Could not convert to Ascii letter");
            }
            return ascii;

        }

        public static String CreateAnotherString(WineItemCollection[] collections)
        {
            String location = " ";
            foreach (WineItemCollection collection in collections)
            {
                if (collection != null)
                {
                    location += collection.ToString() + Environment.NewLine;
                }
            }

            return location;
        }




        //public static void PopulateCollection()
        //{
        //    Int32 counter = 0;
        //    StreamReader csv = new StreamReader("../../../datafiles/WineList.csv");
        //    while (!csv.EndOfStream)
        //    {
        //        String[] Temp = csv.ReadLine().Split(',');
        //        //WineItem[] wineItem[counter] = new WineItem(Temp[0], Temp[1], Temp[2]);
        //        counter++;
        //    }
        //    csv.Close();
        //}


        

        

       
    }
}
