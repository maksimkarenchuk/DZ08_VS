// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



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

         int[,] DivMatrix(int[,] mas1, int[,] mas2)
{
    var matrix = new int[mas1.GetLength(0), mas2.GetLength(1)];
    if (mas1.GetLength(1) == mas2.GetLength(0))
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = 0;
                for (int n = 0; n < mas1.GetLength(1); n++)
                {
                    matrix[i, j] += mas1[i, n] * mas2[n, j];
                }
            }
        }
    }
    return matrix;
}

         Console.Write("Введите количество строк двумерного массива ");
         int m = Convert.ToInt32(Console.ReadLine());
         Console.Write("Введите количество стобцов двумерного массива ");
         int n = Convert.ToInt32(Console.ReadLine());
         int[,] mas1 = FillArray(m, n);
         int[,] mas2 = FillArray(m, n);
         PrintArray(mas1);
         Console.WriteLine();
         PrintArray(mas2);
         Console.WriteLine();
         PrintArray(DivMatrix(mas1, mas2));

      