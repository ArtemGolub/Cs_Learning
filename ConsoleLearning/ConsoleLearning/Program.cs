TelleMeTheType(12);
TelleMeTheType(" ");
TelleMeTheType(DateTime.Now);

void TelleMeTheType(object x)
{
    switch (x)
    {
        case int i:
        {
            Console.WriteLine($"int");
            break;
        }
        case string s:
        {
            Console.WriteLine($"string");
            break;
        }
        case DateTime:
        {
            Console.WriteLine("dt");
            break;
        }
    }
}