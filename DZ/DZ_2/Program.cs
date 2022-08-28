// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int m =  ReadInt("количество строк: ");
int n = ReadInt("количество столбцов: ");
int positionM = ReadInt("позиция в строке: ");
int positionN = ReadInt("позиция в столбце: ");
int element = 0;
int[,] matrix = new int[m, n];

FillArray(matrix);
PrintArray(matrix);

if (positionM >= m || positionN >= n)
{
    Console.Write($"Такого числа нет.");
}
else
{
   element = matrix[positionM, positionN];
    Console.Write($"Значение элемента: {matrix[positionM, positionN]}");
}

int ReadInt(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0, 10);
        }
    }
}
