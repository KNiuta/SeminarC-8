/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
              Например, на выходе получается вот такой массив:
              01 02 03 04
              12 13 14 05
              11 16 15 06
              10 09 08 07 */

int[,] resalt = GetMatrix(4, 4);
PrintMatrix(resalt);


/// <summary>
/// Метод заполняющий массив 4 на 4 по спирали
///  значениями от 1 до 16 размером 
/// </summary>
/// <param name="rows">число строк</param>
/// <param name="cols">число столбцов</param>
/// <returns>Заполненый "спиралью" массив</returns>
int[,] GetMatrix(int rows, int cols)
{
              int[,] spiralMatrix = new int[rows, cols];
              int s = 0;
              for (int j = 0; j < 3; j++)
              {
                            spiralMatrix[0, j] = s + 1;
                            s = s + 1;
              }
              for (int i = 0; i < 3; i++)
              {
                            spiralMatrix[i, 3] = s + 1;
                            s = s + 1;
              }

              for (int k = 3; k > 0; k--)
              {
                            spiralMatrix[3, k] = s + 1;
                            s = s + 1;
              }
              for (int l = 3; l > 0; l--)
              {
                            spiralMatrix[l, 0] = s + 1;
                            s = s + 1;
              }
              for (int e = 1; e < 3; e++)
              {
                            spiralMatrix[1, e] = s + 1;
                            s = s + 1;
              }
              for (int f = 2; f > 0; f--)
              {
                            spiralMatrix[2, f] = s + 1;
                            s = s + 1;
                                          }
          return spiralMatrix;
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
