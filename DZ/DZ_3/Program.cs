// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Буду использовать массив из первого задания.

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Clear();
Console.WriteLine($"m = {m}, n = {n}.");

double[,] array = new double[m, n];

ArrayDouble(array);

WriteArray(array);

Console.WriteLine();

void ArrayDouble(double[,] array)
{
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      array[i, j] = new Random().NextDouble() * 20 - 10;
    }
  }
}

void WriteArray (double[,] array)
{
for (int i = 0; i < m; i++)
  {
      for (int j = 0; j < n; j++)
      {
        double Number = Math.Round(array[i, j], 1);
        Console.Write(Number + "|");
      }
      Console.WriteLine();
  }
}

// Взял массив из первого задания. 

int[,] arrayWhole = new int[m, n];
arrayWhole = Transform(array);

WriteArrayInt(arrayWhole);

Console.Write($"\nCреднее арифметическое:\n");
for (int i = 0; i < n; i++)
{
  double arithmMean = 0;
  for (int j = 0; j < m; j++)
  {
    arithmMean += arrayWhole[j, i];
  }
  arithmMean = Math.Round(arithmMean / m, 1);
  Console.WriteLine($"столбца № {i+1}   {arithmMean}");
}

int[,] Transform (double[,] array)
{
  int[,] arrayWhole = new int[array.GetLength(0), array.GetLength(1)];
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      arrayWhole[i, j] = Convert.ToInt32(array[i, j]);
    }
  }
  return arrayWhole;
}
void WriteArrayInt (int[,] arrayWhole)
{
for (int i = 0; i < m; i++)
  {
      for (int j = 0; j < n; j++)
      {
        Console.Write(arrayWhole[i, j] + " ");
      }
      Console.WriteLine();
  }
}
