
string[] names = { "Rodney", "Jack", "Jill" };
string match = Array.Find(names, n => n.Contains("a"));
Console.WriteLine($"Match: {match}");


