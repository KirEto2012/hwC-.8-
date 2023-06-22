/*
Задача 58:
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

//неразобрался как сделать в методе 

int rows = ReadLine("Введите склько хотите строк: ");
int columns = ReadLine("Введите склько хотите столбцов: ");

int[,] array = new int[rows, columns];
int[,] array2 = new int[rows, columns];
int[,] sumArray = new int[rows, columns];
Console.WriteLine("Первоя матрица");
GenerateRandom2DArray(array);
PrintArray(array);

Console.WriteLine("Вторая матрица");

GenerateRandom2DArray(array2);
PrintArray(array2);


if (array.GetLength(0) != array2.GetLength(1))
{
    Console.WriteLine(" error ");
    return;
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array2.GetLength(1); j++)
    {
        sumArray[i, j] = 0;
        for (int k = 0; k < array.GetLength(1); k++)
        {
            sumArray[i, j] += array[i, k] * array2[k, j];
        }
    }
}

Console.WriteLine("Результирующая матрица будет = ");
PrintArray(sumArray);

// генирирует рандрмные числа в масиве 
void GenerateRandom2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}
// виыводит массив
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

int ReadLine(string enteringArrayValues)
{
    Console.Write(enteringArrayValues);
    return Convert.ToInt32(Console.ReadLine());
}



