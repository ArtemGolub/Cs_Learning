string a = "Heat";
string b = "Heat";
string c = "Here's a tab:\t";
Console.WriteLine(c + (a==b));

string a1 = @"\\server\fileshare\file.txt";
string xml = @"<customer id= ""12345""></customer>";
Console.WriteLine(xml);

string concat = "a" + "b";
Console.WriteLine(concat);


string concatNum = "a" + 5;
Console.WriteLine(concatNum);

int x = 1;
string interpolatedString = $"The value of x is {x}";
Console.WriteLine(interpolatedString);

string s = $"255 in hex is {byte.MaxValue:X2}";
Console.WriteLine(s);

bool z = true;
Console.WriteLine($"The answer in binary is {(z ? 1: 0)}");

const string greeting = "Hello!";
const string message = $"{greeting}, world";

ReadOnlySpan<byte> utf8 = "ab→св"u8;
Console.WriteLine(utf8.Length);