TelleMeTheType(false);
TelleMeTheType(true);

void TelleMeTheType(object x)
{
    switch (x)
    {
        case bool b when b == true:
        {
            Console.WriteLine($"b == true");
            break;
        }
        case bool b:
        {
            Console.WriteLine($"false");
            break;
        }
    }
}