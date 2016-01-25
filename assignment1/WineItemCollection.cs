using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class WineItemCollection
    {
        // Sorts the the file by id and swaps the id, name and size if needed.
        public static void BubbleSort(String[] id, String[] name, String[] size)
        {
            for (Int32 anotherCounter_Int32 = 1; anotherCounter_Int32 < id.Length; anotherCounter_Int32++)
            {
                for (Int32 yetAnotherCounter_Int32 = 0; yetAnotherCounter_Int32 < id.Length - anotherCounter_Int32; yetAnotherCounter_Int32++)
                {
                    if (id[yetAnotherCounter_Int32].CompareTo(id[yetAnotherCounter_Int32 + 1]) > 0)
                    {
                        SwapId(ref id[yetAnotherCounter_Int32], ref id[yetAnotherCounter_Int32 + 1]);
                        SwapName(ref name[yetAnotherCounter_Int32], ref name[yetAnotherCounter_Int32 + 1]);
                        SwapSize(ref size[yetAnotherCounter_Int32], ref size[yetAnotherCounter_Int32 + 1]);
                    }
                    else
                    {
                        //Leave good enough alone
                    }
                }
            }
        }

        // The process used to swap two id's.
        private static void SwapId(ref String id1, ref String id2)
        {
            String temp_String = id1;
            id1 = id2;
            id2 = temp_String;
        }

        // The process used to swap two names.
        private static void SwapName(ref String name1, ref String name2)
        {
            String temp_String2 = name1;
            name1 = name2;
            name2 = temp_String2;
        }

        // The process used to swap two sizes.
        private static void SwapSize(ref String size1, ref String size2)
        {
            String temp_String3 = size1;
            size1 = size2;
            size2 = temp_String3;
        }
    }
}
