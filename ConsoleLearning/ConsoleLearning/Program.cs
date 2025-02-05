char[] vowels = ['a', 'b', 'c', 'd', 'e'];

Index first = 0;
Index last = ^1;

char firstElement = vowels[first];
char lastElement = vowels[last];

for (int i = 1; i <= vowels.Length; i++)
{
    Index index = ^i;
    Console.WriteLine($"{vowels[index]}");
}

