int[] numbers = [1, 2, 3, 4, 5];
ref int numRef = ref numbers[2];

numRef *= 10;
Console.WriteLine(numRef); // 30
Console.WriteLine(numbers[2]); // 30