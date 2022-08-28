// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Clear();   // Необязательно но я сделал.
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

