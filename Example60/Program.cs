/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая 
              будет построчно выводить массив, добавляя индексы каждого элемента.
              Массив размером 2 x 2 x 2
              66(0,0,0) 25(0,1,0)
              34(1,0,0) 41(1,1,0)
              27(0,0,1) 90(0,1,1)
              26(1,0,1) 55(1,1,1)
*/

ThreeDimensional (2, 2, 2, 0, 100);

/// <summary>
/// Метод формирования трехмерного массива рандомными 
/// элементами в деапазоне (min;max) с выводом индексов каждого элемента.
/// </summary>
/// <param name="rows">Количество строк</param>
/// <param name="cols">Количество столбцов</param>
/// <param name="depth">Количество элементов "глубина"</param>
/// <param name="min">Минимальрое число для рандома</param>
/// <param name="max">Максимальное число для рандома</param>
void ThreeDimensional (int rows, int cols, int depth, int min, int max)
{
              int[,,] matrix = new int[rows, cols, depth];
              for (int i = 0; i < rows; i++)
              {
                            for (int j = 0; j < cols; j++)
                            {
                                          for (int k = 0; k < depth; k++)
                                          {
                                                        matrix[i, j, k] = new Random().Next(min, max + 1);
                                                        Console.WriteLine($"{matrix[i, j, k]}{(i, j, k)}");
                                          }
                            }

              }
}

