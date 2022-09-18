// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


void PrintArray(int[,] table)
{
   for (int i = 0; i < table.GetLength(0); i++)
   {
      for (int j = 0; j < table.GetLength(1); j++)
      {
         Console.Write(table[i, j] + "\t");
      }
      Console.WriteLine();
   }
}

int[,] FillArray(int m, int n)
{
   int[,] array = new int[m, n];
   for (int i = 0; i < m; i++)
   {
      for (int j = 0; j < n; j++)
         array[i, j] = new Random().Next(1, 10);
   }
   return array;
}

void SorttArray(int[,] matrix)
{
   for (int i = 0; i < matrix.GetLength(0); i++)
      for (int j = 0; j < matrix.GetLength(1); j++)
         for (int k = 0; k < matrix.GetLength(1); k++)
         {
            if (matrix[i, j] <= matrix[i, k]) continue;
            int temp = matrix[i, j];
            matrix[i, j] = matrix[i, k];
            matrix[i, k] = temp;
         }

   for (int i = 0; i < matrix.GetLength(0); i++, Console.WriteLine())
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
         Console.Write(matrix[i, j] + "\t");
      }
}


Console.Write("Введите количество строк двумерного массива ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество стобцов двумерного массива ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] mas = FillArray(m, n);
PrintArray(mas);
Console.WriteLine();
SorttArray(mas);

