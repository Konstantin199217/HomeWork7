// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> число с таким адресом в массиве нет
int rows = 5;
int colums = 5;


int[,] NewArray = CreateArray(rows, colums);
int[,] CreateArray(int r, int c)
{
    int[,] Array = new int[r, c];
    for (int i = 0; i < r; i++)
    {
        for (int j = 0; j < c; j++)
        {
            Array[i, j] = new Random().Next(1, 20);
        }
    }
    return Array;
}

int ReadData(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

void PrintArray(int[,] arr)
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

int Y = ReadData("Введите координуту по Y: ");
int X = ReadData("Введите координату по X: ");
PrintArray(NewArray);
if (Y<=NewArray.GetLength(0) && X<= NewArray.GetLength(1))
{
    Console.Write(NewArray[Y,X]);
}
else
{
    Console.WriteLine("Числа с таким адрессом нет!");
}
Console.WriteLine();

