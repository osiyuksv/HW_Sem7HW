// вывести трёхмерный рандомный массив с элементами, которые 
// уникальные положительные двухзанчные числа

Console.WriteLine("Задайте количество строк массива m");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов массива n");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество страниц массива k");
int pages = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,,] matrix3D = new int[rows, columns, pages];
int unicNum = 0;

if(rows * columns * pages < 100)
{
  for (int k = 0; k < matrix3D.GetLength(2); k++)
  {
    for (int i = 0; i < matrix3D.GetLength(0); i++)
    {
      for (int j = 0; j < matrix3D.GetLength(1); j++)
      {
        
         unicNum ++;
         matrix3D[i, j, k] = unicNum;
      
        Console.Write(matrix3D[i, j, k] + $"({i};{j};{k}) ");
      }
      Console.WriteLine();
    }
    Console.WriteLine($"Страница {k+1}");
    Console.WriteLine();
  }
}
else Console.WriteLine("Для данного массива невозможно подобрать элементы с уникальными положительными двухзначными числасми");
