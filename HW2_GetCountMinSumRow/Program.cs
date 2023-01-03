// вывести номер строки с наименьшей суммой
// элементов в двумерном рандомном массиве

Console.WriteLine("Задайте количество строк массива m");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов массива n");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int minSumRow = int.MaxValue;
int indexMinSumRow = 0;

int[,] FillArrayRandomNunmbers0()
{
  int[,] matrix0 = new int[rows, columns];

  for (int i = 0; i < matrix0.GetLength(0); i++)
  {
    int sumRow = 0;
    
    for (int j = 0; j < matrix0.GetLength(1); j++)
      {
        matrix0[i, j] = new Random().Next(10);
        sumRow += matrix0[i, j];
      }
    if(sumRow < minSumRow) 
    {
      minSumRow = sumRow;
      indexMinSumRow = i;
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

Console.WriteLine($"Номер строки с минимальной суммой элесентов в массиве равен {indexMinSumRow + 1}");
