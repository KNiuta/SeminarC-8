/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
              Например, даны 2 матрицы:
              2 4 | 3 4
              3 2 | 3 3
              Результирующая матрица будет:
              18 20
              15 18*/
              
int[,] resultMatrix1 = GetMatrix(4,2,0,10);
int[,] resultMatrix2 =  GetMatrix(2,4,0,10);
PrintMatrix(resultMatrix);
Console.WriteLine();
PrintMatrix(resultMatrix2);
Console.WriteLine();
int[,] resultMatrix3= MultiplicationMatrix(resultMatrix1,resultMatrix2);
PrintMatrix(resultMatrix3);

/// <summary>
/// Этот метод заполняет двумерный массив 
/// числами от min до max (общее описание)
/// </summary>
/// <param name="rows">Количество строк</param>   
/// <param name="cols">Количество столбцов</param> 
/// <param name="min">Минимальрое число для рандома</param> 
/// <param name="max">Максимальное число для рандома</param> 
/// <returns> Заполненный двумерный массив целых чисел </returns>
int[,] GetMatrix(int rows,int cols, int min, int max)               
{
     int[,] matrix = new int[rows,cols];
     for (int i = 0; i < rows; i++)
     {
         for (int j = 0; j < cols; j++)
         {
              matrix[i,j]=new Random().Next(min,max+1);
         }     
     }
     return matrix;
}

/// <summary>
/// Метод печатает матрицу, которую передали на вход
/// </summary>
/// <param name="inputMatrix"> Двумерный массив или таблица </param>
void PrintMatrix (int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
              for (int j = 0; j < inputMatrix.GetLength(1); j++)
              {
                   Console.Write(inputMatrix[i,j]+"\t");         
              }
              Console.WriteLine();
    }
}

/// <summary>
/// Метод позволяет вычислить произведение двух матриц, 
/// которые передали на вход
/// </summary>
/// <param name="matrix1">Первая матрица (двумерный массив)</param>
/// <param name="matrix2">Вторая матрица (двумерный массив)</param>
/// <returns></returns>
int[,] MultiplicationMatrix(int[,] matrix1,int[,] matrix2)
{
               int[,] newMatrix = new int[matrix1.GetLength(0),matrix2.GetLength(1)];
              if (matrix1.GetLength(1)== matrix2.GetLength(0))
              {
                            for (int i = 0; i < matrix1.GetLength(0); i++)
                            {     
                                          for (int j = 0;  j < matrix2.GetLength(1); j++)
                                          {
                                                        newMatrix[i,j]=0;
                                                        for (int k = 0; k < matrix1.GetLength(1); k++)
                                                        {
                                                            newMatrix[i,j]  +=matrix1[i,k]*matrix2[k,j];      
                                                        }      
                                          }       
                            }  
              }
              return newMatrix;
}