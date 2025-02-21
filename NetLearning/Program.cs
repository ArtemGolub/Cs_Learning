int[] numbers = {1,2,3,4,5};
Array.Sort(numbers, (x,y) 
    => x % 2 == y % 2 
        ? 0 
        : x % 2 == 1
            ? -1
            : 1
       );

foreach (int number in numbers)
    Console.Write(number);