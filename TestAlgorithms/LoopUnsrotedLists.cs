using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareLookUpAlgorithms.TestAlgorithms
{
    internal class LoopUnsrotedLists(List<Guid> items, List<Guid> lookup)
    {
        public bool Process()
        {
            for (int itemCount = 0; itemCount < items.Count; itemCount++)
            {
                for (int lookupCount = 0; lookupCount < lookup.Count; lookupCount++)
                {
                    var currentItem = items[itemCount];
                    var lookupItem = lookup[lookupCount];

                    if (currentItem == lookupItem)
                    {
                        var test = $"{currentItem} - {lookupItem}";
                    }
                }

            }

            return true;
        }
    }
}
