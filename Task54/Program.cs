//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

void OrderArrayLines(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

int GetNumbers(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}


void CreateArray(int[,] array)
{
    int range = GetNumbers("Введите диапазон зачений для заполнения массива: от 0 до ");
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(range);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.WriteLine($"Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");
Console.WriteLine($"Введите размер массива m x n и диапазон случайных значений:");
int m = GetNumbers("Введите кол-во строк (m): ");
int n = GetNumbers("Введите кол-во столбцов (n): ");
int[,] array = new int[m, n];
CreateArray(array);
PrintArray(array);
Console.WriteLine($"Отсортированный массив: ");
OrderArrayLines(array);
PrintArray(array);