using System.Collections;
using System.Collections.Specialized;

OrderedDictionary oD = new OrderedDictionary
{
    { 3, "Three" },
    { 1, "One" },
    { 2, "Two" }
};

for (int i = 0; i < oD.Count; i++)
    Console.WriteLine(oD[i]?.ToString());

foreach (DictionaryEntry entry in oD)
    Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");