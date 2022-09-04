// Задача 58: Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void PrintArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}, ");
        }
        Console.WriteLine();
    }
}

int[,] CreateArrayFirst(int m, int n)
{
    var result = new int[m, n];

    var random = new Random();

    for (var i = 0; i < result.GetLength(0); i++)
    {
        for (var j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = random.Next(0, 10);
        }
    }

    return result;
}
int[,] CreateArraySecond(int m, int n)
{
    var result = new int[m, n];

    var random = new Random();

    for (var k = 0; k < result.GetLength(0); k++)
    {
        for (var l = 0; l < result.GetLength(1); l++)
        {
            result[k, l] = random.Next(0, 10);
        }
    }

    return result;
}

int [,] ProductOfArray (int [,] array1, int[,] array2) 
{
    int[,] resultArray = new int [array1.GetLength(0), array2.GetLength(1)];
    for(int i = 0; i < array1.GetLength(0); i++)
        for (int l = 0; l < array2.GetLength(1); l++)
            {
            int sum=0;
            for (int j = 0; j < array1.GetLength(1); j++)
                sum += array1[i,j] * array2[j,l];
      
            resultArray[i,l] = sum;
            }
    return resultArray;
}

Console.WriteLine("Введите число строк (m)");
if (!int.TryParse(Console.ReadLine()!, out var m))
{
    Console.WriteLine("Всё плохо");
}

Console.WriteLine("Введите число столбцов (n)");
if (!int.TryParse(Console.ReadLine()!, out var n))
{
    Console.WriteLine("Всё плохо");
}

Console.WriteLine("Матрица 1:");
var array1 = CreateArrayFirst(m, n);
PrintArray(array1);
Console.WriteLine();
Console.WriteLine("Матрица 2:");
var array2 = CreateArraySecond(m, n);
PrintArray(array2);
Console.WriteLine();
Console.WriteLine("Результат умножения матриц:");
var array3 = ProductOfArray(array1, array2);
PrintArray(array3);