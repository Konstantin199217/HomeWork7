// Задача 47. Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7,0 -2,0 -0,2
// 1,0 -3,3 8,0 -9,9
// 8,0 7,8 -7,1 9,0

Console.WriteLine("Введите колличество строк: ");
string rows = Console.ReadLine();
int newRows = Convert.ToInt32(rows);
Console.WriteLine("Введите колличество столбцов: ");
string colums = Console.ReadLine();
int newColums = Convert.ToInt32(colums);
double GetRandomNumber(double minimum, double maximum)
{
return Math.Round(new Random().NextDouble() * (maximum - minimum) + minimum,2);
}

double[,] Array = new double[newRows, newColums];
for (int i = 0; i < newRows; i++)
{
    for (int j = 0; j <newColums ; j++)
    {
        Array[i, j] = GetRandomNumber(1, 99);
    }
}
void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}\t");
        }
        Console.WriteLine();
    }
}

PrintArray(Array);

