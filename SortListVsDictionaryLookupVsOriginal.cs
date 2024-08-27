using BenchmarkDotNet.Attributes;
using CompareLookUpAlgorithms;

public class SortListVsDictionaryLookupVsOriginal
{  
    private SortListsAndLoopByItem sortLists;
    private UseDictionaryForLookup useDictionary;
    private LoopUnsrotedLists original;

    [GlobalSetup]
    public void Setup()
    {
        var items = new List<Guid>();
        var lookup = new List<Guid>();

        for (int i = 0; i < 1_000_000; i++)
        {
            var guid = Guid.NewGuid();
            items.Add(guid);
            lookup.Add(guid);
        }

        items.Shuffle();
        lookup.Shuffle();

        sortLists = new SortListsAndLoopByItem(items, lookup);
        useDictionary = new UseDictionaryForLookup(items, lookup);
        original = new LoopUnsrotedLists(items, lookup);
    }

    [Benchmark]
    public bool SortedLists() => sortLists.Process();

    [Benchmark]
    public bool UseDictionary() => useDictionary.Process();
}