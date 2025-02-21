

var letters = new HashSet<char> ("the quick brown fox");
Console.WriteLine(letters.Contains('t'));
Console.WriteLine(letters.Contains('j'));

foreach (char c in letters)
    Console.Write(c);