/*
Задача 56:
Задайте прямоугольный двумерный массив. Напишите программу,
которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
int[,] array = GenerateRandom2DArray(10, 4);
PrintArray(array);
Console.WriteLine();
RowWithMinimumSumOfElements(array);

void RowWithMinimumSumOfElements(int[,] array)
{
    int minString = 0;
    int minAmountOfRows = 0;
    int sumOfLines = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minString += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) sumOfLines += array[i, j];
        if (sumOfLines < minString)
        {
            minString = sumOfLines;
            minAmountOfRows = i;
        }
        sumOfLines = 0;
    }
    Console.Write($" строка с наименьшем суммой элементов: №{minAmountOfRows + 1}");
}

int[,] GenerateRandom2DArray(int m, int n)
{
    if (m < 0 || n < 0)
    {
        return new int[0, 0];
    }

    int[,] array = new int[m, n];

    Random random = new Random();
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 10);
        }
    }

    return array;
}

void PrintArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}