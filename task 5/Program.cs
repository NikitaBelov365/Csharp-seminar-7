// Задача 4: Задайте двумерный массив. Введите элемент, 
// и найдите первое его вхождение, 
// выведите позиции по горизонтали и вертикали, 
// или напишите, что такого элемента нет.



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

void ValueFinder(int[,] array, int value)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == value)
            {
                System.Console.WriteLine($"{value} in this array got position: row {i}, column {j}");
                return;
            }
        }
    }
    System.Console.WriteLine($"There is no {value} in this array");
    return;
}


int rows = InputSize("Input ammount of rows");
int columns = InputSize("Input ammount of columns");
int value = InputSize("Input some value to get from array");
int[,] array = ArrayCreation(rows, columns);
PrintArray(array);
ValueFinder(array, value);
