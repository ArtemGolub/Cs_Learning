int x = 0;
while (true)
{
    if(x++ > 5)
        break;
}

for (int i = 0; i < 10; i++)
{
    if((i % 2) == 0)
        continue;
    
    Console.WriteLine(i);
}

int y = default;
switch (y)
{
    case 0:
    {
        goto case 1;
    }
    case 1:
    {
        Console.WriteLine(y);
        break;
    }
}

string w = null;
if (w == null)
    throw new ArgumentException("My String for this exception");
