using ConsoleLearning.Nullables;

object o  = "string";
int? x = o as int?;
Console.WriteLine(x.HasValue);

int? z = 5;
int? f = 10;
bool b = x < f; // true