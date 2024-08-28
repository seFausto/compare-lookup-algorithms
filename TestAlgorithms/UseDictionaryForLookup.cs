using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CompareLookUpAlgorithms.TestAlgorithms
{
    internal class UseDictionaryForLookup(List<Guid> items, List<Guid> lookup)
    {

        public bool Process()
        {
            var dictionary = new Dictionary<Guid, bool>();

            foreach (var item in lookup)
            {
                dictionary.Add(item, true);
            }

            foreach (var item in items)
            {
                var test = $"{item} - {dictionary[item]}";
            }

            return true;
        }
    }
}
