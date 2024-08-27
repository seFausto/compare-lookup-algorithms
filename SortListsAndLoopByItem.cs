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
            items.Sort();
            lookup.Sort();

            for (int itemCount = 0; itemCount < items.Count; itemCount++)
            {
                var currentItem = items[itemCount];
                var lookupItem = lookup[itemCount];

                var test = $"{currentItem} - {lookupItem}";

            }

            return true;
        }
    }
}
