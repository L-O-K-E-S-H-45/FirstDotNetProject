using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject._24_4_2.Collection
{
    internal class CollectionOperations
    {

        public static void BasicCollectionOperations()
        {
            List<string> list = new List<string>();
            list.Add("hj");
            list.Add("hj");
            list.Add("hj");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            SortedList<int, int> sl = new SortedList<int, int>();

            HashSet<int> set = new HashSet<int>();
            set.Add(1);
            set.Add(1);
            set.Add(1);
            foreach (var item in set) { Console.WriteLine(item); }
            SortedSet<int> ints = new SortedSet<int>();
            ints.Add(1);
            ints.Add(4);
            ints.Add(9);
            ints.Add(3);
            foreach (var item in ints)
            {
                Console.WriteLine(item);
            }
        }

    }
}
