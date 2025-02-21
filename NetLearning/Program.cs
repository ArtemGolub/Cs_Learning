int [] numbers = {3,2,1};
string[] words = {"three", "two", "one"};
Array.Sort(numbers, words);

for (int i = 0; i < numbers.Length; i++)
    Console.WriteLine($"{i} element: {numbers[i]} , {words[i]}");
