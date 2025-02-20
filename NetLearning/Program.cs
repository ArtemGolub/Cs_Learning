int x = 5;
int y = 5;
Console.WriteLine(x == y);

object a = 5;
object b = 5;
Console.WriteLine(a.Equals(b));
a = null;
Console.WriteLine(Equals(a, b));