/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет */

using System;
using static System.Console;

Clear();
Write("Введите число сторок: ");
int raws = int.Parse(ReadLine());
Write("Введите число столбцов: ");
int columns = int.Parse(ReadLine());
int[,] array = GetNewArray(raws, columns, 0, 10);
PrintArray(array);
WriteLine();
Write("Введите позицию необходимого элемента через пробел: ");
string[] Position = ReadLine().Split(" ");
int raw = int.Parse(Position[0]);
int column = int.Parse(Position[1]);

if (raw <= raws && column <= columns)
{
WriteLine($"{array[raw, column]}");
}
else
{
  WriteLine("Число с указанной позицией не существует в заданном массиве");
}


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


