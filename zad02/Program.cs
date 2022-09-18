// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


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

int[] SumStrok(int[,] array)
{
   int[] summ = new int[array.GetLength(0)];
   for (int i = 0; i < array.GetLength(0); i++)
   {

      for (int j = 0; j < array.GetLength(1); j++)
      {
         summ[i] += array[i, j];
      }
   }
   foreach (double elem in summ)
   {
      Console.Write($"{elem},  ");
   }
   return summ;
}


   void MinSting(int[] table)
   {
      int min = table[0];
      int indexMin = 0;
      for (int i = 0; i < table.GetLength(0); i++)
      {
         if (min > table[i])
         {
            indexMin = i;
         }
      }
      Console.WriteLine($"Минимальная сумма элементов в {indexMin + 1}-ой строке");
   }



   Console.Write("Введите количество строк двумерного массива ");
   int m = Convert.ToInt32(Console.ReadLine());
   Console.Write("Введите количество стобцов двумерного массива ");
   int n = Convert.ToInt32(Console.ReadLine());
   int[,] mas = FillArray(m, n);
   PrintArray(mas);
   Console.WriteLine();
   MinSting(SumStrok(mas));