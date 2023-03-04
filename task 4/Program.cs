// Задача 3: Задайте двумерный массив. 
// Найдите сумму элементов главной диагонали.


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
            array[i, j] = new Random().Next(1, 10);
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
    System.Console.WriteLine();
}

int DiagonalSum(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
            sum += array[i, i];
    }
    return sum;
}

int rows = InputSize("Input ammount of rows");
int columns = InputSize("Input ammount of columns");
int[,] array = ArrayCreation(rows, columns);
PrintArray(array);
System.Console.WriteLine(DiagonalSum(array));