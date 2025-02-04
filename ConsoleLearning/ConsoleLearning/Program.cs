using ConsoleLearning.BoolOperations;


Console.WriteLine(CountMax.Max(1,2));


Dude d1 = new Dude("John");
Dude d2 = new Dude("John"); // одно имя с d1

Console.WriteLine(d1 == d2);
Dude d3 = d1;
Console.WriteLine(d1 == d3);

Console.WriteLine(UmbrellaCheck.UseUmbrella(false, true, false));
string str = null;
int length = str.Length;