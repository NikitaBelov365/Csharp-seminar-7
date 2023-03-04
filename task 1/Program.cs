// Задача 1: Задайте двумерный массив размером m×n, 
// заполненный случайными целыми числами.

int InputSize(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] ArrayCreation(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-99, 100);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]} ");
        }
        System.Console.WriteLine();
    }
    
}

int rows = InputSize("Input ammount of rows");
int columns = InputSize("Input ammount of columns");
PrintArray(ArrayCreation(rows, columns));