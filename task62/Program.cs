/*
Задача 62.
Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int len = 4;
int[,] table = new int[len, len];
arraySpiral(table, len);
printArray(table);

void arraySpiral(int[,] array, int n)
{
    int i = 0; 
    int j = 0;
    int tmp = 1;
    for (int e = 0; e < n * n; e++)
    {
        int k = 0;
        do { array[i, j++] = tmp++; } while (++k < n - 1);
        for (k = 0; k < n - 1; k++) array[i++, j] = tmp++;
        for (k = 0; k < n - 1; k++) array[i, j--] = tmp++;
        for (k = 0; k < n - 1; k++) array[i--, j] = tmp++;
        ++i; ++j;
        n = n < 2 ? 0 : n - 2;
    }
}

void printArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j]);
                Console.Write(" ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
