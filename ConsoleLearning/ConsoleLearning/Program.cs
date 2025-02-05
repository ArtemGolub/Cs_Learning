char[] vowels = ['a', 'b', 'c', 'd', 'e'];

char[] firstTwo = vowels[..2];
char[] lastThree = vowels[2..];
char[] middleOne = vowels[2..3];

Console.WriteLine(firstTwo);
Console.WriteLine(lastThree);
Console.WriteLine(middleOne);

