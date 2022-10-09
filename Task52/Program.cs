// Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// int[,] CreateArray(int m, int n)
// {
//     int[,] numbers = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < n; j++)
//         {
//             numbers[i, j] = new Random().Next(1, 99);
//             sum += numbers[i, j];
//         }
//     }
//     return numbers;
// }
// int[,] NumArray = CreateArray(5, 5);



// void PrintArray(int[,] arra)
// {
//     for (int i = 0; i < arra.GetLength(0); i++)
//     {
//         for (int j = 0; j < arra.GetLength(1); j++)
//         {
//             Console.Write($"{arra[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
// }

// PrintArray(NumArray);

// Console.WriteLine($"Среднее арифметическое: {i + 1} = {sum / 5}");


void PrintArray(int[,] arra)
{
    for (int i = 0; i < arra.GetLength(0); i++)
    {
        for (int j = 0; j < arra.GetLength(1); j++)
        {
            Console.Write($"{arra[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] Arr = new int[5, 5];
for (int i = 0; i < 5; i++)
{
    int sum = 0;
    for (int j = 0; j < 5; j++)
    {
        Arr[i, j] = new Random().Next(1, 99);
        sum += Arr[i, j];
    }
    Console.WriteLine();
    Console.WriteLine($"Cреднее арифметическое элементов столбца {i + 1} = {sum/5}");
}

PrintArray(Arr);
