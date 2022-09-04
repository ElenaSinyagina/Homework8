// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер
// строки с наименьшей суммой элементов: 1 строка

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

int[,] CreateArrayWithRandomNumbers(int m, int n)
{
    var result = new int[m, n];

    var random = new Random();

    for (var i = 0; i < result.GetLength(0); i++)
    {
        for (var j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = random.Next(0, 11);
        }
    }

    return result;
}

int Sum(int[,] array)
{
    int sum = 0;
    int minSum = 0;
    int minNum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == 0) 
            {
                sum += array[i, j];
                minSum += array[i, j]; 
            }
            else sum += array[i, j]; 
        }
        if (sum < minSum)
        {
            minSum = sum;
            minNum = i + 1;
        }
        sum = 0;
    }
    return minNum;
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

var array = CreateArrayWithRandomNumbers(m, n);
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Cтрока с наименьшей суммой элементов: " + Sum(array));
