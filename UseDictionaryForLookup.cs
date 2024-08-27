using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CompareLookUpAlgorithms
{
    internal class UseDictionaryForLookup(List<Guid> items, List<Guid> lookup)
    {

        public bool Process()
        { 
            var set = new HashSet<Guid>();

            foreach (var item in lookup) 
            {
                set.Add(item);
            }

            foreach (var item in items) 
            { 
               Console.WriteLine($"{item} - {set.Contains(item)}");
            }

            return true;
        }
    }
}
