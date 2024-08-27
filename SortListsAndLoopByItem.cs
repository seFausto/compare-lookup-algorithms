using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace CompareLookUpAlgorithms
{
    internal class SortListsAndLoopByItem(List<Guid> items, List<Guid> lookup)
    {
        public bool Process()
        {
            // sort both lists

            items.Sort();
            lookup.Sort();

            //for loop to go throu each item
            for (int itemCount = 0; itemCount < items.Count; itemCount++)
            {
               // Console.WriteLine($"{items[itemCount]}, {lookup[itemCount]}");
            }

            return true;
        }
    }
}
