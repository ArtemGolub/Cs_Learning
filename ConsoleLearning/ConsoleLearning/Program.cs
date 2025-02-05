char[] vowels = ['a', 'b', 'c', 'd', 'e'];

Range firstTwoRange = 0..2;
char[] firstTwo = vowels[firstTwoRange];

Console.WriteLine(firstTwo);

int[][] jaggedArray = new int[3][];
jaggedArray[0] = new int[] { 1, 2 };       // Первая строка с 2 элементами
jaggedArray[1] = new int[] { 3, 4, 5 };    // Вторая строка с 3 элементами
jaggedArray[2] = new int[] { 6, 7, 8, 9 }; // Третья строка с 4 элементами

// Вывод зубчатого массива
for (int i = 0; i < jaggedArray.Length; i++) // Обход строк
{
    for (int j = 0; j < jaggedArray[i].Length; j++) // Обход элементов в строке
    {
        Console.Write(jaggedArray[i][j] + " ");
    }
    Console.WriteLine(); // Переход на новую строку после завершения текущей строки
}