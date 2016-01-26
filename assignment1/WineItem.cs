using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class WineItem
    {
        private String id;
        private String description;
        private String pack;

        public String Id
        {
            get { return id; }
            set { id = value; }
        }

        public String Description
        {
            get { return description; }
            set { description = value; }
        }

        public String Pack
        {
            get { return pack; }
            set { pack = value; }
        }

        public String FullDetails()
        {
            return this.id + " " + this.description + " " + this.pack;
        }

        //3 Parameter constructor
        public WineItem (String id, String description, String pack)
        {
            this.id = id;
            this.description = description;
            this.pack = pack;
        }

        //Default constructor
        public WineItem()
        {
            //Lets just leave this blank
        }


        //Override method that will print all of the fields
        //It overrides the the default ToString method.
        public override String ToString()
        {
            return this.id + " " + this.description + " " + this.pack;
        }

        // Displays multiple results on the Console in Ascending or Descending order
        // depending on the user's selection.


        //public static void ListArray( String[] id, String[] name, String[] size, Int32 orderSelection)
        //{
        //    Console.Clear();
        //    Console.WriteLine(" Wine Directory ");
        //    Console.WriteLine();
        //    Console.WriteLine("{0,-8} {1,4} {2,12}", "Id", "Name", "Size");
        //    Console.WriteLine();
        //    switch (orderSelection)
        //    {
        //        case 1:
        //            {
        //                for (Int32 localCounter_Int32 = 0; localCounter_Int32 < id.Length; localCounter_Int32++)
        //                {
        //                    Console.WriteLine("{0,-8} {1,4} {2,12}", id[localCounter_Int32], name[localCounter_Int32], size[localCounter_Int32]);   // Output in Ascending order.
        //                }
        //                break;
        //            }
        //        case 2:
        //            {
        //                Array.Reverse(id);
        //                Array.Reverse(name);
        //                Array.Reverse(size);
        //                for (Int32 localCounter_Int32 = 0; localCounter_Int32 < id.Length; localCounter_Int32++)
        //                {
        //                    Console.WriteLine("{0,-8} {1,4} {2,12}", id[localCounter_Int32], name[localCounter_Int32], size[localCounter_Int32]);   // Output in Descending order.
        //                }
        //                break;
        //            }
        //    }

        //}
    }
}
