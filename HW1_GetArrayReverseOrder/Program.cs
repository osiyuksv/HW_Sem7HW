// упорядочить по убыванию элементы
// каждой строки двумерного рандомного массива

Console.WriteLine("Задайте количество строк массива m");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов массива n");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] FillArrayRandomNunmbers0()
{
  int[,] matrix0 = new int[rows, columns];

  for (int i = 0; i < matrix0.GetLength(0); i++)
  {
    for (int j = 0; j < matrix0.GetLength(1); j++)
      {
        matrix0[i, j] = new Random().Next(10);
      }
  }
  return(matrix0);
}

int[,] ReverseOrderedNumRowsArray(int[,] matrix0)
{
  for (int i = 0; i < matrix0.GetLength(0); i++)
  {
    for (int j = 0; j < matrix0.GetLength(1)-1; j++)
    {
      if(matrix0[i, j] < matrix0[i, j + 1])
      {
        int tempNum = matrix0[i, j];
        matrix0[i, j] = matrix0[i, j + 1];
        matrix0[i, j + 1] = tempNum;
         j = -1;
      }
    }
  }
  return(matrix0);
}

void PrintMatrix(int[,] matrix0)
{
  for (int i = 0; i < matrix0.GetLength(0); i++)
  {
    for (int j = 0; j < matrix0.GetLength(1); j++)
    {
      Console.Write(matrix0[i, j] + " ");
    }
    Console.WriteLine();
  }
}

int[,] matrix = FillArrayRandomNunmbers0();
PrintMatrix(matrix);
Console.WriteLine();

PrintMatrix(ReverseOrderedNumRowsArray(matrix));
Console.WriteLine();
