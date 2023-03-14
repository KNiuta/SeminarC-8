/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
              Например, задан массив:
              1 4 7 2
              5 9 2 3
              8 4 2 4
              В итоге получается вот такой массив:
              7 4 2 1
              9 5 3 2
              8 4 4 2*/


int[,] resultMatrix = GetMatrix(3, 4, 0, 10);
PrintMatrix(resultMatrix);
Console.WriteLine("Отсортированная матрица: ");

DecreasingRowElements(resultMatrix);
PrintMatrix(resultMatrix);

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
/// Метод печатает матрицу, которую передали на вход
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
/// Метод сортирует по убыванию элементы строки матрицы, переданной на вход
/// </summary>
/// <param name="inputMatrix">Двумерный массив или таблица</param>
/// <returns></returns>

int[,] DecreasingRowElements(int[,] inputMatrix)
{
              for (int k = 0; k < inputMatrix.GetLength(1); k++)
              {
                            int temp;
                            for (int i = 0; i < inputMatrix.GetLength(0); i++)
                            {
                                          for (int j = 0; j < inputMatrix.GetLength(1) - 1; j++)
                                          {
                                                        if (inputMatrix[i, j] < inputMatrix[i, j + 1])
                                                        {
                                                                      temp = inputMatrix[i, j];
                                                                      inputMatrix[i, j] = inputMatrix[i, j + 1];
                                                                      inputMatrix[i, j + 1] = temp;

                                                        }

                                          }
                            }
              }
              return inputMatrix;
}



