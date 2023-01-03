// перемножить две рандомные матрицы, где количеством
// столбцов первой равно количесвту строк второй

Console.WriteLine("Задайте количество строк массива №1 m");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов массива №1 n = количеству строк массива №2 K");
int columns1 = Convert.ToInt32(Console.ReadLine());
int rows2 = columns1;
Console.WriteLine("Задайте количество столбцов массива №2 l");
int columns2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] matrix1 = new int[rows1, columns1];

  for (int i = 0; i < matrix1.GetLength(0); i++)
  {
    for (int j = 0; j < matrix1.GetLength(1); j++)
      {
        matrix1[i, j] = new Random().Next(10);
        Console.Write(matrix1[i, j] + " ");
      }
    Console.WriteLine();
  }
Console.WriteLine();

int[,] matrix2 = new int[rows2, columns2];

  for (int i = 0; i < matrix2.GetLength(0); i++)
  {
    for (int j = 0; j < matrix2.GetLength(1); j++)
      {
        matrix2[i, j] = new Random().Next(10);
        Console.Write(matrix2[i, j] + " ");
      }
    Console.WriteLine();
  }
Console.WriteLine();

int[,] matrix3 = new int[rows1, columns2];

  for (int i = 0; i < matrix3.GetLength(0); i++)
  {
    for (int j = 0; j < matrix3.GetLength(1); j++)
      {
        matrix3[i, j] = 0;

        for (int k = 0; k < matrix2.GetLength(0); k++)
        {
           matrix3[i, j] = matrix3[i, j] + matrix1[i, k] * matrix2[k, j];
        }        
       
        Console.Write(matrix3[i, j] + " ");
      }
    Console.WriteLine();
  }
Console.WriteLine();