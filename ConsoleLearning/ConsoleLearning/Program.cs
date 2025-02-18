

int? x = null;
int y = x ?? 5;
Console.WriteLine(y);

int? a = null , b = 1, c = 2;
Console.WriteLine(a ?? b ?? c);