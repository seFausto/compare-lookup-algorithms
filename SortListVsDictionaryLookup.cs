using BenchmarkDotNet.Attributes;
using CompareLookUpAlgorithms;

public class SortListVsDictionaryLookup
{

    private SortListsAndLoopByItem sortLists;
    private UseDictionaryForLookup useDictionary;
    public SortListVsDictionaryLookup()
    {
      
    }


    [GlobalSetup]
    public void Setup() 
    {
        var items = new List<Guid>();
        var lookup = new List<Guid>();

        for (int i = 0; i < 1000; i++)
        {
            var guid = Guid.NewGuid();
            items.Add(guid);
            lookup.Add(guid);
        }

        items.Shuffle();
        lookup.Shuffle();

        sortLists = new SortListsAndLoopByItem(items, lookup);
        useDictionary = new UseDictionaryForLookup(items, lookup);
    }



    [Benchmark]
    public bool SortedLists() => sortLists.Process();

    [Benchmark]
    public bool UseDictionary() => useDictionary.Process();

}

public static class ListExtensions
{
    private static Random rng = new Random();

    public static void Shuffle<T>(this IList<T> list)
    {
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            (list[n], list[k]) = (list[k], list[n]);
        }
    }
}