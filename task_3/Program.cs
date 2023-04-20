/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */
using static System.Console;

Clear();
Write("Введите число сторок: ");
int raws = int.Parse(ReadLine());
Write("Введите число столбцов: ");
int columns = int.Parse(ReadLine());
int[,] array = GetNewArray(raws, columns, 0, 10);
PrintArray(array);
WriteLine();
double[] result = MediumSum(array);
Write("Среднее арифметическое каждого столбца равно: ");
for (int i = 0; i < result.Length; i++)
    {
      Write($"{result[i]:f1}, ");
    }
/* WriteLine($"Среднее арифметическое равно: {string.Join(", ", result):f2}"); // Не ограничивает количество знаков после запятой */


int[,] GetNewArray(int m, int n, int minValue, int maxValue)
{
  int[,] result = new int[m, n];
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      result[i, j] = new Random().Next(minValue, maxValue + 1);
    }
  }
  return result;
}


void PrintArray(int[,] inArray)
{
  for (int i = 0; i < inArray.GetLength(0); i++)
  {
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
      Write($"{inArray[i, j]} ");
    }
    WriteLine();
  }
}


double[] MediumSum(int[,] inArray)
{
  double[] SumColumns = new double[inArray.GetLength(1)];
  for (int i = 0; i < inArray.GetLength(1); i++)
  {
    for (int j = 0; j < inArray.GetLength(0); j++)
    {
      SumColumns[i] += inArray[j, i];
    }
    SumColumns[i] /= inArray.GetLength(0);
  }
  return SumColumns;
}
