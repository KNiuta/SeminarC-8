/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

              Например, задан массив:

              1 4 7 2

              5 9 2 3

              8 4 2 4

              5 2 6 7

              Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/
int[,] resultMatrix = GetMatrix(3,4,0,10);
PrintMatrix(resultMatrix);
Console.WriteLine("Строка с минимальной суммой элементов: ");
Console.WriteLine(IndexMinSum(resultMatrix));



/// <summary>
/// Этот метод заполняет двумерный массив 
/// числами от min до max (общее описание)
/// </summary>
/// <param name="rows">Количество строк</param>   
/// <param name="cols">Количество столбцов</param> 
/// <param name="min">Минимальрое число для рандома</param> 
/// <param name="max">Максимальное число для рандома</param> 
/// <returns> Заполненный двумерный массив целых чисел </returns>
int[,] GetMatrix(int rows, int cols, int min, int max)
{
              int[,] matrix = new int[rows, cols];
              for (int i = 0; i < rows; i++)
              {
                            for (int j = 0; j < cols; j++)
                            {
                                          matrix[i, j] = new Random().Next(min, max + 1);
                            }
              }
              return matrix;
}
/// <summary>
/// Метод печатает матрицу, которая передали на вход
/// </summary>
/// <param name="inputMatrix"> Двумерный массив или таблица </param>
void PrintMatrix(int[,] inputMatrix)
{
              for (int i = 0; i < inputMatrix.GetLength(0); i++)
              {
                            for (int j = 0; j < inputMatrix.GetLength(1); j++)
                            {
                                          Console.Write(inputMatrix[i, j] + "\t");
                            }
                            Console.WriteLine();
              }
}
/// <summary>
/// Метод находит номер индекса строки с минимальной
/// суммой элементов для введенной матрицы.
/// </summary>
/// <param name="inputMatrix">Двумерный массив или таблица</param>
/// <returns>Номер индекса строки с минимальной суммой элементов</returns>
int IndexMinSum(int[,] inputMatrix)
{
              int[] maximumValues = new int[inputMatrix.GetLength(0)];

              for (int i = 0; i < inputMatrix.GetLength(0); i++)
              {
                            int sum = 0;
                            for (int j = 0; j < inputMatrix.GetLength(1); j++)
                            {
                                          sum = sum + inputMatrix[i, j];

                            }
                            maximumValues[i] = sum;
              }
              int min = maximumValues[0];
              int indexMinRows = 0;
              for (int k = 0; k < maximumValues.Length; k++)
              {
                            if (min > maximumValues[k])
                            {
                                          min = maximumValues[k];
                                          indexMinRows = k;
                            }
              }

return indexMinRows;
}
