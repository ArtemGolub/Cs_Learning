
int[] myArray = {1,2,3};
int first = myArray[0];
int last = myArray[^1];

Console.WriteLine($"{first} {last}");

Array a = Array.CreateInstance(typeof(string), 2);
a.SetValue("hi", 0);
a.SetValue("there", 1);
string? s = (string) a.GetValue(0)!;
