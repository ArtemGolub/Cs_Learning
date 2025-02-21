using System.Collections;
using System.Collections.Specialized;

OrderedDictionary oD = new OrderedDictionary();
oD.Add(3, "Three");
oD.Add(1, "One");
oD.Add(2, "Two");

for (int i = 0; i < oD.Count; i++)
    Console.WriteLine(oD[i].ToString());

foreach (DictionaryEntry entry in oD)
    Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");