// Задача 5: Задайте двумерный массив. 
// Найдите максимальный элемент массива и 
// среднее арифметическое всех элементов массива.

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

int FindMax(int[,] array)
{
    int max = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j] > max) max = array[i, j];
        }
    }
    return max;
}

int ArithmeticalMean(int[,] array)
{
    int mean = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            mean += array[i,j];
        }
    }
    return mean/(array.GetLength(0)*array.GetLength(1));
}

int rows = InputSize("Input ammount of rows");
int columns = InputSize("Input ammount of columns");
int[,] array = ArrayCreation(rows, columns);
PrintArray(array);
int maxValue = FindMax(array);
int arithmeticalMean = ArithmeticalMean(array);
System.Console.WriteLine($"Max value is: {maxValue} \nArithmetical mean is: {arithmeticalMean}");