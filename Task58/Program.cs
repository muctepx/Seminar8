// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

int GetNumbers(string massage)
{
  Console.Write(massage);
  int number = int.Parse(Console.ReadLine() ?? "");
  return number;
}

void CreateArray(int[,] array)
{
  Random rnd = new Random();
  int range = GetNumbers("Введите диапазон случайных чисел которыми будет заполнена матрица: от 0 до ");
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = rnd.Next(range);
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}

Console.Clear();
Console.WriteLine($"Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.\nЗададим матрицу, которую можно перемножить, т.е. количество столбцов первой равно количеству строк второй");
Console.WriteLine($"Введите размеры матриц и диапазон случайных значений:");
int m = GetNumbers("Введите число строк 1-й матрицы: ");
int n = GetNumbers("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int p = GetNumbers("Введите число столбцов 2-й матрицы: ");
int[,] firstMartrix = new int[m, n];
CreateArray(firstMartrix);
Console.WriteLine($"Первая матрица:");
WriteArray(firstMartrix);
int[,] secomdMartrix = new int[n, p];
CreateArray(secomdMartrix);
Console.WriteLine($"Вторая матрица:");
WriteArray(secomdMartrix);
int[,] resultMatrix = new int[m,p];
MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($"Произведение первой и второй матриц:");
WriteArray(resultMatrix);