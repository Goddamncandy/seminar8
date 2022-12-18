// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($" {matr[i, j]} ");
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
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

void MultiplyMatrix(int[,] firstMatrix, int[,] secondMatrix, int[,] resultMatrix)
{
  for (int i = 0; i < firstMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < secondMatrix.GetLength(1); j++)
    {
      int r = 0;
      for (int a = 0; a < firstMatrix.GetLength(1); a++)
      {
        r += firstMatrix[i, a] * secondMatrix[a, j];
      }
      resultMatrix[i, j] = r;
    }
  }
}

Console.WriteLine("Введите количество строк первой матрицы");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов первой матрицы (и строк второй)");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов второй матрицы");
int p = Convert.ToInt32(Console.ReadLine());

int[,] firstMatrix = new int[m, n];
int[,] secondMatrix = new int[n, p];
int[,] resultMatrix = new int[m, p]; 

FillArray(firstMatrix);
PrintArray(firstMatrix);
Console.WriteLine();
FillArray(secondMatrix);
PrintArray(secondMatrix);
Console.WriteLine();
MultiplyMatrix(firstMatrix, secondMatrix, resultMatrix);
PrintArray(resultMatrix);